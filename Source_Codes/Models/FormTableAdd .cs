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
    public partial class FormTableAdd : SampleAdd
    {
        AlertShowing AS = new AlertShowing();
        DatabaseModel db = new DatabaseModel();
        public FormTableAdd()
        {
            InitializeComponent();
        }
        public int ID = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                try 
                {
                    Masalar kt = new Masalar();
                    kt.Ad = textBoxKategoriAd.Text;
                    db.Masalar.Add(kt);
                    db.SaveChanges();
                    textBoxKategoriAd.Text = "";

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
                    var KategoriUpdate = db.Masalar.FirstOrDefault(u => u.ID == ID);
                    if (KategoriUpdate != null)
                    {
                        try
                        {
                            KategoriUpdate.Ad = textBoxKategoriAd.Text;
                            db.SaveChanges();

                            AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Başarıyla kaydedildi.");
                            ID = 0;
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
    }
}
