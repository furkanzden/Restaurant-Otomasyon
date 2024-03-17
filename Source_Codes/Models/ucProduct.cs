using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanOzden_221103052.Models
{
    public partial class ucProduct : UserControl
    {
        public ucProduct()
        {
            InitializeComponent();
        }

        public event EventHandler OnSelect = null;

        public int ID { get; set; }
        public decimal pPrice { get; set; }
        public string pName
        {
            get { return labelProductName.Text; }
            set { labelProductName.Text = value; }
        }
        public string pCategory { get; set; }
        public Image pImage
        {
            get { return productImage.Image; }
            set { productImage.Image = value; }
        }

       

        private void productImage_Click_1(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }

        private void gunaShadowPanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelProductName_Click(object sender, EventArgs e)
        {
            OnSelect?.Invoke(this, e);
        }
    }
}
