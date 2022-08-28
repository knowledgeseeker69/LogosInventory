
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
            this.CategoryTable = new System.Windows.Forms.DataGridView();
            this.AddCatbtn = new System.Windows.Forms.Button();
            this.customButton1 = new LogosInventory.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryTable
            // 
            this.CategoryTable.BackgroundColor = System.Drawing.Color.White;
            this.CategoryTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryTable.Location = new System.Drawing.Point(35, 61);
            this.CategoryTable.Name = "CategoryTable";
            this.CategoryTable.RowHeadersWidth = 51;
            this.CategoryTable.RowTemplate.Height = 24;
            this.CategoryTable.Size = new System.Drawing.Size(760, 381);
            this.CategoryTable.TabIndex = 0;
            this.CategoryTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoryTable_CellContentClick);
            // 
            // AddCatbtn
            // 
            this.AddCatbtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCatbtn.Location = new System.Drawing.Point(332, 455);
            this.AddCatbtn.Name = "AddCatbtn";
            this.AddCatbtn.Size = new System.Drawing.Size(103, 47);
            this.AddCatbtn.TabIndex = 1;
            this.AddCatbtn.Text = "Add";
            this.AddCatbtn.UseVisualStyleBackColor = true;
            this.AddCatbtn.Click += new System.EventHandler(this.AddCatbtn_Click);
            // 
            // customButton1
            // 
            this.customButton1.Image = ((System.Drawing.Image)(resources.GetObject("customButton1.Image")));
            this.customButton1.ImageHover = null;
            this.customButton1.ImageNormal = null;
            this.customButton1.Location = new System.Drawing.Point(12, 12);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(46, 43);
            this.customButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customButton1.TabIndex = 4;
            this.customButton1.TabStop = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(848, 514);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.AddCatbtn);
            this.Controls.Add(this.CategoryTable);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoryTable;
        private System.Windows.Forms.Button AddCatbtn;
        private CustomButton customButton1;
    }
}