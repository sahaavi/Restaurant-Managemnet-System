using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoryService
    {
        CategoryRepository catRepo;
        public CategoryService()
        {
            catRepo = new CategoryRepository();
        }

        public List<Category> GetAllCategories()
        {
            return catRepo.GetAll();
        }
        public Category GetById(int id)
        {
            return catRepo.Get(id);
        }
        public Category GetByName(string name)
        {
            return catRepo.Get(name);
        }
        public int Insert(Category cat)
        {
            return catRepo.Insert(cat);
        }
        public int Update(Category cat)
        {
            return catRepo.Update(cat);
        }
        //public int Delete(int id)
        //{
        //    return catRepo.Delete(id);
        //}
    }
}
