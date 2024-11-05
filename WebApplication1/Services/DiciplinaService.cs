using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class DisciplinaService : IDisciplinaService
    {
        private readonly IDisciplinaRepository _disciplinaRepository;

        public DisciplinaService(IDisciplinaRepository disciplinaRepository)
        {
            _disciplinaRepository = disciplinaRepository;
        }

        public bool Criar(NovaDisciplina novaDisciplina)
        {
            // Verifica se a disciplina já existe com o nome informado
            Disciplina disciplinaExistente = _disciplinaRepository.BuscarPorNome(novaDisciplina.Nome);

            if (disciplinaExistente == null)
            {
                _disciplinaRepository.Criar(novaDisciplina);
                return true;
            }
            return false;
        }

        public List<Disciplina> ObterTodos()
        {
            return _disciplinaRepository.BuscarTodas();
        }
    }
}
