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
    public partial class TillScreen : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public TillScreen()
        {
            InitializeComponent();
            LoadAttendant();
            LoadProduct();
        }
        public void LoadAttendant()
        {
            AttendantTable.Rows.Clear();
            cmd = new SqlCommand("select AttendantID, Surname, OtherName from Attendant where concat(AttendantID, Surname, OtherName) like '%"+Search.Text+"%'", Con);
            Con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                AttendantTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            Con.Close();

        }
        public void LoadProduct()
        {
            ProductTable.Rows.Clear();
            cmd = new SqlCommand("select ProductID, ProductName, Price, ProductQty, PCategory from Product where concat(ProductID, ProductName, Price, ProductQty, PCategory) like '%"+ProdSearch.Text+"%'", Con);
            Con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ProductTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            Con.Close();

        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            LoadAttendant();
        }

        private void ProdSearch_TextChanged(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ProdQty.Value) > qty)
            {
                MessageBox.Show("Cannot increase beyond available quantity for selected item!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ProdQty.Value = ProdQty.Value - 1;
                return;
            }
            int total = Convert.ToInt32(ProdQty.Value) * Convert.ToInt32(ProdPrice.Text);
            ProdTotal.Text = total.ToString();
        }

        private void AttendantTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AttID.Text = AttendantTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            AttSurname.Text = AttendantTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            AttOthername.Text = AttendantTable.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        int qty = 0;

        private void ProductTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdID.Text = ProductTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            ProdName.Text = ProductTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            ProdPrice.Text = ProductTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            qty = Convert.ToInt32(ProdCategory.Text = ProductTable.Rows[e.RowIndex].Cells[3].Value.ToString());
            ProdCategory.Text = ProductTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            
            ProdQty.Value = 1;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (AttID.Text == "" || ProdID.Text =="")
            {
                MessageBox.Show(this, "Select an attendant and a product");
            }
            else
            {

                try
                {
                    Con.Open();
                    cmd = new SqlCommand("insert into Sale values(@PID, @AttID, @SaleDate, @Qty, @ProdPrice, @Total)", Con);
                    cmd.Parameters.AddWithValue("@PID", Convert.ToInt32(ProdID.Text));
                    cmd.Parameters.AddWithValue("@AttID", Convert.ToInt32(AttID.Text));
                    cmd.Parameters.AddWithValue("@SaleDate", SaleDate.Value);
                    cmd.Parameters.AddWithValue("@Qty", Convert.ToInt32(ProdQty.Value));
                    cmd.Parameters.AddWithValue("@ProdPrice", Convert.ToInt32(ProdPrice.Text));
                    cmd.Parameters.AddWithValue("@Total", Convert.ToInt32(ProdTotal.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Sale Recorded!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();

        }
    }
}
