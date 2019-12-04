using KontaktHome.Core.Exstensions;
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
    public partial class BrandAddForm : Form
    {
        private object categoriesBindingSource;

        public BrandAddForm()
        {
            InitializeComponent();
        }

        private void BrandAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.dataSet.Brands);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            brandsTableAdapter.SearchBrand(dataSet.Brands,textBoxBrandAdd.Text);
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxBrandAdd.Text))
            {
                errorProvider1.SetError(textBoxBrandAdd,"Bos olmaz");
                return;
            }

            brandsTableAdapter.AddBrand(textBoxBrandAdd.Text, Program.UserId);

            brandsTableAdapter.Fill(this.dataSet.Brands);

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
             this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = brandsBindingSource.GetCurrentRow<BrandsRow>();
                   if (current == null) return;

             textBoxBrandAdd.Text = current.Name;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var current = brandsBindingSource.GetCurrentRow<BrandsRow>();
            if (current == null) return;
            brandsTableAdapter.EditBrand(textBoxBrandAdd.Text,current.Id);
            brandsTableAdapter.Fill(this.dataSet.Brands);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var current = brandsBindingSource.GetCurrentRow<BrandsRow>();
            if (current == null) return;
            brandsTableAdapter.DeleteBrand(dataSet.Brands,current.Id);
            brandsTableAdapter.Fill(this.dataSet.Brands);

        }
    }
}
