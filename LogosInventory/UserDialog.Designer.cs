
namespace LogosInventory
{
    partial class UserDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.AdminBtn = new LogosInventory.CustomButton();
            this.AttendantBtn = new LogosInventory.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AdminBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which class of users would you like to access?";
            // 
            // AdminBtn
            // 
            this.AdminBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdminBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdminBtn.Image")));
            this.AdminBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("AdminBtn.ImageHover")));
            this.AdminBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AdminBtn.ImageNormal")));
            this.AdminBtn.Location = new System.Drawing.Point(145, 108);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(160, 150);
            this.AdminBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminBtn.TabIndex = 1;
            this.AdminBtn.TabStop = false;
            this.AdminBtn.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // AttendantBtn
            // 
            this.AttendantBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AttendantBtn.Image = ((System.Drawing.Image)(resources.GetObject("AttendantBtn.Image")));
            this.AttendantBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("AttendantBtn.ImageHover")));
            this.AttendantBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AttendantBtn.ImageNormal")));
            this.AttendantBtn.Location = new System.Drawing.Point(490, 108);
            this.AttendantBtn.Name = "AttendantBtn";
            this.AttendantBtn.Size = new System.Drawing.Size(160, 150);
            this.AttendantBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttendantBtn.TabIndex = 1;
            this.AttendantBtn.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administrator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attendant";
            // 
            // UserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 318);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AttendantBtn);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserDialog";
            this.Text = "UserDialog";
            ((System.ComponentModel.ISupportInitialize)(this.AdminBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomButton AdminBtn;
        private CustomButton AttendantBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}