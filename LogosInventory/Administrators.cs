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
    public partial class Administrators : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();
        SqlDataReader dr;

        public Administrators()
        {
            InitializeComponent();
            LoadAdministrators();
        }
        public void LoadAdministrators()
        {
            AdminTable.Rows.Clear();
            Com = new SqlCommand("select * from AdminAcc", Con);
            Con.Open();
            dr = Com.ExecuteReader();
            while (dr.Read())
            {
                AdminTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            Con.Close();

        }

        private void AddAdminBtn_Click_1(object sender, EventArgs e)
        {
            AddAdmin NewAddAdmin = new AddAdmin();
            NewAddAdmin.SaveBtn.Enabled = true;
            NewAddAdmin.UpdateBtn.Enabled = false;
            NewAddAdmin.ShowDialog();
            LoadAdministrators();

        }

        private void AdminTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string nameColumn = AdminTable.Columns[e.ColumnIndex].Name;
            if (nameColumn == "Edit")
            {
                AddAdmin newAddAdmin = new AddAdmin();
                newAddAdmin.Username.Text = AdminTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                newAddAdmin.Surname.Text = AdminTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                newAddAdmin.OtherNames.Text = AdminTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                newAddAdmin.Email.Text = AdminTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                newAddAdmin.Phone.Text = AdminTable.Rows[e.RowIndex].Cells[5].Value.ToString();
                newAddAdmin.Password.Text = AdminTable.Rows[e.RowIndex].Cells[6].Value.ToString();


                newAddAdmin.SaveBtn.Enabled = false;
                newAddAdmin.UpdateBtn.Enabled = true;
                newAddAdmin.Username.Enabled = false;
                newAddAdmin.Password.Enabled = false;
                newAddAdmin.Password2.Enabled = false;


                newAddAdmin.ShowDialog();
            }
            else if (nameColumn == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this administator?", "Delete Administrator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Con.Open();
                    Com = new SqlCommand("delete from AdminAcc where Username like'" + AdminTable.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", Con);
                    Com.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Administrator Deleted!");
                }
            }
            LoadAdministrators();

        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
