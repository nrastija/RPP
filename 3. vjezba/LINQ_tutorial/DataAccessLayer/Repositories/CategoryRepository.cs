using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository() : base(new NorthwndModel())
        {

        }

        public override int Update(Category entity, bool saveChanges = true)
        {
            var category = Entities.SingleOrDefault(c => c.CategoryID == entity.CategoryID);

            category.CategoryName = entity.CategoryName;
            category.Description = entity.Description;  

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
        public IQueryable<Category> GetCategoriesByName(string phrase)
        {
            var query = from c in Entities
                where c.CategoryName.Contains(phrase)
                select c;
            return query;
        }
        public IQueryable<int> GetNumberOfProducts(Category category)
        {
            var query = from c in Entities
                where c.CategoryID == category.CategoryID
                select c.Products.Count;
            return query;
        }
    }

}

