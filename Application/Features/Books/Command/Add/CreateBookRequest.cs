using MediatR;

namespace Application.Features.Books.Command.Add
{
    public class CreateBookRequest : IRequest<CreateBookResponse>
    {
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime? TimeWhenBookWasTaken { get; set; }
        public DateTime? TimeWhenBookMustBeReturned { get; set; }

    }
}
