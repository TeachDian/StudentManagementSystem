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
            panel2Design();
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

        private void panel2Design()
        {
            f2StuAcaSubpanel.Visible = false;
            f2StuReqSubpanel.Visible = false;
            f2StuExaSubpanel.Visible = false;
            f2StuLibSubpanel.Visible = false;
        }
        private void panel2Hide()
        {
            if (f2StuAcaSubpanel.Visible == true)
                f2StuAcaSubpanel.Visible = false;
            if (f2StuReqSubpanel.Visible == true)
                f2StuReqSubpanel.Visible = false;
            if (f2StuExaSubpanel.Visible == true)
                f2StuExaSubpanel.Visible = false;
           if (f2StuLibSubpanel.Visible == true)
                f2StuLibSubpanel.Visible = false;         
        }

        private void panel2Show(Panel panel2Menu)
        {
            if (panel2Menu.Visible == false)
            {
                panel2Hide();
                panel2Menu.Visible = true;
            }
            else panel2Menu.Visible = false;
        }

        private void panel2PNBtn()
        {
            f2StubtnAcademic.Text = "Academic +";
            f2StubtnRequest.Text = "Request +";            
            f2StubtnExamMaster.Text = "Exam Master +";
            f2StubtnLibrary.Text = "Library +";
        }
        

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f2StubtnDashboard_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuDashboard());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnInstructor_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuInstructor());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnAcademic_Click(object sender, EventArgs e)
        {
            panel2Show(f2StuAcaSubpanel); 
            this.f2StubtnAcademic.Text = "Academic -";
            
        }

        private void f2StubtnSubject_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuSubject());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnClassSched_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuClassSched());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnCuriculum_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuCuriculum());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnViewcor_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuViewcor());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnRequest_Click(object sender, EventArgs e)
        {
            panel2Show(f2StuReqSubpanel);
            this.f2StubtnRequest.Text = "Request -";
        }

        private void f2StubtnLeavereq_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuRequestLeave());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnShiftreq_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuRequestShift());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnExamMaster_Click(object sender, EventArgs e)
        {
            panel2Show(f2StuExaSubpanel);
            this.f2StubtnExamMaster.Text = "Exam Master -";
        }

        private void f2StubtnExamsched_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuExamSched());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnReportcard_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuReportCard());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnAttendance_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuAttendance());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnLibrary_Click(object sender, EventArgs e)
        {
            panel2Show(f2StuLibSubpanel);
            this.f2StubtnLibrary.Text = "Library -";
        }

        private void f2StubtnFindbook_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuFindBook());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnReturnbook_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuReturnBook());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnEvents_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuEvents());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2StubtnSchoolfees_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2StuSchoolFees());
            panel2Hide();
            panel2PNBtn();
        }
    }
}
