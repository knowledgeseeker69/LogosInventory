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
            LoadCategory();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();
        SqlDataReader dr;

        public void LoadCategory()
        {
            CategoryTable.Rows.Clear();
            Com = new SqlCommand("select * from Category", Con);
            Con.Open();
            dr = Com.ExecuteReader();
            while (dr.Read())
            {
                CategoryTable.Rows.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            Con.Close();
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CategoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nameColumn = CategoryTable.Columns[e.ColumnIndex].Name;
            if (nameColumn == "Edit")
            {
                AddCategory newAddCat = new AddCategory();
                newAddCat.CategoryName.Text = CategoryTable.Rows[e.RowIndex].Cells[1].Value.ToString();

                newAddCat.SaveBtn.Enabled = false;
                newAddCat.UpdateBtn.Enabled = true;


                newAddCat.ShowDialog();
            }
            else if (nameColumn == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Con.Open();
                    Com = new SqlCommand("delete from Category where Username like'" + CategoryTable.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", Con);
                    Com.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Attendant Deleted!");
                }
            }
            LoadCategory();

        }

        private void AddCatBtn_Click(object sender, EventArgs e)
        {
            AddCategory newAddCat = new AddCategory();
            newAddCat.SaveBtn.Enabled = true;
            newAddCat.UpdateBtn.Enabled = false;

            newAddCat.ShowDialog();

            LoadCategory();

        }
    }
}
