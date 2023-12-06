using Application.Mapper;
using Core.Entities;
using Core.Repositories;
using MediatR;

namespace Application.Features.Books.Command.Update
{
    public class UpdateBookHandler : IRequestHandler<UpdateBookRequest, UpdateBookResponse>
    {
        private readonly IBookRepository _bookRepository;

        public UpdateBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<UpdateBookResponse> Handle(UpdateBookRequest request, CancellationToken cancellationToken)
        {
            var book = Mapping.Mapper.Map<Book>(request);
            var updatedBook = await _bookRepository.UpdateBook(book);
            var response = Mapping.Mapper.Map<UpdateBookResponse>(updatedBook);

            return response;
        }
    }
}
