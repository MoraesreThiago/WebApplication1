using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;

namespace WebApplication1.Models
{
    public class NotaAluno
    {
        public int RaAluno { get; set; }
        public int IdDisciplina { get; set; }
        public double Nota { get; set; }
        public double Frequencia { get; set; }
    }
}
