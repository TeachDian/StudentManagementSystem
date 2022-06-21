using StudentManagementSystem.programForms.formsLandingPage;
using StudentManagementSystem.programForms.formsMeettheMaker;
using StudentManagementSystem.programSystemClasses.globalLinkClass;


namespace StudentManagementSystem.programForms.formsInProgress
{
    public partial class Form1InstructorForm : Form
    {
        public Form1InstructorForm()
        {
            InitializeComponent();
            maxlength();
        }
        private void maxlength()
        {
            f1InsUsername_txt.MaxLength = 20;
            f1InsPassword_txt.MaxLength = 24;
        }
        socialMedLinks InsLnks = new socialMedLinks();

        private Form activeForm = null;
        private void openMainForm1Panel(Form Form1InstructorForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = Form1InstructorForm;
            Form1InstructorForm.TopLevel = false;
            Form1InstructorForm.FormBorderStyle = FormBorderStyle.None;
            Form1InstructorForm.Dock = DockStyle.Fill;
            InsMainFormpanel.Controls.Add(Form1InstructorForm); //InsMainFormpanel
            InsMainFormpanel.Tag = Form1InstructorForm;
            Form1InstructorForm.BringToFront();
            Form1InstructorForm.Show();
        }
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

        private void f1InsbtnLogin_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new F2InstructorLanding());
        }

        private void signupAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openMainForm1Panel(new Form1SignupForm());
        }

        private void meetTheMakerbtn_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new FormofPhilip());
        }
    }
}
