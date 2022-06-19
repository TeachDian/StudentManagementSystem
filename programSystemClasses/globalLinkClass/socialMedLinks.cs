using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.programSystemClasses.globalLinkClass
{
    internal class socialMedLinks
    {
        public socialMedLinks()
        {

        }
        public void GithubLink()
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/TeachDian");
        }
        public void FacebookLink()
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.facebook.com/philip.sabinet0924");
        }
    }
    
}
