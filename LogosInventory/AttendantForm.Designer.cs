
namespace LogosInventory
{
    partial class AttendantForm
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
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.OtherNames = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.NewAttBtn = new System.Windows.Forms.Button();
            this.UpdateAttBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(228, 107);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(246, 22);
            this.Username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(228, 267);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(246, 22);
            this.Email.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Other Names";
            // 
            // OtherNames
            // 
            this.OtherNames.Location = new System.Drawing.Point(228, 216);
            this.OtherNames.Name = "OtherNames";
            this.OtherNames.Size = new System.Drawing.Size(246, 22);
            this.OtherNames.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(228, 317);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(246, 22);
            this.Phone.TabIndex = 1;
            // 
            // NewAttBtn
            // 
            this.NewAttBtn.BackColor = System.Drawing.Color.OliveDrab;
            this.NewAttBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAttBtn.ForeColor = System.Drawing.Color.White;
            this.NewAttBtn.Location = new System.Drawing.Point(151, 389);
            this.NewAttBtn.Name = "NewAttBtn";
            this.NewAttBtn.Size = new System.Drawing.Size(101, 40);
            this.NewAttBtn.TabIndex = 2;
            this.NewAttBtn.Text = "Create";
            this.NewAttBtn.UseVisualStyleBackColor = false;
            this.NewAttBtn.Click += new System.EventHandler(this.NewAttBtn_Click);
            // 
            // UpdateAttBtn
            // 
            this.UpdateAttBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.UpdateAttBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAttBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateAttBtn.Location = new System.Drawing.Point(291, 389);
            this.UpdateAttBtn.Name = "UpdateAttBtn";
            this.UpdateAttBtn.Size = new System.Drawing.Size(101, 40);
            this.UpdateAttBtn.TabIndex = 2;
            this.UpdateAttBtn.Text = "Update";
            this.UpdateAttBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.IndianRed;
            this.CancelBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(420, 389);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(101, 40);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(228, 163);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(246, 22);
            this.Surname.TabIndex = 1;
            // 
            // AttendantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.UpdateAttBtn);
            this.Controls.Add(this.NewAttBtn);
            this.Controls.Add(this.OtherNames);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AttendantForm";
            this.Text = "AttendantForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OtherNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.Button NewAttBtn;
        private System.Windows.Forms.Button UpdateAttBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Surname;
    }
}