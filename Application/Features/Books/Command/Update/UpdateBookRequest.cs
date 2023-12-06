using MediatR;

namespace Application.Features.Books.Command.Update
{
    public class UpdateBookRequest : IRequest<UpdateBookResponse>
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime? TimeWhenBookWasTaken { get; set; }
        public DateTime? TimeWhenBookMustBeReturned { get; set; }
    }
}
