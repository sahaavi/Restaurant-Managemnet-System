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
    public class SalesReportRepository : ISalesReport<Pos>, IDisposable
    {
        DataAccess dataAccess;
        public SalesReportRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<Pos> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM Sales ORDER BY Sale_Date DESC";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Pos> sales = new List<Pos>();
                while (reader.Read())
                {
                    Pos sale = new Pos();
                    sale.ItemId = (int)reader["Item_Id"];
                    sale.Name = reader["Name"].ToString();
                    sale.Price = Convert.ToSingle(reader["Price"]);
                    sale.Quantity = (int)reader["Quantity"];
                    sale.Discount = (int)reader["Discount"];
                    sale.TotalAmount = (int)reader["Total_Amount"];
                    sale.PaymentType = reader["Payment_Type"].ToString();
                    sale.SaleDate = Convert.ToDateTime(reader["Sale_Date"]);
                    sale.CustomerId = (int)reader["Customer_Id"];
                    sale.CashierName = reader["Cashier_Name"].ToString();
                    sales.Add(sale);
                }
                return sales;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Pos> GetAllDate(DateTime date1, DateTime date2)
        {
            try
            {
                string sql = "SELECT * FROM Sales WHERE Sale_Date >='" + date1 + "' AND Sale_Date <= '" + date2 + "' ORDER BY Sale_Date DESC";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Pos> sales = new List<Pos>();
                while (reader.Read())
                {
                    Pos sale = new Pos();
                    sale.ItemId = (int)reader["Item_Id"];
                    sale.Name = reader["Name"].ToString();
                    sale.Price = Convert.ToSingle(reader["Price"]);
                    sale.Quantity = (int)reader["Quantity"];
                    sale.Discount = (int)reader["Discount"];
                    sale.TotalAmount = (int)reader["Total_Amount"];
                    sale.PaymentType = reader["Payment_Type"].ToString();
                    sale.SaleDate = Convert.ToDateTime(reader["Sale_Date"]);
                    sale.CustomerId = (int)reader["Customer_Id"];
                    sale.CashierName = reader["Cashier_Name"].ToString();
                    sales.Add(sale);
                }
                return sales;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Pos> GetAllItem(string name)
        {
            try
            {
                string sql = "SELECT * FROM Sales WHERE Name='" + name + "' ORDER BY Sale_Date DESC";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Pos> sales = new List<Pos>();
                while (reader.Read())
                {
                    Pos sale = new Pos();
                    sale.ItemId = (int)reader["Item_Id"];
                    sale.Name = reader["Name"].ToString();
                    sale.Price = Convert.ToSingle(reader["Price"]);
                    sale.Quantity = (int)reader["Quantity"];
                    sale.Discount = (int)reader["Discount"];
                    sale.TotalAmount = (int)reader["Total_Amount"];
                    sale.PaymentType = reader["Payment_Type"].ToString();
                    sale.SaleDate = Convert.ToDateTime(reader["Sale_Date"]);
                    sale.CustomerId = (int)reader["Customer_Id"];
                    sale.CashierName = reader["Cashier_Name"].ToString();
                    sales.Add(sale);
                }
                return sales;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Pos Get(int id)
        {
            try
            {
                string sql = "SELECT * FROM Sales WHERE Item_Id=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Pos sale = new Pos();
                sale.ItemId = (int)reader["Item_Id"];
                sale.Name = reader["Name"].ToString();
                sale.Price = Convert.ToSingle(reader["Price"]);
                sale.Quantity = (int)reader["Quantity"];
                sale.Discount = (int)reader["Discount"];
                sale.TotalAmount = (int)reader["Total_Amount"];
                sale.PaymentType = reader["Payment_Type"].ToString();
                sale.SaleDate = Convert.ToDateTime(reader["Sale_Date"]);
                sale.CustomerId = (int)reader["Customer_Id"];
                sale.CashierName = reader["Cashier_Name"].ToString();
                dataAccess.Dispose();
                return sale;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Pos Get(string name)
        {
            try
            {
                string sql = "SELECT * FROM Sales WHERE Name='" + name + "' ORDER BY Sale_Date DESC";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Pos sale = new Pos();
                sale.ItemId = (int)reader["Item_Id"];
                sale.Name = reader["Name"].ToString();
                sale.Price = Convert.ToSingle(reader["Price"]);
                sale.Quantity = (int)reader["Quantity"];
                sale.Discount = (int)reader["Discount"];
                sale.TotalAmount = (int)reader["Total_Amount"];
                sale.PaymentType = reader["Payment_Type"].ToString();
                sale.SaleDate = Convert.ToDateTime(reader["Sale_Date"]);
                sale.CustomerId = (int)reader["Customer_Id"];
                sale.CashierName = reader["Cashier_Name"].ToString();
                dataAccess.Dispose();
                return sale;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
