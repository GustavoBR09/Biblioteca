using Biblioteca.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Interfaces
{
    public interface ILivroRepository
    {
        Livro GetLivro(int id);
        IEnumerable<Livro> BuscaLivro(Expression<Func<Livro>> filtro);
        Livro Add(Livro livro);
        Livro Editar(Livro livro);
        void Delete(int id);
    }
}
