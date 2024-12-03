using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    internal class SupplierServices
    {
        public List<Supplier> GetSuppliers()
        {
            using (var repo = new SupplierRepository())
            {
                List<Supplier> suppliers = repo.GetAll().ToList();
                return suppliers;
            }
        }

        public List<Supplier> GetSuppliersByName(string phrase)
        {
            using (var repo = new SupplierRepository())
            {
                List<Supplier> supplier = repo.GetSuppliersByName(phrase).ToList();
                return supplier;
            }
        }

        public bool AddCategory(Supplier supplier)
        {
            bool isSuccessful = false;

            using (var repo = new SupplierRepository())
            {
                int affectedRows = repo.Add(supplier);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool UpdateCategory(Supplier supplier)
        {
            bool isSuccessful = false;

            using (var repo = new SupplierRepository())
            {
                int affectedRows = repo.Update(supplier);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool RemoveProduct(Supplier supplier)
        {
            bool isSuccessful = false;

            bool canRemove = CheckIfCategoryCanBeRemoved(supplier);
            if (canRemove)
            {
                using (var repo = new SupplierRepository())
                {
                    int affectedRows = repo.Remove(supplier);
                    isSuccessful = affectedRows > 0;
                }
            }

            return isSuccessful;
        }

        private bool CheckIfCategoryCanBeRemoved(Supplier supplier)
        {
            if (supplier == null) return false;

            using (var repo = new SupplierRepository())
            {
                int numOfProducts = repo.GetNumberOfProducts(supplier).Single();

                if (numOfProducts > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
