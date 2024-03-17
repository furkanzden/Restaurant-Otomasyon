using FurkanOzden_221103052.Class;
using FurkanOzden_221103052.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FurkanOzden_221103052.Class.AlertShowing;
using static FurkanOzden_221103052.Class.BackGroundBlur;

namespace FurkanOzden_221103052.Models
{
    public partial class FormProductAdd : SampleAdd
    {
        AlertShowing AS = new AlertShowing();
        DatabaseModel db = new DatabaseModel();
        public FormProductAdd()
        {
            InitializeComponent();
        }
        public int ID = 0;

        public string saveImage()
        {
            string resim = "";
            if (pictureBox1.Image != null)
            {
                string resimlerKlasoru = Path.Combine(Application.StartupPath, "resimler");

                if (!Directory.Exists(resimlerKlasoru))
                {
                    Directory.CreateDirectory(resimlerKlasoru);
                }

                resim = Guid.NewGuid().ToString() + ".png";
                string kaydedilecekDosyaAdi = Path.Combine(resimlerKlasoru, resim);

                pictureBox1.Image.Save(kaydedilecekDosyaAdi);

                

            }
            return resim;
        }
        public override void btnSave_Click(object sender, EventArgs e)
        {
            
                if (textBoxAd.Text != string.Empty && textBoxFiyat.Text != string.Empty && textBoxResim.Text != string.Empty && comboBoxKategori.SelectedValue != "0")
            {
                if (ID == 0)
                {
                    try
                    {
                        Urunler kt = new Urunler();
                        kt.Ad = textBoxAd.Text;
                        kt.Fiyat = Convert.ToDecimal(textBoxFiyat.Text);
                        kt.KategoriID = Convert.ToInt32(comboBoxKategori.SelectedValue.ToString());
                        kt.Resim = saveImage();
                        db.Urunler.Add(kt);
                        db.SaveChanges();

                        textBoxAd.Text = "";
                        textBoxFiyat.Text = "";
                        textBoxResim.Text = "";
                        comboBoxKategori.SelectedValue = 0;

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
                        var Update = db.Urunler.FirstOrDefault(u => u.ID == ID);
                        if (Update != null)
                        {
                            try
                            {
                                Update.Ad = textBoxAd.Text;
                                Update.Fiyat = Convert.ToDecimal(textBoxFiyat.Text);
                                Update.KategoriID = Convert.ToInt32(comboBoxKategori.SelectedValue.ToString());
                                if (Update.Resim != textBoxResim.Text)
                                {
                                    Update.Resim = saveImage();
                                }
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
            var KategorilerList = db.Kategoriler.ToList();
            KategorilerList.Insert(0, new Kategoriler { ID = 0, Ad = "Kategori seçin" });
            comboBoxKategori.DataSource = KategorilerList;
            comboBoxKategori.DisplayMember = "Ad";
            comboBoxKategori.ValueMember = "ID";


            if (ID != 0)
            {
                var data = db.Urunler.FirstOrDefault(k => k.ID == ID);
                textBoxAd.Text = data.Ad;
                textBoxFiyat.Text = data.Fiyat.ToString();
                textBoxResim.Text = data.Resim;
                comboBoxKategori.SelectedValue = data.KategoriID;
                try
                {
                    pictureBox1.Image = new Bitmap(".\\resimler\\" + data.Resim);
                }
                catch (Exception)
                {
                    AS.ShowAlert(MessageType.Warning, "HATA :(", "Resim dosyası bulunamadı lütfen yeni resim seçin!");
                }
                
            }
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg;";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                textBoxResim.Text = dosya.FileName;
                pictureBox1.Image = new Bitmap(dosya.FileName);
            }
            
        }

        private void textBoxFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

    
}
