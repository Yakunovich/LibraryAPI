using Application.Mapper;
using Core.Repositories;
using MediatR;

namespace Application.Features.Books.Queries.GetAll
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksRequest, IEnumerable<GetAllBooksResponse>>
    {
        private readonly IBookRepository _bookRepository;
        public GetAllBooksHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IEnumerable<GetAllBooksResponse>> Handle(GetAllBooksRequest request, CancellationToken cancellationToken)
        {
            var books = await _bookRepository.GetBooks();
            var booksResponse = Mapping.Mapper.Map<IEnumerable<GetAllBooksResponse>>(books);
            return booksResponse;
        }
    }
}
