using Projeto_ControleDespesas.Enum;
using Projeto_ControleDespesas.Model.Entity;

namespace Projeto_ControleDespesas.Repository.Interface;

public interface IControleDespesaRepository 
{
    Task <List<ControleDespesa>>BuscarTodos();
    Task <ControleDespesa?>BuscarPorId(int id);
    Task <List<ControleDespesa>>BuscarPorCategoria(Categoria categoria);
    Task <List<ControleDespesa>> BuscarPorSubCategoria(SubCategoria subCategoria);
    Task<List<ControleDespesa>> BuscarPorDescricao(string descricao);
    Task<ControleDespesa> Adicionar(ControleDespesa controleDespesa);
    Task<ControleDespesa> Atualizar(ControleDespesa controleDespesa);
    Task<bool> Apagar(int id);
}
