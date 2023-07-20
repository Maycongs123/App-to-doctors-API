using DoctorAPI.Models;
using DoctorAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private readonly LoginService _loginService;
        private readonly TokenService _tokenService;

        public LoginController(LoginService loginService, TokenService tokenService)
        {
            _loginService = loginService;
            _tokenService = tokenService;
        }
        [HttpPost]
        public ActionResult Login([FromBody] Login login)
        {

            try
            {              

                var _users = _loginService.Get(login);               

                string _token = _tokenService.GenerateToken(_users);

                var token = new { token = _token };

                return Ok(token);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message, exception);
            }
        }

    }
}
