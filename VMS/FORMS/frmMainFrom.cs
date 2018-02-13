using NUML_UNI_ADMISSION.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficPoliceApp2;
using VMS.Reports;

namespace VMS.FORMS
{
    public partial class frmMainFrom : Form
    {
        public frmMainFrom()
        {
            InitializeComponent();
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
             frmCheckIn inv = new frmCheckIn();

             if (!MngFormOps.check_open_forms(inv.Name))
             {
                 inv.MdiParent = this;
                 inv.Show();
             }
        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {
            
        }

        private void ribbonBar2_ItemClick(object sender, EventArgs e)
        {
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
          
            frmCheckIn inv = new frmCheckIn();

            if (!MngFormOps.check_open_forms(inv.Name))
            {
                inv.MdiParent = this;
                inv.Show();
            }
            
        }

        private void buttonItem16_Click(object sender, EventArgs e)
        {

            frmCheckOut inv = new frmCheckOut();

            if (!MngFormOps.check_open_forms(inv.Name))
            {
                inv.MdiParent = this;
                inv.Show();
            }
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            frmReportDateWise inv = new frmReportDateWise();

            if (!MngFormOps.check_open_forms(inv.Name))
            {
                inv.MdiParent = this;
                inv.Show();
            }
        }

        private void buttonItem18_Click(object sender, EventArgs e)
        {
            frmReportDailyWithImages inv = new frmReportDailyWithImages();

            if (!MngFormOps.check_open_forms(inv.Name))
            {
                inv.MdiParent = this;
                inv.Show();
            }
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {
            frmUser inv = new frmUser();

            if (!MngFormOps.check_open_forms(inv.Name))
            {
                inv.MdiParent = this;
                inv.Show();
            }
        }

        private void frmMainFrom_Load(object sender, EventArgs e)
        {

        }

        private void buttonItem20_Click(object sender, EventArgs e)
        {
            frmRptCharts inv = new frmRptCharts();

            if (!MngFormOps.check_open_forms(inv.Name))
            {
                inv.MdiParent = this;
                inv.Show();
            }
        }

        private void buttonItem21_Click(object sender, EventArgs e)
        {
            frmReportVisitsByVisitor inv = new frmReportVisitsByVisitor();

            if (!MngFormOps.check_open_forms(inv.Name))
            {
                inv.MdiParent = this;
                inv.Show();
            }
        }

        private void frmMainFrom_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Close();
            }
        }

        private void buttonItem22_Click(object sender, EventArgs e)
        {
           frmReportCheckOutWithBadges inv = new frmReportCheckOutWithBadges();

            if (!MngFormOps.check_open_forms(inv.Name))
            {
                inv.MdiParent = this;
                inv.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
