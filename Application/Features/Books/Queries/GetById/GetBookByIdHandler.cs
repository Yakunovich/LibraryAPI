using Application.Mapper;
using Core.Repositories;
using MediatR;

namespace Application.Features.Books.Queries.GetById
{
    public class GetBookByIdHandler : IRequestHandler<GetBookByIdRequest, GetBookByIdResponse>
    {
        private readonly IBookRepository _bookRepository;
        public GetBookByIdHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<GetBookByIdResponse> Handle(GetBookByIdRequest request, CancellationToken cancellationToken)
        {
            var book = await _bookRepository.GetBookById(request.Id);
            var booksResponse = Mapping.Mapper.Map<GetBookByIdResponse>(book);
            return booksResponse;
        }
    }
}
