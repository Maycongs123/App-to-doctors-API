using DoctorAPI.Models;
using DoctorAPI.Repositories;
using DoctorAPI.Repositories.Interface;
using DoctorAPI.Services.Interface;

namespace DoctorAPI.Services
{
    public class LoginService : ILoginService
    {
        private readonly LoginRepository _loginRepository;

        public LoginService(LoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public Usuario Get(Login login)
        {
            try
            {
                var users = _loginRepository.Get(login);
                var user = users.FirstOrDefault();
                return user;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception);
            }
        }
    }
}
