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
    public partial class Form1AdminForm : Form
    {
        public Form1AdminForm()
        {
            InitializeComponent();
        }

        socialMedLinks AdmLnks = new socialMedLinks();

        private void f1AdmStupage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        #region socialmedia
        private void f1Adm1Gitpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmLnks.FacebookLink();
        }

        private void f1AdmCrepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdmLnks.GithubLink();
        }
        #endregion
    }
}
