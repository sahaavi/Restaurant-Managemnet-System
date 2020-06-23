using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService
    {

        CustomerRepository cusRepo;
        public CustomerService()
        {
            cusRepo = new CustomerRepository();
        }

        public List<Customer> GetAllCategories()
        {
            return cusRepo.GetAll();
        }
        public Customer GetById(int id)
        {
            return cusRepo.Get(id);
        }
        public Customer GetByName(string name)
        {
            return cusRepo.Get(name);
        }
        public int Insert(Customer cus)
        {
            return cusRepo.Insert(cus);
        }
        public int Update(Customer cus)
        {
            return cusRepo.Update(cus);
        }
        //public int Delete(int id)
        //{
        //    return cusRepo.Delete(id);
        //}

    }
}
