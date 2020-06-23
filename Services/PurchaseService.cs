using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PurchaseService
    {
        PurchaseRepository PRepo;
       
         public PurchaseService()
        {
            PRepo = new PurchaseRepository();
        }

        public List<Purchase> GetAllPurchases()
        {
            return PRepo.GetAll();
        }
        
        public List<Purchase> GetById(String id, DateTime Date1, DateTime Date2) {
            int x = Convert.ToInt16(id);
            return PRepo.GetById(x, Date1, Date2);             
        
        }

        public Purchase GetByName(string name)
        {
            return PRepo.Get(name);
        }
        public int Insert(Purchase p)
        {
            return PRepo.Insert(p);
        }
        public int Update(Purchase p)
        {
            return PRepo.Update(p);
        }
        //public int Delete(int id)
        //{
        //    return catRepo.Delete(id);
        //}
    }
}
