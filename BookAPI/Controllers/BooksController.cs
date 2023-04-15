using BookAPI.Models;
using BookAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public Task<IEnumerable<Books>> GetBooks()
        {
            return _bookRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Books>> GetBookById(int id)
        {
            return await _bookRepository.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Books>> PostBooks(Books book)
        {
            Books newBook = await _bookRepository.Create(book);

            return CreatedAtAction(nameof(GetBooks), new {id = newBook.Id}, newBook);
        }

        [HttpDelete]
        public async Task<ActionResult<Books>> Delete(int id)
        {
            Books bookToDelete = await _bookRepository.GetById(id);

            if (bookToDelete == null)
            {
                return NotFound();

            }
            await _bookRepository.Delete(bookToDelete.Id);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult<Books>> PutBooks([FromBody] Books book, int id)
        {
            if (id != book.Id)
            {
                return BadRequest();

            }
            await _bookRepository.Update(book, id);
            return NoContent();
        }
    }
}
