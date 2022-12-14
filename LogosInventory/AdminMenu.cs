using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogosInventory
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
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

        private void AttendantMenuBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new UserDialog());
        }

        private void ProductMenuBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new Products());
        }

        private void CategoryMenuBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new Category());
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Login newLogin = new Login();
                newLogin.Show();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
