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
        public Products()
        {
            InitializeComponent();
            LoadProduct();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();
        SqlDataReader dr;

        public void LoadProduct()
        {
            ProductTable.Rows.Clear();
            Com = new SqlCommand("select * from Product", Con);
            Con.Open();
            dr = Com.ExecuteReader();
            while (dr.Read())
            {
                ProductTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            Con.Close();

        }


        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            AddProduct NewProd = new AddProduct();
            NewProd.SaveBtn.Enabled = true;
            NewProd.UpdateBtn.Enabled = false;

            NewProd.ShowDialog();
            LoadProduct();
        }

        private void ProductTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nameColumn = ProductTable.Columns[e.ColumnIndex].Name;
            if (nameColumn == "Edit")
            {
                AddProduct newAddProd = new AddProduct();
                newAddProd.ProdID.Text = ProductTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                newAddProd.ProductName.Text = ProductTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                newAddProd.Price.Text = ProductTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                newAddProd.CategoryCombo.Text = ProductTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                newAddProd.Quantity.Text = ProductTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                newAddProd.ExpiryDate.Text = ProductTable.Rows[e.RowIndex].Cells[5].Value.ToString();

                newAddProd.SaveBtn.Enabled = false;
                newAddProd.UpdateBtn.Enabled = true;
                newAddProd.ProdID.Enabled = false;


                newAddProd.ShowDialog();
            }
            else if (nameColumn == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Con.Open();
                    Com = new SqlCommand("delete from Product where ProductName like'" + ProductTable.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", Con);
                    Com.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Attendant Deleted!");
                }
            }
            LoadProduct();

        }
    }
}
