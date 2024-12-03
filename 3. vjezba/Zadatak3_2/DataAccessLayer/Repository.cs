using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public abstract class Repository<T> : IDisposable where T : class
    {
        protected Northwind Context { get; set; }
        public DbSet<T> Entities { get; set; }

        public Repository(Northwind context)
        {
            Context = context;
            Entities = Context.Set<T>();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
