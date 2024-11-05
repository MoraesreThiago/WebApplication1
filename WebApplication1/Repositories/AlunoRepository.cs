using WebApplication1.Models;

namespace WebApplication1.Services
{
	public class AlunoRepository : IAlunoRepository
	{
		private static List<DadosAluno> dadosAlunosList = new List<DadosAluno>();

		public AlunoRepository() { }

		public void Inserir(NovoAluno novoAluno)
		{
			dadosAlunosList.Add(new DadosAluno() { 
				cpf = novoAluno.cpf,
				email = novoAluno.email,
				 nome = novoAluno.nome,
				 telefone = novoAluno.telefone,
				 ra = novoAluno.ra
			});
		}

		public DadosAluno obterAlunosPorCpf(string cpf)
		{
			return dadosAlunosList.Where(a => a.cpf == cpf).FirstOrDefault();
		}

		public List<DadosAluno> obterTodosAlunos()
		{
			return dadosAlunosList;
		}
	}
}
