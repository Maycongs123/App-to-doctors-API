using System.Net.NetworkInformation;

namespace DoctorAPI.Models
{
    public class Medicamento
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? MedicamentoUso { get; set; }

        public string? CalculoRenal { get; set; }

        public string? AlteracaoValorFaixas { get; set; }

        public string? Faixa_Hemodialise_Horario { get; set; }

        public int? Valor_1_ClearanceCreatinina { get; set; }

        public int? Valor_2_ClearanceCreatinina { get; set; }

        public int? Valor_3_ClearanceCreatinina { get; set; }

        public int? Valor_1_Porcetagem_ClearanceCreatinina { get; set; }

        public int? Valor_2_Porcetagem_ClearanceCreatinina { get; set; }

        public int? Valor_3_Porcetagem_ClearanceCreatinina { get; set; }

        public string? Faixa_1_HorarioClCr { get; set; }

        public string? Faixa_2_HorarioClCr { get; set; }

        public string? Faixa_3_HorarioClCr { get; set; }

        public int? DosagemMaxima { get; set; }

        public int? VariacaoMinimaDosagemMaxima { get; set; }

        public int? VariacaoMaximaDosagemMaxima { get; set; }

        public string? Tipo { get; set; }

        public string? DosagemTipo { get; set; }

        public string? ModoDeUso { get; set; }

        public string? QuantidadeMg { get; set; }

        public string? QuantidadeMl { get; set; }

        public float? QuantidadeMgKg { get; set; }

        public float? QuantidadeSoro { get; set; }

        public string? Indicacao { get; set; }

        public string? ContraIndicacao { get; set; }

        public float? NumeroDoses { get; set; }

        public float? QuantidadeAmpolas { get; set; }

        public string? Dose { get; set; }

        public string? PreparoDiluicao { get; set; }

        public string? Administracao { get; set; }

        public string? UsoGestacao { get; set; }

    }  
}
