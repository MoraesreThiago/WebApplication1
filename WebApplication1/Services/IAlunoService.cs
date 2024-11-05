using WebApplication1.Models;

namespace WebApplication1.Services
{
    public interface IAlunoService
    {
        public List<DadosAluno> obterTodosAlunos();
        public DadosAluno obterAlunosPorCpf(string cpf);

        public bool Inserir(NovoAluno novoAluno);
    }
}
