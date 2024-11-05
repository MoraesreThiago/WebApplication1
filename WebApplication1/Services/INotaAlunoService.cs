using WebApplication1.Models;
using System.Collections.Generic;

namespace WebApplication1.Services
{
    public interface INotaAlunoService
    {
        void InserirNota(NovaNotaAluno novaNotaAluno);
        List<NotaAluno> ListarAlunosAprovados();
        List<NotaAluno> ListarAlunosReprovados();
    }
}
