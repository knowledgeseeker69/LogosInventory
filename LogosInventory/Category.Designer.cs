
namespace LogosInventory
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SubPanel = new System.Windows.Forms.Panel();
            this.CategoryTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customButton1 = new LogosInventory.CustomButton();
            this.AddProdBtn = new LogosInventory.CustomButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProdBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.SubPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1282, 501);
            this.MainPanel.TabIndex = 1;
            // 
            // SubPanel
            // 
            this.SubPanel.BackColor = System.Drawing.Color.Transparent;
            this.SubPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SubPanel.Location = new System.Drawing.Point(0, 0);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(382, 501);
            this.SubPanel.TabIndex = 0;
            // 
            // CategoryTable
            // 
            this.CategoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Edit,
            this.Delete});
            this.CategoryTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.CategoryTable.Location = new System.Drawing.Point(369, 0);
            this.CategoryTable.Name = "CategoryTable";
            this.CategoryTable.RowHeadersWidth = 51;
            this.CategoryTable.RowTemplate.Height = 24;
            this.CategoryTable.Size = new System.Drawing.Size(913, 501);
            this.CategoryTable.TabIndex = 2;
            this.CategoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryTable_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Category ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 102;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Category Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 124;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(191, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 28);
            this.label7.TabIndex = 47;
            this.label7.Text = "NVENTORY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Green;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(64, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 48;
            this.label4.Text = "OGOS";
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
            this.customButton1.TabIndex = 50;
            this.customButton1.TabStop = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // AddProdBtn
            // 
            this.AddProdBtn.BackColor = System.Drawing.Color.Gold;
            this.AddProdBtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddProdBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddProdBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddProdBtn.Image")));
            this.AddProdBtn.ImageHover = ((System.Drawing.Image)(resources.GetObject("AddProdBtn.ImageHover")));
            this.AddProdBtn.ImageNormal = ((System.Drawing.Image)(resources.GetObject("AddProdBtn.ImageNormal")));
            this.AddProdBtn.Location = new System.Drawing.Point(0, 451);
            this.AddProdBtn.Name = "AddProdBtn";
            this.AddProdBtn.Size = new System.Drawing.Size(369, 50);
            this.AddProdBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddProdBtn.TabIndex = 49;
            this.AddProdBtn.TabStop = false;
            this.AddProdBtn.Click += new System.EventHandler(this.AddProdBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Green;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 46);
            this.label6.TabIndex = 44;
            this.label6.Text = "L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Green;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(142, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 46);
            this.label5.TabIndex = 45;
            this.label5.Text = "I";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "Category Table";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 501);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.AddProdBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryTable);
            this.Controls.Add(this.MainPanel);
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddProdBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Panel SubPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private CustomButton customButton1;
        private CustomButton AddProdBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView CategoryTable;
    }
}