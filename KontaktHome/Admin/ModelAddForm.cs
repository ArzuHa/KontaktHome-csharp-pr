using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontaktHome.Admin
{
    public partial class ModelAddForm : Form
    {
        public ModelAddForm()
        {
            InitializeComponent();
        }

        private void ModelAddForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.dataSet2.Models);
            // TODO: This line of code loads data into the 'dataSet1.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.dataSet1.Brands);
            // TODO: This line of code loads data into the 'dataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.dataSet1.Categories);
            // TODO: This line of code loads data into the 'dataSet.Models' table. You can move, or remove it, as needed.
            this.modelsTableAdapter.Fill(this.dataSet.Models);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            modelsTableAdapter.AddModel(dataSet.Models,textBoxAddModel.Text,Convert.ToInt32(comboBoxCategori.SelectedValue),Convert.ToInt32(comboBoxBrand.SelectedValue),1);
            this.modelsTableAdapter.Fill(this.dataSet.Models);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            modelsTableAdapter.SearchModel(dataSet.Models,textBoxAddModel.Text,Convert.ToInt32(comboBoxBrand.SelectedValue),Convert.ToInt32(comboBoxCategori.SelectedValue));
        }
    }
}
