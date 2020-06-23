using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
   public class SalaryService
    {
        SalaryRepository salRepo;

        public SalaryService()
        {
            salRepo = new SalaryRepository();
        }

        public List<Salary> GetAllCategories()
        {
            return salRepo.GetAll();
        }
        public Salary GetById(int id,String Month,String Year)
        {
            Console.WriteLine(Month+Year);
            return salRepo.Get(id,Month,Year);
        }
        public Salary GetByName(string name)
        {
            return salRepo.Get(name);
        }
        public int Insert(Salary s)
        {
            return salRepo.Insert(s);
        }
        public int Update(Salary s)
        {
            return salRepo.Update(s);
        }
        //public int Delete(int id)
        //{
        //    return cusRepo.Delete(id);
        //}

    }
}