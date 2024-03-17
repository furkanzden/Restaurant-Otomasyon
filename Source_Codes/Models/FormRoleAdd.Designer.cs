
namespace FurkanOzden_221103052.Models
{
    partial class FormRoleAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRolAd = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxKategori = new Guna.UI.WinForms.GunaCheckBox();
            this.checkBoxMasa = new Guna.UI.WinForms.GunaCheckBox();
            this.checkBoxUrun = new Guna.UI.WinForms.GunaCheckBox();
            this.checkBoxMutfak = new Guna.UI.WinForms.GunaCheckBox();
            this.checkBoxPos = new Guna.UI.WinForms.GunaCheckBox();
            this.checkBoxRol = new Guna.UI.WinForms.GunaCheckBox();
            this.checkBoxKadro = new Guna.UI.WinForms.GunaCheckBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Size = new System.Drawing.Size(372, 80);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 492);
            this.gunaPanel2.Size = new System.Drawing.Size(372, 59);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 8);
            this.btnSave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // labelHeader
            // 
            this.labelHeader.Size = new System.Drawing.Size(118, 38);
            this.labelHeader.Text = "Rol Ekle";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(187, 8);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rol Adı:";
            // 
            // textBoxRolAd
            // 
            this.textBoxRolAd.BackColor = System.Drawing.Color.Transparent;
            this.textBoxRolAd.BaseColor = System.Drawing.Color.White;
            this.textBoxRolAd.BorderColor = System.Drawing.Color.Silver;
            this.textBoxRolAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRolAd.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxRolAd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxRolAd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxRolAd.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRolAd.Location = new System.Drawing.Point(33, 145);
            this.textBoxRolAd.Name = "textBoxRolAd";
            this.textBoxRolAd.PasswordChar = '\0';
            this.textBoxRolAd.Radius = 7;
            this.textBoxRolAd.SelectedText = "";
            this.textBoxRolAd.Size = new System.Drawing.Size(306, 43);
            this.textBoxRolAd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxKadro);
            this.groupBox1.Controls.Add(this.checkBoxRol);
            this.groupBox1.Controls.Add(this.checkBoxPos);
            this.groupBox1.Controls.Add(this.checkBoxMutfak);
            this.groupBox1.Controls.Add(this.checkBoxUrun);
            this.groupBox1.Controls.Add(this.checkBoxMasa);
            this.groupBox1.Controls.Add(this.checkBoxKategori);
            this.groupBox1.Location = new System.Drawing.Point(33, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 258);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yetkiler";
            // 
            // checkBoxKategori
            // 
            this.checkBoxKategori.BaseColor = System.Drawing.Color.White;
            this.checkBoxKategori.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxKategori.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxKategori.FillColor = System.Drawing.Color.White;
            this.checkBoxKategori.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxKategori.Location = new System.Drawing.Point(18, 31);
            this.checkBoxKategori.Name = "checkBoxKategori";
            this.checkBoxKategori.Size = new System.Drawing.Size(217, 25);
            this.checkBoxKategori.TabIndex = 0;
            this.checkBoxKategori.Text = "Kategori Ekle/Düzenle";
            // 
            // checkBoxMasa
            // 
            this.checkBoxMasa.BaseColor = System.Drawing.Color.White;
            this.checkBoxMasa.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxMasa.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxMasa.FillColor = System.Drawing.Color.White;
            this.checkBoxMasa.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxMasa.Location = new System.Drawing.Point(18, 62);
            this.checkBoxMasa.Name = "checkBoxMasa";
            this.checkBoxMasa.Size = new System.Drawing.Size(190, 25);
            this.checkBoxMasa.TabIndex = 1;
            this.checkBoxMasa.Text = "Masa Ekle/Düzenle";
            // 
            // checkBoxUrun
            // 
            this.checkBoxUrun.BaseColor = System.Drawing.Color.White;
            this.checkBoxUrun.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxUrun.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxUrun.FillColor = System.Drawing.Color.White;
            this.checkBoxUrun.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxUrun.Location = new System.Drawing.Point(18, 93);
            this.checkBoxUrun.Name = "checkBoxUrun";
            this.checkBoxUrun.Size = new System.Drawing.Size(185, 25);
            this.checkBoxUrun.TabIndex = 1;
            this.checkBoxUrun.Text = "Ürün Ekle/Düzenle";
            // 
            // checkBoxMutfak
            // 
            this.checkBoxMutfak.BaseColor = System.Drawing.Color.White;
            this.checkBoxMutfak.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxMutfak.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxMutfak.FillColor = System.Drawing.Color.White;
            this.checkBoxMutfak.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxMutfak.Location = new System.Drawing.Point(18, 124);
            this.checkBoxMutfak.Name = "checkBoxMutfak";
            this.checkBoxMutfak.Size = new System.Drawing.Size(90, 25);
            this.checkBoxMutfak.TabIndex = 1;
            this.checkBoxMutfak.Text = "Mutfak";
            // 
            // checkBoxPos
            // 
            this.checkBoxPos.BaseColor = System.Drawing.Color.White;
            this.checkBoxPos.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxPos.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxPos.FillColor = System.Drawing.Color.White;
            this.checkBoxPos.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxPos.Location = new System.Drawing.Point(18, 155);
            this.checkBoxPos.Name = "checkBoxPos";
            this.checkBoxPos.Size = new System.Drawing.Size(61, 25);
            this.checkBoxPos.TabIndex = 1;
            this.checkBoxPos.Text = "Pos";
            // 
            // checkBoxRol
            // 
            this.checkBoxRol.BaseColor = System.Drawing.Color.White;
            this.checkBoxRol.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxRol.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxRol.FillColor = System.Drawing.Color.White;
            this.checkBoxRol.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxRol.Location = new System.Drawing.Point(18, 186);
            this.checkBoxRol.Name = "checkBoxRol";
            this.checkBoxRol.Size = new System.Drawing.Size(172, 25);
            this.checkBoxRol.TabIndex = 1;
            this.checkBoxRol.Text = "Rol Ekle/Düzenle";
            // 
            // checkBoxKadro
            // 
            this.checkBoxKadro.BaseColor = System.Drawing.Color.White;
            this.checkBoxKadro.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBoxKadro.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.checkBoxKadro.FillColor = System.Drawing.Color.White;
            this.checkBoxKadro.Font = new System.Drawing.Font("Quicksand Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxKadro.Location = new System.Drawing.Point(18, 217);
            this.checkBoxKadro.Name = "checkBoxKadro";
            this.checkBoxKadro.Size = new System.Drawing.Size(196, 25);
            this.checkBoxKadro.TabIndex = 1;
            this.checkBoxKadro.Text = "Kadro Ekle/Düzenle";
            // 
            // FormRoleAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(372, 551);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxRolAd);
            this.Controls.Add(this.label1);
            this.Name = "FormRoleAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCategoryAdd";
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxRolAd, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox textBoxRolAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaCheckBox checkBoxKategori;
        private Guna.UI.WinForms.GunaCheckBox checkBoxRol;
        private Guna.UI.WinForms.GunaCheckBox checkBoxPos;
        private Guna.UI.WinForms.GunaCheckBox checkBoxMutfak;
        private Guna.UI.WinForms.GunaCheckBox checkBoxUrun;
        private Guna.UI.WinForms.GunaCheckBox checkBoxMasa;
        private Guna.UI.WinForms.GunaCheckBox checkBoxKadro;
    }
}