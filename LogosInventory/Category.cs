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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            ShowCategory();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void ShowCategory()
        {
            Con.Open();
            string Query = "select * from Category";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CategoryTable.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void AddCatbtn_Click(object sender, EventArgs e)
        {

        }

        private void CategoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
