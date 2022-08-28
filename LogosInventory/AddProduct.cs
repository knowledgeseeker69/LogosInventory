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
            LoadCategory();
        }

        public void LoadCategory()
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
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(ProductName.Text == "" || Quantity.Text == "" || Price.Text == "" || CategoryCombo.SelectedIndex == -1)
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Product values(@ProductName, @Price, @ProductQty, @ExpiryDate, @ProductCategory)", Con);
                    cmd.Parameters.AddWithValue("@ProductName", ProductName.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(Price.Text));
                    cmd.Parameters.AddWithValue("@ProductQty", Convert.ToInt32(Quantity.Text));
                    cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ProductCategory", CategoryCombo.Text);

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

        public void Clear()
        {
            ProductName.Clear();
            Price.Clear();
            Quantity.Clear();
            CategoryCombo.Text = "";

        }

        private void Updatebtn_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("update Product set ProductName=@ProductName, Price=@Price, ProductQty=@ProductQty, ExpiryDate=@ExpiryDate, ProductCategory=@ProductCategory where ProductName like'"+ProductName.Text+"'", Con);
                    cmd.Parameters.AddWithValue("@ProductName", ProductName.Text);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToInt32(Price.Text));
                    cmd.Parameters.AddWithValue("@ProductQty", Convert.ToInt32(Quantity.Text));
                    cmd.Parameters.AddWithValue("@ExpiryDate", ExpiryDate.Value.Date);
                    cmd.Parameters.AddWithValue("@ProductCategory", CategoryCombo.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "Product Updated!");
                    Clear();
                    this.Dispose();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            
        }

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExpiryDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
