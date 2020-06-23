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
    public class ItemListRepository : IItemList<Item>, IDisposable
    {
        DataAccess dataAccess;
        public ItemListRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<Item> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM Item";
                //string sql = "SELECT Itm.Id, Itm.Name, Itm.Price, Itm.Description,cat.Category_Name,Itm.Category_Id FROM Item itm inner join ItemCategory cat on(itm.Category_Id=cat.Id)";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Item> itemList = new List<Item>();
                while (reader.Read())
                {
                    Item item = new Item();
                    item.Id = (int)reader["Id"];
                    item.ItemName = reader["Name"].ToString();
                    item.ItemPrice = Convert.ToSingle(reader["Price"]);
                    item.ItemDescription = reader["Description"].ToString();
                    //item.Category_Id = (int)reader["Category_Id"];
                    item.Category_Name = reader["Category_Name"].ToString();

                    itemList.Add(item);

                }
                return itemList;
            }
            catch (Exception)
            {
                return null;
            }
        }


        
        public Item Get(int id)
        {
            try
            {
                string sql = "SELECT * FROM Item WHERE Id=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Item item = new Item();
                item.Id = (int)reader["Id"];
                item.ItemName = reader["Name"].ToString();
                item.ItemPrice = Convert.ToSingle(reader["Price"]);
                item.ItemDescription = reader["Description"].ToString();
                //item.Category_Id = (int)reader["Category_Id"];
                item.Category_Name = reader["Category_Name"].ToString();
                dataAccess.Dispose();
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Item Get(string name)
        {
            try
            {
                string sql = "SELECT * FROM Item WHERE Name='" + name + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Item item = new Item();
                item.Id = (int)reader["Id"];
                item.ItemName = reader["Name"].ToString();
                item.ItemPrice = Convert.ToSingle(reader["Price"]);
                item.ItemDescription = reader["Description"].ToString();
                //item.Category_Id = (int)reader["Category_Id"];
                item.Category_Name = reader["Category_Name"].ToString();
                dataAccess.Dispose();
                return item;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Update(Item entity)
        {
            try
            {
                dataAccess = new DataAccess();
                string sql = "UPDATE Item SET Name='" + entity.ItemName + "',Price='" + entity.ItemPrice + "',Description='" + entity.ItemDescription + "',Category_Name='" + entity.Category_Name + "'  WHERE Id=" + entity.Id;
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Delete(int id)
        {
            try
            {

                string sql = "DELETE FROM Item WHERE Id=" + id;
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
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
