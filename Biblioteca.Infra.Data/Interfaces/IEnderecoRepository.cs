using Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Interfaces
{
    public interface IEnderecoRepository
    {
        Endereco GetEndereco(int id);
        IEnumerable<Endereco> BuscaEndereco(Expression<Func<Endereco>> filtro);
        Endereco Add(Endereco endereco);
        Endereco Editar(Endereco endereco);
        void Delete(int id);
    }
}
