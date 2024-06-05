using Biblioteca.Dominio.Entidades;
using Biblioteca.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Infra.Data.Context
{
    public class BibliotecaDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1433;Database=bibliotecaDb;User ID=gustavo;Password=gu$t4v0;Persist Security Info=False;Encrypt=False");

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
