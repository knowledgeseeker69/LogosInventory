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

    public partial class AddAttendant : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public AddAttendant()
        {
            InitializeComponent();
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Surname.Text == "" || OtherNames.Text == "" || Email.Text == ""|| Phone.Text == "")
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Attendant values(@Username, @Surname, @OtherName, @Email, @Phone)", Con);
                    cmd.Parameters.AddWithValue("@Username", Username.Text);
                    cmd.Parameters.AddWithValue("@Surname", Surname.Text);
                    cmd.Parameters.AddWithValue("@OtherName", OtherNames.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@Phone", Phone.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "Attendant Added!");
                    this.Dispose();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            Con.Close();
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
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
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update Attendant set Username=@Username, Surname=@Surname, OtherName=@OtherName, Email=@Email, Phone=@Phone where username like '"+ Username.Text +"'", Con);
                    cmd.Parameters.AddWithValue("@Username", Username.Text);
                    cmd.Parameters.AddWithValue("@Surname", Surname.Text);
                    cmd.Parameters.AddWithValue("@OtherName", OtherNames.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@Phone", Phone.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "Attendant Data Updated!");
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
