using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class EmployeeServices
    {
        public List<object> GetAllEmployees()
        {
            using (var repo = new EmployeeRepository())
            {
                List<object> employees = repo.GetAll().ToList();
                return employees;
            }
        }

        public List<string> GetCities()
        {
            using (var repo = new EmployeeRepository())
            {
                List<string> cities = repo.GetCities().ToList();
                return cities;
            }
        }

        public List<object> GetFilteredEmployees(string city)
        {
            using (var repo = new EmployeeRepository())
            {
                List<object> filteredEmployees = repo.GetEmployeesByCity(city).ToList();
                return filteredEmployees;
            }
        }
    }
}
