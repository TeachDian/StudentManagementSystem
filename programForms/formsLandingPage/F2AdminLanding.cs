using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.programForms.formsLandingPage.f2AdminLanding;

namespace StudentManagementSystem.programForms.formsLandingPage
{
    public partial class F2AdminLanding : Form
    {
        public F2AdminLanding()
        {
            InitializeComponent();
        }

        private Form actvAdmLnding = null;
        private void openMainForm1Panel(Form AdmMainFormpanel)
        {
            if (actvAdmLnding != null) //actvAdmLnding 
                actvAdmLnding.Close();
            actvAdmLnding = AdmMainFormpanel;
            AdmMainFormpanel.TopLevel = false;
            AdmMainFormpanel.FormBorderStyle = FormBorderStyle.None; //f2AdmMainboardPanel
            AdmMainFormpanel.Dock = DockStyle.Fill;
            f2AdmMainboardPanel.Controls.Add(AdmMainFormpanel);
            f2AdmMainboardPanel.Tag = AdmMainFormpanel;
            AdmMainFormpanel.BringToFront();
            AdmMainFormpanel.Show();
        }


        private void f2AdmbtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f2AdmbtnHome_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2AdmHome());
        }

        private void f2AdmbtnAccounts_Click(object sender, EventArgs e)
        {

        }

        private void f2AdmbtnDepartment_Click(object sender, EventArgs e)
        {

        }

        private void f2AdmbtnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void f2AdmbtnStatistics_Click(object sender, EventArgs e)
        {

        }

        private void f2AdmbtnEvents_Click(object sender, EventArgs e)
        {

        }

        private void f2AdmbtnAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
