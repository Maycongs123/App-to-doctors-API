using DoctorAPI.Models;
using DoctorAPI.Repositories;
using DoctorAPI.Repositories.Interface;
using DoctorAPI.Services.Interface;

namespace DoctorAPI.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        private readonly IUsuarioRepository _usuarioRepository;

        public LoginService(ILoginRepository loginRepository, IUsuarioRepository usuarioRepository)
        {
            _loginRepository = loginRepository;
            _usuarioRepository = usuarioRepository;
        }
        public Usuario Get(Login login)
        {
            try
            {
                //var users = _loginRepository.Get(login);
                //var user = users.FirstOrDefault();
                var user = _usuarioRepository.GetByLogin(login);
                return user;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception);
            }
        }
    }
}
