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
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        UnitOfWork UoW;
        public EnderecoRepository(BibliotecaDBContext context) : base(context) 
        {
            UoW = new UnitOfWork(context);
        }

        public Endereco Add(Endereco endereco)
        {
            //endereco.Id = ProximoId();
            DbSet.Add(endereco);
            UoW.Commit();

            return endereco;
        }

        public IEnumerable<Endereco> BuscaEndereco(Expression<Func<Endereco, bool>> filtro)
        {
            IQueryable<Endereco> context = DbSet.AsQueryable();
            IQueryable<Endereco> enderecos = context.Where(filtro);
            return enderecos;
        }

        public void Delete(int id)
        {
            var endereco = GetEndereco(id);
            if (endereco != null)
            {
                DbSet.Remove(endereco);
            }
            UoW.Commit();
        }

        public Endereco Editar(Endereco endereco)
        {
            DbSet.Update(endereco);
            UoW.Commit();
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
