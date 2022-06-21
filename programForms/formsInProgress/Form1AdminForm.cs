using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.programSystemClasses.globalLinkClass;
using StudentManagementSystem.programForms.formsLandingPage;
using StudentManagementSystem;

namespace StudentManagementSystem.programForms.formsInProgress
{
    public partial class Form1AdminForm : Form
    {
        public Form1AdminForm()
        {
            InitializeComponent();
            maxlength();
        }
        private void maxlength()
        {
            f1AdmUsername_txt.MaxLength = 20;
            f1AdmPassword_txt.MaxLength = 24;
        }
        socialMedLinks AdmLnks = new socialMedLinks();

        private Form activeForm = null;
        private void openMainForm1Panel(Form Form1AdminForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Form1AdminForm;
            Form1AdminForm.TopLevel = false;
            Form1AdminForm.FormBorderStyle = FormBorderStyle.None;
            Form1AdminForm.Dock = DockStyle.Fill;
            AdmMainFormpanel.Controls.Add(Form1AdminForm);
            AdmMainFormpanel.Tag = Form1AdminForm;
            Form1AdminForm.BringToFront();
            Form1AdminForm.Show();
        }


        #region socialmedia
        private void f1AdmGitpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmLnks.FacebookLink();
        }

        private void f1AdmCrepage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmLnks.GithubLink();
        }

        #endregion

        private void adminLoginpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void f1AdmbtnLogin_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new F2AdminLanding());
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openMainForm1Panel(new Form1SignupForm());
        }
    }
}
