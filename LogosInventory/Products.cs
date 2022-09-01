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

    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();
        SqlDataReader dr;

        public void LoadAttendant()
        {
            ProductTable.Rows.Clear();
            Com = new SqlCommand("select * from Product", Con);
            Con.Open();
            dr = Com.ExecuteReader();
            while (dr.Read())
            {
                ProductTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            Con.Close();

        }


        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            AddProduct NewProd = new AddProduct();
            NewProd.Show();

        }
    }
}
