
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
            this.customButton1 = new LogosInventory.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.Image = ((System.Drawing.Image)(resources.GetObject("customButton1.Image")));
            this.customButton1.ImageHover = null;
            this.customButton1.ImageNormal = null;
            this.customButton1.Location = new System.Drawing.Point(204, 156);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(100, 50);
            this.customButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customButton1.TabIndex = 0;
            this.customButton1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customButton1);
            this.Name = "Menu";
            this.Text = "tool";
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton customButton1;
    }
}