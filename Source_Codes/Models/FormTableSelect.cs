using FurkanOzden_221103052.DAL;
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
    public partial class FormTableSelect : Form
    {
        DatabaseModel db = new DatabaseModel();
        public string TableName;
        public int TableID=0;
        public FormTableSelect()
        {
            InitializeComponent();
        }

        private void FormTableSelect_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var veri = db.Masalar.ToList();
            if (veri.Count > 0)
            {
                foreach (var item in veri)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.Text = item.Ad;
                    b.Tag = item.ID;
                    b.Width = 200;
                    b.Height = 60;
                    b.Image = null;
                    b.TextAlign = HorizontalAlignment.Center;
                    b.BaseColor = Color.FromArgb(222, 81, 38);
                    b.BorderColor = Color.FromArgb(222, 81, 38);
                    b.OnHoverBaseColor = Color.FromArgb(222, 81, 60);
                    b.OnHoverBorderColor = Color.FromArgb(222, 81, 60);

                    b.Click += new EventHandler(b_Click);

                    flowLayoutPanel1.Controls.Add(b);
                }
            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            TableName = (sender as Guna.UI.WinForms.GunaButton).Text.ToString();
            TableID = int.Parse((sender as Guna.UI.WinForms.GunaButton).Tag.ToString());
            this.Close();
        }
    }
}
