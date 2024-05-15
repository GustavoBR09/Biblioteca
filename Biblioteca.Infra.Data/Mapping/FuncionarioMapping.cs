using Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Mapping
{
    public class FuncionarioMapping : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("Funcionario");
            builder.Property(c => c.Nome).HasMaxLength(50).IsRequired();
            builder.Property(c => c.EnderecoID).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(50).IsRequired();
            builder.Property(c => c.CarteiraTrabalho).HasMaxLength(14).IsRequired();
            builder.Property(c => c.NomeUsuario).HasMaxLength(20).IsRequired();
            builder.Property(c => c.Senha).HasMaxLength(20).IsRequired();
        }
    }
}
