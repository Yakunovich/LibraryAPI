using MediatR;

namespace Application.Features.Books.Queries.GetById
{
    public class GetBookByIdRequest : IRequest<GetBookByIdResponse>
    {
        public int Id { get; set; }
        public GetBookByIdRequest(int id)
        {
            Id = id;
        }
    }
}
