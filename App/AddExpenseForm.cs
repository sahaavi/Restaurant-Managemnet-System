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
    public partial class AddExpenseForm : Form
    {
        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void AddExpenseForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MMM-yyyy";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_ExpName.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Expense name");
            }
            else if (t_ExpAmount.Text == string.Empty)
            {
                MessageBox.Show("Please Enter Expense amount");
            }
            else
            {
                AddExpenseService expService = new AddExpenseService();
                int result = expService.Insert(new Expense() { ExpenseName = t_ExpName.Text, ExpenseAmount = float.Parse(t_ExpAmount.Text), ExpenseDate = dateTimePicker1.Value });
                if (result > 0)
                {
                    MessageBox.Show("Expense added.");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void t_ExpAmount_ONLY_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void t_ExpName_ONLY_CHAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
