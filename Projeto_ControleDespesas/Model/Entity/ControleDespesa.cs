using Projeto_ControleDespesas.Enum;

namespace Projeto_ControleDespesas.Model.Entity;

public class ControleDespesa// Planta com o Projeto Modelo com a ideia de reutilização quando necessário;
{
    public int Id { get; set; }
    public string? Descricao { get; set; } // Atributo = Caracteristica;
    //Conjunto de Atributos(Características do objeto material ou imaterial);
    public Categoria Categoria { get; set; } // Encapsulamento(Modificador de Acesso/Permissão): P/ este ser "Encontrado/Visivel" ao ser
                                             // "Instanciado(Acessado/Chamado)" por outras classes;
    public SubCategoria SubCategoria { get; set; } // Tipo de dado do atributo;
    public DateTime DataCompra {  get; set; } // { Consulta; Adiciona Valor}; 
    public decimal Quantidade { get; set;}
    public decimal Preco { get; set;}
    public decimal OutrosCustos { get; set;}
    public decimal ValorTotal { get; set;}
}
