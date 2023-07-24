using DoctorAPI.Models;
using DoctorAPI.Services;
using DoctorAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;
        private readonly ITokenService _tokenService;

        public LoginController(ILoginService loginService, ITokenService tokenService)
        {
            _loginService = loginService;
            _tokenService = tokenService;
        }

        [HttpPost]
        public async Task<ActionResult<Login>> Login(Login login)
        {
            try
            {              

                var _users = _loginService.Get(login);

                if(_users == null)
                {
                    return NotFound();
                }
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
