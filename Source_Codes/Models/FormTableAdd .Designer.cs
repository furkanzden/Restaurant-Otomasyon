
namespace FurkanOzden_221103052.Models
{
    partial class FormTableAdd
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
            this.textBoxKategoriAd = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Size = new System.Drawing.Size(285, 80);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 212);
            this.gunaPanel2.Size = new System.Drawing.Size(285, 59);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 9);
            this.btnSave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // labelHeader
            // 
            this.labelHeader.Size = new System.Drawing.Size(106, 30);
            this.labelHeader.Text = "Masa Ekle";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(167, 9);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masa Adı:";
            // 
            // textBoxKategoriAd
            // 
            this.textBoxKategoriAd.BackColor = System.Drawing.Color.Transparent;
            this.textBoxKategoriAd.BaseColor = System.Drawing.Color.White;
            this.textBoxKategoriAd.BorderColor = System.Drawing.Color.Silver;
            this.textBoxKategoriAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxKategoriAd.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxKategoriAd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxKategoriAd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxKategoriAd.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKategoriAd.Location = new System.Drawing.Point(27, 136);
            this.textBoxKategoriAd.Name = "textBoxKategoriAd";
            this.textBoxKategoriAd.PasswordChar = '\0';
            this.textBoxKategoriAd.Radius = 7;
            this.textBoxKategoriAd.SelectedText = "";
            this.textBoxKategoriAd.Size = new System.Drawing.Size(232, 33);
            this.textBoxKategoriAd.TabIndex = 0;
            // 
            // FormTableAdd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(285, 271);
            this.Controls.Add(this.textBoxKategoriAd);
            this.Controls.Add(this.label1);
            this.Name = "FormTableAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCategoryAdd";
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxKategoriAd, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox textBoxKategoriAd;
    }
}