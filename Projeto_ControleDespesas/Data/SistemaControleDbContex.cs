using Microsoft.EntityFrameworkCore;
using Projeto_ControleDespesas.Model.Entity;

namespace Projeto_ControleDespesas.Data;

public class SistemaControleDbContex : DbContext
{
    public SistemaControleDbContex(DbContextOptions<SistemaControleDbContex> options)
    : base(options)
    {
    }

    public DbSet<ControleDespesa> ControleDespesa{ get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
     
    }

}
