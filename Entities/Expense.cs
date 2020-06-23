using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public string ExpenseName { get; set; }
        public float ExpenseAmount { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
