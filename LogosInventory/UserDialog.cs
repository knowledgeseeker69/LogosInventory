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
    public partial class UserDialog : Form
    {
        public UserDialog()
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

        private void AdminBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenNewForm(new Attendants());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void AttendantBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenNewForm(new Attendants());
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            AdminMenu newMenu = new AdminMenu();
            newMenu.Show();
        }


    }
}
