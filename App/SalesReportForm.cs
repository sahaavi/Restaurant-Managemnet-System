using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;

namespace App
{
    public partial class SalesReportForm : Form
    {
        public SalesReportForm()
        {
            InitializeComponent();
        }

        void UpdateGridView()
        {
            SalesReportService salesService = new SalesReportService();
            dataGridView1.DataSource = salesService.GetAllSales();
        }

        void Sum()
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
            }
            label5.Text = sum.ToString();
        }

        private void SalesReportForm_Load(object sender, EventArgs e)
        {
            SalesReportService salesService = new SalesReportService();
            dataGridView1.DataSource = salesService.GetAllSales();
            Sum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesReportService salesService = new SalesReportService();
            List<Pos> list = new List<Pos>();
            dataGridView1.DataSource = salesService.GetAllItem(textBox1.Text);
            Sum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalesReportService salesService = new SalesReportService();
            List<Pos> list = new List<Pos>();
            dataGridView1.DataSource = salesService.GetAllDate(dateTimePicker1.Value, dateTimePicker2.Value);
            Sum();
        }
    }
}
