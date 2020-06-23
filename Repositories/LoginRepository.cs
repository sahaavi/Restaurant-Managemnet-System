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
    public class LoginRepository : ILogin<Login>, IDisposable
    {
        DataAccess dataAccess;
        public LoginRepository()
        {
            dataAccess = new DataAccess();
        }

         public Login Get(int id)
        {
            try
            {
                string sql = "SELECT * FROM User_List WHERE Id=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Login login = new Login();
                login.Id = (int)reader["Id"];
                login.User_Name = reader["User_Name"].ToString();
                login.Password = reader["Password"].ToString();
                dataAccess.Dispose();
                return login;
            }
            catch (Exception)
            {
                return null;
            }
        }

         public Login Get(Login ln)
         {
             try
             {
             string sql = "SELECT * FROM User_List WHERE User_Name='" + ln.User_Name + "' AND Password ='" + ln.Password + "'";
                 SqlDataReader reader = dataAccess.GetData(sql);
                 reader.Read();
                 Login login = new Login();
                 login.Id = (int)reader["ID"];
                 login.User_Name = reader["User_Name"].ToString();
                 login.Password = reader["Password"].ToString();
                 //return login;
                 login.User_Type = reader["User_Type"].ToString();
                 //string userType = reader["User_Type"].ToString();
                 return login;

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
