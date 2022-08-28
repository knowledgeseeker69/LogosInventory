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
    public partial class CategoryForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddNewCatbtn_Click(object sender, EventArgs e)
        {
            if(CategoryNametb.Text == "")
                {
                    MessageBox.Show(this, "Please fill the required field");
                }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Category values(@CategoryName)", Con);
                    cmd.Parameters.AddWithValue("@CategoryName", CategoryNametb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this, "Category Added!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            
        }
    }
}
