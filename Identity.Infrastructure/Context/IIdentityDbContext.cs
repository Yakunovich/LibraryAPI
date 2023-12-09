using Identity.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infrastructure.Context
{
    public interface IIdentityDbContext
    {
        DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync();
    }
}
