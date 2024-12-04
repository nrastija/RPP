using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository() : base(new NorthwindModel())
        {
            
        }

        public IQueryable<object> GetAll()
        {
            var query = from p in Entities
                select new
                {
                    p.ProductID,
                    p.ProductName,
                    p.UnitPrice,
                    p.UnitsInStock,
                    p.UnitsOnOrder
                };
            return query;
        }

        public IQueryable<object> GetProductsInRange(int min, int max)
        {
            var query = from p in Entities
                where p.UnitPrice > min && p.UnitPrice < max
                orderby p.UnitPrice
                select new
                {
                    p.ProductID,
                    p.ProductName,
                    p.UnitPrice,
                    p.UnitsInStock,
                    p.UnitsOnOrder,
                };
            return query;
        }
    }
}
