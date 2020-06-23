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
    public partial class AddItemForm : Form
    {
        //int id;
        string name;
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            CategoryListService catListService = new CategoryListService();
            var list = catListService.GetAll();
            List<string> categoryNames = new List<string>();
            foreach (var item in list)
            {
                categoryNames.Add(item.CategoryName);
            }
            c_Catagory.DataSource = categoryNames;
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            if (t_Name.Text == string.Empty || t_Price.Text == string.Empty || c_Catagory.SelectedItem.ToString() == string.Empty)
            {
                MessageBox.Show("Please enter values");
            }
            else
            {
                name = this.c_Catagory.SelectedItem.ToString();
                CategoryListService catListService = new CategoryListService();
                //id = catListService.GetIdByName(name);
                AddItemService addItemService = new AddItemService();
                int result = addItemService.Insert(new Item() { ItemName = t_Name.Text, ItemPrice = float.Parse(t_Price.Text), ItemDescription = t_Description.Text, Category_Name = name });
                if (result > 0)
                {
                    MessageBox.Show("Item added.");
                }
                else
                {
                    MessageBox.Show("Error");
                }
                t_Name.Text = t_Price.Text = t_Description.Text = string.Empty;
            }
        }

        private void t_Price_ONLY_NUMBER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
