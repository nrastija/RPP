using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using DataAccessLayer;

namespace DataAccessLayer
{
    public class CustomerRepository_inherited : Repository<Customer>
    {
        public CustomerRepository_inherited() : base (new Model1())
        {
            
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
    }
}
