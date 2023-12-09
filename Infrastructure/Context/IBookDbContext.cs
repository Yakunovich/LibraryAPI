using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public interface IBookDbContext
    {
        DbSet<Book> Books { get; set; }
        Task<int> SaveChangesAsync();
    }
}
