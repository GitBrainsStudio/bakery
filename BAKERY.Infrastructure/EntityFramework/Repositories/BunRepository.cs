using Microsoft.EntityFrameworkCore;

using BAKERY.Domain.Entites;
using BAKERY.Domain.Repositories;
using BAKERY.Infrastructure.EntityFramework.Contexts;

namespace BAKERY.Infrastucture.EntityFramework.Repositories
{
    public class BunRepository : IBunRepository
    {
        private readonly DataBaseContext _dbContext;

        public BunRepository(DataBaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Bun>> GetAll()
        {
            return await _dbContext.Buns.ToListAsync();
        }

        public async Task Create(IEnumerable<Bun> buns)
        {
            foreach(var bun in buns)
            {
                await _dbContext.AddAsync(bun);
            }
            
            await _dbContext.SaveChangesAsync();
        }
    }
}
