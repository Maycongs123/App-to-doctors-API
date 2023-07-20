using DoctorAPI.Models;

namespace DoctorAPI.Repositories.Interface
{
    public interface IMedicamentoRepository
    {
        Task<IEnumerable<Medicamento>> GetAll();

        Task<Medicamento> GetById(int id);

        Task<Medicamento> Create(Medicamento medicamento);

        Task Update(Medicamento medicamento, int id);

        Task Delete(int id);

    }
}
