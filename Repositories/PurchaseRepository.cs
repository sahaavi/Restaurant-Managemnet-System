using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    
        public class PurchaseRepository : PInterfce<Purchase>, IDisposable
        {
            DataAccess dataAccess;
            public PurchaseRepository()
            {
                dataAccess = new DataAccess();
            }
            public List<Purchase> GetAll()
            {
                try
                {
                    string sql = "SELECT * FROM Purchase_List";
                    SqlDataReader reader = dataAccess.GetData(sql);
                    List<Purchase> Purchases = new List<Purchase>();
                    while (reader.Read())
                    {
                        Purchase p = new Purchase();
                        p.Id = (int)reader["Id"];
                        p.Item_Name = reader["Item_Name"].ToString();
                        p.Quantity = (int)reader["Quantity"];
                        p.Price = Convert.ToSingle(reader["Price"]);
                        p.Date = Convert.ToDateTime(reader["Date"]);
                        p.Cat_Id = (int)reader["Cat_Id"];
                        p.Total_price = Convert.ToSingle(reader["Total_Price"]);
                        Purchases.Add(p);
                    }
                    return Purchases;
                }
                catch (Exception)
                { return null; }
            }

            

            public List<Purchase> GetById(int id, DateTime Date1,DateTime Date2)
            {
                try
                {
                    string sql = "SELECT * FROM Purchase_List WHERE Cat_Id='" + id + "' and  Date >= '" + Date1 + "' AND Date <= '" + Date2 + "'";
                    SqlDataReader reader = dataAccess.GetData(sql);
                    List<Purchase> Purchases = new List<Purchase>();
                    while (reader.Read())
                    {
                        Purchase p = new Purchase();
                        p.Id = (int)reader["Id"];
                        p.Item_Name = reader["Item_Name"].ToString();
                        p.Quantity = (int)reader["Quantity"];
                        p.Price = Convert.ToSingle(reader["Price"]);
                        p.Date = Convert.ToDateTime(reader["Date"]);
                        p.Cat_Id = (int)reader["Cat_Id"];
                        p.Total_price = Convert.ToSingle(reader["Total_Price"]);
                        Purchases.Add(p);
                    }
                    return Purchases;
                }
                catch (Exception)
                { return null;  }
            }


            

            public Purchase Get(string name)
            {
                try
                {
                    string sql = "SELECT * FROM Purchase_List WHERE Item_Name='" + name + "'";
                    SqlDataReader reader = dataAccess.GetData(sql);
                    reader.Read();
                    Purchase p = new Purchase();
                    p.Id = (int)reader["Id"];
                    p.Item_Name = reader["Item_Name"].ToString();
                    p.Quantity = (int)reader["Quantity"];
                    p.Price = Convert.ToSingle(reader["Price"]);
                    p.Date = Convert.ToDateTime(reader["Date"]);
                    p.Cat_Id = (int)reader["Cat_Id"];
                    p.Total_price = Convert.ToSingle(reader["Total_Price"]);
                    return p;
                }
                catch (Exception)
                { return null; }

            }

            public int Insert(Purchase entity)
            {
                try
                {
                    string sql = "INSERT INTO Purchase_List(Item_Name,Quantity,Price,Date,Cat_Id,Total_Price) VALUES('" + entity.Item_Name + "','" + entity.Quantity + "','" + entity.Price + "','" + entity.Date + "','" + entity.Cat_Id + "'," + entity.Total_price + ")";

                    return dataAccess.ExecuteQuery(sql);
                }
                catch (Exception)
                { return 0; }
            }

            public int Update(Purchase entity)
            {
                try
                {
                    dataAccess = new DataAccess();
                    string sql = "UPDATE Purchase_List SET Item_Name='" + entity.Item_Name + "' WHERE Id=" + entity.Id;
                    return dataAccess.ExecuteQuery(sql);
                }
                catch (Exception)
                { return 0; }
            }

            

           

            public void Dispose()
            {
                throw new NotImplementedException();
            }
        
    }
}
