using FurkanOzden_221103052.Class;
using FurkanOzden_221103052.DAL;
using FurkanOzden_221103052.Models;
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

namespace FurkanOzden_221103052.Views
{
    public partial class FormProductView : SampleView
    {
        AlertShowing AS = new AlertShowing();
        public FormProductView()
        { 
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                string search = textBoxSearch.Text;
                dataGridView1.Rows.Clear();
                DatabaseModel db = new DatabaseModel();
                var sonuclar = db.Urunler.Where(x => x.Ad.Contains(search))
                .Join(db.Kategoriler,
                      urun => urun.KategoriID,
                      kategori => kategori.ID,
                      (urun, kategori) => new { Urun = urun, Kategori = kategori })
                .ToList();
                

                for (int i = 0; i < sonuclar.Count; i++)
                {

                    dataGridView1.Rows.Add(sonuclar[i].Urun.ID.ToString(), (i + 1).ToString(), sonuclar[i].Urun.Ad.ToString(), sonuclar[i].Urun.Fiyat.ToString(), sonuclar[i].Kategori.Ad.ToString(), sonuclar[i].Kategori.ID.ToString());
                }
            }
            catch (Exception)
            {
                AS.ShowAlert(MessageType.Warning, "HATA :(", "Beklenmedik bir hata oluştu!");
            }

        }

        private void FormCategoryView_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public override void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //FormCategoryAdd FCA = new FormCategoryAdd();
                //FCA.ShowDialog();
                BackGroundBlur.BlurBackground(new FormProductAdd());
                LoadData();
            }
            catch (Exception)
            {
                AS.ShowAlert(MessageType.Warning, "HATA :(", "Beklenmedik bir hata oluştu!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentCell.OwningColumn.Name == "edit")
                {
                    FormProductAdd FCE = new FormProductAdd();
                    FCE.ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                    BackGroundBlur.BlurBackground(FCE);
                    LoadData();

                }
                else if (dataGridView1.CurrentCell.OwningColumn.Name == "delete")
                {
                    DialogResult result = AS.ShowDialogAlert("Silmek istediğinizden emin misiniz?");

                    if (result == DialogResult.Yes)
                    {
                        int entityId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                        DatabaseModel db = new DatabaseModel();
                        var entityDelete = new Urunler { ID = entityId };
                        db.Entry(entityDelete).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        AS.ShowAlert(MessageType.Success, "İşlem Başarılı!", "Başarıyla silindi.");
                    }
                    


                }
                LoadData();
            }
            catch (Exception)
            {
                AS.ShowAlert(MessageType.Warning, "HATA :(", "Beklenmedik bir hata oluştu!");
            }
            
        }
    }
}
