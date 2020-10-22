using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineLibrary.Data
{
    public class OnlineAccessService
    {
        private readonly ApplicationDbContext _dbContext;

        public OnlineAccessService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<OnlineAccess>> GetOnlineAccesssesAsync()
        {
            return await _dbContext.OnlineAccess.ToListAsync();
        }

        public async Task<OnlineAccess> GetOnlineAccessAsync(int onlineAccessId)
        {
            return await _dbContext.OnlineAccess.FirstOrDefaultAsync(onlineAccess => onlineAccess.OnlineAccessId == onlineAccessId);
        }

        public async Task<bool> RemoveOnlineAccessAsync(int onlineAccessId)
        {
            var onlineAccess = await _dbContext.OnlineAccess.FirstOrDefaultAsync(onlineAccess => onlineAccess.OnlineAccessId == onlineAccessId);
            _dbContext.OnlineAccess.Remove(onlineAccess);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateOnlineAccessAsync(OnlineAccess onlineAccess)
        {
            _dbContext.OnlineAccess.Update(onlineAccess);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> AddOnlineAccessAsync(OnlineAccess onlineAccess)
        {
            await _dbContext.OnlineAccess.AddAsync(onlineAccess);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}