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
    public partial class StaffForm : Form
    {
        string username;
        public StaffForm(string name)
        {
            
            InitializeComponent();
            this.username = name;
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            l_Name.Text = username;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void pOSWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosForm pos = new PosForm(username);
            pos.Show();
            //Visible = false;
        }

        private void StaffForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCutomerForm addcustomer = new AddCutomerForm();
            addcustomer.Show();
        }

        private void customerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListForm customerlist = new CustomerListForm();
            customerlist.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReportForm salesreport = new SalesReportForm();
            salesreport.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.Show();
        }

        private void addPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddpurchaseForm addpurchase = new AddpurchaseForm();
            addpurchase.Show();
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExpenseForm addexpense = new AddExpenseForm();
            addexpense.Show();
        }

        private void expenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseReportForm expensereport = new ExpenseReportForm();
            expensereport.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            Visible = false;
            login.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportForm purchase = new PurchaseReportForm();
            purchase.Show();
        }
    }
}
