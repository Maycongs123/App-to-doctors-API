using DoctorAPI.Models;
using DoctorAPI.Repositories.Interface;
using DoctorAPI.Services.Interface;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace DoctorAPI.Services
{
    public class MedicamentoService : IMedicamentoService
    {
        private readonly IMedicamentoRepository _medicamentoRepository;

        public MedicamentoService(IMedicamentoRepository medicamentoRepository)
        {
            _medicamentoRepository = medicamentoRepository;
        }
        
        public Task<IEnumerable<Medicamento>> GetMedicamentos()
        {
            return _medicamentoRepository.GetAll();
        }
       
        public async Task<ActionResult<Medicamento>> GetMedicamentoById(int id)
        {
            return await _medicamentoRepository.GetById(id);
        }
       
        public async Task<ActionResult<Medicamento>> PostMedicamento(Medicamento medicamento)
        {
            Medicamento newMedicamento = await _medicamentoRepository.Create(medicamento);

            return newMedicamento;
        }
       
        public async Task<ActionResult<Medicamento>> Delete(int id)
        {
            Medicamento medicamentoToDelete = await _medicamentoRepository.GetById(id);
          
            await _medicamentoRepository.Delete(medicamentoToDelete.Id);

            return medicamentoToDelete;
        }
  
        public async Task<ActionResult<Medicamento>> PutMedicamento([FromBody] Medicamento medicamento, int id)
        {
         
            await _medicamentoRepository.Update(medicamento, id);

            return medicamento;
        }
    }
}
