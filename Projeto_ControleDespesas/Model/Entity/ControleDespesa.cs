using Projeto_ControleDespesas.Enum;

namespace Projeto_ControleDespesas.Model.Entity;

public class ControleDespesa
{
    public int Id { get; set; }
    public Categoria Categoria { get; set; } 
    public SubCategoria SubCategoria { get; set; }
    public string? Descricao { get; set; }
    public DateTime DataCompra {  get; set; } 
    public decimal Quantidade { get; set;}
    public decimal Preco { get; set;}
    public decimal OutrosCustos { get; set;}
    public decimal ValorTotal { get; set;}
}
