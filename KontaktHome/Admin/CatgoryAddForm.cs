using KontaktHome.Core.Exstensions;
using KontaktHome.Data.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KontaktHome.Data.DataSet;

namespace KontaktHome.Admin
{
    public partial class CatgoryAddForm : Form
    {
        public CatgoryAddForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameCat.Text))
            {
                errorProvider1.SetError(textBoxNameCat,"Bos olmaz");
                return;
            }

            categoriesTableAdapter.AddCategory(textBoxNameCat.Text,Program.UserId);

            categoriesTableAdapter.Fill(this.dataSet.Categories);
            
        }

        private void CatgoryAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dataSet.Categories);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            var current = categoriesBindingSource.GetCurrentRow<CategoriesRow>();
            if (current == null) return;
            categoriesTableAdapter.DeleteCategory(current.Id);
            this.categoriesTableAdapter.Fill(this.dataSet.Categories);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            categoriesTableAdapter.SearchCategory(dataSet.Categories,textBoxNameCat.Text);
           
        }

        private void dgvCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = categoriesBindingSource.GetCurrentRow<CategoriesRow>();
            if (current == null) return;
           
            textBoxNameCat.Text = current.Name;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var current = categoriesBindingSource.GetCurrentRow<CategoriesRow>();
            categoriesTableAdapter.EditCategory(textBoxNameCat.Text,current.Id);
            
            this.categoriesTableAdapter.Fill(this.dataSet.Categories);
        }

        private void textBoxNameCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
