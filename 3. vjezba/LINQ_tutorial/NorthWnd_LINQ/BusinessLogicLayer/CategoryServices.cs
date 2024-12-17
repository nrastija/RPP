using System;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicLayer
{
    public class CategoryServices
    {
        public List<Category> GetCategories()
        {
            using (var repo = new CategoryRepository())
            {
                List<Category> categories = repo.GetAll().ToList();
                return categories;
            }
        }

        public List<Category> GetCategoriesByName(string phrase)
        {
            using (var repo = new CategoryRepository())
            {
                List<Category> category = repo.GetCategoriesByName(phrase).ToList();
                return category;
            }
        }

        public bool AddCategory(Category category)
        {
            bool isSuccessful = false;

            using (var repo = new CategoryRepository())
            {
                int affectedRows = repo.Add(category);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool UpdateCategory(Category category)
        {
            bool isSuccessful = false;

            using (var repo = new CategoryRepository())
            {
                int affectedRows = repo.Update(category);
                isSuccessful = affectedRows > 0;
            }

            return isSuccessful;
        }

        public bool RemoveProduct(Category category)
        {
            bool isSuccessful = false;

            bool canRemove = CheckIfCategoryCanBeRemoved(category);
            if (canRemove)
            {
                using (var repo = new ProductRepository())
                {
                    int affectedRows = repo.Remove(category);
                    isSuccessful = affectedRows > 0;
                }
            }

            return isSuccessful;
        }

        private bool CheckIfCategoryCanBeRemoved(Category category)
        {
            if (category == null) return false;

            using (var repo = new CategoryRepository())
            {
                int numOfProducts = repo.GetNumberOfProducts(category).Single();

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