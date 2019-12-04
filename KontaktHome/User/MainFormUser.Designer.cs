namespace KontaktHome.User
{
    partial class MainFormUser
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnCategoryView = new System.Windows.Forms.Button();
            this.dataSet = new KontaktHome.Data.DataSet();
            this.categoriesTableAdapter = new KontaktHome.Data.DataSetTableAdapters.CategoriesTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitt = new System.Windows.Forms.Button();
            this.btnWriteUs = new System.Windows.Forms.Button();
            this.btnCareer = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.product1 = new KontaktHome.Core.Controls.Product();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(1, 228);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(165, 109);
            this.checkedListBox1.TabIndex = 1;
            // 
            // btnCategoryView
            // 
            this.btnCategoryView.BackColor = System.Drawing.Color.Red;
            this.btnCategoryView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCategoryView.Location = new System.Drawing.Point(44, 356);
            this.btnCategoryView.Name = "btnCategoryView";
            this.btnCategoryView.Size = new System.Drawing.Size(75, 23);
            this.btnCategoryView.TabIndex = 2;
            this.btnCategoryView.Text = "Goster";
            this.btnCategoryView.UseVisualStyleBackColor = false;
            this.btnCategoryView.Click += new System.EventHandler(this.btnCategoryView_Click_1);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 160);
            this.listBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.btnExitt);
            this.panel1.Controls.Add(this.btnWriteUs);
            this.panel1.Controls.Add(this.btnCareer);
            this.panel1.Controls.Add(this.btnInfo);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 55);
            this.panel1.TabIndex = 4;
            // 
            // btnExitt
            // 
            this.btnExitt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitt.Location = new System.Drawing.Point(712, 9);
            this.btnExitt.Name = "btnExitt";
            this.btnExitt.Size = new System.Drawing.Size(75, 23);
            this.btnExitt.TabIndex = 4;
            this.btnExitt.Text = "Cixis";
            this.btnExitt.UseVisualStyleBackColor = true;
            this.btnExitt.Click += new System.EventHandler(this.btnExitt_Click);
            // 
            // btnWriteUs
            // 
            this.btnWriteUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWriteUs.Location = new System.Drawing.Point(384, 9);
            this.btnWriteUs.Name = "btnWriteUs";
            this.btnWriteUs.Size = new System.Drawing.Size(75, 23);
            this.btnWriteUs.TabIndex = 3;
            this.btnWriteUs.Text = "Elaqe";
            this.btnWriteUs.UseVisualStyleBackColor = true;
            // 
            // btnCareer
            // 
            this.btnCareer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCareer.Location = new System.Drawing.Point(284, 9);
            this.btnCareer.Name = "btnCareer";
            this.btnCareer.Size = new System.Drawing.Size(75, 23);
            this.btnCareer.TabIndex = 2;
            this.btnCareer.Text = "Karyera";
            this.btnCareer.UseVisualStyleBackColor = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInfo.Location = new System.Drawing.Point(186, 9);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(75, 23);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Info";
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.product1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(172, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(616, 355);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // product1
            // 
            this.product1.Location = new System.Drawing.Point(3, 3);
            this.product1.Name = "product1";
            this.product1.Picture = null;
            this.product1.Price = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.product1.ProductId = 0;
            this.product1.Size = new System.Drawing.Size(194, 234);
            this.product1.TabIndex = 0;
            this.product1.Click += new System.EventHandler(this.product1_Click);
            // 
            // MainFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnCategoryView);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "MainFormUser";
            this.Text = "MainFormUser";
            this.Load += new System.EventHandler(this.MainFormUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnCategoryView;
        private Data.DataSet dataSet;
        private Data.DataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnWriteUs;
        private System.Windows.Forms.Button btnCareer;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnExitt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Core.Controls.Product product1;
    }
}