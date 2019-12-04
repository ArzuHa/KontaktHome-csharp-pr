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

namespace KontaktHome
{
    public partial class RegisterForm : Form
    {
        private Point mousedownpoint;

        public RegisterForm()
        {
            InitializeComponent();
            this.RoundControl(this.Width,this.Height,20,20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCansel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cixmaq istediyinizden eminsinizmi?","Sorgu",0,MessageBoxIcon.Question)==DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Point mousedownpoint = Point.Empty;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxLogin.Text)) {
                errorProvider1.SetError(textBoxLogin,"Login bos buraxila bilmez");
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                errorProvider1.SetError(textBoxPassword, "Password bos buraxila bilmez");
            }

            try
            {
                spCheckUserTableAdapter1.Fill(dataSet.spCheckUser,textBoxLogin.Text,textBoxPassword.Text);
                if (dataSet.spCheckUser.Count < 1)
                {
                    MessageBox.Show("Istifadeci tapilmadi", "Xeta", 0, MessageBoxIcon.Error);
                    return;
                }
                spCheckUserRow user = dataSet.spCheckUser.FirstOrDefault();
                switch (user.RoleId)
                {
                    case 1:
                        //admin
                        using (var frm=new Admin.MainFormAdmin())
                        {
                            frm.ShowDialog();
                        }
                        break;

                    case 2:
                        //user
                        using (var frm = new User.MainFormUser())
                        {
                            frm.ShowDialog();
                        }
                        break;
                    default:
                        MessageBox.Show("Daxil edilen istifadeci yoxdur", "Xeta", 0, MessageBoxIcon.Error);
                        break;
                }
                Program.UserId = user.Id; 
            }

            catch (System.Exception)
            {

                ////throw;
            }
        }

       
    }
}
