using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class BookDbContext : DbContext, IBookDbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasIndex(b => b.ISBN)
                        .IsUnique();

                entity.Property(b => b.ISBN)
                        .IsRequired()
                        .HasMaxLength(13);

            });

            modelBuilder.Entity<Book>().HasData(
                new Book[]
                {
                    new Book{Id = 1, Author = "George Lucas", Description = "Episode one", Genre = "Fantazy", ISBN = "1234567890123", Name = "Star Wars: Phantom Menace", TimeWhenBookWasTaken = DateTime.Now.AddDays(-1), TimeWhenBookMustBeReturned = DateTime.Now.AddDays(1)},
                    new Book{Id = 2, Author = "George Lucas", Description = "Episode two", Genre = "Fantazy", ISBN = "1234567890124", Name = "Star Wars: Clone wars", TimeWhenBookWasTaken = DateTime.Now.AddDays(-1), TimeWhenBookMustBeReturned = DateTime.Now.AddDays(1)}
                });
        }

        public DbSet<Book> Books { get; set; }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
