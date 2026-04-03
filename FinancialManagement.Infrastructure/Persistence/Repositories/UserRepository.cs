using FinancialManagement.Domain.Entities;
using FinancialManagement.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinancialManagement.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext) => _dbContext = dbContext;

        public async Task<Users> AddAsync(Users user)
        {
            await _dbContext.Users.AddAsync(user);
            return user;
        }

        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Users?> GetUserByIdAsync(Guid id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
