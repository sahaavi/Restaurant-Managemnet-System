using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;

namespace Services
{
    public class AddExpenseService
    {
        AddExpenseRepository addExpRepo;
        public AddExpenseService()
        {
            addExpRepo = new AddExpenseRepository();
        }

        public int Insert(Expense exp)
        {
            return addExpRepo.Insert(exp);
        }
    }
}
