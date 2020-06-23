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
    public partial class InventoryForm : Form
    {
        int id;
        float quantity;
        public InventoryForm()
        {
            InitializeComponent();
        }

        void UpdateGridView()
        {
            InventoryService inventoryService = new InventoryService();
            dataGridView1.DataSource = inventoryService.GetAllProduct();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            InventoryService inventoryService = new InventoryService();
            dataGridView1.DataSource = inventoryService.GetAllProduct();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            quantity = float.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void b_Search_Click(object sender, EventArgs e)
        {
            InventoryService inventoryService = new InventoryService();
            List<Inventory> list = new List<Inventory>();
            dataGridView1.DataSource = inventoryService.GetAllItem(total.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InventoryService inventoryService = new InventoryService();
            Inventory inventory = inventoryService.GetById(id);
            inventory.Id = id;
            inventory.ProductName = textBox1.Text;
            if (quantity < Convert.ToSingle(textBox2.Text))
            {
                MessageBox.Show("Exceed Limit");
            }
            else
            {
                inventory.Quantity = quantity - Convert.ToSingle(textBox2.Text);


                int result = inventoryService.Update(inventory);
                if (result > 0)
                {
                    MessageBox.Show("Inventory Updated.");
                    UpdateGridView();
                    textBox1.Text = textBox2.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
