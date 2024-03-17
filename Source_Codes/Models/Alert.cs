using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanOzden_221103052
{
    public partial class Alert : Form
    {
        public Alert(string type, string header, string text)
        {
            
            InitializeComponent();
            customizeAlert(type, header, text);
        }

        public void customizeAlert(string type, string headerText, string alertText)
        {
            
            var color = Color.FromArgb(255, 128, 0);

            switch (type.ToLower())
            {
                case "success":
                    color = Color.Green;
                    break;
                case "warning":
                    color = Color.FromArgb(219, 175, 0);
                    break;
                case "danger":
                    color = Color.DarkRed;
                    break;
                default:
                    color = Color.FromArgb(255, 128, 0);
                    break;

            }

            header.Text = headerText;
            text.Text = alertText;
            head.BackColor = color;
            
            
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
