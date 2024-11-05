using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
             _alunoRepository = alunoRepository;
        }
        public bool Inserir(NovoAluno novoAluno)
        {
           DadosAluno dadosAluno = _alunoRepository
                .obterAlunosPorCpf(novoAluno.cpf);

            //outras de negocio, exemplo curso existir
           if (dadosAluno == null && dadosAluno.ra != novoAluno.ra)
            {
                _alunoRepository.Inserir(novoAluno);
                return true;
            }
            return false;

        }

        public DadosAluno obterAlunosPorCpf(string cpf)
        {
           return  _alunoRepository.obterAlunosPorCpf(cpf);
        }

        public List<DadosAluno> obterTodosAlunos()
        {
            return _alunoRepository.obterTodosAlunos();
        }
    }
}