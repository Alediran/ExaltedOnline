using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ExaltedOnlineAPI.Internal
{
    public interface IPasswordEncrypter
    {
        string Hash(string password);

        (bool Verified, bool NeedsUpgrade) Check(string hash, string password);
    }

    public sealed class HashingOptions
    {
        public int Iterations { get; set; } = 10000;
    }

    public sealed class PasswordEncryption : IPasswordEncrypter
    {
        protected readonly IStringLocalizer Localizer;
        private const int SaltSize = 16; // 128 bit 
        private const int KeySize = 32; // 256 bit

        public PasswordEncryption(IOptions<HashingOptions> options)
        {
            Contract.Requires(options != null, "options cannot be Null");

            Options = options.Value;
        }

        private HashingOptions Options { get; }

        public string Hash(string password)
        {
            using (var algorithm = new Rfc2898DeriveBytes(
              password,
              SaltSize,
              Options.Iterations,
              HashAlgorithmName.SHA512))
            {
                var key = Convert.ToBase64String(algorithm.GetBytes(KeySize));
                var salt = Convert.ToBase64String(algorithm.Salt);

                return $"{Options.Iterations}.{salt}.{key}";
            }
        }

        public (bool Verified, bool NeedsUpgrade) Check(string hash, string password)
        {
            Contract.Requires(!string.IsNullOrEmpty(hash), "Password Hash cannot be Null");

            var parts = hash.Split('.', 3);

            if (parts.Length != 3)
            {
                throw new FormatException(Localizer["HashFormatIncorrect"]);
            }

            var iterations = Convert.ToInt32(parts[0]);
            var salt = Convert.FromBase64String(parts[1]);
            var key = Convert.FromBase64String(parts[2]);

            var needsUpgrade = iterations != Options.Iterations;

            using (var algorithm = new Rfc2898DeriveBytes(
              password,
              salt,
              iterations,
              HashAlgorithmName.SHA512))
            {
                var keyToCheck = algorithm.GetBytes(KeySize);

                var verified = keyToCheck.SequenceEqual(key);

                return (verified, needsUpgrade);
            }
        }
    }
}