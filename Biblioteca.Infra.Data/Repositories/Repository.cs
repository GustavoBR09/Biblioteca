using Biblioteca.Dominio.Entidades;
using Biblioteca.Infra.Data.Context;
using Biblioteca.Infra.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Biblioteca.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : Entidade
    {
        protected readonly BibliotecaDBContext Db;
        protected readonly DbSet<T> DbSet;

        public Repository(BibliotecaDBContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        protected IQueryable<T> Query()
        {
            return DbSet;
        }
        public void Dispose()
        {

            Db?.Dispose();
            GC.SuppressFinalize(obj: this);
        }
        public long Count()
        {
            return DbSet.LongCount();
        }
        public long Count(Expression<Func<T, bool>> predicate)
        {
            var result = DbSet.LongCount(predicate);
            return result;
        }

        public int ProximoId()
        {
            int id = 1;
            if (Count() > 0)
            {
                id += DbSet.Max(x => x.Id);
            }

            return id;
        }
    }
}
