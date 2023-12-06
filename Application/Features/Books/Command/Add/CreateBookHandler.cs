using Application.Mapper;
using Core.Entities;
using Core.Repositories;
using MediatR;

namespace Application.Features.Books.Command.Add
{
    public class CreateBookHandler : IRequestHandler<CreateBookRequest, CreateBookResponse>
    {
        private readonly IBookRepository _bookRepository;

        public CreateBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<CreateBookResponse> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            var book = Mapping.Mapper.Map<Book>(request);
            if (book == null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            var newBook = await _bookRepository.AddBook(book);
            var bookResponse = Mapping.Mapper.Map<CreateBookResponse>(newBook);
            return bookResponse;
        }
    }
}
