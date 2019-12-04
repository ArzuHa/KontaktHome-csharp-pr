using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontaktHome.Core.Controls
{
    public partial class Product : UserControl
    {
        public Product()
        {
            InitializeComponent();
        }
        public int ProductId { get; set; }
        new public string ProductName 
        {
            get
            {
                return labelNameProduct.Text;
            }
            set
            {
                labelNameProduct.Text = value;
            }
        }
        decimal price;
        public decimal Price
        {
            set {
                price = value;
                labelNamePrice.Text = $"{value:0.00}₼";
            }
            get {
                return price;
            }
        }
        public Image Picture {

            get {
                return pictureBoxProduct.Image;            
            }
            set {
                pictureBoxProduct.Image = value;
            }
        }

       new public EventHandler Click;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (Click!=null)
            {
                Click.Invoke(this,e);
            }
        }
    }
}
