using DoctorAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Services.Interface
{
    public interface IMedicamentoService
    {
        Task<IEnumerable<Medicamento>> GetMedicamentos();
        Task<ActionResult<Medicamento>> GetMedicamentoById(int id);
        Task<ActionResult<Medicamento>> PostMedicamento(Medicamento medicamento);
        Task<ActionResult<Medicamento>> Delete(int id);
        Task<ActionResult<Medicamento>> PutMedicamento([FromBody] Medicamento medicamento, int id);
    }
}
