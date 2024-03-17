
namespace FurkanOzden_221103052.Models
{
    partial class FormProductAdd
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
            this.textBoxAd = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFiyat = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKategori = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResim = new Guna.UI.WinForms.GunaTextBox();
            this.btnSelectImage = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Size = new System.Drawing.Size(559, 80);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 364);
            this.gunaPanel2.Size = new System.Drawing.Size(559, 59);
            this.gunaPanel2.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(319, 8);
            this.btnSave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // labelHeader
            // 
            this.labelHeader.Size = new System.Drawing.Size(103, 30);
            this.labelHeader.Text = "Ürün Ekle";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(455, 8);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // textBoxAd
            // 
            this.textBoxAd.BackColor = System.Drawing.Color.Transparent;
            this.textBoxAd.BaseColor = System.Drawing.Color.White;
            this.textBoxAd.BorderColor = System.Drawing.Color.Silver;
            this.textBoxAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAd.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxAd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxAd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxAd.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(27, 136);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.PasswordChar = '\0';
            this.textBoxAd.Radius = 7;
            this.textBoxAd.SelectedText = "";
            this.textBoxAd.Size = new System.Drawing.Size(232, 33);
            this.textBoxAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyat:";
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.BackColor = System.Drawing.Color.Transparent;
            this.textBoxFiyat.BaseColor = System.Drawing.Color.White;
            this.textBoxFiyat.BorderColor = System.Drawing.Color.Silver;
            this.textBoxFiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxFiyat.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxFiyat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxFiyat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxFiyat.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxFiyat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxFiyat.Location = new System.Drawing.Point(27, 198);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.PasswordChar = '\0';
            this.textBoxFiyat.Radius = 7;
            this.textBoxFiyat.SelectedText = "";
            this.textBoxFiyat.Size = new System.Drawing.Size(232, 33);
            this.textBoxFiyat.TabIndex = 1;
            this.textBoxFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiyat_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kategori:";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxKategori.BaseColor = System.Drawing.Color.White;
            this.comboBoxKategori.BorderColor = System.Drawing.Color.Silver;
            this.comboBoxKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKategori.FocusedColor = System.Drawing.Color.Empty;
            this.comboBoxKategori.Font = new System.Drawing.Font("Quicksand Medium", 11F, System.Drawing.FontStyle.Bold);
            this.comboBoxKategori.ForeColor = System.Drawing.Color.Black;
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.ItemHeight = 27;
            this.comboBoxKategori.Location = new System.Drawing.Point(304, 139);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.comboBoxKategori.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBoxKategori.Radius = 7;
            this.comboBoxKategori.Size = new System.Drawing.Size(228, 33);
            this.comboBoxKategori.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resim:";
            // 
            // textBoxResim
            // 
            this.textBoxResim.BackColor = System.Drawing.Color.Transparent;
            this.textBoxResim.BaseColor = System.Drawing.Color.White;
            this.textBoxResim.BorderColor = System.Drawing.Color.Silver;
            this.textBoxResim.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxResim.Enabled = false;
            this.textBoxResim.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxResim.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxResim.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxResim.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxResim.Location = new System.Drawing.Point(304, 198);
            this.textBoxResim.Name = "textBoxResim";
            this.textBoxResim.PasswordChar = '\0';
            this.textBoxResim.Radius = 7;
            this.textBoxResim.SelectedText = "";
            this.textBoxResim.Size = new System.Drawing.Size(191, 33);
            this.textBoxResim.TabIndex = 3;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.AnimationHoverSpeed = 0.07F;
            this.btnSelectImage.AnimationSpeed = 0.03F;
            this.btnSelectImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectImage.BaseColor = System.Drawing.Color.White;
            this.btnSelectImage.BorderColor = System.Drawing.Color.Silver;
            this.btnSelectImage.BorderSize = 2;
            this.btnSelectImage.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSelectImage.FocusedColor = System.Drawing.Color.Empty;
            this.btnSelectImage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectImage.ForeColor = System.Drawing.Color.Black;
            this.btnSelectImage.Image = null;
            this.btnSelectImage.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectImage.Location = new System.Drawing.Point(498, 198);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnSelectImage.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSelectImage.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSelectImage.OnHoverImage = null;
            this.btnSelectImage.OnPressedColor = System.Drawing.Color.Black;
            this.btnSelectImage.Radius = 7;
            this.btnSelectImage.Size = new System.Drawing.Size(38, 33);
            this.btnSelectImage.TabIndex = 3;
            this.btnSelectImage.Text = "...";
            this.btnSelectImage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(304, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormProductAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(559, 423);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.textBoxResim);
            this.Controls.Add(this.textBoxFiyat);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormProductAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCategoryAdd";
            this.Load += new System.EventHandler(this.FormStaffAdd_Load);
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxAd, 0);
            this.Controls.SetChildIndex(this.textBoxFiyat, 0);
            this.Controls.SetChildIndex(this.textBoxResim, 0);
            this.Controls.SetChildIndex(this.comboBoxKategori, 0);
            this.Controls.SetChildIndex(this.btnSelectImage, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox textBoxAd;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox textBoxFiyat;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox comboBoxKategori;
        private System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaTextBox textBoxResim;
        private Guna.UI.WinForms.GunaButton btnSelectImage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}