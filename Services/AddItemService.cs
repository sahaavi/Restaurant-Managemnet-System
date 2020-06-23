using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class AddItemService
    {
        AddItemRepository addItemRepo;
        public AddItemService()
        {
            addItemRepo = new AddItemRepository();
        }

        public int Insert(Item item)
        {
            return addItemRepo.Insert(item);
        }
    }
}
