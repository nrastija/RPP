using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;

namespace BusinessLogicLayer
{
    internal class ProductServices
    {
        public List<Product> GetProducts()
        {
            using (var repo = new ProductRepository())
            {
                List<Product> products = repo.GetAll().ToList();
                return products;
            }
        }

        public List<Product> GetProductsByName(string phrase)
        {
            using (var repo = new ProductRepository())
            {
                List<Product> products = repo.GetProductsByName(phrase).ToList();
                return products;
            }
        }

        public bool AddProduct(Product product)
        {
            bool isSuccessful = false;

            using (var repo = new ProductRepository())
            {
                int affectedRows = repo.Add(product);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool UpdateProduct(Product product)
        {
            bool isSuccessful = false;

            using (var repo = new ProductRepository())
            {
                int affectedRows = repo.Update(product);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool RemoveProduct(Product product)
        {
            bool isSuccessful = false;

            bool canRemove = CheckIfProductCanBeRemoved(product);
            if (canRemove)
            {
                using (var repo = new ProductRepository())
                {
                    int affectedRows = repo.Remove(product);
                    isSuccessful = affectedRows > 0;
                }
            }

            return isSuccessful;
        }

        private bool CheckIfProductCanBeRemoved(Product product)
        {
            if (product == null || product.Discontinued == false || product.UnitsInStock > 0 ||
                product.UnitsOnOrder > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
