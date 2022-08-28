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
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        public Attendants()
        {
            InitializeComponent();
            LoadAttendant();
        }
        public void LoadAttendant()
        {
            AttendantTable.Rows.Clear();
            cm = new SqlCommand("select * from Attendant", Con);
            Con.Open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                AttendantTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[5].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
            }
            dr.Close();
            Con.Close();

        }
    }
}
