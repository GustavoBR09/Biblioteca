﻿using Biblioteca.Dominio.Entidades;
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
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(BibliotecaDBContext context) : base(context) 
        {
        }

        public Endereco Add(Endereco endereco)
        {
            DbSet.Add(endereco);
            return endereco;
        }

        public IEnumerable<Endereco> BuscaEndereco(Expression<Func<Endereco, bool>> filtro)
        {
            var context = DbSet.AsQueryable();
            var enderecos = context.Where(filtro);
            return enderecos;
        }

        public void Delete(int id)
        {
            var endereco = GetEndereco(id);
            if (endereco != null)
            {
                DbSet.Remove(endereco);
            }
        }

        public Endereco Editar(Endereco endereco)
        {
            DbSet.Update(endereco);
            return endereco;
        }

        public Endereco GetEndereco(int id)
        {
            var context = DbSet.AsQueryable();
            var endereco = context.FirstOrDefault(e => e.Id == id);
            return endereco;
        }
    }
}
