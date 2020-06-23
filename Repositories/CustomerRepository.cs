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
   public class CustomerRepository:CustomerInterface<Customer>,IDisposable
    {
        DataAccess dataAccess;
        public CustomerRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Customer> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM Customer_List";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Customer> customers = new List<Customer>();
                while (reader.Read())
                {
                    Customer cus = new Customer();
                    cus.CusId = (int)reader["CusId"];
                    cus.Name = reader["Name"].ToString();
                    cus.Contact = reader["Contact"].ToString();
                    cus.Address = reader["Address"].ToString();
                    customers.Add(cus);
                }
                return customers;
            }
            catch (Exception )
            {
                return null;
            }


            
        }

        public Customer Get(int id)
        {  
      try{

            string sql = "SELECT * FROM Customer_List WHERE CusId=" + id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Customer cus = new Customer();
            cus.CusId = (int)reader["CusId"];
            cus.Name = reader["Name"].ToString();
            cus.Contact = reader["Contact"].ToString();
            cus.Address = reader["Address"].ToString();
            dataAccess.Dispose();
            return cus;
        }
            catch (Exception )
            {
                return null;
            }

        }

        public Customer Get(string name)
        {
            try
            {

                string sql = "SELECT * FROM Customer_List WHERE Name='" + name + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Customer cus = new Customer();
                cus.CusId = (int)reader["CusId"];
                cus.Name = reader["Name"].ToString();
                cus.Contact = reader["Contact"].ToString();
                cus.Address = reader["Address"].ToString();
                return cus;
            }
            catch (Exception)
            { return null; }
        }

        public int Insert(Customer entity)
        {
            try
            {
                string sql = "INSERT INTO Customer_List(Name,Contact,Address) VALUES('" + entity.Name + "','" + entity.Contact + "','" + entity.Address + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Update(Customer entity)
        {
            try
            {
                dataAccess = new DataAccess();
                string sql = "UPDATE Customer_List SET Name='" + entity.Name + "',Contact='" + entity.Contact + "',Address='" + entity.Address + "' WHERE CusId=" + entity.CusId;
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        //public int Delete(int id)
        //{

        //    string sql = "DELETE FROM Categories WHERE Id="+id;
        //    return dataAccess.ExecuteQuery(sql);
        //}

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
