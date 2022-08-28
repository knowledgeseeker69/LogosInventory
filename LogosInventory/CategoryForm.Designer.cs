
namespace LogosInventory
{
    partial class CategoryForm
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
            this.CategoryNametb = new System.Windows.Forms.TextBox();
            this.AddNewCatbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // CategoryNametb
            // 
            this.CategoryNametb.Location = new System.Drawing.Point(216, 56);
            this.CategoryNametb.Name = "CategoryNametb";
            this.CategoryNametb.Size = new System.Drawing.Size(210, 22);
            this.CategoryNametb.TabIndex = 1;
            this.CategoryNametb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddNewCatbtn
            // 
            this.AddNewCatbtn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewCatbtn.Location = new System.Drawing.Point(188, 110);
            this.AddNewCatbtn.Name = "AddNewCatbtn";
            this.AddNewCatbtn.Size = new System.Drawing.Size(122, 45);
            this.AddNewCatbtn.TabIndex = 2;
            this.AddNewCatbtn.Text = "Save";
            this.AddNewCatbtn.UseVisualStyleBackColor = true;
            this.AddNewCatbtn.Click += new System.EventHandler(this.AddNewCatbtn_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 179);
            this.Controls.Add(this.AddNewCatbtn);
            this.Controls.Add(this.CategoryNametb);
            this.Controls.Add(this.label1);
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryNametb;
        private System.Windows.Forms.Button AddNewCatbtn;
    }
}