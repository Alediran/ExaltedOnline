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
                TypeId = request.TypeId,
                Type = request.Type,
                DurationId = request.DurationId,
                Duration = request.Duration,
                Description = request.Description,
                IsCustomCharm = request.IsCustomCharm,
                GameId = request.GameId,
                CharmTraits = request.CharmTraits,
                CharmCosts = request.CharmCosts,
                CharmKeywords = request.CharmKeywords,
                CharmPrerequisitesCharm = request.CharmPrerequisitesCharm                
            };
        #endregion

        #region "Traits"
        public static IQueryable<Traits> GetTraits(this ExaltedDBContext dbContext, int pageSize = 10, int pageNumber = 1, int? Id = null, string Name = null)
        {
            // Get query from DbSet
            var query = dbContext.Traits.AsQueryable();

            // Filter by: 'Id'
            if (Id.HasValue)
                query = query.Where(item => item.Id == Id);

            // Filter by: 'Name'
            if (!string.IsNullOrEmpty(Name))
                query = query.Where(item => item.Name == Name);

            return query;
        }

        public static async Task<Traits> GetTraitsAsync(this ExaltedDBContext dbContext, Traits entity)
            => await dbContext.Traits.FirstOrDefaultAsync(item => item.Id == entity.Id).ConfigureAwait(true);

        public static async Task<Traits> GetTraitsByTraitsNameAsync(this ExaltedDBContext dbContext, Traits entity)
            => await dbContext.Traits.FirstOrDefaultAsync(item => item.Name == entity.Name).ConfigureAwait(true);

        public static Traits ToEntity(this Traits request)
            => new Traits
            {
                Id = request.Id,
                Name = request.Name,
                TraitTypeId = request.TraitTypeId,
                Description = request.Description
            };
        #endregion

        #region "Users"
        public static IQueryable<Users> GetUsers(this ExaltedDBContext dbContext, int pageSize = 10, int pageNumber = 1, int? Id = null, string UserName = null, string Password = null)
        {
            // Get query from DbSet
            var query = dbContext.Users.AsQueryable();

            // Filter by: 'Id'
            if (Id.HasValue)
                query = query.Where(item => item.Id == Id);

            // Filter by: 'Name'
            if (!string.IsNullOrEmpty(UserName))
                query = query.Where(item => item.UserName == UserName);

            return query;
        }

        public static async Task<Users> GetUsersAsync(this ExaltedDBContext dbContext, Users entity)
            => await dbContext.Users.FirstOrDefaultAsync(item => item.Id == entity.Id).ConfigureAwait(true);

        public static Users ToEntity(this Users request)
            => new Users
            {
                Id = request.Id,
                UserName = request.UserName,
                SignatureFirst = request.SignatureFirst
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
