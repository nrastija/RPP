using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ProductServices
    {
        public List<object> GetAllProducts()
        {
            using (var repo = new ProductRepository())
            {
                List<object> products = repo.GetAll().ToList();
                return products;
            }
        }

        public List<object> GetFilteredProducts(int min, int max)
        {
            using (var repo = new ProductRepository())
            {
                List<object> filteredProducts = repo.GetProductsInRange(min, max).ToList();
                return filteredProducts;
            }
        }
    }
}
