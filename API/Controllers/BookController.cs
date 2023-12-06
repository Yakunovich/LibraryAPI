using Application.Features.Books.Command.Add;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetAllBooks()
        //{
        //    var query = new GetAllBooksQuery();
        //    var result = await _mediator.Send(query);
        //    return Ok(result);
        //}
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetBook(int id)
        //{
        //    var query = new GetBookByIdQuery(id);
        //    var result = await _mediator.Send(query);
        //    return Ok(result);
        //}
        //[HttpGet("{ISBN}")]
        //public async Task<IActionResult> GetBookByISBN(string ISBN)
        //{
        //    var Books = await _context.Books.ToListAsync();
        //    if (Books == null) { return NotFound(); }

        //    return Ok(Books);
        //}
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookRequest command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        //[HttpPut]
        //public async Task<IActionResult> ChangeBook()
        //{
        //    var Books = await _context.Books.ToListAsync();
        //    if (Books == null) { return NotFound(); }

        //    return Ok(Books);
        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteBook()
        //{
        //    var Books = await _context.Books.ToListAsync();
        //    if (Books == null) { return NotFound(); }

        //    return Ok(Books);
        //}
    }
}
