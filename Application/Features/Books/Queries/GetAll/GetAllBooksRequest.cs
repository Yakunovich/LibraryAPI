using MediatR;

namespace Application.Features.Books.Queries.GetAll
{
    public class GetAllBooksRequest : IRequest<IEnumerable<GetAllBooksResponse>>
    {

    }
}
