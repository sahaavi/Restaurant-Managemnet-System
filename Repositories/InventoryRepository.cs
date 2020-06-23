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
    public class InventoryRepository : IInventory<Inventory>, IDisposable
    {
        DataAccess dataAccess;
        public InventoryRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<Inventory> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM Inventory";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Inventory> inventories = new List<Inventory>();
                while (reader.Read())
                {
                    Inventory inventory = new Inventory();
                    inventory.Id = (int)reader["Id"];
                    inventory.ProductName = reader["ProductName"].ToString();
                    inventory.Quantity = Convert.ToSingle(reader["Quantity"]);
                    inventories.Add(inventory);
                }
                return inventories;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Inventory> GetAllItem(string name)
        {
            try
            {
                string sql = "SELECT * FROM Inventory WHERE ProductName='" + name + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Inventory> inventories = new List<Inventory>();
                while (reader.Read())
                {
                    Inventory inventory = new Inventory();
                    inventory.Id = (int)reader["Id"];
                    inventory.ProductName = reader["ProductName"].ToString();
                    inventory.Quantity = Convert.ToSingle(reader["Quantity"]);
                    inventories.Add(inventory);
                }
                return inventories;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Inventory Get(int id)
        {
            try
            {
                string sql = "SELECT * FROM Inventory WHERE Id=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Inventory inventory = new Inventory();
                inventory.Id = (int)reader["Id"];
                inventory.ProductName = reader["ProductName"].ToString();
                inventory.Quantity = Convert.ToSingle(reader["Quantity"]);
                dataAccess.Dispose();
                return inventory;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Inventory Get(string name)
        {
            try
            {
                string sql = "SELECT * FROM Inventory WHERE ProductName='" + name + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Inventory inventory = new Inventory();
                inventory.Id = (int)reader["Id"];
                inventory.ProductName = reader["ProductName"].ToString();
                inventory.Quantity = Convert.ToSingle(reader["Quantity"]);
                dataAccess.Dispose();
                return inventory;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Insert(Inventory entity)
        {
            try
            {
                string sql = "INSERT INTO Inventory(ProductName,Quantity) VALUES('" + entity.ProductName + "','" + entity.Quantity + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Update(Inventory entity)
        {
            try
            {
                dataAccess = new DataAccess();
                string sql = "UPDATE Inventory SET ProductName='" + entity.ProductName + "',Quantity='" + entity.Quantity + "' WHERE Id=" + entity.Id;
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
