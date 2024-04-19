using Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Interfaces
{
    public interface IClienteRepository
    {
        Cliente GetClienteById(int id);
        IEnumerable<Cliente> BuscaCliente(Expression<Func<Cliente>> filtro);
        Cliente Add(Cliente cliente);
        Cliente Editar(Cliente cliente);
        void Delete(int id);
    }
}
