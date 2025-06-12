using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjStudInfoSys;

namespace NewClgAttdMgnmt
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
          
            
        }

        private void studentAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach(Form f in Application.OpenForms)
            {
                if (f.Text == "Student Attendance")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if(Isopen==false)
            {
                    StdAttd obj = new StdAttd();
                    obj.Show();
            }
             //this.Enabled = false;
        }

        private void manageStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Student Personal Information")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                frmStudPerInfo obj = new frmStudPerInfo();
                obj.Show();
            } 
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Student Course Information")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                addClass obj = new addClass();
                obj.Show();
            } 
        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool Isopen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Student Report")
                {
                    Isopen = true;
                    f.Focus();
                    break;
                }
            }
            if (Isopen == false)
            {
                Clg_Report obj = new Clg_Report();
                obj.Show();
            } 
        }

        private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to exit","", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true ;
            }
       
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();           
         }


    }
}
