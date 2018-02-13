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
    public partial class frmReportDailyWithImages : Form
    {
        public frmReportDailyWithImages()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
           // usp_GetVisitorDetailsBwDatesTableAdapter.Fill(dbVisManDataSet.usp_GetVisitorDetailsBwDates, dtpFrom.Value.Date, dtpTo.Value.Date);
           // this.usp_GetVisitorDetailsBwDatesTableAdapter1.Fill(this.DataSetWithImages.usp_GetVisitorDetailsBwDates, dtpFrom.Value, dtpTo.Value);
            try
            {
                this.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter.Fill(this.dsVisitorDetailWithImages.usp_GetVisitorDetailsWithImagesBwDates, dtpFrom.Value, dtpTo.Value);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //return 0;

            }
        }

        private void frmReportDailyWithImages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVisitorDetailWithImages.usp_GetVisitorDetailsWithImagesBwDates' table. You can move, or remove it, as needed.
            this.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter.Fill(this.dsVisitorDetailWithImages.usp_GetVisitorDetailsWithImagesBwDates,dtpFrom.Value,dtpTo.Value);
            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'dsVisitorDetailWithImages.usp_GetVisitorDetailsWithImagesBwDates' table. You can move, or remove it, as needed.
            //this.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter.Fill(this.dsVisitorDetailWithImages.usp_GetVisitorDetailsWithImagesBwDates,dtpFrom.Value,dtpTo.Value);
            // TODO: This line of code loads data into the 'dbVisManDataSet.usp_GetVisitorDetailsBwDates' table. You can move, or remove it, as needed.
            //this.usp_GetVisitorDetailsBwDatesTableAdapter.Fill(this.dbVisManDataSet.usp_GetVisitorDetailsBwDates,dtpFrom.Value,dtpTo.Value);
            //reportViewer1.Refresh();

            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();

        }
    }
}
