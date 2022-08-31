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
    public partial class Login : Form
    {
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

        private void UserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            OpenNewForm(new Menu());
        }


    }
}
