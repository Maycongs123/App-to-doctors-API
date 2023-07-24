using DoctorAPI.Models;
using DoctorAPI.Repositories;
using DoctorAPI.Repositories.Interface;
using DoctorAPI.Services;
using DoctorAPI.Services.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MedicamentosController : ControllerBase
    {
        private readonly IMedicamentoService _medicamentoService;

        public MedicamentosController(IMedicamentoService medicamentoService)
        {
            _medicamentoService = medicamentoService;
        }

        [HttpGet]
        public Task<IEnumerable<Medicamento>> GetAll()
        {
            return _medicamentoService.GetMedicamentos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Medicamento>> GetById(int id)
        {
            return await _medicamentoService.GetMedicamentoById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Medicamento>> Post(Medicamento medicamento)
        {
            var newMedicamento = await _medicamentoService.PostMedicamento(medicamento);

            if (newMedicamento == null)
            {
                return BadRequest();
            }

            return Ok(newMedicamento);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Medicamento>> Delete(int id)
        {
            var medicamentoToDelete = await _medicamentoService.GetMedicamentoById(id);

            if (medicamentoToDelete == null)
            {
                return NotFound();

            }
            await _medicamentoService.Delete(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Medicamento>> Put([FromBody] Medicamento medicamento, int id)
        {
            if (id != medicamento.Id)
            {
                return BadRequest();
            }
            await _medicamentoService.PutMedicamento(medicamento, id);

            return NoContent();
        }
    }
}
