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
    public partial class ExpenseReportForm : Form
    {
        int id;
        public ExpenseReportForm()
        {
            InitializeComponent();
        }

        void UpdateGridView()
        {
            ExpenseReportService expService = new ExpenseReportService();
            dataGridView1.DataSource = expService.GetAllExpenses();
        }
        void Sum()
        {
            int sum = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                sum = sum + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            label5.Text = sum.ToString();
        }

        private void ExpenseReportForm_Load(object sender, EventArgs e)
        {
            ExpenseReportService expService = new ExpenseReportService();
            dataGridView1.DataSource = expService.GetAllExpenses();
            Sum();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            t_ExpName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            t_ExpAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker_ExpDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
        }

        private void b_SearchItem_Click(object sender, EventArgs e)
        {
            ExpenseReportService expService = new ExpenseReportService();
            List<Expense> list = new List<Expense>();
            dataGridView1.DataSource = expService.GetAllItem(t_Search.Text);
            Sum();
            
        }

        private void b_Update_Click(object sender, EventArgs e)
        {
            if (t_ExpName.Text == string.Empty || t_ExpAmount.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Expense name and amount");
            }
            else
            {
                ExpenseReportService expService = new ExpenseReportService();
                Expense expense = expService.GetById(id);
                expense.Id = id;
                expense.ExpenseName = t_ExpName.Text;
                expense.ExpenseAmount = Convert.ToSingle(t_ExpAmount.Text);
                expense.ExpenseDate = dateTimePicker_ExpDate.Value;
                int result = expService.Update(expense);
                if (result > 0)
                {
                    MessageBox.Show("Expense Updated.");
                    UpdateGridView();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void b_SearchDate_Click(object sender, EventArgs e)
        {
            ExpenseReportService expService = new ExpenseReportService();
            List<Expense> list = new List<Expense>();
            dataGridView1.DataSource = expService.GetAllDate(dateTimePicker_From.Value, dateTimePicker_To.Value);
            Sum();
        }

        private void t_ExpName_ONLY_CHAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void t_ExpAmount_ONLY_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
