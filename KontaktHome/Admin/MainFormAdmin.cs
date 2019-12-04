using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KontaktHome.Core.Exstensions;
using KontaktHome.Data;
using KontaktHome.Data.DataSetTableAdapters;
using static KontaktHome.Data.DataSet;

namespace KontaktHome.Admin
{
    public partial class MainFormAdmin : Form
    {

        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = categoriesBindingSource.GetCurrentRow<CategoriesRow>();
            brandsTableAdapter.FillByCategoryId(dataSet.Brands,current.Id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var buff = Image.FromFile(openFileDialog1.FileName).GetBuffer();
            using (var adp= new CommonAdapter())
            {
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                adp.spAddImage(fileName,buff,1);
            }
                productsTableAdapter.AddProduct(dataSet.Products,Convert.ToInt32(comboBoxCategory.SelectedValue),Convert.ToInt32(comboBoxBrand.SelectedValue),Convert.ToInt32(comboBoxModel.SelectedValue),Convert.ToInt32(numericUpDownPrice.Value),1);
            this.productsTableAdapter.Fill(this.dataSet.Products);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var frm = new Admin.CatgoryAddForm())
            {
                var result = frm.ShowDialog();

                if (result==DialogResult.OK) {
                    this.categoriesTableAdapter.Fill(this.dataSet.Categories);

                }

            }
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataSet.Products);
            // TODO: This line of code loads data into the 'dataSet.Models' table. You can move, or remove it, as needed.
            //this.modelsTableAdapter.Fill(this.dataSet.Models);
            // TODO: This line of code loads data into the 'dataSet.Brands' table. You can move, or remove it, as needed.
            //this.brandsTableAdapter.Fill(this.dataSet.Brands);
            // TODO: This line of code loads data into the 'dataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dataSet.Categories);

        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            using (var frm = new Admin.BrandAddForm())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.brandsTableAdapter.Fill(this.dataSet.Brands);

                }

            }
        }

        private void Fill(Data.DataSet.CategoriesDataTable categories)
        {
            throw new NotImplementedException();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = categoriesBindingSource.GetCurrentRow<CategoriesRow>();
            brandsTableAdapter.FillByCategoryId(dataSet.Brands, current.Id);
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxModel_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? brandId = comboBoxBrand.SelectedValue == null ? (int?)null : Convert.ToInt32(comboBoxBrand.SelectedValue);
            int? Categoryid = comboBoxCategory.SelectedValue == null ? (int?)null : Convert.ToInt32(comboBoxCategory.SelectedValue);
            var current = brandsBindingSource.GetCurrentRow<BrandsRow>();
            modelsTableAdapter.FillByBrand(dataSet.Models, brandId, Categoryid);

        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
              

            }
            else
                pictureBox1.Image = null;
        }

        private void btnAddModel_Click(object sender, EventArgs e)
        {
            using (var frm = new Admin.ModelAddForm())
            {
                var result = frm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    this.modelsTableAdapter.Fill(this.dataSet.Models);

                }

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var current = productsBindingSource.GetCurrentRow<ProductsRow>();
            if (current != null)
            {
                using (var adp = new CommonAdapter())
                {
                    byte[] buffer = adp.fnGetImage(current.Id);
                    if (buffer ==null) 
                    {
                        pictureBox1.Image = null;
                        return;
                    }
                    var ms = new MemoryStream();
                    ms.Write(buffer,0,buffer.Length);
                    ms.Flush();
                    pictureBox1.Image = Image.FromStream(ms);
                
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }




    

       
    }


