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
    public class SalaryRepository:SalaryInterface<Salary>,IDisposable
    {
        DataAccess dataAccess;
        public SalaryRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<Salary> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM Salary_List";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Salary> salaries = new List<Salary>();

                while (reader.Read())
                {
                    Salary sal = new Salary();

                    sal.Eid = (int)reader["Eid"];
                    sal.Name = reader["Name"].ToString();
                    sal.Month = reader["Month"].ToString();
                    sal.Pay = Convert.ToSingle(reader["Pay"]);
                    sal.Total_Salary = Convert.ToSingle(reader["Salary"]);
                    sal.Remain_salary = Convert.ToSingle(reader["Remain_salary"]);
                    sal.Year = reader["Year"].ToString();

                    salaries.Add(sal);
                }
                return salaries;
            }
            catch (Exception)
            { return null; }
        }

        public Salary Get(int id, String Month, String Year)
        {
            try
            {
                string sql = "SELECT * FROM Salary_List WHERE (Eid='" + id + "' AND Month='" + Month + "' AND Year='" + Year + "')";
                //string sql = "SELECT * FROM Salary_List WHERE Eid=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Salary sal = new Salary();

                sal.Eid = (int)reader["Eid"];
                sal.Name = reader["Name"].ToString();
                sal.Month = reader["Month"].ToString();
                sal.Pay = Convert.ToSingle(reader["Pay"]);
                sal.Total_Salary = Convert.ToSingle(reader["Salary"]);
                sal.Remain_salary = Convert.ToSingle(reader["Remain_salary"]);
                sal.Year = reader["Year"].ToString();
                return sal;
            }
            catch (Exception)
            { return null; }

        }

        public Salary Get(string name)
        {
            try
            {
                string sql = "SELECT * FROM Salary_List WHERE Name='" + name + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Salary sal = new Salary();
                sal.Eid = (int)reader["Eid"];
                sal.Name = reader["Name"].ToString();
                sal.Month = reader["Month"].ToString();
                sal.Pay = Convert.ToSingle(reader["Pay"]);
                sal.Total_Salary = Convert.ToSingle(reader["Salary"]);
                sal.Remain_salary = Convert.ToSingle(reader["Remain_salary"]);
                sal.Year = reader["Year"].ToString();
                return sal;
            }
            catch (Exception)
            { return null;  }
        }

        public int Insert(Salary entity)
        {
            try
            {
                string sql = "INSERT INTO Salary_List(Eid,Name,Month,Pay,Salary,Remain_salary,Year) VALUES('" + entity.Eid + "','" + entity.Name + "','" + entity.Month + "','" + entity.Pay + "','" + entity.Total_Salary + "','" + entity.Remain_salary + "','" + entity.Year + "')";
                return dataAccess.ExecuteQuery(sql);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public int Update(Salary entity)
        {
            try
            {
                dataAccess = new DataAccess();
                string sql = "UPDATE Salary_List SET Pay='" + entity.Pay + "',Remain_salary='" + entity.Remain_salary + "',Month='" + entity.Month + "',Year='" + entity.Year + "' WHERE Eid=" + entity.Eid;
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