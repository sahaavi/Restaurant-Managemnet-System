using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Login
    {
        public int Id { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string User_Type{ get; set; }
    }
}
