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
        public List<Customer> GetCustomerByCountryAndCity(string country, string city)
        {
            using (var repo = new CustomerRepository())
            {
                List<Customer> customers = repo.GetCustomerByCountryAndCity(country, city).ToList();
                return customers;
            }
        }
    }
}
