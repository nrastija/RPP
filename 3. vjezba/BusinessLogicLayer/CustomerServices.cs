using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class CustomerServices
    {
        public List<Customer> GetCustomers()
        {
            using (var repo = new CustomerRepository())
            {
                List<Customer> customers = repo.GetAll().ToList();
                return customers;
            }
        }

        public List<Customer> GetCustomersByCountry(string country)
        {
            using (var repo = new CustomerRepository())
            {
                List<Customer> customers = repo.GetCustomersByCounty(country).ToList();
                return customers;
            }
        }

        public List<string> GetCountries()
        {
            using (var repo = new CustomerRepository())
            {
                List<string> countries = repo.GetCountries().ToList();
                return countries;
            }
        }
    }
}
