using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository() : base(new Model1())
        {

        }

        public override IQueryable<Customer> GetAll()
        {
            var query = from e in Entities select e;
            return query;
        }

        public IQueryable<Customer> GetCustomersByCounty(string country)
        {
            var query = from e in Entities where e.Country == country select e;
            return query;
        }

        public IQueryable<string>  GetCountries()
        {
            var query = from e in Entities select e.Country;
            return query;
        }
    }
}
