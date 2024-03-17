using FurkanOzden_221103052.Class;
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
using static FurkanOzden_221103052.Class.AlertShowing;
using static FurkanOzden_221103052.Class.BackGroundBlur;

namespace FurkanOzden_221103052.Models
{
    public partial class FormStaffAdd : SampleAdd
    {
        AlertShowing AS = new AlertShowing();
        DatabaseModel db = new DatabaseModel();
        public FormStaffAdd()
        {
            InitializeComponent();
        }
        public int ID = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxKullaniciAdi.Text != string.Empty && textBoxAdSoyad.Text != string.Empty && textBoxParola.Text != string.Empty && textBoxTelefon.Text != string.Empty && comboBoxRol.SelectedValue != "0")
            {
                if (ID == 0)
                {
                    try
                    {
                        Kadro kt = new Kadro();
                        kt.KullaniciAdi = textBoxKullaniciAdi.Text;
                        kt.AdSoyad = textBoxAdSoyad.Text;
                        kt.Parola = textBoxParola.Text;
                        kt.Telefon = textBoxTelefon.Text;
                        kt.Rol = Convert.ToInt32(comboBoxRol.SelectedValue.ToString());
                        kt.IGiris = 1;
                        db.Kadro.Add(kt);
                        db.SaveChanges();
                        textBoxKullaniciAdi.Text = "";
                        textBoxAdSoyad.Text = "";
                        textBoxParola.Text = "";
                        textBoxTelefon.Text = "";
                        comboBoxRol.SelectedValue = 0;

                        AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Başarıyla kaydedildi.");
                    }
                    catch (Exception)
                    {

                        AS.ShowAlert(MessageType.Warning, "HATA :(", "Beklenmedik bir hata oluştu!");
                    }

                }
                else
                {
                    

                    DialogResult result = AS.ShowDialogAlert("Düzenleme işlemini onaylıyor musunuz?");
                    if (result == DialogResult.Yes)
                    {
                        var Update = db.Kadro.FirstOrDefault(u => u.ID == ID);
                        if (Update != null)
                        {
                            try
                            {
                                Update.KullaniciAdi = textBoxKullaniciAdi.Text;
                                Update.AdSoyad = textBoxAdSoyad.Text;
                                Update.Parola = textBoxParola.Text;
                                Update.Telefon = textBoxTelefon.Text;
                                Update.Rol = Convert.ToInt32(comboBoxRol.SelectedValue.ToString());
                                db.SaveChanges();

                                AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Başarıyla kaydedildi.");
                                ID = 0;
                                Close();
                            }
                            catch (Exception)
                            {
                                AS.ShowAlert(MessageType.Warning, "HATA :(", "Beklenmedik bir hata oluştu!");
                            }
                        }
                    }

                }
            }
            else
            {
                AS.ShowAlert(MessageType.Warning, "Dikkat", "Lütfen boş alan bırakmayın!");
            }
        }

        private void FormStaffAdd_Load(object sender, EventArgs e)
        {
            var Roller = db.Roller.ToList();
            Roller.Insert(0, new Roller { ID = 0, Ad = "Rol seçin" });
            comboBoxRol.DataSource = Roller;
            comboBoxRol.DisplayMember = "Ad";
            comboBoxRol.ValueMember = "ID";

            if (ID != 0)
            {
                var data = db.Kadro.FirstOrDefault(k => k.ID == ID);
                textBoxKullaniciAdi.Text = data.KullaniciAdi;
                textBoxAdSoyad.Text = data.AdSoyad;
                textBoxParola.Text = data.Parola;
                textBoxTelefon.Text = data.Telefon;
                comboBoxRol.SelectedValue = data.Rol;
            }
        }

        private void textBoxTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

    
}
