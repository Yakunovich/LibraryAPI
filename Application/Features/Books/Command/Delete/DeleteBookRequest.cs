using MediatR;

namespace Application.Features.Books.Command.Delete
{
    public class DeleteBookRequest : IRequest<DeleteBookResponse>
    {
        public int Id { get; set; }
        public DeleteBookRequest(int id)
        {
            Id = id;
        }
    }
}
