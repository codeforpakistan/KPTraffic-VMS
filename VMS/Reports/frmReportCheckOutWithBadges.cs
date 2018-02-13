using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMS.Reports
{
    public partial class frmReportCheckOutWithBadges : Form
    {
        public frmReportCheckOutWithBadges()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            try
            {
                this.usp_GetVisitorsCheckOutWithBadgeTableAdapter.Fill(this.dbVisManDataSet3.usp_GetVisitorsCheckOutWithBadge, dtpFrom.Value, dtpTo.Value);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //return 0;

            }
        }
    }
}

           