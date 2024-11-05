using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IDisciplinaRepository
    {
        Disciplina BuscarPorNome(string nome);
        List<Disciplina> BuscarTodas();
        void Criar(NovaDisciplina novaDisciplina);
    }
}
