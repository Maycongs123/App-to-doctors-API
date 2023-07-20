using System.Net.NetworkInformation;

namespace DoctorAPI.Models
{
    public class Medicamento
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? MedicamentoUso { get; set; }
        public string? Tipo { get; set; }
        public string? dosagemTipo { get; set; }
        public string? ModoDeUso { get; set; }
        public string? QuantidadeMg { get; set; }
        public string? QuantidadeMl { get; set; }
        public float? QuantidadeMgKg { get; set; }
        public float? QuantidadeSoro { get; set; }
        public string? Indicacao { get; set; }
        public string? ContraIndicacao { get; set; }
        public float? NumeroDoses { get; set; }
        public float? QuantidadeAmpolas { get; set; }

    }  
}
