using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExaltedOnlineAPI.Models
{
#pragma warning disable CS1591
    public static class ExaltedDBDbContextExtensions
    {
        #region "Charms"
        public static IQueryable<Charms> GetCharms(this ExaltedDBContext dbContext, int pageSize = 10, int pageNumber = 1, int? Id = null, string Name = null, int? Essence = null, bool? IsCustomCharm = null, int? GameId = null)
        {
            // Get query from DbSet
            var query = dbContext.Charms.AsQueryable();            

            // Filter by: 'Id'
            if (Id.HasValue)
                query = query.Where(item => item.Id == Id);

            // Filter by: 'Name'
            if (!string.IsNullOrEmpty(Name))
                query = query.Where(item => item.Name == Name);

            // Filter by: 'Essence'
            if (Essence.HasValue)
                query = query.Where(item => item.Essence == Essence);

            // Filter by: 'IsCustomCharm'
            if (IsCustomCharm.HasValue)
                query = query.Where(item => item.IsCustomCharm == IsCustomCharm);

            // Filter by: 'GameId'
            if (GameId.HasValue)
                query = query.Where(item => item.GameId == GameId);

            return query;                       
        }

        public static async Task<Charms> GetCharmsAsync(this ExaltedDBContext dbContext, Charms entity)
            => await dbContext.Charms.FirstOrDefaultAsync(item => item.Id == entity.Id);

        public static async Task<Charms> GetCharmsByCharmsNameAsync(this ExaltedDBContext dbContext, Charms entity)
            => await dbContext.Charms.FirstOrDefaultAsync(item => item.Name == entity.Name);

        public static Charms ToEntity(this Charms request)
            => new Charms
            {
                Id = request.Id,
                Name = request.Name,
                Essence = request.Essence,
                TreeTypeId = request.TreeTypeId,                
                TreeType = request.TreeType,
                TypeId = request.TypeId,
                Type = request.Type,
                DurationId = request.DurationId,
                Duration = request.Duration,
                Description = request.Description,
                IsCustomCharm = request.IsCustomCharm,
                GameId = request.GameId,
                CharmAttributes = request.CharmAttributes,
                CharmCosts = request.CharmCosts,
                CharmKeywords = request.CharmKeywords,
                CharmPrerequisitesCharm = request.CharmPrerequisitesCharm                
            };
        #endregion

        #region "Attributes"
        public static IQueryable<Attributes> GetAttributes(this ExaltedDBContext dbContext, int pageSize = 10, int pageNumber = 1, int? Id = null, string Name = null)
        {
            // Get query from DbSet
            var query = dbContext.Attributes.AsQueryable();

            // Filter by: 'Id'
            if (Id.HasValue)
                query = query.Where(item => item.Id == Id);

            // Filter by: 'Name'
            if (!string.IsNullOrEmpty(Name))
                query = query.Where(item => item.Name == Name);

            return query;
        }

        public static async Task<Attributes> GetAttributesAsync(this ExaltedDBContext dbContext, Attributes entity)
            => await dbContext.Attributes.FirstOrDefaultAsync(item => item.Id == entity.Id);

        public static async Task<Attributes> GetAttributesByAttributesNameAsync(this ExaltedDBContext dbContext, Attributes entity)
            => await dbContext.Attributes.FirstOrDefaultAsync(item => item.Name == entity.Name);

        public static Attributes ToEntity(this Attributes request)
            => new Attributes
            {
                Id = request.Id,
                Name = request.Name,
                AttributeTypeId = request.AttributeTypeId,
                Description = request.Description
            };
        #endregion

    }

    public static class IQueryableExtensions
    {
        public static IQueryable<TModel> Paging<TModel>(this IQueryable<TModel> query, int pageSize = 0, int pageNumber = 0) where TModel : class
            => pageSize > 0 && pageNumber > 0 ? query.Skip((pageNumber - 1) * pageSize).Take(pageSize) : query;
    }
#pragma warning restore CS1591
}
