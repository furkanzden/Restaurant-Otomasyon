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
    public partial class FormRoleAdd : SampleAdd
    {
        AlertShowing AS = new AlertShowing();
        DatabaseModel db = new DatabaseModel();
        public FormRoleAdd()
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
                    Roller r = new Roller();
                    r.Ad = textBoxRolAd.Text;
                    r.Kategori = (checkBoxKategori.Checked) ? 1 : 0;
                    r.Masa = (checkBoxMasa.Checked) ? 1 : 0;
                    r.Urun = (checkBoxUrun.Checked) ? 1 : 0;
                    r.Mutfak = (checkBoxMutfak.Checked) ? 1 : 0;
                    r.Pos = (checkBoxPos.Checked) ? 1 : 0;
                    r.Rol = (checkBoxRol.Checked) ? 1 : 0;
                    r.Kadro = (checkBoxKadro.Checked) ? 1 : 0;
                    db.Roller.Add(r);
                    db.SaveChanges();
                    

                    AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Başarıyla kaydedildi.");
                    Close();
                }
                catch (Exception)
                {

                    AS.ShowAlert(MessageType.Warning, "HATA :(", "Beklenmedik bir hata oluştu!");
                    Close();
                }

            }
            else
            {
                
                DialogResult result = AS.ShowDialogAlert("Düzenleme işlemini onaylıyor musunuz?");
                if (result == DialogResult.Yes)
                {
                    var Update = db.Roller.FirstOrDefault(u => u.ID == ID);
                    if (Update != null)
                    {
                        try
                        {

                            Update.Ad = textBoxRolAd.Text;
                            Update.Kategori = (checkBoxKategori.Checked) ? 1 : 0;
                            Update.Masa = (checkBoxMasa.Checked) ? 1 : 0;
                            Update.Urun = (checkBoxUrun.Checked) ? 1 : 0;
                            Update.Mutfak = (checkBoxMutfak.Checked) ? 1 : 0;
                            Update.Pos = (checkBoxPos.Checked) ? 1 : 0;
                            Update.Rol = (checkBoxRol.Checked) ? 1 : 0;
                            Update.Kadro = (checkBoxKadro.Checked) ? 1 : 0;
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
    }
}
