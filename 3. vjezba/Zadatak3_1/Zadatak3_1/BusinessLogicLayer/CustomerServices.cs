using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DataAccesLayer;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CustomerServices
    {
        public List<Customer> GetAllCustomers()
        {
            using (var repo = new CustomerRepository_solo())
            {
                List<Customer> customers = repo.GetAllCustomers().ToList();
                return customers;
            }
        }

        public List<Customer> GetCustomersFromCountry(string filter)
        {
            using (var repo = new CustomerRepository_solo())
            {
                List<Customer> filtered = repo.FilterCustomersByCounty(filter).ToList();
                return filtered;
            }
        }

        public List<string> GetCountries()
        {
            using (var repo = new CustomerRepository_solo())
            {
                List<string> countries = repo.GetAllCountries().ToList();
                return countries;
            }
        }
    }
}
