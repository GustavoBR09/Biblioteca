using Biblioteca.Dominio.Entidades;
using Biblioteca.Infra.Data.Context;
using Biblioteca.Infra.Data.Interfaces;
using Biblioteca.Infra.Data.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        UnitOfWork UoW;
        public ClienteRepository(BibliotecaDBContext context) : base(context)
        {
            UoW = new UnitOfWork(context);
        }

        public Cliente Add(Cliente cliente)
        {
            DbSet.Add(cliente);
            UoW.Commit();
            return cliente;
        }

        public IEnumerable<Cliente> BuscaCliente(Expression<Func<Cliente, bool>> filtro)
        {
            var context = DbSet.AsQueryable();
            var clientes = context.Where(filtro);
            return clientes;
        }

        public void Delete(int id)
        {
            var livro = GetCliente(id);
            if (livro != null)
            {
                DbSet.Remove(livro);
            }
            UoW.Commit();
        }

        public Cliente Editar(Cliente cliente)
        {
            DbSet.Update(cliente);
            UoW.Commit();
            return cliente;
        }

        public Cliente GetCliente(int id)
        {
            var context = DbSet.AsQueryable();
            var cliente = context.FirstOrDefault(e => e.Id == id);
            return cliente;
        }
        public Cliente GetClienteById(int id)
        {
            var context = DbSet.AsQueryable();
            var cliente = context.FirstOrDefault(e => e.Id == id);
            return cliente;
        }
    }
}
