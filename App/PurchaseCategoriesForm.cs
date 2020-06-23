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
    public partial class PurchaseCategoriesForm : Form
    {
        int id;
        public PurchaseCategoriesForm()
        {
            InitializeComponent();
        }

        void UpdateGridView()
        {
            CategoryService catService = new CategoryService();
            dataGridView1.DataSource = catService.GetAllCategories();
        }
        private void PurchaseCategoriesForm_Load(object sender, EventArgs e)
        {
            CategoryService catService = new CategoryService();
            dataGridView1.DataSource = catService.GetAllCategories();

        }


        

      

        private void padd_Click(object sender, EventArgs e)
        {
             CategoryService catService = new CategoryService();
             int result = catService.Insert(new Category() { Category_Name = textBox1.Text });
            if (result > 0)
            {
                MessageBox.Show("Category added.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void pupdate_Click(object sender, EventArgs e)
        {
             CategoryService catService = new CategoryService();
            Category category = catService.GetById(id);
            category.Id = id;
            category.Category_Name = textBox1.Text;
            int result = catService.Update(category);
            if (result > 0)
            {
                MessageBox.Show("Category updated.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

       
    }
}
