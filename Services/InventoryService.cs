using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class InventoryService
    {
        InventoryRepository inventoryRepo;
        public InventoryService()
        {
            inventoryRepo = new InventoryRepository();
        }

        public List<Inventory> GetAllProduct()
        {
            return inventoryRepo.GetAll();
        }

        public List<Inventory> GetAllItem(string name)
        {
            return inventoryRepo.GetAllItem(name);
        }

        public Inventory GetById(int id)
        {
            return inventoryRepo.Get(id);
        }

        public Inventory GetByName(string name)
        {
            return inventoryRepo.Get(name);
        }

        public int Insert(Inventory item)
        {
            return inventoryRepo.Insert(item);
        }

        public int Update(Inventory report)
        {
            return inventoryRepo.Update(report);
        }
    }
}
