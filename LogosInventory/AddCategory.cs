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
    public partial class AddCategory : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();

        public AddCategory()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CategoryName.Text == "")
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {

                try
                {
                    Con.Open();
                    cmd = new SqlCommand("insert into Category values(@CategoryName)", Con);
                    cmd.Parameters.AddWithValue("@CategoryName", CategoryName.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "Category Added!");
                    this.Dispose();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CategoryName.Text == "")
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    cmd = new SqlCommand("update Category set CategoryName=@CategoryName where CategoryID like '" + CategoryID.Text + "'", Con);
                    cmd.Parameters.AddWithValue("@CategoryName", CategoryName.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "Category Data Updated!");
                    this.Dispose();
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
