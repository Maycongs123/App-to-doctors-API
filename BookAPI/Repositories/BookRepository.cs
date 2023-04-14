using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly BooksContext _context;

        public BookRepository(BooksContext context)
        {
            _context = context; 
        }


        public async Task<Books> Create(Books book)
        {
            _context.Books.Add(book);

            await _context.SaveChangesAsync();

            return book;
        }

        public async Task Delete(int id)
        {
            var bookToDelete = await _context.Books.FindAsync(id);

            _context.Books.Remove(bookToDelete);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Books>> GetAll()
        {
          return await  _context.Books.ToListAsync();
        }

        public async Task<Books> GetById(int id)
        {
            return await _context.Books.FindAsync(id);
        }

        public async Task Update(Books book)
        {
            _context.Entry(book).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
