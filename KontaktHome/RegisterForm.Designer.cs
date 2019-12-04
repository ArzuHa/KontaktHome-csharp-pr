namespace KontaktHome
{
    partial class RegisterForm
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
            this.Login = new System.Windows.Forms.GroupBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCansel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.spCheckUserTableAdapter1 = new KontaktHome.Data.DataSetTableAdapters.spCheckUserTableAdapter();
            this.dataSet = new KontaktHome.Data.DataSet();
            this.Login.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Controls.Add(this.textBoxLogin);
            this.Login.Location = new System.Drawing.Point(53, 108);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(215, 56);
            this.Login.TabIndex = 0;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(6, 19);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(188, 20);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "admin@mail.ru";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Location = new System.Drawing.Point(53, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(6, 20);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(188, 20);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.Text = "1234";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Red;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.Location = new System.Drawing.Point(96, 255);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCansel
            // 
            this.btnCansel.BackColor = System.Drawing.Color.Red;
            this.btnCansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCansel.Location = new System.Drawing.Point(178, 255);
            this.btnCansel.Name = "btnCansel";
            this.btnCansel.Size = new System.Drawing.Size(69, 31);
            this.btnCansel.TabIndex = 3;
            this.btnCansel.Text = "Cansel";
            this.btnCansel.UseVisualStyleBackColor = false;
            this.btnCansel.Click += new System.EventHandler(this.btnCansel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::KontaktHome.Properties.Resources.kontakthomelogo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // spCheckUserTableAdapter1
            // 
            this.spCheckUserTableAdapter1.ClearBeforeFill = true;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(429, 306);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCansel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCansel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Data.DataSet dataSet;
        private Data.DataSetTableAdapters.spCheckUserTableAdapter spCheckUserTableAdapter1;
    }
}

