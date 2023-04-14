using BookAPI.Models;
using BookAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    public class BooksController
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

    }
}
