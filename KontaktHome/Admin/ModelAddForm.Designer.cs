namespace KontaktHome.Admin
{
    partial class ModelAddForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBoxAddModel = new System.Windows.Forms.TextBox();
            this.modelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new KontaktHome.Data.DataSet();
            this.modelsTableAdapter = new KontaktHome.Data.DataSetTableAdapters.ModelsTableAdapter();
            this.comboBoxCategori = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new KontaktHome.Data.DataSet();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.brandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new KontaktHome.Data.DataSetTableAdapters.CategoriesTableAdapter();
            this.brandsTableAdapter = new KontaktHome.Data.DataSetTableAdapters.BrandsTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter1 = new KontaktHome.Data.DataSetTableAdapters.CategoriesTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.brandsTableAdapter1 = new KontaktHome.Data.DataSetTableAdapters.BrandsTableAdapter();
            this.dataSet2 = new KontaktHome.Data.DataSet();
            this.modelsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(646, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 68);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(545, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 68);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(444, 47);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 68);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(346, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 68);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(245, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 68);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBoxAddModel
            // 
            this.textBoxAddModel.Location = new System.Drawing.Point(137, 56);
            this.textBoxAddModel.Name = "textBoxAddModel";
            this.textBoxAddModel.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddModel.TabIndex = 11;
            // 
            // modelsBindingSource
            // 
            this.modelsBindingSource.DataMember = "Models";
            this.modelsBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelsTableAdapter
            // 
            this.modelsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBoxCategori
            // 
            this.comboBoxCategori.DataSource = this.categoriesBindingSource;
            this.comboBoxCategori.DisplayMember = "Name";
            this.comboBoxCategori.FormattingEnabled = true;
            this.comboBoxCategori.Location = new System.Drawing.Point(3, 32);
            this.comboBoxCategori.Name = "comboBoxCategori";
            this.comboBoxCategori.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategori.TabIndex = 13;
            this.comboBoxCategori.ValueMember = "Id";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DataSource = this.brandsBindingSource;
            this.comboBoxBrand.DisplayMember = "Name";
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(3, 72);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBrand.TabIndex = 14;
            this.comboBoxBrand.ValueMember = "Id";
            // 
            // brandsBindingSource
            // 
            this.brandsBindingSource.DataMember = "Brands";
            this.brandsBindingSource.DataSource = this.dataSet1;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // brandsTableAdapter
            // 
            this.brandsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Categories";
            this.bindingSource1.DataSource = this.dataSet;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Brands";
            this.bindingSource2.DataSource = this.dataSet;
            // 
            // brandsTableAdapter1
            // 
            this.brandsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modelsBindingSource1
            // 
            this.modelsBindingSource1.DataMember = "Models";
            this.modelsBindingSource1.DataSource = this.dataSet2;
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
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.brandIdDataGridViewTextBoxColumn,
            this.categoryIdDataGridViewTextBoxColumn,
            this.createUserIdDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.deleteDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 192);
            this.dataGridView1.TabIndex = 15;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandNameDataGridViewTextBoxColumn
            // 
            this.brandNameDataGridViewTextBoxColumn.DataPropertyName = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.HeaderText = "BrandName";
            this.brandNameDataGridViewTextBoxColumn.Name = "brandNameDataGridViewTextBoxColumn";
            this.brandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandIdDataGridViewTextBoxColumn
            // 
            this.brandIdDataGridViewTextBoxColumn.DataPropertyName = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.HeaderText = "BrandId";
            this.brandIdDataGridViewTextBoxColumn.Name = "brandIdDataGridViewTextBoxColumn";
            this.brandIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // categoryIdDataGridViewTextBoxColumn
            // 
            this.categoryIdDataGridViewTextBoxColumn.DataPropertyName = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.HeaderText = "CategoryId";
            this.categoryIdDataGridViewTextBoxColumn.Name = "categoryIdDataGridViewTextBoxColumn";
            this.categoryIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createUserIdDataGridViewTextBoxColumn
            // 
            this.createUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.HeaderText = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.Name = "createUserIdDataGridViewTextBoxColumn";
            this.createUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createUserIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // deleteDateDataGridViewTextBoxColumn
            // 
            this.deleteDateDataGridViewTextBoxColumn.DataPropertyName = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.HeaderText = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.Name = "deleteDateDataGridViewTextBoxColumn";
            this.deleteDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // ModelAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.comboBoxCategori);
            this.Controls.Add(this.textBoxAddModel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Name = "ModelAddForm";
            this.Text = "ModelAddForm";
            this.Load += new System.EventHandler(this.ModelAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBoxAddModel;
        private Data.DataSet dataSet;
        private System.Windows.Forms.BindingSource modelsBindingSource;
        private Data.DataSetTableAdapters.ModelsTableAdapter modelsTableAdapter;
        private System.Windows.Forms.ComboBox comboBoxCategori;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Data.DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.BindingSource brandsBindingSource;
        private Data.DataSetTableAdapters.BrandsTableAdapter brandsTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Data.DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private Data.DataSetTableAdapters.BrandsTableAdapter brandsTableAdapter1;
        private Data.DataSet dataSet2;
        private System.Windows.Forms.BindingSource modelsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteDateDataGridViewTextBoxColumn;
    }
}