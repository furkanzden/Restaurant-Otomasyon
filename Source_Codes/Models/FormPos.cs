using FurkanOzden_221103052.Class;
using FurkanOzden_221103052.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FurkanOzden_221103052.Class.AlertShowing;

namespace FurkanOzden_221103052.Models
{
    
    public partial class FormPos : Form
    {
        DatabaseModel db = new DatabaseModel();
        AlertShowing AS = new AlertShowing();
        public FormPos()
        {
            InitializeComponent();
        }

        public int MainID = 0;
        public string OrderType;

        private void FormPos_Load(object sender, EventArgs e)
        {
            dataGridListe.BorderStyle = BorderStyle.FixedSingle;
            loadCategory();

            productPanel.Controls.Clear();
            loadProduct();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void loadCategory()
        {
            categoryPanel.Controls.Clear();

            var kategoriler = db.Kategoriler.ToList();
            kategoriler.Insert(0, new Kategoriler { ID = 0, Ad = "Tümü" });
            if (kategoriler.Count > 0)
            {
                foreach (var item in kategoriler)
                {
                    Guna.UI.WinForms.GunaButton b = new Guna.UI.WinForms.GunaButton();
                    b.BaseColor = Color.FromArgb(255, 128, 0);
                    b.OnHoverBaseColor = Color.FromArgb(192, 64, 0);
                    b.Size = new Size(210, 45);
                    b.Text = item.Ad;
                    b.Tag = (item.Ad == "Tümü") ? "" : item.Ad;
                    b.TextAlign = HorizontalAlignment.Center;
                    b.Image = null;

                    b.Click += new EventHandler(b_Click);

                    categoryPanel.Controls.Add(b);

                }
                
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaButton b = (Guna.UI.WinForms.GunaButton)sender;

            foreach (var item in productPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.pCategory.ToLower().Contains(b.Tag.ToString().Trim().ToLower());
            }

        }

        private void addItems(string ID, string pID, string name, string cat, string price, string pImage)
        {
            var w = new ucProduct()
            {
                pName = name,
                pPrice = decimal.Parse(price),
                pCategory = cat,
                pImage = new Bitmap(".\\resimler\\" + pImage),
                ID = Convert.ToInt32(pID)
            };

            productPanel.Controls.Add(w);
            w.OnSelect += (ss, ee) =>
            {
                var wdg = (ucProduct)ss;
                
                foreach (DataGridViewRow item in dataGridListe.Rows)
                {
                    if (Convert.ToInt32(item.Cells["pID"].Value) == wdg.ID)
                    {
                        item.Cells["Adet"].Value = int.Parse(item.Cells["Adet"].Value.ToString()) + 1;
                        item.Cells["Toplam"].Value = int.Parse(item.Cells["Adet"].Value.ToString()) *
                                                      decimal.Parse(item.Cells["Fiyat"].Value.ToString());
                        getTotal();
                        return;
                    }

                }
                dataGridListe.Rows.Add(new object[] { 0, 0, wdg.ID, wdg.pName, 1, wdg.pPrice, wdg.pPrice });
                getTotal();
            };



        }

        private void loadProduct()
        {
            var sonuclar = db.Urunler
                .Join(db.Kategoriler,
                      urun => urun.KategoriID,
                      kategori => kategori.ID,
                      (urun, kategori) => new { Urun = urun, Kategori = kategori })
                .ToList();

            foreach (var item in sonuclar)
            {
                var u = item.Urun;
                var k = item.Kategori;
                addItems("0", u.ID.ToString(), u.Ad, k.Ad, u.Fiyat.ToString(), u.Resim);
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in productPanel.Controls)
            {
                var pro = (ucProduct)item;
                pro.Visible = pro.pName.ToLower().Contains(search.Text.Trim().ToLower());
            }
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

        private void getTotal()
        {
            decimal tot = 0;
            labelTotalPrice.Text = "";

            foreach (DataGridViewRow item in dataGridListe.Rows)
            {
                tot += decimal.Parse(item.Cells["Toplam"].Value.ToString());
            }

            labelTotalPrice.Text = tot.ToString("N2"); ;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            labelMasa.Text = "";
            labelGarson.Text = "";
            labelTotalPrice.Text = "0.00";
            labelMasa.Visible = false;
            labelGarson.Visible = false;
            dataGridListe.Rows.Clear();
            MainID = 0;
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            labelMasa.Text = "";
            labelGarson.Text = "";
            labelMasa.Visible = false;
            labelGarson.Visible = false;
            OrderType = "Paket";
            btnKot.Enabled = true;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            labelMasa.Text = "";
            labelGarson.Text = "";
            labelMasa.Visible = false;
            labelGarson.Visible = false;
            OrderType = "Gel Al";
            btnKot.Enabled = true;
        }

        private void btnDin_Click(object sender, EventArgs e)
        {
            OrderType = "İçeride";
            FormTableSelect FtS = new FormTableSelect();
            BackGroundBlur.BlurBackground(FtS);
            if (FtS.TableName != "")
            {
                labelMasa.Text = (FtS.TableID != 0) ? FtS.TableName : "-";
                //labelMasa.Tag = (FtS.TableID != 0) ? FtS.TableID : 0;
                labelMasa.Visible = true;

            }
            else
            {
                labelMasa.Text = "";
            }

            FormWaiterSelect FwS = new FormWaiterSelect();
            BackGroundBlur.BlurBackground(FwS);
            if (FwS.WaiterName != "")
            {
                labelGarson.Text = (FwS.WaiterID != 0) ? FwS.WaiterName : "-";
                //labelGarson.Tag = (FwS.WaiterID != 0) ? FwS.WaiterID : 0;
                labelGarson.Visible = true;
            }
            else
            {
                labelGarson.Text = "";
            }

            btnKot.Enabled = true;
        }

        private void btnKot_Click(object sender, EventArgs e)
        {
            btnKot.Enabled=false;
            if (OrderType != null)
            {
                int detailID = 0;
                if (MainID == 0)
                {
                    Siparisler s = new Siparisler();
                    s.Tarih = DateTime.Now.Date.ToString();
                    s.Saat = DateTime.Now.ToShortTimeString().ToString();
                    s.MasaAd = labelMasa.Text.ToString();
                    s.GarsonAd = labelGarson.Text.ToString();
                    s.Durum = 1;
                    s.Tur = OrderType.ToString();
                    s.Toplam = Convert.ToDecimal(labelTotalPrice.Text);
                    s.Alınan = Convert.ToDecimal(0);
                    s.changed = Convert.ToDecimal(0);

                    db.Siparisler.Add(s);
                    db.SaveChanges();

                    MainID = s.ID;
                }
                else
                {
                    var Update = db.Siparisler.FirstOrDefault(u => u.ID == MainID);
                    if (Update != null)
                    {
                        Update.Durum = 1;
                        Update.Toplam = Convert.ToDecimal(labelTotalPrice.Text);
                        Update.Alınan = Convert.ToDecimal(0);
                        Update.changed = Convert.ToDecimal(0);
                        db.SaveChanges();
                    }
                }

                foreach (DataGridViewRow item in dataGridListe.Rows)
                {
                    detailID = Convert.ToInt32(item.Cells["ID"].Value);

                    if (detailID == 0)
                    {
                        Detaylar d = new Detaylar();
                        d.SipID = MainID;
                        d.UrID = Convert.ToInt32(item.Cells["pID"].Value);
                        d.Adet = Convert.ToInt32(item.Cells["Adet"].Value);
                        d.Fiyat = Convert.ToDecimal(item.Cells["Fiyat"].Value);
                        d.AraToplam = Convert.ToDecimal(item.Cells["Toplam"].Value);
                        db.Detaylar.Add(d);
                        db.SaveChanges();
                    }
                    else
                    {
                        var DUpdate = db.Detaylar.FirstOrDefault(u => u.ID == detailID);
                        if (DUpdate != null)
                        {
                            DUpdate.UrID = Convert.ToInt32(item.Cells["pID"].Value);
                            DUpdate.Adet = Convert.ToInt32(item.Cells["Adet"].Value);
                            DUpdate.Fiyat = Convert.ToDecimal(item.Cells["Fiyat"].Value);
                            DUpdate.AraToplam = Convert.ToDecimal(item.Cells["Toplam"].Value);
                            db.SaveChanges();
                        }
                    }

                    MainID = 0;


                }
                AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Yaptığınız işlemler başarıyla kaydedildi.");
                labelMasa.Text = "";
                labelGarson.Text = "";
                labelTotalPrice.Text = "0.00";
                labelMasa.Visible = false;
                labelGarson.Visible = false;
                dataGridListe.Rows.Clear();
                MainID = 0;
                detailID = 0;
            }
            else
            {
                AS.ShowAlert(MessageType.Warning, "İşlem Hatası!", "Mutfağa gönderme işleminden önce sipariş oluşturunuz.");
            }

        }
        public int Id=0;
        private void btnBill_Click(object sender, EventArgs e)
        {
            FormBillList FbL = new FormBillList();
            BackGroundBlur.BlurBackground(FbL);

            if (FbL.MainID > 0)
            {
                Id= FbL.MainID;
                loadEntries();
                //buttonOdemeAl.Visible = true;
            }
        }

        private void loadEntries()
        {
            var detaylar = db.Detaylar.Where(d => d.SipID == Id)
                .Join(db.Siparisler, detay => detay.SipID, siparis => siparis.ID, (detay, siparis) => new
                {
                    DetayID = detay.ID,
                    UrunID = detay.UrID,
                    Toplam= siparis.Toplam,
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
                dataGridListe.Rows.Add(item.DetayID, 0, item.UrunID, item.UrunAdi, item.Adet, item.Fiyat, item.Toplam);
            }

            getTotal();
        }

        private void buttonOdemeAl_Click(object sender, EventArgs e)
        {
            //MainID = 0;
            //FormCheckOut FcO = new FormCheckOut();
            //FcO.FID = Id;
            //BackGroundBlur.BlurBackground(FcO);
        }
    }
}
