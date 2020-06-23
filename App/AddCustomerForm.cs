using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AddCutomerForm : Form
    {
        public AddCutomerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == String.Empty || ContactBox.Text == string.Empty)
            {
                MessageBox.Show("Please Fillup Name and contact ");

            }
            else
            {
                CustomerService cus = new CustomerService();
                int result = cus.Insert(new Customer()
                {
                    Name = NameBox.Text,
                    Contact = ContactBox.Text,
                    Address = AdressBox.Text

                });
                if (result > 0)
                {
                    MessageBox.Show("Customer added.");

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
