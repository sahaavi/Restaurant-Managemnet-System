using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class ItemListService
    {
        ItemListRepository itemListRepo;
        public ItemListService()
        {
            itemListRepo = new ItemListRepository();
        }

        public List<Item> GetAll()
        {
            return itemListRepo.GetAll();
        }

        public Item GetById(int id)
        {
            return itemListRepo.Get(id);
        }

        public Item GetByName(string name)
        {
            return itemListRepo.Get(name);
        }

        public int Update(Item itemList)
        {
            return itemListRepo.Update(itemList);
        }

        public int Delete(int id)
        {
            return itemListRepo.Delete(id);
        }
    }
}
