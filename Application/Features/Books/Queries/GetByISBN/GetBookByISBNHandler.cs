using Application.Mapper;
using Core.Repositories;
using MediatR;

namespace Application.Features.Books.Queries.GetByISBN
{
    public class GetBookByISBNHandler : IRequestHandler<GetBookByISBNRequest, GetBookByISBNResponse>
    {
        private readonly IBookRepository _bookRepository;
        public GetBookByISBNHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<GetBookByISBNResponse> Handle(GetBookByISBNRequest request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetBookByISBN(request.ISBN);
            var booksResponse = Mapping.Mapper.Map<GetBookByISBNResponse>(book);
            return booksResponse;
        }
    }
}
