using Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.Property(c => c.Rua).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Complemento).IsRequired();
            builder.Property(c => c.Numero).IsRequired();
            builder.Property(c => c.Bairro).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Cidade).HasMaxLength(30).IsRequired();
            builder.Property(c => c.Estado).HasMaxLength(30).IsRequired();
        }
    }
}
