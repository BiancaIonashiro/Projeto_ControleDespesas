using Projeto_ControleDespesas.Data;
using Projeto_ControleDespesas.Repository.Interface;
using Projeto_ControleDespesas.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//
builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SistemaControleDbContex>(
       options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
       );

builder.Services.AddTransient<IControleDespesaRepository, ControleDespesaRepository>();
//

/* Criação do objeto: Declaro Tipo(Classe), crio variavel("Caixa" p/ armazenar valores) = Novo (Instancia/Chamado) da minha Classe(), através do 
 * método, exemplo: 
 * Tipo(Classe) ->ControleDespesasModel<- Var(Objeto dessa classe) ->controleDespesasModel(minusculo)<- = 
 * (Usado p/ instancia) ->new<- Metodo() ->ControleDespesasModel();<- , ou seja, criação de uma instância do ControleDespesasModel: */

//ControleDespesasModel controleDespesasModel = new ControleDespesasModel(); 

//objeto.Propriedade = 123; <-Atributo **Geralmente "setar" valor em métodos é o mais indicado e performatico, ou seja, pode-se
//inserir {get; private set;} p/ só consultar e não alterar ou private double Saldo {get;set;} indicado p/ proteger totalmente o atributo p/
//somente a Classe poder manipular o valor;

//objeto.Propriedade(caracteristica unica da minha classe que pode ser Quantidade, Preco, ..., etc)->(Valor desejado p/ add); <-Metodo **Geralmente
//o mais utilizado, pois qualquer validação é utilizado dentro do metodo que é criado p/ executar, sendo facil manutenção ao add valores"setar";

//controleDespesasModel.Limite = 123;
//controleDespesasModel.Deposito(1500);

//double saldoTotal = conta.Saldo();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


