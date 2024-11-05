using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/notaaluno")]
    public class NotaAlunoController : ControllerBase
    {
        private readonly INotaAlunoService _notaAlunoService;

        public NotaAlunoController(INotaAlunoService notaAlunoService)
        {
            _notaAlunoService = notaAlunoService;
        }

        [HttpPost]
        [Route("InserirNota")]
        public IActionResult InserirNota(NovaNotaAluno novaNotaAluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                _notaAlunoService.InserirNota(novaNotaAluno);
                return Ok($"Nota para o aluno {novaNotaAluno.RaAluno} na disciplina {novaNotaAluno.IdDisciplina} inserida com sucesso.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao inserir nota: {ex.Message}");
            }
        }

        [HttpGet]
        [Route("ListarAprovados")]
        public IActionResult ListarAprovados()
        {
            var alunosAprovados = _notaAlunoService.ListarAlunosAprovados();
            return Ok(alunosAprovados);
        }

        [HttpGet]
        [Route("ListarReprovados")]
        public IActionResult ListarReprovados()
        {
            var alunosReprovados = _notaAlunoService.ListarAlunosReprovados();
            return Ok(alunosReprovados);
        }
    }
}
