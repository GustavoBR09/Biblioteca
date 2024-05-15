using Biblioteca.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infra.Data.Context
{
    public class BibliotecaDBContext : DbContext
    {
        public BibliotecaDBContext(DbContextOptions<BibliotecaDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new EnderecoMapping());
            modelBuilder.ApplyConfiguration(new EmprestimoMapping());
            modelBuilder.ApplyConfiguration(new LivroMapping());
            modelBuilder.ApplyConfiguration(new FuncionarioMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
