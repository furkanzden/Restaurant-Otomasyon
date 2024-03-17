
namespace FurkanOzden_221103052.Models
{
    partial class FormChangePw
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
            this.textBoxOld = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNew = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Size = new System.Drawing.Size(312, 80);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Location = new System.Drawing.Point(0, 289);
            this.gunaPanel2.Size = new System.Drawing.Size(312, 59);
            this.gunaPanel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 8);
            this.btnSave.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            // 
            // labelHeader
            // 
            this.labelHeader.Size = new System.Drawing.Size(259, 29);
            this.labelHeader.Text = "Parolanızı Değiştirin";
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
            this.label1.Location = new System.Drawing.Point(47, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Eski Parola:";
            // 
            // textBoxOld
            // 
            this.textBoxOld.BackColor = System.Drawing.Color.Transparent;
            this.textBoxOld.BaseColor = System.Drawing.Color.White;
            this.textBoxOld.BorderColor = System.Drawing.Color.Silver;
            this.textBoxOld.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxOld.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxOld.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxOld.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOld.Location = new System.Drawing.Point(47, 139);
            this.textBoxOld.Name = "textBoxOld";
            this.textBoxOld.PasswordChar = '●';
            this.textBoxOld.Radius = 7;
            this.textBoxOld.SelectedText = "";
            this.textBoxOld.Size = new System.Drawing.Size(232, 33);
            this.textBoxOld.TabIndex = 0;
            this.textBoxOld.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Parola:";
            // 
            // textBoxNew
            // 
            this.textBoxNew.BackColor = System.Drawing.Color.Transparent;
            this.textBoxNew.BaseColor = System.Drawing.Color.White;
            this.textBoxNew.BorderColor = System.Drawing.Color.Silver;
            this.textBoxNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNew.FocusedBaseColor = System.Drawing.Color.White;
            this.textBoxNew.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBoxNew.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNew.Location = new System.Drawing.Point(47, 201);
            this.textBoxNew.Name = "textBoxNew";
            this.textBoxNew.PasswordChar = '●';
            this.textBoxNew.Radius = 7;
            this.textBoxNew.SelectedText = "";
            this.textBoxNew.Size = new System.Drawing.Size(232, 33);
            this.textBoxNew.TabIndex = 0;
            this.textBoxNew.UseSystemPasswordChar = true;
            // 
            // FormChangePw
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(312, 348);
            this.Controls.Add(this.textBoxNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOld);
            this.Controls.Add(this.label1);
            this.Name = "FormChangePw";
            this.Text = "FormCategoryAdd";
            this.Controls.SetChildIndex(this.gunaPanel1, 0);
            this.Controls.SetChildIndex(this.gunaPanel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBoxOld, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBoxNew, 0);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaTextBox textBoxOld;
        private System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaTextBox textBoxNew;
    }
}