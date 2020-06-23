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
    public class AddExpenseRepository : IAddExpense<Expense>, IDisposable
    {
        DataAccess dataAccess;
        public AddExpenseRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Insert(Expense entity)
        {
            try
            {
                string sql = "INSERT INTO Expenses(ExpenseName,ExpenseAmount,ExpenseDate) VALUES('" + entity.ExpenseName + "','" + entity.ExpenseAmount + "','" + entity.ExpenseDate + "')";
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
