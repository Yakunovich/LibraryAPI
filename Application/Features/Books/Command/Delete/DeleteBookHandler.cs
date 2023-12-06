using Application.Mapper;
using Core.Repositories;
using MediatR;

namespace Application.Features.Books.Command.Delete
{
    internal class DeleteBookHandler : IRequestHandler<DeleteBookRequest, DeleteBookResponse>
    {
        private readonly IBookRepository _bookRepository;

        public DeleteBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<DeleteBookResponse> Handle(DeleteBookRequest request, CancellationToken cancellationToken)
        {

            var book = await _bookRepository.GetBookById(request.Id);
            if (book == null)
                return default;

            var result = await _bookRepository.DeleteBook(book.Id);
            var response = Mapping.Mapper.Map<DeleteBookResponse>(result);

            return response;

        }
    }
}
