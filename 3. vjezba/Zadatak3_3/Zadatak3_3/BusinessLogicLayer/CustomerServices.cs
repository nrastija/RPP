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
        List<Customer> getCustomers()
        {
            using (var repo = new CustomerRepository())
            {
                List<Customer> customers = repo.GetAll().ToList();
                return customers;
            }
        }

        public bool AddCustomer(Customer customer)
        {
            bool isSuccessful = false;

            using (var repo = new CustomerRepository())
            {
                int affectedRows = repo.Add(customer);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }
        
    }
}
