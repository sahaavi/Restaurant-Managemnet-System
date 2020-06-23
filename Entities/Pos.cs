using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pos
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public int TotalAmount { get; set; }
        public string PaymentType { get; set; }
        public DateTime SaleDate { get; set; }
        public int CustomerId { get; set; }
        public string CashierName { get; set; }
    }
}
