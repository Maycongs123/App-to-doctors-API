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
            _context.Usuarios.Add(usuario);

            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task Delete(int id)
        {
            var usuarioToDelete = await _context.Usuarios.FindAsync(id);

            _context.Usuarios.Remove(usuarioToDelete);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Usuario>> GetAll()
        {
          return await  _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetById(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task Update(Usuario usuario, int id)
        {
            try
            {
                Usuario findUsuario = await _context.Usuarios.FindAsync(id);

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
    }
}
