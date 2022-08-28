using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogosInventory
{
    public partial class Products : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Products()
        {
            InitializeComponent();
            ShowProduct();
        }
        private Form WorkingForm = null;
        private void OpenNewForm(Form NewForm)
        {
            if (WorkingForm != null)
                WorkingForm.Close();
            WorkingForm = NewForm;
            NewForm.TopLevel = false;
            NewForm.FormBorderStyle = FormBorderStyle.None;
            NewForm.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(NewForm);
            MainPanel.Tag = NewForm;
            NewForm.BringToFront();
            NewForm.Show();


        }


        private void ShowProduct()
        {
            int i = 0;
            ProductTable.Rows.Clear();
            cm = new SqlCommand("select * from Product", Con);
            Con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                ProductTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            Con.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void ProductTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = ProductTable.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AddProduct AddProductForm = new AddProduct();
                
                AddProductForm.ProductName.Text = ProductTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                AddProductForm.Price.Text = ProductTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                AddProductForm.Quantity.Text = ProductTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                AddProductForm.ExpiryDate.Text = ProductTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                AddProductForm.CategoryCombo.Text = ProductTable.Rows[e.RowIndex].Cells[5].Value.ToString();

                AddProductForm.SaveBtn.Enabled = false;
                AddProductForm.UpdateBtn.Enabled = true;
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Con.Open();
                    SqlCommand cm = new SqlCommand("delete from Product where ProductName like'" + ProductTable.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", Con);
                    cm.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "Product Deleted Successfully");
                }
            }
            ShowProduct();

        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new AddProduct());
        }
    }
}
