using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;

namespace DataAccessLayer
{
    public class CustomerRepository_solo : IDisposable
    {
        private Model1 Context { get; set; }

        public DbSet<Customer> Entities { get; set; }

        public CustomerRepository_solo()
        {
            Context = new Model1();
            Entities = Context.Set<Customer>();
        }

        public IQueryable<Customer> GetAllCustomers()
        {
            var query = from c in Entities select c;
            return query;
        }

        public IQueryable<Customer> FilterCustomersByCounty(string country)
        {
            var query = from c in Entities where c.Country == country select c;
            return query;
        }

        public IQueryable<string> GetAllCountries()
        {
            var query = (from c in Entities select c.Country).Distinct();
            return query;
        }

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
