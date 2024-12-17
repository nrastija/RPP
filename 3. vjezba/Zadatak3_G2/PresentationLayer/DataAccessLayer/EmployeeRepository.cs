using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository() : base(new NorthwindModel())
        {
            
        }

        public IQueryable<object> GetAll()
        {
            var query = from e in Entities select new
            {
                e.EmployeeID,
                e.FirstName,
                e.LastName,
                e.Title,
                e.HireDate,
                e.City,
                e.Country
            };
            return query;
        }

        public IQueryable<string> GetCities()
        {
            var query = (from e in Entities select e.City).Distinct();
            return query;
        }

        public IQueryable<object> GetEmployeesByCity(string city)
        {
            var query = from e in Entities
                where e.City == city
                select new
                {
                    e.EmployeeID,
                    e.FirstName,
                    e.LastName,
                    e.Title,
                    e.HireDate,
                    e.City,
                    e.Country
                };
            return query;
        }
    }
}
