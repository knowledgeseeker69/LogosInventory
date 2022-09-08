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
    public partial class SalesRecords : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public SalesRecords()
        {
            InitializeComponent();
            LoadSale();
        }
        public void LoadSale()
        {
            SalesTable.Rows.Clear();
            cmd = new SqlCommand("select * from Sale", Con);
            Con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                SalesTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToDateTime(dr[3].ToString()).ToString("dd/MM/yyyy"), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            Con.Close();

        }
    }
}
