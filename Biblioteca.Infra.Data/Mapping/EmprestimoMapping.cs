using Biblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Biblioteca.Infra.Data.Mapping
{
    public class EmprestimoMapping : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("Emprestimo");
            builder.Property(c => c.LivroID).IsRequired();
            builder.Property(c => c.ClienteID).IsRequired();
            builder.Property(c => c.FuncionarioID).IsRequired();
            builder.Property(c => c.DataEmprestimo).IsRequired();
            builder.Property(c => c.DataDevolucaoPrevista).IsRequired();
            builder.Property(c => c.Multa).HasDefaultValue(0);
        }
    }
}
