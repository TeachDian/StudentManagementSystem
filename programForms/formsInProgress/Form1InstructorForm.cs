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

namespace StudentManagementSystem.programForms.formsInProgress
{
    public partial class Form1InstructorForm : Form
    {
        public Form1InstructorForm()
        {
            InitializeComponent();
        }

        socialMedLinks InsLnks = new socialMedLinks();
        private void instructorLoginpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        #region social media
        private void f1InsCrepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InsLnks.FacebookLink();
        }

        private void f1InsGitpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InsLnks.GithubLink();
        }
        #endregion
    }
}
