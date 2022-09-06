
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AttendantBtn = new LogosInventory.CustomButton();
            this.AdminBtn = new LogosInventory.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.CancelBtn);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.AttendantBtn);
            this.MainPanel.Controls.Add(this.AdminBtn);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1282, 501);
            this.MainPanel.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.LightCoral;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(439, 357);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(111, 43);
            this.CancelBtn.TabIndex = 37;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(641, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Attendant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Administrator";
            // 
            // AttendantBtn
            // 
            this.AttendantBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AttendantBtn.Image = ((System.Drawing.Image)(resources.GetObject("AttendantBtn.Image")));
            this.AttendantBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("AttendantBtn.ImageHover")));
            this.AttendantBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AttendantBtn.ImageNormal")));
            this.AttendantBtn.Location = new System.Drawing.Point(586, 91);
            this.AttendantBtn.Name = "AttendantBtn";
            this.AttendantBtn.Size = new System.Drawing.Size(210, 186);
            this.AttendantBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AttendantBtn.TabIndex = 33;
            this.AttendantBtn.TabStop = false;
            this.AttendantBtn.Click += new System.EventHandler(this.AttendantBtn_Click_1);
            // 
            // AdminBtn
            // 
            this.AdminBtn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AdminBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdminBtn.Image")));
            this.AdminBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("AdminBtn.ImageHover")));
            this.AdminBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AdminBtn.ImageNormal")));
            this.AdminBtn.Location = new System.Drawing.Point(203, 91);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(210, 186);
            this.AdminBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminBtn.TabIndex = 34;
            this.AdminBtn.TabStop = false;
            this.AdminBtn.Click += new System.EventHandler(this.AdminBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "Which class of users would you like to access?";
            // 
            // UserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 501);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDialog";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendantBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomButton AttendantBtn;
        private CustomButton AdminBtn;
        private System.Windows.Forms.Label label1;
    }
}