using Microsoft.EntityFrameworkCore;
using Projeto_ControleDespesas.Data;
using Projeto_ControleDespesas.Enum;
using Projeto_ControleDespesas.Model.Entity;
using Projeto_ControleDespesas.Repository.Interface;

namespace Projeto_ControleDespesas.Repository;

public class ControleDespesaRepository : IControleDespesaRepository
{
    private readonly SistemaControleDbContex _dBContext;

    public ControleDespesaRepository(SistemaControleDbContex sistemaControleDbContex)
    {
        _dBContext = sistemaControleDbContex;
    }
    public async Task<ControleDespesa> Adicionar(ControleDespesa controleDespesa)
    {
        var resultado = await _dBContext.ControleDespesa.AddAsync(controleDespesa);

        await _dBContext.SaveChangesAsync();

        return resultado.Entity;
    }

    public Task<bool> Apagar(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ControleDespesa> Atualizar(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<List<ControleDespesa>> BuscarPorCategoria(Categoria categoria)
    {
        var listaControleDespesa = await _dBContext.ControleDespesa
            .Where(controleDespesa => controleDespesa.Categoria == categoria)
            .ToListAsync();

        return listaControleDespesa;
    }

    public async Task<List<ControleDespesa>> BuscarPorDescricao(string descricao)
    {
        var listaControleDespesa = await _dBContext.ControleDespesa
            .Where(controleDespesa => controleDespesa.Descricao == descricao)
            .ToListAsync();

        return listaControleDespesa;
    }

    public async Task<ControleDespesa?> BuscarPorId(int id)
    {
        var controleDespesa = await _dBContext.ControleDespesa
            .FirstOrDefaultAsync(cd => cd.Id == id);

        return controleDespesa;
    }

    public async Task<List<ControleDespesa>> BuscarPorSubCategoria(SubCategoria subCategoria)
    {
        var listaControleDespesa = await _dBContext.ControleDespesa
            .Where(controleDespesa => controleDespesa.SubCategoria == subCategoria)
            .ToListAsync();

        return listaControleDespesa;
    }

    public async Task<List<ControleDespesa>> BuscarTodos()
    {
        var listaControleDespesa = await _dBContext.ControleDespesa.ToListAsync();

        return listaControleDespesa;
    }
}
