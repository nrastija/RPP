using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository : IDisposable
    {
        private Northwind Context {get; set; }

        public DbSet<Customer> Entities { get; set; }

        public CustomerRepository()
        {
            Context = new Northwind();
            Entities = Context.Set<Customer>();
        }

        public IQueryable<Customer> GetAll()
        {
            var query = from c in Entities select c;
            return query;
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }
        public int Add(Customer entity, bool saveChanges = true)
        {
            var customer = new Customer
            {
                CustomerID = entity.CustomerID,
                CompanyName = entity.CompanyName,
                Country = entity.Country,
                City = entity.City
            };

            Entities.Add(customer);

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public int Remove(Customer entity, bool saveChanges = true)
        {
            Entities.Attach(entity);
            Entities.Remove(entity);

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
