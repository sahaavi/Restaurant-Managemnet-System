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
    public partial class CustomerListForm : Form
    {
        int id;
        public CustomerListForm()
        {
            InitializeComponent();
        }

        void UpdateGridView()
        {
            CustomerService CService = new CustomerService();
            dataGridView1.DataSource = CService.GetAllCategories();
        }

        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            CustomerService CService = new CustomerService();
            dataGridView1.DataSource = CService.GetAllCategories();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            TName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TContact.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TAdress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            if (TName.Text == String.Empty || TContact.Text == string.Empty)
            {
                MessageBox.Show("Please Fillup Name and contact ");

            }
            else
            {
                CustomerService cs = new CustomerService();
                Customer cus = cs.GetById(id);
                cus.CusId = id;
                cus.Name = TName.Text;
                cus.Contact = TContact.Text;
                cus.Address = TAdress.Text;

                int result = cs.Update(cus);
                if (result > 0)
                {
                    MessageBox.Show("Customer updated.");
                    UpdateGridView();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

    }
}
