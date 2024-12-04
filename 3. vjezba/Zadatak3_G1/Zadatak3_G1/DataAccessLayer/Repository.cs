using System;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public class Repository<T> : IDisposable where T : class
    {
        protected NorthwindModel Context { get; set; }

        public DbSet<T> Entities { get; set; }

        public Repository(NorthwindModel context)
        {
            Context = context;
            Entities = Context.Set<T>();
        }


        public virtual IQueryable<T> GetAll()
        {
            var query = from p in Entities select p;
            return query;
        }


        public void Dispose()
        {
            Context.Dispose();
        }
    }
}