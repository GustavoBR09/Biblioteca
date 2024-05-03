using Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Interfaces
{
    public interface IFuncionarioRepository
    {
        Funcionario GetFuncionarioById(int id);
        IEnumerable<Funcionario> BuscaFuncionario(Expression<Func<Funcionario, bool>> filtro);
        Funcionario Add(Funcionario funcionario);
        Funcionario Editar(Funcionario funcionario);
        void Delete(int id);
    }
}
