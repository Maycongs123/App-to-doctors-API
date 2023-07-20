using DoctorAPI.Models;
using DoctorAPI.Repositories.Interface;
using DoctorAPI.Services.Interface;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace DoctorAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        
        public Task<IEnumerable<Usuario>> GetUsuarios()
        {
            return _usuarioRepository.GetAll();
        }

       
        public async Task<ActionResult<Usuario>> GetUsuarioById(int id)
        {
            return await _usuarioRepository.GetById(id);
        }
       
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            Usuario newUsuario = await _usuarioRepository.Create(usuario);

            return newUsuario;
        }
       
        public async Task<ActionResult<Usuario>> Delete(int id)
        {
            Usuario usuarioToDelete = await _usuarioRepository.GetById(id);
          
            await _usuarioRepository.Delete(usuarioToDelete.Id);

            return usuarioToDelete;
        }
  
        public async Task<ActionResult<Usuario>> PutUsuario([FromBody] Usuario usuario, int id)
        {
         
            await _usuarioRepository.Update(usuario, id);

            return usuario;
        }
    }
}
