﻿using Biblioteca.Dominio.Entidades;
using Biblioteca.Infra.Data.Context;
using Biblioteca.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra.Data.Repositories
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        public LivroRepository(BibliotecaDBContext dbContext) : base(dbContext)
        {
        }
        public Livro Add(Livro livro)
        {
            DbSet.Add(livro);
            return livro;
        }

        public IEnumerable<Livro> BuscaLivro(Expression<Func<Livro, bool>> filtro)
        {
            var context = DbSet.AsQueryable();
            var livros = context.Where(filtro);
            return livros;
        }


        public void Delete(int id)
        {
            var livro = GetLivro(id);
            if (livro != null)
            {
                DbSet.Remove(livro);
            }
        }

        public Livro Editar(Livro livro)
        {
            DbSet.Update(livro);
            return livro;
        }

        public Livro GetLivro(int id)
        {
            var context = DbSet.AsQueryable();
            var livro = context.FirstOrDefault(e => e.Id == id);
            return livro;
        }
    }
}
