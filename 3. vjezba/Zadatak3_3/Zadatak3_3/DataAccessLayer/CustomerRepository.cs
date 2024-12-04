using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerRepository : Repository<Customer>

    {
        public CustomerRepository() : base(new Northwind())
        {
        }

        public override int Add(Customer entity, bool saveChanges = true)
        {
            var customer = new Customer
            {
                CustomerID = entity.CustomerID,
                CompanyName = entity.CompanyName,
                City = entity.City,
                Country = entity.Country
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
    }
}
