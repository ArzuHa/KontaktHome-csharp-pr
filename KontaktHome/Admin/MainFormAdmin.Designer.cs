namespace KontaktHome.Admin
{
    partial class MainFormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new KontaktHome.Data.DataSet();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBrand = new System.Windows.Forms.Button();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddModel = new System.Windows.Forms.Button();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.categoriesTableAdapter = new KontaktHome.Data.DataSetTableAdapters.CategoriesTableAdapter();
            this.brandsTableAdapter = new KontaktHome.Data.DataSetTableAdapters.BrandsTableAdapter();
            this.modelsTableAdapter = new KontaktHome.Data.DataSetTableAdapters.ModelsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.productsTableAdapter = new KontaktHome.Data.DataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.categoriesBindingSource;
            this.comboBoxCategory.DisplayMember = "Name";
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(6, 16);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(95, 21);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.ValueMember = "Id";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(13, 22);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownPrice.TabIndex = 3;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(651, 32);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(75, 23);
            this.btnAddPicture.TabIndex = 5;
            this.btnAddPicture.Text = "SetImage";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(713, 91);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Yadda Saxla";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.btnAddCategory);
            this.groupBox.Controls.Add(this.comboBoxCategory);
            this.groupBox.Location = new System.Drawing.Point(12, 67);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(137, 47);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Category";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(104, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(27, 27);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBrand);
            this.groupBox2.Controls.Add(this.comboBoxBrand);
            this.groupBox2.Location = new System.Drawing.Point(14, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 50);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brand";
            // 
            // btnAddBrand
            // 
            this.btnAddBrand.Location = new System.Drawing.Point(102, 15);
            this.btnAddBrand.Name = "btnAddBrand";
            this.btnAddBrand.Size = new System.Drawing.Size(27, 27);
            this.btnAddBrand.TabIndex = 12;
            this.btnAddBrand.Text = "+";
            this.btnAddBrand.UseVisualStyleBackColor = true;
            this.btnAddBrand.Click += new System.EventHandler(this.btnAddBrand_Click);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DataSource = this.brandsBindingSource;
            this.comboBoxBrand.DisplayMember = "Name";
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(6, 19);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(93, 21);
            this.comboBoxBrand.TabIndex = 11;
            this.comboBoxBrand.ValueMember = "Id";
            this.comboBoxBrand.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.dataSet;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddModel);
            this.groupBox3.Controls.Add(this.comboBoxModel);
            this.groupBox3.Location = new System.Drawing.Point(180, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 50);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model";
            // 
            // btnAddModel
            // 
            this.btnAddModel.Location = new System.Drawing.Point(105, 19);
            this.btnAddModel.Name = "btnAddModel";
            this.btnAddModel.Size = new System.Drawing.Size(26, 23);
            this.btnAddModel.TabIndex = 11;
            this.btnAddModel.Text = "+";
            this.btnAddModel.UseVisualStyleBackColor = true;
            this.btnAddModel.Click += new System.EventHandler(this.btnAddModel_Click);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DataSource = this.modelsBindingSource;
            this.comboBoxModel.DisplayMember = "Name";
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(6, 19);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(95, 21);
            this.comboBoxModel.TabIndex = 0;
            this.comboBoxModel.ValueMember = "Id";
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            this.comboBoxModel.SelectedValueChanged += new System.EventHandler(this.comboBoxModel_SelectedValueChanged);
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.dataSet;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownPrice);
            this.groupBox4.Location = new System.Drawing.Point(355, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(103, 60);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(473, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryNameDataGridViewTextBoxColumn,
            this.brandNameDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.imageNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.brandIdDataGridViewTextBoxColumn,
            this.modelIdDataGridViewTextBoxColumn,
            this.fileIdDataGridViewTextBoxColumn,
            this.createUserIdDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.deleteDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 229);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // imageNameDataGridViewTextBoxColumn
            // 
            this.imageNameDataGridViewTextBoxColumn.DataPropertyName = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.HeaderText = "ImageName";
            this.imageNameDataGridViewTextBoxColumn.Name = "imageNameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            this.brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            this.brandIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelIdDataGridViewTextBoxColumn
            // 
            this.modelIdDataGridViewTextBoxColumn.DataPropertyName = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.HeaderText = "ModelId";
            this.modelIdDataGridViewTextBoxColumn.Name = "modelIdDataGridViewTextBoxColumn";
            this.modelIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileIdDataGridViewTextBoxColumn
            // 
            this.fileIdDataGridViewTextBoxColumn.DataPropertyName = "FileId";
            this.fileIdDataGridViewTextBoxColumn.HeaderText = "FileId";
            this.fileIdDataGridViewTextBoxColumn.Name = "fileIdDataGridViewTextBoxColumn";
            this.fileIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createUserIdDataGridViewTextBoxColumn
            // 
            this.createUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.HeaderText = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.Name = "createUserIdDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // deleteDateDataGridViewTextBoxColumn
            // 
            this.deleteDateDataGridViewTextBoxColumn.DataPropertyName = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.HeaderText = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.Name = "deleteDateDataGridViewTextBoxColumn";
            this.deleteDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dataSet;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // MainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddPicture);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainFormAdmin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainFormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnAddBrand;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private Data.DataSet dataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Data.DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private Data.DataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private Data.DataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.Button btnAddModel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Data.DataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteDateDataGridViewTextBoxColumn;
    }
}