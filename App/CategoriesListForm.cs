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
    public partial class CategoriesListForm : Form
    {
        int id;
        public CategoriesListForm()
        {
            InitializeComponent();
        }
        void UpdateGridView()
        {
            CategoryListService catListService = new CategoryListService();
            dataGridView1.DataSource = catListService.GetAll();
        }

        private void CategoriesListForm_Load(object sender, EventArgs e)
        {
            CategoryListService catListService = new CategoryListService();
            dataGridView1.DataSource = catListService.GetAll();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            t_CatName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void b_search_Click(object sender, EventArgs e)
        {
            CategoryListService catListService = new CategoryListService();
            List<CategoryList> list = new List<CategoryList>();
            list.Add(catListService.GetByName(t_CatName.Text));
            dataGridView1.DataSource = list;
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            CategoryListService catListService = new CategoryListService();
            int result = catListService.Insert(new CategoryList() { CategoryName = t_CatName.Text });
            if (result > 0)
            {
                MessageBox.Show("Category Added.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void b_update_Click(object sender, EventArgs e)
        {
            CategoryListService catListService = new CategoryListService();
            CategoryList category = catListService.GetById(id);
            category.Id = id;
            category.CategoryName = t_CatName.Text;
            int result = catListService.Update(category);
            if (result > 0)
            {
                MessageBox.Show("Category Updated.");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void t_CatName_ONLY_CHAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
