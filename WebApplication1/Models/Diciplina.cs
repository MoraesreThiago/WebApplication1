using System.ComponentModel.DataAnnotations;
using WebApplication1.Validations;

namespace WebApplication1.Models
{
    public class Disciplina
    {
        public int IdDisciplina { get; set; }
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Id { get; internal set; }
    }
}
