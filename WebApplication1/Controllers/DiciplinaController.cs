using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/diciplina")]
    public class DiciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _diciplinaService;

        public DiciplinaController(IDisciplinaService diciplinaService)
        {
            _diciplinaService = diciplinaService;
        }

        [HttpPost]
        [Route("Criar")]

        public IActionResult Criar(NovaDisciplina diciplina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            bool FlCriou = _diciplinaService.Criar(diciplina);

            if (FlCriou)
            {
                return Ok($"Diciplina {diciplina.Nome} criada com sucesso");
            }

            return BadRequest($"Diciplina {diciplina.Nome} nao criada, nome ja existente");
        }

        [HttpGet]
        [Route("ObterTodos")]
        public IActionResult ObterTodos()
        {
            return Ok(_diciplinaService.ObterTodos());
        }
    }
}
