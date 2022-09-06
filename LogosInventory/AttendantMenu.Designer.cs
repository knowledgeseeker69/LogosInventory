
namespace LogosInventory
{
    partial class AttendantMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendantMenu));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SalesBtn = new LogosInventory.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.SalesBtn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1023, 501);
            this.MainPanel.TabIndex = 0;
            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.Gold;
            this.SalesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesBtn.Image")));
            this.SalesBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("SalesBtn.ImageHover")));
            this.SalesBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("SalesBtn.ImageNormal")));
            this.SalesBtn.Location = new System.Drawing.Point(217, 146);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(200, 190);
            this.SalesBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalesBtn.TabIndex = 0;
            this.SalesBtn.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales";
            // 
            // AttendantMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 501);
            this.Controls.Add(this.MainPanel);
            this.Name = "AttendantMenu";
            this.Text = "AttendantMenu";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private CustomButton SalesBtn;
        private System.Windows.Forms.Label label1;
    }
}