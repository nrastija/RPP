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
        private NorthwindModel Context { get; set; }

        public DbSet<T> Entities { get; set; }

        public Repository(NorthwindModel context)
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
