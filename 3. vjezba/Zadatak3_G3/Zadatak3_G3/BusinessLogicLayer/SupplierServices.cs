using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class SupplierServices
    {
        public List<Supplier> GetAllSuppliers()
        {
            using (var repo = new SupplierRepository())
            {
                List<Supplier> allSuppliers = repo.GetAll().ToList();
                return allSuppliers;
            } 
        }

        public List<string> GetCountries()
        {
            using (var repo = new SupplierRepository())
            {
                List<string> countries = repo.GetCountries().ToList();
                return countries;
            }
        }

        public bool addSupplier(Supplier supplier)
        {
            bool isSuccessful = false;

            using (var repo = new SupplierRepository())
            {
                var affectedRows = repo.Add(supplier);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }
    }
}
