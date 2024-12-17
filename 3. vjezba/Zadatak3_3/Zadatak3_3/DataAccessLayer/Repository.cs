using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Repository<T> : IDisposable where T : class
    {
        protected Northwind Context { get; set; }

        public DbSet<T> Entities { get; set; }

        public Repository(Northwind context)
        {
            Context = context;
            Entities = Context.Set<T>();
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
        public virtual int Add(T entity, bool saveChanges = true)
        {
            Entities.Add(entity);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public IQueryable<T> GetAll()
        {
            var query = from c in Entities select c;
            return query;
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
