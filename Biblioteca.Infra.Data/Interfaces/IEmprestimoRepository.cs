using Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Interfaces
{
    public interface IEmprestimoRepository
    {
        Emprestimo GetEmprestimoByID(int id);
        IEnumerable<Emprestimo> BuscaEmprestimo(Expression<Func<Emprestimo, bool>> filtro);
        Emprestimo Add(Emprestimo emprestimo);
        Emprestimo Editar(Emprestimo emprestimo);
        void Delete(int id);

    }
}
