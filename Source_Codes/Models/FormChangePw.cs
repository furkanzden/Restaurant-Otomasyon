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
    public partial class FormChangePw : SampleAdd
    {
        AlertShowing AS = new AlertShowing();
        DatabaseModel db = new DatabaseModel();
        public FormChangePw()
        {
            InitializeComponent();
        }
        public int ID = 0;
        public override void btnSave_Click(object sender, EventArgs e)
        {
           
            var Update = db.Kadro.FirstOrDefault(u => u.ID == ID);
            if (Update.Parola == textBoxOld.Text)
            {
                if (Update != null)
                {
                    try
                    {
                        Update.Parola = textBoxNew.Text;
                        Update.IGiris = 0;
                        db.SaveChanges();

                        AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Başarıyla kaydedildi.");

                        Close();
                    }
                    catch (Exception)
                    {

                        AS.ShowAlert(MessageType.Danger, "HATA :(", "Beklenmedik bir hata oluştu!");
                    }
                }
            }
            else
            {
                AS.ShowAlert(MessageType.Warning, "Doğrulama hatası!", "Parolanızı doğru girdiğinizden emin olun.");
            }
                
                
            
        }
    }
}
