using DoctorAPI.Models;
using DoctorAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace DoctorAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public readonly DoctorsContext _context;

        public UsuarioRepository(DoctorsContext context)
        {
            _context = context; 
        }

        public async Task<Usuario> Create(Usuario usuario)
        {
            _context.Usuario.Add(usuario);

            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task Delete(int id)
        {
            var usuarioToDelete = await _context.Usuario.FindAsync(id);

            _context.Usuario.Remove(usuarioToDelete);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
          return await  _context.Usuario.ToListAsync();
        }

        public async Task<Usuario> GetById(int id)
        {
            return await _context.Usuario.FindAsync(id);
        }

        public async Task Update(Usuario usuario, int id)
        {
            try
            {
                Usuario findUsuario = await _context.Usuario.FindAsync(id);

                if (findUsuario != null)
                {
                    // Monitora as mudanças no objeto "findUsuario"
                    _context.Entry(findUsuario).CurrentValues.SetValues(usuario);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

            await _context.SaveChangesAsync();
        }

        public Usuario GetByLogin(Login login)
        {
            try
            {
                var user = _context.Usuario.FirstOrDefault(u => u.Email == login.Email && u.Password == login.Password);

                return user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }
    }
}
