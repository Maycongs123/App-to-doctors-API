using DoctorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Services.Interface
{
    public interface ILoginService
    {
        Usuario Get(Login login);
    }
}
