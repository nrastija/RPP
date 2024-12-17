using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class SupplierRepository : Repository<Supplier>
    {
        public SupplierRepository() : base(new NorthwndModel())
        {

        }

        public override int Update(Supplier entity, bool saveChanges = true)
        {
            var supplier = Entities.SingleOrDefault(s => s.SupplierID == entity.SupplierID);

            supplier.CompanyName = entity.CompanyName;
            supplier.City = entity.City;
            supplier.Country = entity.Country;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
        public IQueryable<Supplier> GetSuppliersByName(string phrase)
        {
            var query = from s in Entities
                where s.CompanyName.Contains(phrase)
                select s;
            return query;
        }

        public IQueryable<int> GetNumberOfProducts(Supplier supplier)
        {
            var query = from s in Entities
                where s.SupplierID == supplier.SupplierID
                select s.Products.Count;
            return query;
        }
     }
}
