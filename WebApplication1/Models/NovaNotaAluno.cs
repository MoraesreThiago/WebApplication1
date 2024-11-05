using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;

namespace WebApplication1.Models
{
    public class NovaNotaAluno
    {
        [Required(ErrorMessage = "Obrigatório")]
        public int RaAluno { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public int IdDisciplina { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public double Nota { get; set; }
        [Required(ErrorMessage = "Obrigatório")]
        public double Frequencia { get; set; }
    }
}
