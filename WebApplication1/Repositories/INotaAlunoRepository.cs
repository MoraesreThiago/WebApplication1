using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Repositories
{
    public interface INotaAlunoRepository
    {
        void InserirNota(NovaNotaAluno novaNotaAluno);
        bool AlunoExiste(int raAluno);        
        bool DisciplinaExiste(int idDisciplina);
        bool NotaJaExiste(int raAluno, int idDisciplina);
        List<NotaAluno> ListarAlunosAprovados();
        List<NotaAluno> ListarAlunosReprovados();
    }
}
