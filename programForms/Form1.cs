using StudentManagementSystem.programForms.formsInProgress;
using StudentManagementSystem.programForms.formsLandingPage;
using StudentManagementSystem.programSystemClasses.globalLinkClass;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            maxlength();
        }
        private void maxlength()
        {
            username_txt.MaxLength = 20;
            password_txt.MaxLength = 24;
        }
        socialMedLinks lnks = new socialMedLinks();



        private Form activeForm = null;
        // the name of the main panel is MainForm1Panel
        private void openMainForm1Panel(Form MainForm1)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = MainForm1;
            MainForm1.TopLevel = false;
            MainForm1.FormBorderStyle = FormBorderStyle.None;
            MainForm1.Dock = DockStyle.Fill;
            MainForm1Panel.Controls.Add(MainForm1);
            MainForm1Panel.Tag = MainForm1;
            MainForm1.BringToFront();
            MainForm1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)//input reader
        {
            openMainForm1Panel(new F2StudentLanding());
        }

        private void signupAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//primary buttons but dont have yet functions
        {

        }

        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//primary buttons but dont have yet functions
        {

        }
        #region social media
        private void creatorFbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("explorer.exe", "https://www.facebook.com/philip.sabinet0924");
            lnks.FacebookLink();
        }

        private void creatorGitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("explorer.exe", "https://github.com/TeachDian");
            lnks.GithubLink();
        }
        #endregion
        private void adminLoginpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openMainForm1Panel(new Form1AdminForm());
            
        }

        private void instructorLoginpage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openMainForm1Panel(new Form1InstructorForm());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}