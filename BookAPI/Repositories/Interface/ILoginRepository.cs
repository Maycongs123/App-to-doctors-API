using DoctorAPI.Models;

namespace DoctorAPI.Repositories.Interface
{
    public interface ILoginRepository
    {
        List<Usuario> Get(Login login);

    }
}
