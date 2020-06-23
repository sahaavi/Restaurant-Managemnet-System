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
    public partial class PurchaseReportForm : Form
    {
        

        public PurchaseReportForm()
        {
            InitializeComponent();
        }
        void UpdateGridView()
        {
            PurchaseService PService = new PurchaseService();
            dataGridView1.DataSource = PService.GetAllPurchases();
        }

        private void PurchaseReportForm_Load(object sender, EventArgs e)
        {
            
            PurchaseService PService = new PurchaseService();
            dataGridView1.DataSource = PService.GetAllPurchases();

            CategoryService catService = new CategoryService();
            var list = catService.GetAllCategories();
            List<string> categoryNames = new List<string>();
            List<int> cid = new List<int>();
            foreach (var item in list)
            {
                categoryNames.Add(item.Category_Name);
                cid.Add(item.Id);
                
            }
            comboBox1.DataSource = cid;

            Sum();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PurchaseService PService = new PurchaseService();
            List<Purchase> list = new List<Purchase>();

            Purchase p = new Purchase();
            p = PService.GetByName(textBox1.Text);

            if (p != null)
            {
                list.Add(p);
                dataGridView1.DataSource = list;
                Sum();
            }
            else
            { MessageBox.Show("data not found"); }

        }

        private void b_Total_Click(object sender, EventArgs e)
        {
            

            PurchaseService PService = new PurchaseService();
            dataGridView1.DataSource = PService.GetById(comboBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            Sum();

        }


        void Sum()
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            PAmount.Text = sum.ToString();
            
        }


    }
}
