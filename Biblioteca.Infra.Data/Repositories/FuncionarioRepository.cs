using Biblioteca.Dominio.Entidades;
using Biblioteca.Infra.Data.Context;
using Biblioteca.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Repositories
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(BibliotecaDBContext context) : base(context)
        {
        }

        public Funcionario Add(Funcionario funcionario)
        {
            DbSet.Add(funcionario);
            return funcionario;
        }

        public IEnumerable<Funcionario> BuscaFuncionario(Expression<Func<Funcionario, bool>> filtro)
        {
            var context = DbSet.AsQueryable();
            var funcionarios = context.Where(filtro);
            return funcionarios;
        }

        public void Delete(int id)
        {
            var funcionario = GetFuncionarioById(id);
            if (funcionario != null)
            {
                DbSet.Remove(funcionario);
            }
        }

        public Funcionario Editar(Funcionario funcionario)
        {
            DbSet.Update(funcionario);
            return funcionario;
        }

        public Funcionario GetFuncionarioById(int id)
        {
            var context = DbSet.AsQueryable();
            var funcionario = context.FirstOrDefault(e => e.Id == id);
            return funcionario;
        }
    }
}
