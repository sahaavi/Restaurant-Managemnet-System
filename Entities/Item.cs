using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public float ItemPrice { get; set; }
        public string ItemDescription { get; set; }
        //public int Category_Id { get; set; }
        public string Category_Name { get; set; }
    }
}
