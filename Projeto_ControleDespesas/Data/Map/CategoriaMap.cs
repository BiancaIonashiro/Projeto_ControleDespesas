using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Projeto_ControleDespesas.Model.Entity;

namespace Projeto_ControleDespesas.Data.Map;

public class CategoriaMap : IEntityTypeConfiguration<ControleDespesa>
{
    public void Configure(EntityTypeBuilder<ControleDespesa> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Categoria).IsRequired().HasMaxLength(50);
    }
}