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
    public partial class frmReportDateWise : Form
    {
        public frmReportDateWise()
        {
            InitializeComponent();
        }

        private void frmReportDateWise_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVisManDataSet.usp_GetVisitorDetailsBwDates' table. You can move, or remove it, as needed.
            this.usp_GetVisitorDetailsBwDatesTableAdapter.Fill(this.dbVisManDataSet.usp_GetVisitorDetailsBwDates,dtpFrom.Value,dtpTo.Value);

            this.reportViewer1.RefreshReport();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {

            //dbVisManDataSetTableAdapters.usp_GetVisitorDetailsBwDatesTableAdapter da = new dbVisManDataSetTableAdapters.usp_GetVisitorDetailsBwDatesTableAdapter();
            //dbVisManDataSet.usp_GetVisitorDetailsBwDatesDataTable dt = new VMS.dbVisManDataSet.usp_GetVisitorDetailsBwDatesDataTable();
            //dt.TableName = "mydt";
            //da.Fill(dt, dtpFrom.Value.Date, dtpTo.Value.Date);
            this.usp_GetVisitorDetailsBwDatesTableAdapter.Fill(this.dbVisManDataSet.usp_GetVisitorDetailsBwDates, dtpFrom.Value, dtpTo.Value);

            this.reportViewer1.RefreshReport();



            //uspGetVisitorDetailsBwDatesBindingSource.DataSource =  usp_GetVisitorDetailsBwDatesTableAdapter.Fill(dbVisManDataSet.usp_GetVisitorDetailsBwDates, dtpFrom.Value.Date, dtpTo.Value.Date);
            //var datasource1 = new ReportDataSource("DataSet1",dt);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add();
            this.reportViewer1.RefreshReport();          
          
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
