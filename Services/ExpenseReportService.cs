using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class ExpenseReportService
    {
        ExpenseReportRepository exprptRepo;
        public ExpenseReportService()
        {
            exprptRepo = new ExpenseReportRepository();
        }

        public List<Expense> GetAllExpenses()
        {
            return exprptRepo.GetAll();
        }
        public List<Expense> GetAllDate(DateTime date1, DateTime date2)
        {
            return exprptRepo.GetAllDate(date1, date2);
        }
        public List<Expense> GetAllItem(string name)
        {
            return exprptRepo.GetAllItem(name);
        }
        public Expense GetById(int id)
        {
            return exprptRepo.Get(id);
        }
        public Expense GetByName(string name)
        {
            return exprptRepo.Get(name);
        }
        public int Update(Expense report)
        {
            return exprptRepo.Update(report);
        }
    }
}
