using Projeto_ControleDespesas.Enum;
using Projeto_ControleDespesas.Model.Entity;

namespace Projeto_ControleDespesas.Repository.Interface;

public interface IControleDespesaRepository 
{
    Task <List<ControleDespesa>>BuscarTodos();
    Task <ControleDespesa?>BuscarPorId(int id);
    Task <List<ControleDespesa>>BuscarPorCategoria(Categoria categoria);//Ex: Padaria, Açougue
    Task <List<ControleDespesa>> BuscarPorSubCategoria(SubCategoria subCategoria);//Ex: Só Padaria
    Task<List<ControleDespesa>> BuscarPorDescricao(string descricao);//Ex: Leite ou Confeiteiro
    Task<ControleDespesa> Adicionar(ControleDespesa controleDespesa);
    Task<ControleDespesa> Atualizar(ControleDespesa controleDespesa);
    Task<bool> Apagar(int id);
}
