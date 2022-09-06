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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rashid\Documents\LogosInventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand Com = new SqlCommand();
        SqlDataReader dr;

        public Category()
        {
            InitializeComponent();
            LoadCategory();
        }
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


        private void CategoryTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nameColumn = CategoryTable.Columns[e.ColumnIndex].Name;
            if (nameColumn == "Edit")
            {
                AddCategory newAddCategory = new AddCategory();
                newAddCategory.CategoryID.Text = CategoryTable.Rows[e.RowIndex].Cells[0].Value.ToString();
                newAddCategory.CategoryName.Text = CategoryTable.Rows[e.RowIndex].Cells[1].Value.ToString();

                newAddCategory.SaveBtn.Enabled = false;
                newAddCategory.UpdateBtn.Enabled = true;
                newAddCategory.CategoryID.Enabled = false;

                newAddCategory.ShowDialog();
            }
            else if (nameColumn == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Con.Open();
                    Com = new SqlCommand("delete from Category where CategoryID like'" + CategoryTable.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", Con);
                    Com.ExecuteNonQuery();
                    Con.Close();
                    MessageBox.Show("Category Deleted!");
                }
            }
            LoadCategory();

        }

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            AddCategory NewAddCat = new AddCategory();
            NewAddCat.SaveBtn.Enabled = true;
            NewAddCat.UpdateBtn.Enabled = false;
            NewAddCat.CategoryID.Enabled = false;
            NewAddCat.ShowDialog();
            LoadCategory();

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
