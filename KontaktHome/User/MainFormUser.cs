using KontaktHome.Core.Controls;
using KontaktHome.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontaktHome.User
{
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }

     

       
       

        private void MainFormUser_Load(object sender, EventArgs e)
        {
            Product product = new Product();
            
            flowLayoutPanel1.Controls.Add(product);
            
                 
            // TODO: This line of code loads data into the 'dataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dataSet.Categories);

        }

        private void btnCategoryView_Click_1(object sender, EventArgs e)
        {
            categoriesTableAdapter.Fill(dataSet.Categories);
            checkedListBox1.Items.Clear();
            foreach (var item in dataSet.Categories)
            {
                var category = new Category();
                category.Id = item.Id;
                category.Name = item.Name;
                checkedListBox1.Items.Add(category);
            }
        }

        private void btnExitt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void product1_Click(object sender, EventArgs e)
        {
            Product product = sender as Product;

            
        }
    }
}
