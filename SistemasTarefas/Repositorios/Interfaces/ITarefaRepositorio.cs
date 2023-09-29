using SistemasTarefas.Models;

namespace SistemasTarefas.Repositorios.Interfaces
{
    public interface ITarefaRepositorio
    {
        Task<List<TarefasModel>> BuscarTodasTarefas();
        Task<TarefasModel> BuscarPorId(int id);
        Task<TarefasModel> Adicionar(TarefasModel tarefa);
        Task<TarefasModel> Atualizar(TarefasModel tarefa, int id);
        Task<bool> Apagar (int id);
    }
}
