using API_SistemaDeTarefas.Models;

namespace API_SistemaDeTarefas.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios(); // tarefa assíncrona retorna uma lista de objetos do tipo UsuarioModel.
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> Adicionar(UsuarioModel usuario);
        Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id);
        Task<bool> Apagar(int id);
    }
}