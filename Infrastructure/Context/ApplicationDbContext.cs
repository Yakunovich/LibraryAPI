using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book[]
                {
                    new Book{Id = 1, Author = "George Lucas", Description = "Episode one", Genre = "Fantazy", ISBN = "123456789", Name = "Star Wars: Phantom Menace", TimeWhenBookWasTaken = DateTime.Now.AddDays(-1), TimeWhenBookMustBeReturned = DateTime.Now.AddDays(1)},
                    new Book{Id = 2, Author = "George Lucas", Description = "Episode two", Genre = "Fantazy", ISBN = "234567890", Name = "Star Wars: Clone wars", TimeWhenBookWasTaken = DateTime.Now.AddDays(-1), TimeWhenBookMustBeReturned = DateTime.Now.AddDays(1)}
                });
        }

        public DbSet<Book> Books { get; set; }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
