using WebApplication1.Models;
using WebApplication1.Repositories;
using System.Collections.Generic;

namespace WebApplication1.Services
{
    public class NotaAlunoService : INotaAlunoService
    {
        private readonly INotaAlunoRepository _notaAlunoRepository;

        public NotaAlunoService(INotaAlunoRepository notaAlunoRepository)
        {
            _notaAlunoRepository = notaAlunoRepository;
        }

        public void InserirNota(NovaNotaAluno novaNotaAluno)
        {
            _notaAlunoRepository.InserirNota(novaNotaAluno);
        }

        public List<NotaAluno> ListarAlunosAprovados()
        {
            return _notaAlunoRepository.ListarAlunosAprovados();
        }

        public List<NotaAluno> ListarAlunosReprovados()
        {
            return _notaAlunoRepository.ListarAlunosReprovados();
        }
    }
}
