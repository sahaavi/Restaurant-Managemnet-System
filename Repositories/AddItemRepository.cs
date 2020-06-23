using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Interfaces;
using System.Data.SqlClient;

namespace Repositories
{
    public class AddItemRepository : IAddItem<Item>, IDisposable
    {
        DataAccess dataAccess;
        public AddItemRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Insert(Item entity)
        {
            try
            {
                string sql = "INSERT INTO Item(Name,Price,Description,Category_Name) VALUES('" + entity.ItemName + "','" + entity.ItemPrice + "','" + entity.ItemDescription + "','" + entity.Category_Name + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch(Exception) 
            {
                return 0;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
