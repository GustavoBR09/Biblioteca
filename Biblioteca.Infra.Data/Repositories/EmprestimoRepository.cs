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
    public class EmprestimoRepository : Repository<Emprestimo>, IEmprestimoRepository
    {
        public EmprestimoRepository(BibliotecaDBContext context) : base(context)
        {
        }

        public Emprestimo Add(Emprestimo emprestimo)
        {
            DbSet.Add(emprestimo);
            return emprestimo;
        }

        public IEnumerable<Emprestimo> BuscaEmprestimo(Expression<Func<Emprestimo, bool>> filtro)
        {
            var context = DbSet.AsQueryable();
            var emprestimo = context.Where(filtro);
            return emprestimo;
        }

        public void Delete(int id)
        {
            var emprestimo = GetEmprestimoByID(id);
            if (emprestimo != null)
            {
                DbSet.Remove(emprestimo);
            }
        }

        public Emprestimo Editar(Emprestimo emprestimo)
        {
            DbSet.Update(emprestimo);
            return emprestimo;
        }

        public Emprestimo GetEmprestimoByID(int id)
        {
            var context = DbSet.AsQueryable();
            var emprestimo = context.FirstOrDefault(e => e.Id == id);
            return emprestimo;
        }
    }
}
