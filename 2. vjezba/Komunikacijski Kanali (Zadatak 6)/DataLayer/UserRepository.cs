using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UserRepository
    {
        public List<User> Users { get; set; }

        public UserRepository()
        {
            Users = new List<User>
            {
                new User() { FirstName = "Pero", LastName = "Perić", Email = "pperic@student.foi.hr", Phone = "0951234091", ViberID = "pero123" },
                new User() { FirstName = "Ivo", LastName = "Ivić", Email = "iivic@gmail.com", Phone = "0951234568", ViberID = "ivo123" },
                new User() { FirstName = "Ana", LastName = "Anić", Email = "aanic@foi.hr", Phone = "0981234092", ViberID = "ana123" },
                new User() { FirstName = "Maja", LastName = "Majić", Email = "mmajic@foi.hr", Phone = "0981234093", ViberID = "maja123" },
                new User() { FirstName = "Pero", LastName = "Horvat", Email = "phorvat@gmail.com", Phone = "0911234098", ViberID = "marko123" },
                new User() { FirstName = "Ivan", LastName = "Horvat", Email = "ihorvat@student.foi.hr", Phone = "0911234562", ViberID = "ivan123" },
                new User() { FirstName = "Ana", LastName = "Perić", Email = "aperic@gmail.com", Phone = "0921234563", ViberID = "marija123" },
                new User() { FirstName = "Matej", LastName = "Anić", Email = "manic@foi.hr", Phone = "0921234564", ViberID = "matej123" },
                new User() { FirstName = "Luka", LastName = "Lukić", Email = "llukic@student.foi.hr", Phone = "0921234565", ViberID = "luka123" },
            };

        }
    }
}
