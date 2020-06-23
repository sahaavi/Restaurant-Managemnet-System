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
    public partial class UserRegistrationForm : Form
    {
        int id;
        public UserRegistrationForm()
        {
            InitializeComponent();
        }

        void UpdateGridView()
        {
            UserService us = new UserService();
            dataGridView1.DataSource = us.GetAllCategories();
        }

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {
            UserService us = new UserService();
            dataGridView1.DataSource = us.GetAllCategories();
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            tname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tcontact.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            tadress.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tnid.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tsalary.Text=dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tusername.Text=dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tpassword.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            ttype.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (tname.Text == String.Empty || tcontact.Text == string.Empty || tadress.Text == null || tsalary.Text==string.Empty || tusername.Text ==string.Empty ||tpassword.Text==string.Empty||ttype.Text==string.Empty || tnid.Text==string.Empty)
            {
                MessageBox.Show("Please Fillup All The Fields ");

            }
            else
            {
                UserService us = new UserService();
                int result = us.Insert(new User()
                {
                    Name = tname.Text,
                    Contact = tcontact.Text,
                    Address = tadress.Text,
                    NID = tnid.Text,
                    Salary = Double.Parse(tsalary.Text),
                    User_Name = tusername.Text,
                    Password = tpassword.Text,
                    User_Type = ttype.Text

                });
                if (result > 0)
                {
                    MessageBox.Show("User added.");

                }
                else
                {
                    MessageBox.Show("Error");
                }
                UpdateGridView();
                tname.Text = tcontact.Text = tadress.Text = tnid.Text = tsalary.Text = tusername.Text = tpassword.Text = ttype.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserService user = new UserService();
            User ur=user.GetById(id);
            if (ur != null)
            {
                if (tname.Text == String.Empty || tcontact.Text == string.Empty || tadress.Text == null || tsalary.Text == string.Empty || tusername.Text == string.Empty || tpassword.Text == string.Empty || ttype.Text == string.Empty || tnid.Text == string.Empty)
                {
                    MessageBox.Show("Please Fillup All The Fields ");
                }

                else
                {
                    UserService us = new UserService();
                    User u = us.GetById(id);
                    u.Name = tname.Text;
                    u.Contact = tcontact.Text;
                    u.Address = tadress.Text;
                    u.NID = tnid.Text;
                    u.Salary = Double.Parse(tsalary.Text);
                    u.User_Name = tusername.Text;
                    u.Password = tpassword.Text;
                    u.User_Type = ttype.Text;

                    int result = us.Update(u);
                    if (result > 0)
                    {
                        MessageBox.Show("User updated.");
                        UpdateGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                    UpdateGridView();
                    tname.Text = tcontact.Text = tadress.Text = tnid.Text = tsalary.Text = tusername.Text = tpassword.Text = ttype.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("User does not exists");
            }

        }
       
    }
}
