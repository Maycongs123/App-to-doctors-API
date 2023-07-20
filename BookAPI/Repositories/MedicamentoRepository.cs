using DoctorAPI.Models;
using DoctorAPI.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace DoctorAPI.Repositories
{
    public class MedicamentoRepository : IMedicamentoRepository
    {
        public readonly DoctorsContext _context;

        public MedicamentoRepository(DoctorsContext context)
        {
            _context = context; 
        }

        public async Task<Medicamento> Create(Medicamento medicamento)
        {
            _context.Medicamentos.Add(medicamento);

            await _context.SaveChangesAsync();

            return medicamento;
        }

        public async Task Delete(int id)
        {
            var medicamentoToDelete = await _context.Medicamentos.FindAsync(id);

            _context.Medicamentos.Remove(medicamentoToDelete);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Medicamento>> GetAll()
        {
          return await  _context.Medicamentos.ToListAsync();
        }

        public async Task<Medicamento> GetById(int id)
        {
            return await _context.Medicamentos.FindAsync(id);
        }

        public async Task Update(Medicamento medicamento, int id)
        {
            try
            {
                Medicamento findMedicamento = await _context.Medicamentos.FindAsync(id);

                if (findMedicamento != null)
                {
                    // Monitora as mudanças no objeto "findMedicamento"
                    _context.Entry(findMedicamento).CurrentValues.SetValues(medicamento);
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }

            await _context.SaveChangesAsync();
        }
    }
}
