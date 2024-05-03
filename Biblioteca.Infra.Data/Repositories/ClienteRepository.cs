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
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(BibliotecaDBContext context) : base(context)
        {
        }

        public Cliente Add(Cliente cliente)
        {
            DbSet.Add(cliente);
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
        }

        public Cliente Editar(Cliente cliente)
        {
            DbSet.Update(cliente);
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
