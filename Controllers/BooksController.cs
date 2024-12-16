using Microsoft.AspNetCore.Mvc;
using MyNetCoreApi.Services;
using MyNetCoreApi.DTOs;

namespace MyNetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookService _bookService;

        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookDTO>>> GetBooks()
        {
            var books = await _bookService.GetAllBooks();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookDTO>> GetBookById(int id)
        {
            var book = await _bookService.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult<BookDTO>> CreateBook(BookDTO bookDto)
        {
            var createdBook = await _bookService.AddBook(bookDto);
            return CreatedAtAction(nameof(GetBookById), new { id = createdBook.Id }, createdBook);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateBook(int id, BookDTO bookDto)
        {
            if (id != bookDto.Id)
            {
                return BadRequest();
            }

            await _bookService.UpdateBook(bookDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBook(int id)
        {
            await _bookService.RemoveBook(id);
            return NoContent();
        }
    }
}