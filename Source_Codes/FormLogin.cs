using FurkanOzden_221103052.Class;
using FurkanOzden_221103052.DAL;
using FurkanOzden_221103052.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanOzden_221103052
{
    
    public partial class FormLogin : Form
    {
        LoginValidation LV = new LoginValidation();
        DatabaseModel db = new DatabaseModel();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = "Furkan";
            textBoxPassword.Text = "Furkan81";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool giris = false;
            if (!textBoxUsername.Text.Equals(string.Empty) && !textBoxPassword.Text.Equals(string.Empty))
            {
                giris = LV.girisDogrula(textBoxUsername.Text, textBoxPassword.Text);

                if (giris)
                {
                    var tGiris = db.Kadro.Where(x => x.KullaniciAdi == textBoxUsername.Text).ToList();

                    if (tGiris[0].IGiris == 1)
                    {
                        FormChangePw CPw = new FormChangePw();
                        CPw.ID = tGiris[0].ID;
                        BackGroundBlur.BlurBackground(CPw);
                    }

                    message.ForeColor = Color.Green;
                    message.Text = "Giriş başarılı.";
                    this.Hide();
                    FormMain frmMain = new FormMain();
                    frmMain.Show();
                }
                else
                {
                    message.ForeColor = Color.Red;
                    message.Text = "Bilgileriniz yanlış! Lütfen kontrol edin";
                }

            }
            else
            {
                message.ForeColor = Color.Red;
                message.Text = "Lütfen boş alan bırakmayın.";
            }
            
            

        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
