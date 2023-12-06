using Core.Entities;

namespace Core.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBookById(int id);
        Task<Book> GetBookByISBN(string ISBN);
        Task<Book> AddBook(Book book);
        Task<Book> UpdateBook(Book book);
        Task<int> DeleteBook(int id);
    }
}
