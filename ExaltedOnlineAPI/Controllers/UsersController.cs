using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ExaltedOnlineAPI.Interfaces;
using ExaltedOnlineAPI.Models;
using Microsoft.Extensions.Localization;

namespace ExaltedOnlineAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class UsersController : ControllerBase//, IAuthController
    {
        private readonly ILogger Logger;
        private readonly IStringLocalizer Localizer;
        private readonly IAuthRepository authRepo;

        public UsersController(ILogger<TraitsController> logger, IAuthRepository repo, IStringLocalizer<Resources.Resources> localizer)
        {
            Logger = logger;
            authRepo = repo;
            Localizer = localizer;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Users/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetUsersAsync(int id)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(GetUsersAsync));

            var response = new SingleResponse<Users>();

            try
            {
                // Get the stock item by id
                response.Model = await authRepo.GetUsersAsync(new Users(id)).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(GetUsersAsync), ex);
            }

            return response.ToHttpResponse();
        }

        [HttpPost("Users/Register")]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> Register([FromBody]Users request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await authRepo.UserExists(request.UserName).ConfigureAwait(true))
                return BadRequest("Username is already taken");

            try
            { 
                var userCreated = await authRepo.Register(request, request.Password).ConfigureAwait(true);
                return StatusCode(201, userCreated);
            }
            catch
            {
                return StatusCode(500);
            }            
        }
    }
}