
namespace FurkanOzden_221103052.Models
{
    partial class ucProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.productImage = new System.Windows.Forms.PictureBox();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.labelProductName = new System.Windows.Forms.Label();
            this.gunaShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.productImage);
            this.gunaShadowPanel1.Controls.Add(this.gunaPanel1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(194, 194);
            this.gunaShadowPanel1.TabIndex = 0;
            this.gunaShadowPanel1.Click += new System.EventHandler(this.gunaShadowPanel1_Click);
            // 
            // productImage
            // 
            this.productImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productImage.Image = ((System.Drawing.Image)(resources.GetObject("productImage.Image")));
            this.productImage.Location = new System.Drawing.Point(19, 12);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(160, 101);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productImage.TabIndex = 2;
            this.productImage.TabStop = false;
            this.productImage.Click += new System.EventHandler(this.productImage_Click_1);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.labelProductName);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 132);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(194, 62);
            this.gunaPanel1.TabIndex = 1;
            // 
            // labelProductName
            // 
            this.labelProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProductName.Font = new System.Drawing.Font("Quicksand SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProductName.Location = new System.Drawing.Point(15, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(164, 48);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "Product Name";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelProductName.Click += new System.EventHandler(this.labelProductName_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(200, 200);
            this.gunaShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.PictureBox productImage;
    }
}
