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
    public class ExpenseReportRepository : IExpenseReport<Expense>, IDisposable
    {
        DataAccess dataAccess;
        public ExpenseReportRepository()
        {
            dataAccess = new DataAccess();
        }

        public List<Expense> GetAll()
        {
            try
            {
                string sql = "SELECT * FROM Expenses ORDER BY ExpenseDate DESC";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Expense> expenses = new List<Expense>();
                while (reader.Read())
                {
                    Expense expense = new Expense();
                    expense.Id = (int)reader["Id"];
                    expense.ExpenseName = reader["ExpenseName"].ToString();
                    expense.ExpenseAmount = Convert.ToSingle(reader["ExpenseAmount"]);
                    expense.ExpenseDate = Convert.ToDateTime(reader["ExpenseDate"]);
                    expenses.Add(expense);
                }
                return expenses;
            }
            catch (Exception)
            {
                return null;
            }
        } 

        public List<Expense> GetAllDate(DateTime date1, DateTime date2)
        {
            try
            {
                string sql = "SELECT * FROM Expenses WHERE ExpenseDate >='" + date1 + "' AND ExpenseDate <= '" + date2 + "' ORDER BY ExpenseDate DESC";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Expense> expenses = new List<Expense>();
                while (reader.Read())
                {
                    Expense expense = new Expense();
                    expense.Id = (int)reader["Id"];
                    expense.ExpenseName = reader["ExpenseName"].ToString();
                    expense.ExpenseAmount = Convert.ToSingle(reader["ExpenseAmount"]);
                    expense.ExpenseDate = Convert.ToDateTime(reader["ExpenseDate"]);
                    expenses.Add(expense);
                }
                return expenses;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Expense> GetAllItem(string name)
        {
            try
            {
                string sql = "SELECT * FROM Expenses WHERE ExpenseName='" + name + "' ORDER BY ExpenseDate DESC";
                SqlDataReader reader = dataAccess.GetData(sql);
                List<Expense> expenses = new List<Expense>();
                while (reader.Read())
                {
                    Expense expense = new Expense();
                    expense.Id = (int)reader["Id"];
                    expense.ExpenseName = reader["ExpenseName"].ToString();
                    expense.ExpenseAmount = Convert.ToSingle(reader["ExpenseAmount"]);
                    expense.ExpenseDate = Convert.ToDateTime(reader["ExpenseDate"]);
                    expenses.Add(expense);
                }
                return expenses;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Expense Get(int id)
        {
            try
            {
                string sql = "SELECT * FROM Expenses WHERE Id=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Expense expense = new Expense();
                expense.Id = (int)reader["Id"];
                expense.ExpenseName = reader["ExpenseName"].ToString();
                expense.ExpenseAmount = Convert.ToSingle(reader["ExpenseAmount"]);
                expense.ExpenseDate = Convert.ToDateTime(reader["ExpenseDate"]);
                dataAccess.Dispose();
                return expense;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Expense Get(string name)
        {
            try
            {
                string sql = "SELECT * FROM Expenses WHERE ExpenseName='" + name + "' ORDER BY ExpenseDate DESC";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                Expense expense = new Expense();
                expense.Id = (int)reader["Id"];
                expense.ExpenseName = reader["ExpenseName"].ToString();
                expense.ExpenseAmount = Convert.ToSingle(reader["ExpenseAmount"]);
                expense.ExpenseDate = Convert.ToDateTime(reader["ExpenseDate"]);
                dataAccess.Dispose();
                return expense;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int Update(Expense entity)
        {
            try
            {
                dataAccess = new DataAccess();
                string sql = "UPDATE Expenses SET ExpenseName='" + entity.ExpenseName + "',ExpenseAmount='" + entity.ExpenseAmount + "',ExpenseDate='" + entity.ExpenseDate + "' WHERE Id=" + entity.Id;
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
