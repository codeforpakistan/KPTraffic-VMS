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
    class BC_CheckOut
    {
        public string CNIC { get; set; }
        public int BadgeNo { get; set; }

        public int CheckOut(int visitID, int visiterID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_CheckOutVisitor", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@Badge", BadgeNo);
                cmd.Parameters.AddWithValue("@VisitID", visitID);
                cmd.Parameters.AddWithValue("@UserID", 2);
                
                // cmd.Parameters.AddWithValue("@EnterByUser_ID", UserID);
                //  cmd.Parameters.AddWithValue("@EnterByUser_ID", UserID);






                int result = Convert.ToInt32(cmd.ExecuteNonQuery());
                DatabaseConnections.CloseConnection();

                return result;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return 0;

            }
        }

        public DataTable GetCheckoutInfo()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_getCheckOutPersonInfo", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pDriverId = new SqlParameter("@Badge", BadgeNo);
                cmd.Parameters.Add(pDriverId);
                SqlParameter pDriverId1 = new SqlParameter("@CDate", DateTime.Now);
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
