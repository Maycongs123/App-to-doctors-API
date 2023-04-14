using BookAPI.Models;

namespace BookAPI.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Books>> GetAll();

        Task<Books> GetById(int id);

        Task<Books> Create(Books book);

        Task Update(Books book);

        Task Delete(int id);

    }
}
