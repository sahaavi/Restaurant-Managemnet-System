using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace App
{
    public partial class AdminForm : Form
    {
        string username;
        public AdminForm(String name)
        {
            InitializeComponent();
            this.username = name;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            l_Name.Text = username;
            LoadData();
        }

        private void LoadData()
        {
            chart1.DataSource = GetData();
            chart1.Series["Series1"].XValueMember="Name";
            chart1.Series["Series1"].YValueMembers = "Total Sales Unit";
        }

        private DataTable GetData()
        {
            DataTable dtChartData = new DataTable();
            using (SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["RMS"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("popular_item", connect))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    connect.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    dtChartData.Load(reader ) ;
                }
            }
            
            return dtChartData;
        }
      


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm additem = new AddItemForm();
            additem.Show();
        }

        private void categoryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesListForm categorylist = new CategoriesListForm();
            categorylist.Show();
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

        private void addDiscountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDiscountForm adddiscount = new AddDiscountForm();
            adddiscount.Show();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosForm pos = new PosForm(username);
            pos.Show();
        }

        private void expenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseReportForm expensereport = new ExpenseReportForm();
            expensereport.Show();
        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryReportForm salaryreport = new SalaryReportForm();
            salaryreport.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReportForm salesreport = new SalesReportForm();
            salesreport.Show();
        }

        private void userRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserRegistrationForm registration = new UserRegistrationForm();
            registration.Show();
        }

        private void purchaseCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseCategoriesForm purchasecategory = new PurchaseCategoriesForm();
            purchasecategory.Show();
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExpenseForm addexpense = new AddExpenseForm();
            addexpense.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportForm purchasereport = new PurchaseReportForm();
            purchasereport.Show();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            Visible = false;
            login.Show();
        }

        private void employeeSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeSalaryForm empsal = new EmployeeSalaryForm();
            empsal.Show();
        }

        private void itemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemListForm itemlist = new ItemListForm();
            itemlist.Show();
        }

        
    }
}
