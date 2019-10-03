using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExaltedOnlineAPI.Models
{
#pragma warning disable CS1591
    public static class ExaltedDBDbContextExtensions
    {
        public static IQueryable<Charms> GetStockItems(this ExaltedDBContext dbContext, int pageSize = 10, int pageNumber = 1, int? Id = null, int? Essence = null, bool? IsCustomCharm = null, int? GameId = null)
        {
            // Get query from DbSet
            var query = dbContext.Charms.AsQueryable();

            // Filter by: 'Id'
            if (Id.HasValue)
                query = query.Where(item => item.Id == Id);

            // Filter by: 'Id'
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

        public static async Task<Charms> GetStockItemsAsync(this ExaltedDBContext dbContext, Charms entity)
            => await dbContext.Charms.FirstOrDefaultAsync(item => item.Id == entity.Id);

        public static async Task<Charms> GetStockItemsByStockItemNameAsync(this ExaltedDBContext dbContext, Charms entity)
            => await dbContext.Charms.FirstOrDefaultAsync(item => item.Name == entity.Name);
    }

    public static class IQueryableExtensions
    {
        public static IQueryable<TModel> Paging<TModel>(this IQueryable<TModel> query, int pageSize = 0, int pageNumber = 0) where TModel : class
            => pageSize > 0 && pageNumber > 0 ? query.Skip((pageNumber - 1) * pageSize).Take(pageSize) : query;
    }
#pragma warning restore CS1591
}
