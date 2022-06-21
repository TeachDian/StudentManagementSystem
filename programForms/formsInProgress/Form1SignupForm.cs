using StudentManagementSystem.programSystemClasses.globalLinkClass;


namespace StudentManagementSystem.programForms.formsLandingPage
{
    public partial class Form1SignupForm : Form
    {
        public Form1SignupForm()
        {
            InitializeComponent();
            SignupMaxlength();
        }

        socialMedLinks spLnks = new socialMedLinks();
        private void SignupMaxlength()
        {
            SignupUsername_txt.MaxLength = 20;
            Signup1Password_txt.MaxLength = 24;
            Signup2Password_txt.MaxLength = 24;
        }

        private void signupAccLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void creatorFbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            spLnks.FacebookLink();
        }

        private void creatorGitLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            spLnks.GithubLink();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //create new id in data base
        }

    }
}
