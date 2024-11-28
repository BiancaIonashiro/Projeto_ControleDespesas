using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto_ControleDespesas.Model.Entity;
using Projeto_ControleDespesas.Repository;
using Projeto_ControleDespesas.Repository.Interface;

namespace Projeto_ControleDespesas.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DespesaController : ControllerBase
{
    private readonly IControleDespesaRepository _controleDespesaRepository;
    public DespesaController(IControleDespesaRepository controleDespesaRepository)
    {
        _controleDespesaRepository = controleDespesaRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<ControleDespesa>>> BuscarTodasDespesas()
    {
        var lista = await _controleDespesaRepository.BuscarTodos();
        return Ok(lista);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<ControleDespesa>> BuscarPorId(int id)
    {
        var resultado = await _controleDespesaRepository.BuscarPorId(id);

        return Ok(resultado);
    }

    
    [HttpPost]
    public async Task<ActionResult<ControleDespesa>> Adicionar(ControleDespesa controleDespesa)
    {
        var lista = await _controleDespesaRepository.Adicionar(controleDespesa);
        return CreatedAtAction(nameof(BuscarPorId), new { id = controleDespesa.Id }, controleDespesa);
    }

    
    [HttpPut]
    public async Task<ActionResult> Atualizar(ControleDespesa controleDespesa)
    {
        var lista = await _controleDespesaRepository.Atualizar(controleDespesa);
        return Ok();
    }
    
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<ControleDespesa>> Apagar(int id)
    {
        var resultado = await _controleDespesaRepository.Apagar(id);

        return Ok(resultado);
    }
    
}
