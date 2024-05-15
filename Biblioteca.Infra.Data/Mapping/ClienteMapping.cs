using Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Infra.Data.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired();
            builder.Property(c => c.EnderecoID).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(50).IsRequired();
            builder.Property(c => c.CPF).HasMaxLength(14).IsRequired();
        }
    }
}
