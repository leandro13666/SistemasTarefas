using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemasTarefas.Data;
using SistemasTarefas.Models;
using SistemasTarefas.Repositorios.Interfaces;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace SistemasTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;

        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        [HttpGet]

        public async Task<ActionResult<List<TarefasModel>>> BuscarTodosUsuarios()
        {
            List<TarefasModel> tarefas = await _tarefaRepositorio.BuscarTodasTarefas();
            return Ok(tarefas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<TarefasModel>>> BuscarPorId(int id)
        {
        TarefasModel tarefa = await _tarefaRepositorio.BuscarPorId(id);
     
            return Ok(tarefa);
        }
        [HttpPost]
        public  async Task<ActionResult<TarefasModel>> Cadastrar([FromBody] TarefasModel tarefasModel)
        {
            TarefasModel tarefa  = await _tarefaRepositorio.Adicionar(tarefasModel);
            return Ok(tarefa);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TarefasModel>> Atualizar([FromBody] TarefasModel tarefasModel, int id)
        {
            tarefasModel.Id = id;
            TarefasModel tarefa = await _tarefaRepositorio.Atualizar(tarefasModel, id);
            return Ok(tarefa);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<TarefasModel>> Apagar( int id)
        {
           bool apagado = await _tarefaRepositorio.Apagar(id);
            return Ok(apagado);
        }
    }
}
