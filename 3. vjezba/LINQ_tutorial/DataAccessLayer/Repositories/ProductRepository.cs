using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository() : base(new NorthwndModel())
        {
            
        }

        public override IQueryable<Product> GetAll()
        {
            var query = from p in Entities.Include("Category").Include("Supplier")
                        select p;
            return query;
        }

        public IQueryable<Product> GetProductsByName(string phrase)
        {
            var query = from p in Entities.Include("Category").Include("Supplier")
                        where p.ProductName.Contains(phrase)
                        select p;
            return query;
        }

        public override int Add(Product entity, bool saveChanges = true)
        {
            var category = Context.Categories.SingleOrDefault(c => c.CategoryID == entity.CategoryID);
            var supplier = Context.Suppliers.SingleOrDefault(s => s.SupplierID == entity.SupplierID);

            var product = new Product
            {
                Category = category,
                Supplier = supplier,
                ProductName = entity.ProductName,
                QuantityPerUnit = entity.QuantityPerUnit,
                Discontinued = entity.Discontinued
            };

            Entities.Add(product);

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Product entity, bool saveChanges = true)
        {
            var category = Context.Categories.SingleOrDefault(c => c.CategoryID == entity.CategoryID);
            var supplier = Context.Suppliers.SingleOrDefault(s => s.SupplierID == entity.SupplierID);

            var product = Entities.SingleOrDefault(p => p.ProductID == entity.ProductID);
            product.Category = category;
            product.Supplier = supplier;
            product.ProductName = entity.ProductName;
            product.QuantityPerUnit = entity.QuantityPerUnit;
            product.Discontinued = entity.Discontinued;

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
