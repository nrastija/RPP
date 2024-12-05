using System;
using System.Data.Entity;
using DataAccesLayer;

namespace DataAccessLayer
{
    public class Repository<T> : IDisposable where T : class
    {
        private Model1 Context { get; set; }

        public DbSet<T> Entities { get; set; }

        public Repository(Model1 context)
        {
            Context = context;
            Entities = Context.Set<T>();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}