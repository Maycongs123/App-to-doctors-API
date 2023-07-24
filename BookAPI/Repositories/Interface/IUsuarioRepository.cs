using DoctorAPI.Models;

namespace DoctorAPI.Repositories.Interface
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> GetAll();

        Task<Usuario> GetById(int id);

        Task<Usuario> Create(Usuario usuario);

        Task Update(Usuario usuario, int id);

        Task Delete(int id);

        Usuario GetByLogin(Login login);

    }
}
