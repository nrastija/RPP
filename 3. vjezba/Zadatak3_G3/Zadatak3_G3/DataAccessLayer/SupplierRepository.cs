using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SupplierRepository : Repository<Supplier>
    {
        public SupplierRepository() : base(new NorthwindModel())
        {

        }

        public IQueryable<Supplier> GetAll()
        {
            var query = from s in Entities select s;
            return query;
        }

        public IQueryable<string> GetCountries()
        {
            var query = (from s in Entities select s.City).Distinct();
            return query;
        }

        
        public int Add(Supplier entity, bool saveChanges = true)
        {
            var supplier = new Supplier
            {
                CompanyName = entity.CompanyName,
                Country = entity.Country,
                City = entity.City
            };

            Entities.Add(supplier);

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
