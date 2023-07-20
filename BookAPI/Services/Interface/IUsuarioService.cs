using DoctorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Services.Interface
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetUsuarios();
        Task<ActionResult<Usuario>> GetUsuarioById(int id);
        Task<ActionResult<Usuario>> PostUsuario(Usuario usuario);
        Task<ActionResult<Usuario>> Delete(int id);
        Task<ActionResult<Usuario>> PutUsuario([FromBody] Usuario usuario, int id);
    }
}
