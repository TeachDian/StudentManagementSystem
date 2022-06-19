using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.programForms.formsLandingPage.f2StudentLanding;

namespace StudentManagementSystem.programForms.formsLandingPage
{
    public partial class F2StudentLanding : Form
    {
        public F2StudentLanding()
        {
            InitializeComponent();
        }

        private Form actvStuLnding = null;
        private void openMainForm1Panel(Form MainForm1)
        {
            if (actvStuLnding != null)
                actvStuLnding.Close();
            actvStuLnding = MainForm1;
            MainForm1.TopLevel = false;
            MainForm1.FormBorderStyle = FormBorderStyle.None;
            MainForm1.Dock = DockStyle.Fill;
            f2StuLandingPanel.Controls.Add(MainForm1);
            f2StuLandingPanel.Tag = MainForm1;
            MainForm1.BringToFront();
            MainForm1.Show();
        }
        private void iconButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuDashboard());
        }

    }
}
