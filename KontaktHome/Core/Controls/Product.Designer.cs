namespace KontaktHome.Core.Controls
{
    partial class Product
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNameProduct = new System.Windows.Forms.Label();
            this.labelNamePrice = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameProduct
            // 
            this.labelNameProduct.ForeColor = System.Drawing.Color.Blue;
            this.labelNameProduct.Location = new System.Drawing.Point(3, 144);
            this.labelNameProduct.Name = "labelNameProduct";
            this.labelNameProduct.Size = new System.Drawing.Size(191, 35);
            this.labelNameProduct.TabIndex = 1;
            this.labelNameProduct.Text = "label1";
            this.labelNameProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNameProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNamePrice
            // 
            this.labelNamePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNamePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNamePrice.ForeColor = System.Drawing.Color.Red;
            this.labelNamePrice.Location = new System.Drawing.Point(3, 179);
            this.labelNamePrice.Name = "labelNamePrice";
            this.labelNamePrice.Size = new System.Drawing.Size(79, 44);
            this.labelNamePrice.TabIndex = 2;
            this.labelNamePrice.Text = "200₼";
            this.labelNamePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(88, 179);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(103, 44);
            this.btnPay.TabIndex = 3;
            this.btnPay.Text = "Sifaris Et";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxProduct.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(188, 138);
            this.pictureBoxProduct.TabIndex = 0;
            this.pictureBoxProduct.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.labelNamePrice);
            this.Controls.Add(this.labelNameProduct);
            this.Controls.Add(this.pictureBoxProduct);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(194, 234);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.Label labelNameProduct;
        private System.Windows.Forms.Label labelNamePrice;
        private System.Windows.Forms.Button btnPay;
    }
}
