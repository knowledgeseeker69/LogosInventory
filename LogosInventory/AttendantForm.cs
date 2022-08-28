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

    public partial class AttendantForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cm = new SqlCommand();

        public AttendantForm()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewAttBtn_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" ||  OtherNames.Text == "" || Email.Text == "" || Phone.Text == "")
            {
                MessageBox.Show(this, "Please fill all required fields");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Attendant values(@Username, @OtherName, @Email, @Phone, @Surname)", Con);
                    cmd.Parameters.AddWithValue("@Username", Username.Text);
                    cmd.Parameters.AddWithValue("@OtherName", OtherNames.Text);
                    cmd.Parameters.AddWithValue("@Email", Email.Text);
                    cmd.Parameters.AddWithValue("@Phone", Phone.Text);
                    cmd.Parameters.AddWithValue("@Surname", Surname.Text);

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show(this, "Attendant Created!");
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
