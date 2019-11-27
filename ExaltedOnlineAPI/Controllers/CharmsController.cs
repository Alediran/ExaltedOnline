using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ExaltedOnlineAPI.Models;
using Microsoft.Extensions.Localization;

namespace ExaltedOnlineAPI.Controllers
{
#pragma warning disable CS1591
    [Route("api")]
    [ApiController]
    public class CharmsController : ControllerBase
    {
        private readonly ILogger Logger;
        private readonly ExaltedDBContext DbContext;
        private readonly IStringLocalizer Localizer;

        public CharmsController(ILogger<CharmsController> logger, ExaltedDBContext dbContext, IStringLocalizer<Resources.Resources> localizer)
        {
            Logger = logger;
            DbContext = dbContext;
            Localizer = localizer;
        }
#pragma warning restore CS1591

        /// <summary>
        /// Return a list of Paged Charms
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        [HttpGet("Charms")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetCharmsAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogDebug(Localizer["ProcessInvoked"], nameof(GetCharmsAsync));

            var response = new PagedResponse<Charms>();

            try
            {
                // Get the "proposed" query from repository
                var query = DbContext.GetCharms();
                
                // Set paging values
                response.PageSize = pageSize;
                response.PageNumber = pageNumber;

                // Get the total rows
                response.ItemsCount = await query.CountAsync().ConfigureAwait(true);

                // Get the specific page from database
                response.Model = await query.Paging(pageSize, pageNumber).ToListAsync().ConfigureAwait(true);

                response.Message = string.Format(Localizer["CharmPaging"], pageNumber.ToString(), response.PageCount.ToString(), response.ItemsCount.ToString());

                Logger?.LogInformation(Localizer["CharmRetrieveSuccessfull"]);
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical(Localizer["InvocationError"], nameof(GetCharmsAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Charms/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetCharmsAsync(int id)
        {
            Logger?.LogDebug(Localizer["ProcessInvoked"], nameof(GetCharmsAsync));

            var response = new SingleResponse<Charms>();

            try
            {
                // Get the stock item by id
                response.Model = await DbContext.GetCharmsAsync(new Charms(id)).ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical(Localizer["InvocationError"], nameof(GetCharmsAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Charms")]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostCharmsAsync([FromBody]Charms request)
        {
            Logger?.LogDebug(Localizer["ProcessInvoked"], nameof(PostCharmsAsync));

            var response = new SingleResponse<Charms>();

            try
            {
                var existingEntity = await DbContext.GetCharmsByCharmsNameAsync(new Charms { Name = request.Name }).ConfigureAwait(true);

                if (existingEntity != null)
                    ModelState.AddModelError("Charms", "Charm Name already exists");

                if (!ModelState.IsValid)
                    return BadRequest();

                // Create entity from request model
                var entity = request.ToEntity();

                // Add entity to repository
                DbContext.Add(entity);

                // Save entity in database
                await DbContext.SaveChangesAsync().ConfigureAwait(true);

                // Set the entity to response model
                response.Model = entity;
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical(Localizer["InvocationError"], nameof(PostCharmsAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("Charms/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PutCharmsAsync(int id, [FromBody]Charms request)
        {
            Logger?.LogDebug(Localizer["ProcessInvoked"], nameof(PutCharmsAsync));

            var response = new Response();

            try
            {
                // Get stock item by id
                var entity = await DbContext.GetCharmsAsync(new Charms(id)).ConfigureAwait(true);

                // Validate if entity exists
                if (entity == null)
                    return NotFound();

                // Set changes to entity
                entity.Id = request.Id;
                entity.Name = request.Name;
                entity.Essence = request.Essence;
                entity.TypeId = request.TypeId;
                entity.DurationId = request.DurationId;
                entity.Description = request.Description;
                entity.IsCustomCharm = request.IsCustomCharm;
                entity.GameId = request.GameId;
               // entity.CharmTraits = request.CharmTraits;

                // Update entity in repository
                DbContext.Update(entity);

                // Save entity in database
                await DbContext.SaveChangesAsync().ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical(Localizer["InvocationError"], nameof(PutCharmsAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Charms/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DeleteCharmsAsync(int id)
        {
            Logger?.LogDebug(Localizer["ProcessInvoked"], nameof(DeleteCharmsAsync));

            var response = new Response();

            try
            {
                // Get stock item by id
                var entity = await DbContext.GetCharmsAsync(new Charms(id)).ConfigureAwait(true);

                // Validate if entity exists
                if (entity == null)
                    return NotFound();

                // Remove entity from repository
                DbContext.Remove(entity);

                // Delete entity in database
                await DbContext.SaveChangesAsync().ConfigureAwait(true);
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical(Localizer["InvocationError"], nameof(DeleteCharmsAsync), ex);
            }

            return response.ToHttpResponse();
        }
    }
}
