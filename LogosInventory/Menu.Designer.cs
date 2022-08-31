
namespace LogosInventory
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.customButton1 = new LogosInventory.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AttendantMenuBtn = new LogosInventory.CustomButton();
            this.CategoryMenuBtn = new LogosInventory.CustomButton();
            this.ProductMenuBtn = new LogosInventory.CustomButton();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantMenuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryMenuBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductMenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.customButton1);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.AttendantMenuBtn);
            this.MainPanel.Controls.Add(this.CategoryMenuBtn);
            this.MainPanel.Controls.Add(this.ProductMenuBtn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 478);
            this.MainPanel.TabIndex = 2;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Gold;
            this.customButton1.Image = ((System.Drawing.Image)(resources.GetObject("customButton1.Image")));
            this.customButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customButton1.ImageHover")));
            this.customButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customButton1.ImageNormal")));
            this.customButton1.Location = new System.Drawing.Point(12, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(46, 43);
            this.customButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customButton1.TabIndex = 3;
            this.customButton1.TabStop = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(591, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attendant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(132, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            // 
            // AttendantMenuBtn
            // 
            this.AttendantMenuBtn.BackColor = System.Drawing.Color.Gold;
            this.AttendantMenuBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttendantMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("AttendantMenuBtn.Image")));
            this.AttendantMenuBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("AttendantMenuBtn.ImageHover")));
            this.AttendantMenuBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AttendantMenuBtn.ImageNormal")));
            this.AttendantMenuBtn.Location = new System.Drawing.Point(560, 147);
            this.AttendantMenuBtn.Name = "AttendantMenuBtn";
            this.AttendantMenuBtn.Size = new System.Drawing.Size(167, 150);
            this.AttendantMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttendantMenuBtn.TabIndex = 0;
            this.AttendantMenuBtn.TabStop = false;
            this.AttendantMenuBtn.Click += new System.EventHandler(this.AttendantMenuBtn_Click);
            // 
            // CategoryMenuBtn
            // 
            this.CategoryMenuBtn.BackColor = System.Drawing.Color.Gold;
            this.CategoryMenuBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CategoryMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("CategoryMenuBtn.Image")));
            this.CategoryMenuBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("CategoryMenuBtn.ImageHover")));
            this.CategoryMenuBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("CategoryMenuBtn.ImageNormal")));
            this.CategoryMenuBtn.Location = new System.Drawing.Point(327, 147);
            this.CategoryMenuBtn.Name = "CategoryMenuBtn";
            this.CategoryMenuBtn.Size = new System.Drawing.Size(167, 150);
            this.CategoryMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CategoryMenuBtn.TabIndex = 0;
            this.CategoryMenuBtn.TabStop = false;
            this.CategoryMenuBtn.Click += new System.EventHandler(this.CategoryMenuBtn_Click);
            // 
            // ProductMenuBtn
            // 
            this.ProductMenuBtn.BackColor = System.Drawing.Color.Gold;
            this.ProductMenuBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductMenuBtn.Image")));
            this.ProductMenuBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("ProductMenuBtn.ImageHover")));
            this.ProductMenuBtn.ImageNormal = null;
            this.ProductMenuBtn.Location = new System.Drawing.Point(92, 147);
            this.ProductMenuBtn.Name = "ProductMenuBtn";
            this.ProductMenuBtn.Size = new System.Drawing.Size(167, 150);
            this.ProductMenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductMenuBtn.TabIndex = 0;
            this.ProductMenuBtn.TabStop = false;
            this.ProductMenuBtn.Click += new System.EventHandler(this.ProductMenuBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.MainPanel);
            this.Name = "Menu";
            this.Text = "tool";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantMenuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryMenuBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductMenuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomButton AttendantMenuBtn;
        private CustomButton CategoryMenuBtn;
        private CustomButton ProductMenuBtn;
        private CustomButton customButton1;
    }
}