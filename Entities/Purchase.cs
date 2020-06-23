using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Purchase
    {
        public int Id { get; set; }
        public string Item_Name { get; set; }        
        public int Quantity{get; set;  }
        public double Price{get; set;}
        public DateTime Date { get; set; }            
        public int Cat_Id{get; set;}
        public double Total_price { get; set; }

    }
}
