using EstoqueApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EstoqueApp.Infra.Data.SqlServer.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder) 
        { 
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Preco).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(p => p.Quantidade).IsRequired();
            builder.Property(p => p.EstoqueId).IsRequired();

            builder.HasOne(p => p.Estoque)
                .WithMany(e => e.Produtos)
                .HasForeignKey(e => e.EstoqueId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
