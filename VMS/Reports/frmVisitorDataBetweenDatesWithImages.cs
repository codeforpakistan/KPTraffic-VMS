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
    public partial class frmVisitorDataBetweenDatesWithImages : Form
    {
        public frmVisitorDataBetweenDatesWithImages()
        {
            InitializeComponent();
        }

        private void frmVisitorDataBetweenDatesWithImages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsVisitorDetailWithImages.usp_GetVisitorDetailsWithImagesBwDates' table. You can move, or remove it, as needed.
            this.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter.Fill(this.dsVisitorDetailWithImages.usp_GetVisitorDetailsWithImagesBwDates,dateTimeInput1.Value,dateTimeInput2.Value);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //this.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter.=
           // this.usp_GetVisitorDetailsWithImagesBwDatesTableAdapter.Fill(this.usp_GetVisitorDetailsWithImagesBwDatesBindingSource,dateTimeInput1.Value,dateTimeInput2.Value);
               //  this.usp_GetVisitorDetailsBwDatesTableAdapter.Fill(this.dbVisManDataSet.usp_GetVisitorDetailsBwDates, dtpFrom.Value, dtpTo.Value);
        }
    }
}
