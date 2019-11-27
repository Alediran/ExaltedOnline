using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ExaltedOnlineAPI.Models;
using Microsoft.Extensions.Localization;

namespace ExaltedOnlineAPI.Interfaces
{
    public class AuthRepository: IAuthRepository
    {
        private readonly ILogger Logger;
        private readonly ExaltedDBContext DbContext;
        private readonly IStringLocalizer Localizer;

        public AuthRepository(ExaltedDBContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<Users> GetUsersAsync(Users entity)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(GetUsersAsync));

            var response = new SingleResponse<Users>();

            try
            {
                // Get the stock item by id
                response.Model = await DbContext.GetUsersAsync(entity).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(GetUsersAsync), ex);
            }

            return response.Model;
        }

        public AuthRepository(ILogger<AuthRepository> logger, ExaltedDBContext dbContext, IStringLocalizer<Resources.Resources> localizer)
        {
            Logger = logger;
            DbContext = dbContext;
            Localizer = localizer;
        }

        public async Task<Users> Login(string username, string password)
        {
            var user = await DbContext.Users.FirstOrDefaultAsync(x => x.UserName == username).ConfigureAwait(true); //Get user from database.
            if (user == null)
                return null; // User does not exist.

            if (!VerifyPassword(password, user.PasswordHash, user.PasswordSalt))
                return null;

            return user;
        }

        public async Task<Users> Register(Users user, string password)
        {
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await DbContext.AddAsync(user);
            await DbContext.SaveChangesAsync().ConfigureAwait(true);

            return user;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await DbContext.Users.AnyAsync(x => x.UserName == username).ConfigureAwait(true))
                return true;
            return false;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        private bool VerifyPassword(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password)); // Create hash using password salt.
                for (int i = 0; i < computedHash.Length; i++)
                { // Loop through the byte array
                    if (computedHash[i] != passwordHash[i]) return false; // if mismatch
                }
            }
            return true; //if no mismatches.
        }
    }
}
