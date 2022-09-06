
namespace LogosInventory
{
    partial class Administrators
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrators));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminTable = new System.Windows.Forms.DataGridView();
            this.customButton1 = new LogosInventory.CustomButton();
            this.AddAdminBtn = new LogosInventory.CustomButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAdminBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AdminTable);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1282, 501);
            this.MainPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Administrator Table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(216, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 46);
            this.label5.TabIndex = 44;
            this.label5.Text = "I";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 46);
            this.label6.TabIndex = 43;
            this.label6.Text = "L";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(138, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 47;
            this.label4.Text = "OGOS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(265, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "NVENTORY";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddAdminBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 501);
            this.panel1.TabIndex = 3;
            // 
            // AdminTable
            // 
            this.AdminTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Edit,
            this.Delete});
            this.AdminTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.AdminTable.Location = new System.Drawing.Point(533, 0);
            this.AdminTable.Name = "AdminTable";
            this.AdminTable.RowHeadersWidth = 51;
            this.AdminTable.RowTemplate.Height = 24;
            this.AdminTable.Size = new System.Drawing.Size(749, 501);
            this.AdminTable.TabIndex = 2;
            this.AdminTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminTable_CellContentClick_1);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Gold;
            this.customButton1.Image = ((System.Drawing.Image)(resources.GetObject("customButton1.Image")));
            this.customButton1.ImageHover = ((System.Drawing.Image)(resources.GetObject("customButton1.ImageHover")));
            this.customButton1.ImageNormal = ((System.Drawing.Image)(resources.GetObject("customButton1.ImageNormal")));
            this.customButton1.Location = new System.Drawing.Point(0, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(30, 30);
            this.customButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customButton1.TabIndex = 49;
            this.customButton1.TabStop = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click_1);
            // 
            // AddAdminBtn
            // 
            this.AddAdminBtn.BackColor = System.Drawing.Color.Gold;
            this.AddAdminBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddAdminBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddAdminBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddAdminBtn.Image")));
            this.AddAdminBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("AddAdminBtn.ImageHover")));
            this.AddAdminBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AddAdminBtn.ImageNormal")));
            this.AddAdminBtn.Location = new System.Drawing.Point(0, 451);
            this.AddAdminBtn.Name = "AddAdminBtn";
            this.AddAdminBtn.Size = new System.Drawing.Size(533, 50);
            this.AddAdminBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddAdminBtn.TabIndex = 42;
            this.AddAdminBtn.TabStop = false;
            this.AddAdminBtn.Click += new System.EventHandler(this.AddAdminBtn_Click_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 102;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Surname";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 94;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Other Names";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 71;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.HeaderText = "Phone";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 78;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column7.HeaderText = "Password";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 98;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 25;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 25;
            // 
            // Administrators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 501);
            this.Controls.Add(this.MainPanel);
            this.Name = "Administrators";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrators";
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddAdminBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView AdminTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private CustomButton customButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private CustomButton AddAdminBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}