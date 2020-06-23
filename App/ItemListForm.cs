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
    public partial class ItemListForm : Form
    {
        int id;
        public ItemListForm()
        {
            InitializeComponent();
        }

        void UpdateGridView()
        {
            ItemListService itemListService = new ItemListService();
            dataGridView1.DataSource = itemListService.GetAll();
        }

        private void ItemListForm_Load(object sender, EventArgs e)
        {
            ItemListService itemListService = new ItemListService();
            dataGridView1.DataSource = itemListService.GetAll();

            CategoryListService catListService = new CategoryListService();
            var list = catListService.GetAll();
            List<string> categoryNames = new List<string>();
            foreach (var item in list)
            {
                categoryNames.Add(item.CategoryName);
            }
            comboBox1.DataSource = categoryNames;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            t_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            t_Price.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            t_Description.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_Name.Text == string.Empty || t_Price.Text == string.Empty || comboBox1.SelectedItem.ToString()==string.Empty)
            {
                MessageBox.Show("Please Enter Values");
            }
            else
            {
            ItemListService itemListService = new ItemListService();
            Item item = itemListService.GetById(id);
            item.Id = id;
            item.ItemName = t_Name.Text;
            item.ItemPrice = Convert.ToSingle(t_Price.Text);
            item.ItemDescription = t_Description.Text;
            item.Category_Name = comboBox1.SelectedItem.ToString();
            int result = itemListService.Update(item);
            if (result > 0)
            {
                MessageBox.Show("Item Updated.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ItemListService itemListService = new ItemListService();

            int result = itemListService.Delete(id);
            if (result > 0)
            {
                MessageBox.Show("Item deleted.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
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
