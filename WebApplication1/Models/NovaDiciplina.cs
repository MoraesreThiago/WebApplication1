using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;

namespace WebApplication1.Models
{
    public class NovaDisciplina
    {
        [Required(ErrorMessage = "Obrigatório")]
        public int IdDisciplina { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Curso { get; set; }
    }
}
