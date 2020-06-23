using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Repositories;


namespace Services
{
    public class LoginService
    {
        LoginRepository loginrepo;

        public LoginService()
        {
            loginrepo = new LoginRepository();
        }

        public Login GetById(int id)
        {
            return loginrepo.Get(id);
        }
        public Login GetUser(Login ln)
        {
            return loginrepo.Get(ln);
        }

        //public string LoginValidation(string username, string password)
        //{
        //    return loginrepo.Validation(username, password);
        //}
    }
}
