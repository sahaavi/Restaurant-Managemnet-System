using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class CategoryListService
    {
        CategoryListRepository catListRepo;
        public CategoryListService()
        {
            catListRepo = new CategoryListRepository();
        }

        public List<CategoryList> GetAll()
        {
            return catListRepo.GetAll();
        }

        public CategoryList GetById(int id)
        {
            return catListRepo.Get(id);
        }

        public CategoryList GetByName(string name)
        {
            return catListRepo.Get(name);
        }

        //public int GetIdByName(string name)
        //{
        //    return catListRepo.GetIdByName(name);
        //}

        public int Insert(CategoryList catList)
        {
            return catListRepo.Insert(catList);
        }

        public int Update(CategoryList catList)
        {
            return catListRepo.Update(catList);
        }
    }
}
