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
    public partial class Attendants : Form
    {
            
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();
        SqlDataReader dr;
        public Attendants()
        {
            InitializeComponent();
            LoadAttendant();
        }
        public void LoadAttendant()
        {
            AttendantTable.Rows.Clear();
            Com = new SqlCommand("select * from Attendant", Con);
            Con.Open();
            dr = Com.ExecuteReader();
            while (dr.Read())
            {
                AttendantTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            Con.Close();

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AttendantTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nameColumn = AttendantTable.Columns[e.ColumnIndex].Name;
            if(nameColumn == "Edit")
            {
                AddAttendant newAddAttendant = new AddAttendant();
                newAddAttendant.Username.Text = AttendantTable.Rows[e.RowIndex].Cells[1].Value.ToString();
                newAddAttendant.Surname.Text = AttendantTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                newAddAttendant.OtherNames.Text = AttendantTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                newAddAttendant.Email.Text = AttendantTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                newAddAttendant.Phone.Text = AttendantTable.Rows[e.RowIndex].Cells[5].Value.ToString();

                newAddAttendant.SaveBtn.Enabled = false;
                newAddAttendant.UpdateBtn.Enabled = true;
                newAddAttendant.Username.Enabled = false;


                newAddAttendant.ShowDialog();
            }
            else if(nameColumn == "Delete")
            {
                if(MessageBox.Show("Are you sure you want to delete this attendant?", "Delete Attendant", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Con.Open();
                    Com = new SqlCommand("delete from Attendant where Username like'" + AttendantTable.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", Con);
                    Com.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Attendant Deleted!");
                }
            }
            LoadAttendant();
        }

        private void AddAttBtn_Click(object sender, EventArgs e)
        {
            AddAttendant NewAddAtt = new AddAttendant();
            NewAddAtt.SaveBtn.Enabled = true;
            NewAddAtt.UpdateBtn.Enabled = false;
            NewAddAtt.ShowDialog();
            LoadAttendant();
        }
    }
}
