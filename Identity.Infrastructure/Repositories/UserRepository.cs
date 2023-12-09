using Identity.Core.Entities;
using Identity.Core.Repositories;
using Identity.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IIdentityDbContext _context;
        public UserRepository(IIdentityDbContext context)
        {
            _context = context;
        }
        public async Task<User> AddUser(User user)
        {
            var result = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<User> GetUser(User user)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == user.Username && u.Password == user.Password);
        }
    }
}
