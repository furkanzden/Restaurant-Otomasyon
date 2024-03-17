
namespace FurkanOzden_221103052
{
    partial class Alert
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
            this.head = new Guna.UI.WinForms.GunaPanel();
            this.header = new System.Windows.Forms.Label();
            this.okButton = new Guna.UI.WinForms.GunaAdvenceButton();
            this.text = new System.Windows.Forms.Label();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.head.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.head.Controls.Add(this.header);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(437, 57);
            this.head.TabIndex = 0;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(16, 14);
            this.header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(88, 25);
            this.header.TabIndex = 0;
            this.header.Text = "Header";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.AnimationHoverSpeed = 0.07F;
            this.okButton.AnimationSpeed = 0.03F;
            this.okButton.BackColor = System.Drawing.Color.Transparent;
            this.okButton.BaseColor = System.Drawing.Color.DodgerBlue;
            this.okButton.BorderColor = System.Drawing.Color.DodgerBlue;
            this.okButton.CheckedBaseColor = System.Drawing.Color.Gray;
            this.okButton.CheckedBorderColor = System.Drawing.Color.Black;
            this.okButton.CheckedForeColor = System.Drawing.Color.White;
            this.okButton.CheckedImage = null;
            this.okButton.CheckedLineColor = System.Drawing.Color.DimGray;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.okButton.FocusedColor = System.Drawing.Color.Empty;
            this.okButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.okButton.ForeColor = System.Drawing.Color.White;
            this.okButton.Image = null;
            this.okButton.ImageSize = new System.Drawing.Size(20, 20);
            this.okButton.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.okButton.Location = new System.Drawing.Point(276, 9);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okButton.Name = "okButton";
            this.okButton.OnHoverBaseColor = System.Drawing.Color.DodgerBlue;
            this.okButton.OnHoverBorderColor = System.Drawing.Color.DodgerBlue;
            this.okButton.OnHoverForeColor = System.Drawing.Color.White;
            this.okButton.OnHoverImage = null;
            this.okButton.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.okButton.OnPressedColor = System.Drawing.Color.Black;
            this.okButton.Radius = 20;
            this.okButton.Size = new System.Drawing.Size(145, 46);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Tamam";
            this.okButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // text
            // 
            this.text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text.Name = "text";
            this.text.Padding = new System.Windows.Forms.Padding(20, 12, 20, 12);
            this.text.Size = new System.Drawing.Size(437, 185);
            this.text.TabIndex = 2;
            this.text.Text = "text";
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.text);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 57);
            this.gunaPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(437, 185);
            this.gunaPanel2.TabIndex = 3;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.okButton);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 185);
            this.gunaPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(437, 60);
            this.gunaPanel3.TabIndex = 4;
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 245);
            this.Controls.Add(this.gunaPanel3);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Alert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alert";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel head;
        private System.Windows.Forms.Label header;
        private Guna.UI.WinForms.GunaAdvenceButton okButton;
        private System.Windows.Forms.Label text;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
    }
}