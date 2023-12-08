using Application.Features.Books.Command.Add;
using Application.Features.Books.Command.Delete;
using Application.Features.Books.Command.Update;
using Application.Features.Books.Queries.GetAll;
using Application.Features.Books.Queries.GetById;
using Application.Features.Books.Queries.GetByISBN;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<BooksController> _logger;
        public BooksController(IMediator mediator, ILogger<BooksController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var result = await _mediator.Send(new GetAllBooksRequest());
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook([FromRoute] int id)
        {
            var result = await _mediator.Send(new GetBookByIdRequest(id));
            return result == null ? NotFound() : Ok(result);
        }
        [HttpGet("GetByISBN/{ISBN}")]
        public async Task<IActionResult> GetBookByISBN([FromRoute] string ISBN)
        {
            var result = await _mediator.Send(new GetBookByISBNRequest(ISBN));
            return result == null ? NotFound() : Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookRequest command)
        {
            var result = await _mediator.Send(command);
            return result == null ? BadRequest() : Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook([FromRoute] int id, [FromBody] UpdateBookRequest command)
        {
            command.Id = id;
            var result = await _mediator.Send(command);
            return result == null ? NotFound() : Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            var result = await _mediator.Send(new DeleteBookRequest(id));
            return result == null ? BadRequest() : Ok(result);
        }
    }
}
