using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ExaltedOnlineAPI.Models;

namespace ExaltedOnlineAPI.Controllers
{
#pragma warning disable CS1591
    [Route("api/Traits")]
    [ApiController]
    public class TraitsController : ControllerBase
    {
        protected readonly ILogger Logger;
        protected readonly ExaltedDBContext DbContext;

        public TraitsController(ILogger<TraitsController> logger, ExaltedDBContext dbContext)
        {
            Logger = logger;
            DbContext = dbContext;
        }


#pragma warning restore CS1591

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <param name="lastEditedBy"></param>
        /// <param name="colorID"></param>
        /// <param name="outerPackageID"></param>
        /// <param name="supplierID"></param>
        /// <param name="unitPackageID"></param>
        /// <returns></returns>
        [HttpGet("Traits")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetTraitsAsync(int pageSize = 10, int pageNumber = 1, int? lastEditedBy = null, int? colorID = null, int? outerPackageID = null, int? supplierID = null, int? unitPackageID = null)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(GetTraitsAsync));

            var response = new PagedResponse<Traits>();

            try
            {
                // Get the "proposed" query from repository
                var query = DbContext.GetTraits();

                // Set paging values
                response.PageSize = pageSize;
                response.PageNumber = pageNumber;

                // Get the total rows
                response.ItemsCount = await query.CountAsync();

                // Get the specific page from database
                response.Model = await query.Paging(pageSize, pageNumber).ToListAsync();

                response.Message = string.Format("Page {0} of {1}, Total of products: {2}.", pageNumber, response.PageCount, response.ItemsCount);

                Logger?.LogInformation("The stock items have been retrieved successfully.");
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(GetTraitsAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Traits/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetTraitsAsync(int id)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(GetTraitsAsync));

            var response = new SingleResponse<Traits>();

            try
            {
                // Get the stock item by id
                response.Model = await DbContext.GetTraitsAsync(new Traits(id));
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(GetTraitsAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Traits")]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostTraitsAsync([FromBody]Traits request)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(PostTraitsAsync));

            var response = new SingleResponse<Traits>();

            try
            {
                var existingEntity = await DbContext
                    .GetTraitsByTraitsNameAsync(new Traits { Name = request.Name });

                if (existingEntity != null)
                    ModelState.AddModelError("Traits", "Charm Name already exists");

                if (!ModelState.IsValid)
                    return BadRequest();

                // Create entity from request model
                var entity = request.ToEntity();

                // Add entity to repository
                DbContext.Add(entity);

                // Save entity in database
                await DbContext.SaveChangesAsync();

                // Set the entity to response model
                response.Model = entity;
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(PostTraitsAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("Traits/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PutTraitsAsync(int id, [FromBody]Traits request)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(PutTraitsAsync));

            var response = new Response();

            try
            {
                // Get stock item by id
                //var entity = await DbContext.GetTraitsAsync(new Traits(id));

                //// Validate if entity exists
                //if (entity == null)
                //    return NotFound();

                //// Set changes to entity
                //entity.Id = request.Id;
                //entity.Name = request.Name;
                //entity.AttributeTypeId = request.AttributeTypeId;
                //entity.Description = request.Description;

                //// Update entity in repository
                //DbContext.Update(entity);

                //// Save entity in database
                //await DbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(PutTraitsAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Traits/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DeleteTraitsAsync(int id)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteTraitsAsync));

            var response = new Response();

            try
            {
               // Get stock item by id
               var entity = await DbContext.GetTraitsAsync(new Traits(id));

                // Validate if entity exists
                if (entity == null)
                    return NotFound();

                // Remove entity from repository
                DbContext.Remove(entity);

                // Delete entity in database
                await DbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(DeleteTraitsAsync), ex);
            }

            return response.ToHttpResponse();
        }
    }
}
