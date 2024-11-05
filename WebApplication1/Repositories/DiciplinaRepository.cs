using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Services
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private static List<Disciplina> novaDisciplinaList = new List<Disciplina>();

        public DisciplinaRepository() { }

        public void Criar(NovaDisciplina novaDisciplina)
        {
            novaDisciplinaList.Add(new Disciplina()
            {
                IdDisciplina = novaDisciplina.IdDisciplina,
                Nome = novaDisciplina.Nome,
                Curso = novaDisciplina.Curso,
            });
        }

        public List<Disciplina> BuscarTodas()
        {
            return novaDisciplinaList;
        }

        public Disciplina BuscarPorNome(string nome)
        {
            return novaDisciplinaList.FirstOrDefault(d => d.Nome == nome);
        }
    }
}
