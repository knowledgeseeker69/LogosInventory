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
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
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

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if(UserType.SelectedIndex == 0)
                {
                    cmd = new SqlCommand("select * from AdminAcc where Username=@Username and Password=@Password", Con);
                    cmd.Parameters.AddWithValue("Username", Username.Text);
                    cmd.Parameters.AddWithValue("Password", Password.Text);
                    Con.Open();
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Logged in as " + dr["Username"].ToString() + ".", "Login Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu newMenu = new Menu();
                        this.Hide();
                        newMenu.Show();
                    }
                    else if (Username.Text == "" || Password.Text == "")
                    {
                        MessageBox.Show(this, "Please fill all required fields");
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Con.Close();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


    }
}
