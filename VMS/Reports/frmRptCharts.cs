using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMS.BC;

namespace VMS.Reports
{
    public partial class frmRptCharts : Form
    {
        public frmRptCharts()
        {
            InitializeComponent();
        }

        private void frmRptCharts_Load(object sender, EventArgs e)
        {
            CallValues(); 
        }

        private void CallValues()
        {
            BC_Reports obj = new BC_Reports();
            DataTable dt = obj.GetChkinChkOutforChart();
            chart1.DataSource = dt;

            chart1.Series["ChkIn"].XValueMember = "RptDate";
            chart1.Series["ChkIn"].YValueMembers = "ChkIns";
            chart1.Series["ChkOut"].XValueMember = "RptDate";
            chart1.Series["ChkOut"].YValueMembers = "ChkOuts";

            this.chart1.Titles.Add("No. of Visitors Check In Check Out");
            //chartVal1.Series["Salary"].ChartType = SeriesChartType.Bar;
            chart1.Series["ChkIn"].IsValueShownAsLabel = true;
            chart1.Series["ChkOut"].IsValueShownAsLabel = true;

            DataTable table = new DataTable();
            table.Columns.Add("Visitors");
            table.Columns.Add("RptDate");

            //table.Rows.Add()
            //DataRow dr = new DataRow();

            table.Rows.Add(dt.Rows[0][0], dt.Rows[0][2]);
            table.Rows.Add(dt.Rows[0][1], dt.Rows[0][2]);
            //table.Rows.Add(ds.Tables[0].Columns["2004"].ColumnName, ds.Tables[0].Rows[0]["2004"]); 

            chart2.DataSource = table;

            chart2.Series["ChkIn"].XValueMember = "RptDate";
            chart2.Series["ChkIn"].YValueMembers = "Visitors";
            //chart2.Series["ChkOut"].XValueMember = "RptDate";
            //chart2.Series["ChkOut"].YValueMembers = "ChkOuts";

            this.chart2.Titles.Add("No. of Visitors Check In Check Out");
        }

    }
}
