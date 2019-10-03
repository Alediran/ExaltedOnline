using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ExaltedOnlineAPI.Models;

namespace ExaltedOnlineAPI.Controllers
{
#pragma warning disable CS1591
    [Route("api/Attributes")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        protected readonly ILogger Logger;
        protected readonly ExaltedDBContext DbContext;

        public AttributesController(ILogger<AttributesController> logger, ExaltedDBContext dbContext)
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
        [HttpGet("Attributes")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAttributesAsync(int pageSize = 10, int pageNumber = 1, int? lastEditedBy = null, int? colorID = null, int? outerPackageID = null, int? supplierID = null, int? unitPackageID = null)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(GetAttributesAsync));

            var response = new PagedResponse<Attributes>();

            try
            {
                // Get the "proposed" query from repository
                var query = DbContext.GetAttributes();

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

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(GetAttributesAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Attributes/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAttributesAsync(int id)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(GetAttributesAsync));

            var response = new SingleResponse<Attributes>();

            try
            {
                // Get the stock item by id
                response.Model = await DbContext.GetAttributesAsync(new Attributes(id));
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(GetAttributesAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("Attributes")]
        [ProducesResponseType(200)]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PostAttributesAsync([FromBody]Attributes request)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(PostAttributesAsync));

            var response = new SingleResponse<Attributes>();

            try
            {
                var existingEntity = await DbContext
                    .GetAttributesByAttributesNameAsync(new Attributes { Name = request.Name });

                if (existingEntity != null)
                    ModelState.AddModelError("Attributes", "Charm Name already exists");

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

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(PostAttributesAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("Attributes/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> PutAttributesAsync(int id, [FromBody]Attributes request)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(PutAttributesAsync));

            var response = new Response();

            try
            {
                // Get stock item by id
                var entity = await DbContext.GetAttributesAsync(new Attributes(id));

                // Validate if entity exists
                if (entity == null)
                    return NotFound();

                // Set changes to entity
                entity.Id = request.Id;
                entity.Name = request.Name;
                entity.AttributeTypeId = request.AttributeTypeId;
                entity.Description = request.Description;

                // Update entity in repository
                DbContext.Update(entity);

                // Save entity in database
                await DbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                response.DidError = true;
                response.ErrorMessage = "There was an internal error, please contact to technical support.";

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(PutAttributesAsync), ex);
            }

            return response.ToHttpResponse();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Attributes/{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> DeleteAttributesAsync(int id)
        {
            Logger?.LogDebug("'{0}' has been invoked", nameof(DeleteAttributesAsync));

            var response = new Response();

            try
            {
                // Get stock item by id
                var entity = await DbContext.GetAttributesAsync(new Attributes(id));

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

                Logger?.LogCritical("There was an error on '{0}' invocation: {1}", nameof(DeleteAttributesAsync), ex);
            }

            return response.ToHttpResponse();
        }
    }
}
