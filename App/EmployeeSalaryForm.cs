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
    public partial class EmployeeSalaryForm : Form
    {
        
        public EmployeeSalaryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tid.Text == string.Empty)
            { MessageBox.Show("Give the Id please"); }
            else
            {
                UserService us = new UserService();

                User u = us.GetById(Convert.ToInt16(tid.Text));
                //tname.Text=u.Name ;


                //int result = us.Update(u);
                if (u != null)
                {

                    tname.Text = u.Name;
                    tsalary.Text = u.Salary.ToString();

                }
                else
                {
                    MessageBox.Show("Id not found");
                }
            }
            
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            if (tid.Text == string.Empty || tname.Text == string.Empty || tpay.Text == string.Empty || tsalary.Text == string.Empty)
            { MessageBox.Show("Please Fillup all the text fields!!"); }
      else{
            if (Double.Parse(tpay.Text) <= Double.Parse(tsalary.Text))
            {
                double x = Double.Parse(tsalary.Text) - Double.Parse(tpay.Text);
                lAmount.Text = x.ToString();



                SalaryService sal = new SalaryService();
                int result = sal.Insert(new Salary()
                {

                    Eid = Convert.ToInt16(tid.Text),
                    Name = tname.Text,
                    Month = dateTimePicker1.Value.Month.ToString(),
                    Pay = Double.Parse(tpay.Text),
                    Total_Salary = Double.Parse(tsalary.Text),
                    Remain_salary = x,
                    Year = tyear.Value.Year.ToString()

                });
                if (result > 0)
                {
                    MessageBox.Show("Salary added.");

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Payment is greater than total salary ");
            }
         }  
            
        }
    }
}
