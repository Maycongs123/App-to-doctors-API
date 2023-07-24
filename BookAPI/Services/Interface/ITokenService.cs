using DoctorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Services.Interface
{
    public interface ITokenService
    {
        string GenerateToken(Usuario usuario);
    }
}
