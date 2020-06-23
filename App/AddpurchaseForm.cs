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
    public partial class AddpurchaseForm : Form
    {
        public AddpurchaseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PriceBox.Text == string.Empty || QuantityBox.Text == string.Empty || dateTimePicker1.Text==string.Empty || comboBox1.Text == string.Empty)
            { MessageBox.Show("Please Fillup All The Text Fields"); }
            else
            {
                double tp = (Double.Parse(PriceBox.Text) * Convert.ToInt16(QuantityBox.Text));
                PurchaseService ps = new PurchaseService();
                int result = ps.Insert(new Purchase()
                {
                    Item_Name = NameBox.Text,
                    Quantity = Convert.ToInt16(QuantityBox.Text),
                    Price = Double.Parse(PriceBox.Text),
                    Date = Convert.ToDateTime(dateTimePicker1.Value),
                    Cat_Id = Convert.ToInt32(comboBox1.Text),
                    Total_price = tp
                });
                if (result > 0)
                {
                    InventoryService inservice = new InventoryService();
                    int insert = inservice.Insert(new Inventory() {
                        ProductName = NameBox.Text,
                        Quantity = Convert.ToSingle(QuantityBox.Text)
                    });
                    MessageBox.Show(" added.");

                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddpurchaseForm_Load(object sender, EventArgs e)
        {
            CategoryService catService = new CategoryService();
            var list = catService.GetAllCategories();
            List<int> categoryId = new List<int>();
            foreach (var item in list)
            {
                categoryId.Add(item.Id);
            }
            comboBox1.DataSource = categoryId;
        }
        

    }
}
                                                   