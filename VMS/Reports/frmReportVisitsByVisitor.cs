using Microsoft.Reporting.WinForms;
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
    public partial class frmReportVisitsByVisitor : Form
    {
        public frmReportVisitsByVisitor()
        {
            InitializeComponent();
        }

        private void frmReportVisitsByVisitor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVisManDataSet1.usp_GetVisitsCountByVisitor' table. You can move, or remove it, as needed.
        //    this.usp_GetVisitsCountByVisitorTableAdapter.Fill(this.dbVisManDataSet1.usp_GetVisitsCountByVisitor, dtpFrom.Value.Date, dtpTo.Value.Date);

         //   this.reportViewer1.RefreshReport();
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            this.usp_GetVisitsCountByVisitorTableAdapter.Fill(this.dbVisManDataSet1.usp_GetVisitsCountByVisitor, dtpFrom.Value.Date, dtpTo.Value.Date);

            
            //dbVisManDataSet1TableAdapters.usp_GetVisitsCountByVisitorTableAdapter da = new dbVisManDataSet1TableAdapters.usp_GetVisitsCountByVisitorTableAdapter();
            //DataTable dt = da.GetData(dtpFrom.Value.Date, dtpTo.Value.Date);
            //reportViewer1.LocalReport.DataSources.Clear();
            //reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            ReportParameter rp1 = new ReportParameter("RptFromDate", dtpFrom.Value.Date.ToShortDateString());
            ReportParameter rp2 = new ReportParameter("RptToDate", dtpTo.Value.Date.ToShortDateString());
            reportViewer1.LocalReport.SetParameters(rp1);
            reportViewer1.LocalReport.SetParameters(rp2);

            this.reportViewer1.RefreshReport();
            //reportViewer1.LocalReport.Refresh();

        }
    }
}
