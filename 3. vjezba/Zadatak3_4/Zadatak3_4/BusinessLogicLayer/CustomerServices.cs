using System.Collections.Generic;
using System.Linq;
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

        public bool AddCusomter(Customer customer)
        {
            bool isSuccessful = false;

            using (var repo = new CustomerRepository())
            {
                int affectedRows = repo.Add(customer);
                isSuccessful = affectedRows> 0;
            }
            return isSuccessful;
        }

        public bool RemoveCustomer(Customer customer)
        {
            bool isSuccessful = false;

            using (var repo = new CustomerRepository())
            {
                int affectedRows = repo.Remove(customer);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool CheckIfCustomerExists(string ID)
        {
            using (var repo = new CustomerRepository())
            {
                return repo.GetAll().Any(c => c.CustomerID == ID);
            }
        }
    }
}