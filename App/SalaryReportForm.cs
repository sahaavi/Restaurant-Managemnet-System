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
    public partial class SalaryReportForm : Form
    {
        public SalaryReportForm()
        {
            InitializeComponent();
        }
        void UpdateGridView()
        {
            SalaryService SalService = new SalaryService();
            dataGridView1.DataSource = SalService.GetAllCategories();
        }


        private void SalaryReportForm_Load(object sender, EventArgs e)
        {
            SalaryService SalService = new SalaryService();
            dataGridView1.DataSource = SalService.GetAllCategories();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tid.Text == string.Empty)
            { MessageBox.Show("please fillup the Id"); }
            else
            {       
                SalaryService SalService = new SalaryService();
                string month = tdate.Value.Month.ToString();
                string year = tyear.Value.Year.ToString();

                List<Salary> list = new List<Salary>();
                Salary ss = SalService.GetById(Convert.ToInt16(tid.Text), month, year);

                if (ss != null)
                {
                    list.Add(ss);
                    dataGridView1.DataSource = list;
                    tname.Text = list[0].Name;
                }
                else
                { MessageBox.Show("Id not found"); }


                // string s=list[0].Name;

               
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (tid.Text == string.Empty || tname.Text == string.Empty || tpay.Text == string.Empty)
            { MessageBox.Show("please Fillup All The Fields"); }
            else
            {
                SalaryService SalService = new SalaryService();
                string month = tdate.Value.Month.ToString();
                string year = tyear.Value.Year.ToString();

                Salary s = SalService.GetById(Convert.ToInt16(tid.Text), month, year);

                if (s != null)
                {
                    if (Double.Parse(tpay.Text) > s.Remain_salary)
                    {
                        MessageBox.Show("input payment is greater than remaining salary.");

                    }
                    else
                    {
                        s.Pay = Double.Parse(tpay.Text);
                        s.Remain_salary = s.Remain_salary - Double.Parse(tpay.Text);

                        int result = SalService.Update(s);
                        if (result > 0)
                        {
                            MessageBox.Show("salary updated.");
                            UpdateGridView();
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    UpdateGridView();
                }
                else
                { MessageBox.Show("id not found"); }
            }
        }



    }
}
