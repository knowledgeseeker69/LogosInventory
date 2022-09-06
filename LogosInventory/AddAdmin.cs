using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogosInventory
{
    public partial class AddAdmin : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Password.Text != Password2.Text)
            {
                MessageBox.Show("The passwords entered do not match. Try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (Username.Text == "" || Surname.Text == "" || OtherNames.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {

                try
                {
                    Con.Open();
                    cmd = new SqlCommand("insert into AdminAcc values(@Username, @Surname, @OtherName, @Email, @Phone, @Password)", Con);
                    cmd.Parameters.AddWithValue("@Username", Username.Text);
                    cmd.Parameters.AddWithValue("@Surname", Surname.Text);
                    cmd.Parameters.AddWithValue("@OtherName", OtherNames.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@Phone", Password.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "New Administrator Added!");
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
            if (Username.Text == "" || Surname.Text == "" || OtherNames.Text == "" || Email.Text == "" || Phone.Text == "")
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to edit this administrator?", "Edit Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Con.Open();
                        cmd = new SqlCommand("update AdminAcc set Username=@Username, Surname=@Surname, OtherName=@OtherName, Email=@Email, Phone=@Phone, Password=@Password where Username like '" + Username.Text + "'", Con);
                        cmd.Parameters.AddWithValue("@Username", Username.Text);
                        cmd.Parameters.AddWithValue("@Surname", Surname.Text);
                        cmd.Parameters.AddWithValue("@OtherName", OtherNames.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                        cmd.Parameters.AddWithValue("@Password", Password.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show(this, "Attendant Data Updated!");
                        this.Dispose();

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
