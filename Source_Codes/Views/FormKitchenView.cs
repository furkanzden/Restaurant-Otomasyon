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

namespace FurkanOzden_221103052.Views
{
    public partial class FormKitchenView : Form
    {
        public FormKitchenView()
        {
            InitializeComponent();
        }
        DatabaseModel db = new DatabaseModel();
        AlertShowing AS = new AlertShowing();
        private void FormKitchenView_Load(object sender, EventArgs e)
        {
            loadOrders();
        }
        private void loadOrders()
        {
            flowLayoutPanel1.Controls.Clear();

            var orders = db.Siparisler.Where(s => s.Durum == 1)
                .ToList();

            FlowLayoutPanel p1;

            for (int i = 0; i < orders.Count; i++)
            {
                p1 = new FlowLayoutPanel();
                p1.AutoSize = true;
                p1.Width = 230;
                p1.Height = 350;
                
                p1.FlowDirection = FlowDirection.TopDown;
                p1.BorderStyle = BorderStyle.FixedSingle;
                p1.Margin = new Padding(10, 10, 10, 10);

                FlowLayoutPanel p2 = new FlowLayoutPanel();
                p2.BackColor = Color.FromArgb(255,128,0);
                p2.AutoSize = true;
                p2.Width = 230;
                p2.Height = 125;
                p2.FlowDirection = FlowDirection.TopDown;
                p2.Margin = new Padding(0,0,0,0);

                Label lb1 = new Label();
                lb1.ForeColor = Color.White;
                lb1.Margin = new Padding(10, 10, 3, 0);
                lb1.AutoSize = true;

                Label lb2 = new Label();
                lb2.ForeColor = Color.White;
                lb2.Margin = new Padding(10, 5, 3, 0);
                lb2.AutoSize = true;

                Label lb3 = new Label();
                lb3.ForeColor = Color.White;
                lb3.Margin = new Padding(10, 5, 3, 0);
                lb3.AutoSize = true;

                Label lb4 = new Label();
                lb4.ForeColor = Color.White;
                lb4.Margin = new Padding(10, 5, 3, 0);
                lb4.AutoSize = true;

                lb1.Text = "Masa: " + orders[i].MasaAd;
                lb2.Text = "Garson: " + orders[i].GarsonAd;
                lb3.Text = "Sipariş Saati: " + orders[i].Saat;
                lb4.Text = "Sipariş Türü: " + orders[i].Tur;

                p2.Controls.Add(lb1);
                p2.Controls.Add(lb2);
                p2.Controls.Add(lb3);
                p2.Controls.Add(lb4);

                p1.Controls.Add(p2);

                int mID = 0;
                mID = Convert.ToInt32(orders[i].ID);

                var detaylar = db.Detaylar.Where(d => d.SipID == mID)
                .Join(db.Siparisler, detay => detay.SipID, siparis => siparis.ID, (detay, siparis) => new
                {
                    UrunID = detay.UrID,
                    Adet = detay.Adet
                })
                .Join(db.Urunler, combined => combined.UrunID, urun => urun.ID, (combined, urun) => new
                {
                    UrunAdi = urun.Ad,
                    Adet = combined.Adet,
                }).ToList();

                for (int j = 0; j < detaylar.Count; j++)
                {
                    Label lb5 = new Label();
                    lb5.ForeColor = Color.Black;
                    lb5.Margin = new Padding(10, 5, 3, 0);
                    lb5.AutoSize = true;

                    int no = j + 1;

                    lb5.Text = "- " + detaylar[j].UrunAdi + " " + detaylar[j].Adet;

                    p1.Controls.Add(lb5);
                }

                Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                b.BaseColor = Color.FromArgb(255, 128, 0);
                b.OnHoverBaseColor = Color.FromArgb(192, 64, 0);
                b.Radius = 19;
                b.Size = new Size(100,35);
                b.Text = "Tamamlandı";
                b.Tag = orders[i].ID;
                b.TextAlign = HorizontalAlignment.Center;
                b.Image = null;

                b.Click += new EventHandler(b_Click);

                p1.Controls.Add(b);




                flowLayoutPanel1.Controls.Add(p1);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32((sender as Guna.UI.WinForms.GunaButton).Tag);

            if (AS.ShowDialogAlert("İşlemi onaylıyor musun?") == DialogResult.Yes)
            {
                var Update = db.Siparisler.FirstOrDefault(u => u.ID == ID);
                if (Update != null)
                {
                    Update.Durum = 2;
                    db.SaveChanges();

                    AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Sipariş başarıyla güncellendi.");
                    loadOrders();
                }
            }


        }
    }
}
