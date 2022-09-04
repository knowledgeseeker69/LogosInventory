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
    public partial class AddProduct : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public AddProduct()
        {
            InitializeComponent();
            LoadCatCombo();
        }

        public void LoadCatCombo()
        {
            CategoryCombo.Items.Clear();
            SqlCommand cm = new SqlCommand("select CategoryName from Category", Con);
            Con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                CategoryCombo.Items.Add(dr[0].ToString());
            }
            dr.Close();
            Con.Close();
        }


        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
   
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "" || Quantity.Text == "" || Price.Text == "" || CategoryCombo.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Product values(@ProductName, @Price, @ProductCategory, @ProductQty, @ExpiryDate)", Con);
                    cmd.Parameters.AddWithValue("@ProductName", ProductName.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(Price.Text));
                    cmd.Parameters.AddWithValue("@ProductCategory", CategoryCombo.Text);
                    cmd.Parameters.AddWithValue("@ProductQty", Convert.ToInt32(Quantity.Text));
                    cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate.Value.Date);


                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "Product Added!");
                    this.Dispose();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (ProductName.Text == "" || Quantity.Text == "" || Price.Text == "" || CategoryCombo.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to edit this product?", "Edit Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("update Product set ProductName=@ProductName, Price=@Price, PCategory=@PCategory, ProductQty=@ProductQty, ExpiryDate=@ExpiryDate where ProductID like'" + ProdID.Text + "'", Con);
                        cmd.Parameters.AddWithValue("@ProductName", ProductName.Text);
                        cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(Price.Text));
                        cmd.Parameters.AddWithValue("@PCategory", CategoryCombo.Text);
                        cmd.Parameters.AddWithValue("@ProductQty", Convert.ToInt32(Quantity.Text));
                        cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate.Value.Date);

                        cmd.ExecuteNonQuery();
                        Con.Close();
                        MessageBox.Show(this, "Product Updated!");
                        this.Dispose();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }

        }

        private void NewCatBtn_Click(object sender, EventArgs e)
        {
            AddCategory NewAddCat = new AddCategory();
            NewAddCat.SaveBtn.Enabled = true;
            NewAddCat.UpdateBtn.Enabled = false;
            NewAddCat.CategoryID.Enabled = false;
            NewAddCat.ShowDialog();
            LoadCatCombo();

        }
    }
}
