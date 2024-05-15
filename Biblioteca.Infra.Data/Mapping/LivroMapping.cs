using Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Infra.Data.Mapping
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");
            builder.Property(c => c.Titulo).HasMaxLength(50).IsRequired();
            builder.Property(c => c.Autor).HasMaxLength(50).IsRequired();
            builder.Property(c => c.AnoPublicacao).IsRequired();
            builder.Property(c => c.NumeroPaginas).IsRequired();
            builder.Property(c => c.QuantidadeDisponiveis).IsRequired();
            builder.Property(c => c.GeneroLiterario).IsRequired();
        }
    }
}
