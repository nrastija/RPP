using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository() : base(new Northwind())
        {
        }

        public IQueryable<Customer> GetCustomerByCountryAndCity(string country, string city)
        {
            var query = from c in Entities where c.Country == country && c.City == city select c;
            return query;
        }

        public IQueryable<string> GetCountries()
        {
            var query = from c in Entities select c.Country;
            return query;
        }

        public IQueryable<string> GetCities()
        {
            var query = from c in Entities select c.City;
            return query;
        }
    }
}
