using DoctorAPI.Models;
using DoctorAPI.Repositories.Interface;
using DoctorAPI.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace DoctorAPI.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        public readonly DoctorsContext _context;

        public LoginRepository(DoctorsContext context)
        {
            _context = context;
        }

        public List<Usuario> Get(Login login)
        {         
            var users = _context.Usuarios
                .Where(u => u.Email == login.Email && u.Password == login.Password)
                .ToList();

            return users;
        }
    }
}
