using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;
using Entities;
using Repositories;

namespace App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            if (t_username.Text == string.Empty || t_password.Text == string.Empty)
            {
                MessageBox.Show("Username or Password can not be empty.");
            }

            else
            {
                
                Login ln = new Login() { User_Name = t_username.Text, Password = t_password.Text };
                LoginService loginService = new LoginService();
                Login log = loginService.GetUser(ln);
                if (log != null)
                {
                    
                    if (log.User_Type == "Admin")
                    {
                        AdminForm admin = new AdminForm(log.User_Name);
                        Visible = false;
                        admin.Show();
                    }
                    else if (log.User_Type == "Staff")
                    {
                        StaffForm staff = new StaffForm(log.User_Name);
                        Visible = false;
                        staff.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
               
            }
            
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
