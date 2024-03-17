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
    public partial class FormBillList : SampleAdd
    {
        AlertShowing AS = new AlertShowing();
        public FormBillList()
        {
            InitializeComponent();
        }
        public int MainID = 0;
        private void FormBillList_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                dataGridView1.Rows.Clear();
                DatabaseModel dbs = new DatabaseModel();


                var orders = dbs.Siparisler.Where(s => s.Durum != 1)
                .ToList();
                orders.Reverse();



                foreach ( var order in orders )
                {
                    string durum = (order.Durum == 1) ? "Hazırlanıyor" : (order.Durum == 2) ? "Ödeme Bekliyor" : "Ödendi";
                    dataGridView1.Rows.Add( order.ID, 0, order.MasaAd, order.GarsonAd, order.Tur, durum, order.Toplam);
                }
            }
            catch (Exception)
            {
                AS.ShowAlert(MessageType.Danger, "HATA :(", "Beklenmedik bir hata oluştu!");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                count++;
                item.Cells[1].Value = count;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.OwningColumn.Name == "ode" && dataGridView1.CurrentRow.Cells["Durum"].Value != "Ödendi")
            {
                FormCheckOut FcO = new FormCheckOut();
                FcO.FID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
                BackGroundBlur.BlurBackground(FcO);
                Close();

            }
            if (dataGridView1.CurrentRow.Cells["Durum"].Value == "Ödendi")
            {
                AS.ShowAlert(MessageType.Warning, "Uyarı", "Bu fatura ödenmiş!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
