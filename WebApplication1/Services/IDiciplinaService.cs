using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IDisciplinaService
    {
        public List<Disciplina> ObterTodos();

        public bool Criar(NovaDisciplina novaDisciplina);
    }
}