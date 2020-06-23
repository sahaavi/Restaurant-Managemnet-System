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
    public class UserRepository:UserInterface<User>,IDisposable
    {
        DataAccess dataAccess;
        public UserRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<User> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM User_List";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<User> users = new List<User>();

                while (reader.Read())
                {
                    User us = new User();
                    us.Id = (int)reader["ID"];
                    us.Name = reader["Name"].ToString();
                    us.Address = reader["Address"].ToString();
                    us.Contact = reader["Contact"].ToString();
                    us.NID = reader["NID"].ToString();
                    us.Salary = Convert.ToSingle(reader["Salary"]);
                    us.User_Name = reader["User_Name"].ToString();
                    us.Password = reader["Password"].ToString();
                    us.User_Type = reader["User_Type"].ToString();

                    users.Add(us);
                }

                return users;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public User Get(int id)
        {
            try
            {
                string sql = "SELECT * FROM User_List WHERE ID=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                User us = new User();
                us.Id = (int)reader["ID"];
                us.Name = reader["Name"].ToString();
                us.Address = reader["Address"].ToString();
                us.Contact = reader["Contact"].ToString();
                us.NID = reader["NID"].ToString();
                us.Salary = Convert.ToSingle(reader["Salary"]);
                us.User_Name = reader["User_Name"].ToString();
                us.Password = reader["Password"].ToString();
                us.User_Type = reader["User_Type"].ToString();
                return us;
            }
            catch (Exception)
            { return null; }

        }

        

        public User Get(string contact)
        {
            try
            {
                string sql = "SELECT * FROM User_List WHERE Contact='" + contact + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                User us = new User();
                us.Id = (int)reader["ID"];
                us.Name = reader["Name"].ToString();
                us.Address = reader["Address"].ToString();
                us.Contact = reader["Contact"].ToString();
                us.NID = reader["NID"].ToString();
                us.Salary = Convert.ToSingle(reader["Salary"]);
                us.User_Name = reader["User_Name"].ToString();
                us.Password = reader["Password"].ToString();
                us.User_Type = reader["User_Type"].ToString();
                return us;
            }
            catch (Exception)
            {
                return null;

            }

        }

        public int Insert(User entity)
        {
            try
            {
                string sql = "INSERT INTO User_List(Name,Address,Contact,NID,Salary,User_Name,Password,User_Type) VALUES('" + entity.Name + "','" + entity.Address + "','" + entity.Contact + "','" + entity.NID + "','" + entity.Salary + "','" + entity.User_Name + "','" + entity.Password + "','" + entity.User_Type + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            { return 0; }
            
       }

        public int Update(User entity)
        {
            try
            {
            dataAccess = new DataAccess();
            string sql = "UPDATE User_List SET Name='" + entity.Name + "',Address='" + entity.Address + "',Contact='" + entity.Contact + "',NID='" + entity.NID + "',Salary='" + entity.Salary + "',User_Name='" + entity.User_Name + "',Password='" + entity.Password + "',User_Type='" + entity.User_Type + "' WHERE ID=" + entity.Id;
            return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            { return 0; }
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


