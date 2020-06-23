using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
    {
        UserRepository UsRepo;

        public UserService()
        {
            UsRepo = new UserRepository();
        }

        public List<User> GetAllCategories()
        {
            return UsRepo.GetAll();
        }
        public User GetById(int id)
        {
            return UsRepo.Get(id);
        }
        public User GetByContact(string conatact)
        {
            return UsRepo.Get(conatact);
        }
        public int Insert(User us)
        {
            return UsRepo.Insert(us);
        }
        public int Update(User us)
        {
            return UsRepo.Update(us);
        }
        //public int Delete(int id)
        //{
        //    return cusRepo.Delete(id);
        //}

    }
}
