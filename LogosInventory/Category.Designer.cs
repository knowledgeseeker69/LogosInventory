
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
            this.CategoryTable = new System.Windows.Forms.DataGridView();
            this.AddCatbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).BeginInit();
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
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 514);
            this.Controls.Add(this.AddCatbtn);
            this.Controls.Add(this.CategoryTable);
            this.Name = "Category";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoryTable;
        private System.Windows.Forms.Button AddCatbtn;
    }
}