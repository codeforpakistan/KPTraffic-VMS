using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMS.BC
{
    class BC_Reports
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int    ID{ get; set; }
        public DataTable GetChkinChkOutforChart()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_GetVisitorsChkInChkOutCount", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pDriverId = new SqlParameter("@From",DateTime.Now.Date);
                cmd.Parameters.Add(pDriverId);

                SqlParameter pDriverId1 = new SqlParameter("@To", DateTime.Now.Date);
                cmd.Parameters.Add(pDriverId1);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                DatabaseConnections.CloseConnection();
                return ds;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ds;
            }

        }

    }
}
