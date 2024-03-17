
namespace FurkanOzden_221103052.Models
{
    partial class FormWaiterSelect
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
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMasa = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gunaPanel1.Controls.Add(this.labelHeader);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(861, 80);
            this.gunaPanel1.TabIndex = 1;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Quicksand", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(26, 25);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(140, 30);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Garson Seçin";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnMasa);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(861, 396);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnMasa
            // 
            this.btnMasa.AnimationHoverSpeed = 0.07F;
            this.btnMasa.AnimationSpeed = 0.03F;
            this.btnMasa.BackColor = System.Drawing.Color.Transparent;
            this.btnMasa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(81)))), ((int)(((byte)(38)))));
            this.btnMasa.BorderColor = System.Drawing.Color.Black;
            this.btnMasa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMasa.FocusedColor = System.Drawing.Color.Empty;
            this.btnMasa.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasa.ForeColor = System.Drawing.Color.White;
            this.btnMasa.Image = null;
            this.btnMasa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMasa.Location = new System.Drawing.Point(3, 3);
            this.btnMasa.Name = "btnMasa";
            this.btnMasa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(81)))), ((int)(((byte)(60)))));
            this.btnMasa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMasa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMasa.OnHoverImage = null;
            this.btnMasa.OnPressedColor = System.Drawing.Color.Black;
            this.btnMasa.Radius = 7;
            this.btnMasa.Size = new System.Drawing.Size(80, 80);
            this.btnMasa.TabIndex = 0;
            this.btnMasa.Text = "gunaButton1";
            this.btnMasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormWaiterSelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 476);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Quicksand Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormWaiterSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormTableSelect";
            this.Load += new System.EventHandler(this.FormTableSelect_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaPanel gunaPanel1;
        public System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaButton btnMasa;
    }
}