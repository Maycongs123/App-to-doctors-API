using DoctorAPI.Models;
using DoctorAPI.Repositories;
using DoctorAPI.Repositories.Interface;
using DoctorAPI.Services;
using DoctorAPI.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public Task<IEnumerable<Usuario>> GetAll()
        {
            return _usuarioService.GetUsuarios();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetById(int id)
        {
            return await _usuarioService.GetUsuarioById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Post(Usuario usuario)
        {
            var newUsuario = await _usuarioService.PostUsuario(usuario);

            if (newUsuario == null)
            {
                return BadRequest();
            }

            return Ok(newUsuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Usuario>> Delete(int id)
        {
            var usuarioToDelete = await _usuarioService.GetUsuarioById(id);

            if (usuarioToDelete == null)
            {
                return NotFound();

            }
            await _usuarioService.Delete(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Usuario>> Put([FromBody] Usuario usuario, int id)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }
            await _usuarioService.PutUsuario(usuario, id);

            return NoContent();
        }
    }
}
