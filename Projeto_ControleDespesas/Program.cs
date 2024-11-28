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



builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<SistemaControleDbContex>(
       options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
       );

builder.Services.AddTransient<IControleDespesaRepository, ControleDespesaRepository>();



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


