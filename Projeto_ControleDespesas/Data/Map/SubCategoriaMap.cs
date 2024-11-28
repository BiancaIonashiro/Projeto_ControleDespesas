using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto_ControleDespesas.Model.Entity;

namespace Projeto_ControleDespesas.Data.Map
{
    public class SubCategoriaMap : IEntityTypeConfiguration<ControleDespesa>
    {
        public void Configure(EntityTypeBuilder<ControleDespesa> builder) 
        { 
            builder.HasKey(x => x.Id);
            builder.Property(x  => x.SubCategoria).IsRequired().HasMaxLength(50);
            builder.Property(x  => x.SubCategoria).IsRequired().HasMaxLength(50);
            builder.Property(x  => x.Descricao).IsRequired().HasMaxLength(50);
            builder.Property(x  => x.DataCompra).IsRequired().HasMaxLength(8);
            builder.Property(x  => x.Quantidade).IsRequired().HasMaxLength(12);
            builder.Property(x  => x.Preco).IsRequired().HasMaxLength(12);
            builder.Property(x  => x.OutrosCustos).IsRequired().HasMaxLength(12);
            builder.Property(x  => x.ValorTotal).IsRequired().HasMaxLength(14);
        }
    }
}
