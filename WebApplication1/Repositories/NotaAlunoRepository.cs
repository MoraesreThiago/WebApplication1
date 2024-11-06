using WebApplication1.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Repositories
{
    public class NotaAlunoRepository : INotaAlunoRepository
    {
        private static List<NotaAluno> NotaAlunosList = new List<NotaAluno>();
        private static List<DadosAluno> AlunosList = new List<DadosAluno>();
        private static List<Disciplina> DisciplinasList = new List<Disciplina>();

        public void InserirNota(NovaNotaAluno novaNotaAluno)
        {
            if (!AlunoExiste(novaNotaAluno.RaAluno))
            {
                throw new Exception("O aluno não existe.");
            }

            if (!DisciplinaExiste(novaNotaAluno.IdDisciplina))
            {
                throw new Exception("A disciplina não existe.");
            }

            if (NotaJaExiste(novaNotaAluno.RaAluno, novaNotaAluno.IdDisciplina))
            {
                throw new Exception("Nota já inserida para o aluno nesta disciplina.");
            }

            NotaAlunosList.Add(new NotaAluno()
            {
                RaAluno = novaNotaAluno.RaAluno,
                IdDisciplina = novaNotaAluno.IdDisciplina,
                Nota = novaNotaAluno.Nota,
                Frequencia = novaNotaAluno.Frequencia
            });
        }

        private bool NotaJaExiste(string raAluno, int idDisciplina)
        {
            throw new NotImplementedException();
        }

        private bool AlunoExiste(string raAluno)
        {
            throw new NotImplementedException();
        }

        public bool AlunoExiste(int raAluno)
        {
            return AlunosList.Any(a => a.ra == raAluno);
        }

        public bool DisciplinaExiste(int idDisciplina)
        {
            return DisciplinasList.Any(d => d.Id == idDisciplina);
        }

        public bool NotaJaExiste(int raAluno, int idDisciplina)
        {
            return NotaAlunosList.Any(n => n.RaAluno == raAluno && n.IdDisciplina == idDisciplina);
        }

        public List<NotaAluno> ListarAlunosAprovados()
        {
            return NotaAlunosList
                .Where(n => n.Nota >= 7.0 && n.Frequencia >= 75)
                .ToList();
        }

        public List<NotaAluno> ListarAlunosReprovados()
        {
            return NotaAlunosList
                .Where(n => n.Nota < 7.0 || n.Frequencia < 75)
                .ToList();
        }
    }
}
