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
    public partial class AttendantMenu : Form
    {
        public AttendantMenu()
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


        private void SalesBtn_Click(object sender, EventArgs e)
        {
            OpenNewForm(new TillScreen());
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            OpenNewForm(new SalesRecords());
        }
    }
}
