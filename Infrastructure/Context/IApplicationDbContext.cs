using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public interface IApplicationDbContext
    {
        DbSet<Book> Books { get; set; }
        Task<int> SaveChangesAsync();
    }
}
