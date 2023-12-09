using Core.Entities;
using Core.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{

    public class BookRepository : IBookRepository
    {
        private readonly IBookDbContext _context;

        public BookRepository(IBookDbContext context)
        {
            _context = context;
        }
        public async Task<Book> AddBook(Book book)
        {
            var result = await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteBook(int id)
        {
            var result = await _context.Books
                .FirstOrDefaultAsync(b => b.Id == id);
            _context.Books.Remove(result);
            return await _context.SaveChangesAsync();
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _context.Books
                 .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Book> GetBookByISBN(string ISBN)
        {
            return await _context.Books
                .FirstOrDefaultAsync(b => b.ISBN == ISBN);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _context.Books
                .ToListAsync();
        }

        public async Task<Book> UpdateBook(Book book)
        {
            var result = await _context.Books
                .FirstOrDefaultAsync(b => b.Id == book.Id);
            if (result == null)
                return default;

            result.Author = book.Author;
            result.Description = book.Description;
            result.TimeWhenBookMustBeReturned = book.TimeWhenBookMustBeReturned;
            result.TimeWhenBookWasTaken = book.TimeWhenBookWasTaken;
            result.Genre = book.Genre;
            result.ISBN = book.ISBN;
            result.Name = book.Name;

            await _context.SaveChangesAsync();
            return result;

        }

    }
}