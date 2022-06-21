using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.programForms.formsLandingPage.f2InstructorLanding;

namespace StudentManagementSystem.programForms.formsLandingPage
{
    public partial class F2InstructorLanding : Form
    {
        public F2InstructorLanding()
        {
            InitializeComponent();
            panel2Design(); 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Form actvInsLnding = null;
        private void openMainForm1Panel(Form InsMainFormpanel)
        {
            if (actvInsLnding != null)
                actvInsLnding.Close();
            actvInsLnding = InsMainFormpanel;
            InsMainFormpanel.TopLevel = false;
            InsMainFormpanel.FormBorderStyle = FormBorderStyle.None;
            InsMainFormpanel.Dock = DockStyle.Fill;
            f2InsLandingPanel.Controls.Add(InsMainFormpanel);
            f2InsLandingPanel.Tag = InsMainFormpanel;
            InsMainFormpanel.BringToFront();
            InsMainFormpanel.Show();
        }

        private void panel2Design()
        {
            f2InsAcaSubpanel.Visible = false;
            f2InsReqSubpanel.Visible = false;
            f2InsExaSubpanel.Visible = false;
            f2InsLibSubpanel.Visible = false;
        }
        private void panel2Hide()
        {
            if (f2InsAcaSubpanel.Visible == true)
                f2InsAcaSubpanel.Visible = false;
            if (f2InsReqSubpanel.Visible == true)
                f2InsReqSubpanel.Visible = false;
            if (f2InsExaSubpanel.Visible == true)
                f2InsExaSubpanel.Visible = false;
            if (f2InsLibSubpanel.Visible == true)
                f2InsLibSubpanel.Visible = false;
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
            f2InsbtnAcademic.Text = "Academic +";
            f2InsbtnRequest.Text = "Request +";
            f2InsbtnExamMaster.Text = "Exam Master +";
            f2InsbtnLibrary.Text = "Library +";
        }

        private void f2InsbtnDashboard_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsDashboard());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnStudents_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsStudents());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnAcademic_Click(object sender, EventArgs e)
        {
            panel2Show(f2InsAcaSubpanel);
            this.f2InsbtnAcademic.Text = "Academic -";
        }

        private void f2InsbtnSubject_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsSubject());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnClassSched_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsClassched());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnCuriculum_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsCuriculum());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnRequest_Click(object sender, EventArgs e)
        {
            panel2Show(f2InsReqSubpanel);
            this.f2InsbtnRequest.Text = "Request -";
        }

        private void f2InsbtnLeavereq_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsLeavereq());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnShiftreq_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsShiftreq());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnExamMaster_Click(object sender, EventArgs e)
        {
            panel2Show(f2InsExaSubpanel);
            this.f2InsbtnExamMaster.Text = "Exam Master -";
        }
    

        private void f2InsbtnExamsched_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsExamsched());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnReportcard_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsReportCard());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnAttendance_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsAttendance());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnLibrary_Click(object sender, EventArgs e)
        {
            panel2Show(f2InsLibSubpanel);
            this.f2InsbtnLibrary.Text = "Library -";
        }

        private void f2InsbtnFindbook_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsFindBook());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnReturnbook_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsReturnBook());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnEvents_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsEvents());
            panel2Hide();
            panel2PNBtn();
        }

        private void f2InsbtnSchoolfees_Click(object sender, EventArgs e)
        {
            openMainForm1Panel(new f2InsSchoolfees());
            panel2Hide();
            panel2PNBtn();
        }

        
    }
}
