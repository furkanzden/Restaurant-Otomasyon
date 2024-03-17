using FurkanOzden_221103052.Class;
using FurkanOzden_221103052.DAL;
using FurkanOzden_221103052.Models;
using FurkanOzden_221103052.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanOzden_221103052
{
    public partial class FormMain : Form
    {
        LoginValidation LV = new LoginValidation();
        DatabaseModel db = new DatabaseModel();
        public FormMain()
        {
            InitializeComponent();
        }

        static FormMain _obj;
        public static FormMain Instance { get { if(_obj == null) { _obj = new FormMain();  } return _obj; } }

        public void FormGetir(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }




        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGetir()
        {
            var yetki = db.Kadro.Where(y => y.ID == LV.USERID)
                .Join(db.Roller, kadro => kadro.Rol , rol => rol.ID, (kadro, rol) => new
                {
                    KatY = rol.Kategori,
                    MasaY = rol.Masa,
                    UrunY = rol.Urun,
                    MutfakY = rol.Mutfak,
                    PosY = rol.Pos,
                    RolY = rol.Rol,
                    KadroY = rol.Kadro


                }).ToList();

            btnKategori.Visible = (yetki[0].KatY == 1) ? true : false;
            btnMasalar.Visible = (yetki[0].MasaY == 1) ? true : false;
            btnUrunler.Visible = (yetki[0].UrunY == 1) ? true : false;
            btnMutfak.Visible = (yetki[0].MutfakY == 1) ? true : false;
            btnPos.Visible = (yetki[0].PosY == 1) ? true : false;
            btnRoller.Visible = (yetki[0].RolY == 1) ? true : false;
            btnKadro.Visible = (yetki[0].KadroY == 1) ? true : false;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonGetir();
            labelUser.Text = LV.USER;
            _obj = this;
            FormGetir(new AnaSayfa());
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            FormGetir(new AnaSayfa());
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FormGetir(new FormCategoryView());
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            FormGetir(new FormTableView());
        }

        private void btnKadro_Click(object sender, EventArgs e)
        {
            FormGetir(new FormStaffView());
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            FormGetir(new FormProductView());
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            FormPos formPos = new FormPos();
            btnPos.Checked = false;
            btnAnaSayfa.Checked = true;
            FormGetir(new AnaSayfa());
            formPos.ShowDialog();
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            FormGetir(new FormKitchenView());
        }

        private void btnRoller_Click(object sender, EventArgs e)
        {
            FormGetir(new FormRoleView());
        }

    }
}
