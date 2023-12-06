using MediatR;

namespace Application.Features.Books.Queries.GetByISBN
{
    public class GetBookByISBNRequest : IRequest<GetBookByISBNResponse>
    {
        public string ISBN { get; set; }
        public GetBookByISBNRequest(string isbn)
        {
            ISBN = isbn;
        }
    }
}
