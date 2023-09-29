using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemasTarefas.Models;

namespace SistemasTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet] 
        public ActionResult<List<ProdutoModel>> BuscarTodosProdutos()
        {
            return Ok();
        }
    }
}
