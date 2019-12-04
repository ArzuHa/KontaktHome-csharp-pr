namespace KontaktHome.Admin
{
    partial class CatgoryAddForm
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
            this.textBoxNameCat = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createUserIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new KontaktHome.Data.DataSet();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.categoriesTableAdapter = new KontaktHome.Data.DataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNameCat
            // 
            this.textBoxNameCat.Location = new System.Drawing.Point(118, 62);
            this.textBoxNameCat.Name = "textBoxNameCat";
            this.textBoxNameCat.Size = new System.Drawing.Size(120, 20);
            this.textBoxNameCat.TabIndex = 0;
            this.textBoxNameCat.TextChanged += new System.EventHandler(this.textBoxNameCat_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(348, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 58);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.Red;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.createUserIdDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.deleteDateDataGridViewTextBoxColumn});
            this.dgvCategory.DataSource = this.categoriesBindingSource;
            this.dgvCategory.Location = new System.Drawing.Point(34, 125);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(240, 150);
            this.dgvCategory.TabIndex = 2;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            this.dgvCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellDoubleClick);
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
            // createUserIdDataGridViewTextBoxColumn
            // 
            this.createUserIdDataGridViewTextBoxColumn.DataPropertyName = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.HeaderText = "CreateUserId";
            this.createUserIdDataGridViewTextBoxColumn.Name = "createUserIdDataGridViewTextBoxColumn";
            this.createUserIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deleteDateDataGridViewTextBoxColumn
            // 
            this.deleteDateDataGridViewTextBoxColumn.DataPropertyName = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.HeaderText = "DeleteDate";
            this.deleteDateDataGridViewTextBoxColumn.Name = "deleteDateDataGridViewTextBoxColumn";
            this.deleteDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(441, 42);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 58);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(533, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 58);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 58);
            this.button3.TabIndex = 5;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(627, 42);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(95, 58);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // CatgoryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxNameCat);
            this.Name = "CatgoryAddForm";
            this.Text = "CatgoryAddForm";
            this.Load += new System.EventHandler(this.CatgoryAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameCat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Data.DataSet dataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private Data.DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createUserIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deleteDateDataGridViewTextBoxColumn;
    }
}