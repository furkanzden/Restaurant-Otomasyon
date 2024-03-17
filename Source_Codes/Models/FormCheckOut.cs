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

namespace FurkanOzden_221103052.Models
{
    public partial class FormCheckOut : Form
    {
        public FormCheckOut()
        {
            InitializeComponent();
        }
        public int FID = 0;
        DatabaseModel db = new DatabaseModel();
        AlertShowing AS = new AlertShowing();
        private void FormCheckOut_Load(object sender, EventArgs e)
        {
            labelTarih.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            loadData();
        }

        private void dataGridListe_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow item in dataGridListe.Rows)
            {
                count++;
                item.Cells[1].Value = count;
            }
        }
        private void loadData()
        {
            var detaylar = db.Detaylar.Where(d => d.SipID == FID)
                .Join(db.Siparisler, detay => detay.SipID, siparis => siparis.ID, (detay, siparis) => new
                {
                    DetayID = detay.ID,
                    UrunID = detay.UrID,
                    Toplam = siparis.Toplam,
                    Adet = detay.Adet
                })
                .Join(db.Urunler, combined => combined.UrunID, urun => urun.ID, (combined, urun) => new
                {
                    DetayID = combined.DetayID,
                    UrunID = combined.UrunID,
                    UrunAdi = urun.Ad,
                    Adet = combined.Adet,
                    Fiyat = urun.Fiyat,
                    Toplam = combined.Toplam

                }).ToList();

            dataGridListe.Rows.Clear();

            foreach (var item in detaylar)
            {
                dataGridListe.Rows.Add(item.DetayID, 0, item.UrunAdi, item.Adet, item.Toplam);
            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            var Update = db.Siparisler.FirstOrDefault(u => u.ID == FID);
            if (Update != null)
            {
                try
                {
                    Update.Durum = 3;
                    db.SaveChanges();

                    AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Ödeme alındı.");
                    FID = 0;
                    this.Close();
                }
                catch (Exception)
                {

                    AS.ShowAlert(MessageType.Warning, "HATA :(", "Beklenmedik bir hata oluştu!");
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            var Update = db.Siparisler.FirstOrDefault(u => u.ID == FID);
            if (Update != null)
            {
                try
                {
                    Update.Durum = 3;
                    db.SaveChanges();

                    AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Ödeme alındı.");
                    FID = 0;
                    this.Close();
                }
                catch (Exception)
                {

                    AS.ShowAlert(MessageType.Warning, "HATA :(", "Beklenmedik bir hata oluştu!");
                }
            }
        }
    }
}
