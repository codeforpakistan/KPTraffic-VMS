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
    class BC_CheckIn
    {


        public string Name { get; set; }
        public string CNIC { get; set; }
        public string Contact { get; set; }
        public string adress { get; set; }
        public string BadgeNo { get; set; }
        public int VisitPurpose { get; set; }
        public  int VisiterID { get; set; }

        public int VisitID { get; set; }

        public int UserID { get; set; }
        public byte[] FaceImage { get; set; }

      
        public int AddCheckIn()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_InsertVisitornChkIN", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VisitorName", Name);
                cmd.Parameters.AddWithValue("@VisitorCNIC", CNIC);
                cmd.Parameters.AddWithValue("@ContactNo", Contact);
                cmd.Parameters.AddWithValue("@BadgeNo",BadgeNo);
              //  cmd.Parameters.AddWithValue("@Admin_NonAdmin", Admin_NonAdmin_ID);
                cmd.Parameters.AddWithValue("@VisitPurpose", VisitPurpose);
                cmd.Parameters.AddWithValue("@VisitorAddress", adress);
                cmd.Parameters.AddWithValue("@EnterByUser_ID", UserData.uid);
                cmd.Parameters.AddWithValue("@VisitorImage",FaceImage);

                cmd.Parameters.AddWithValue("@Office_ID", 3);
                cmd.Parameters.AddWithValue("@HostName", "test");
              //  cmd.Parameters.AddWithValue("@EnterByUser_ID", UserData.uid);
              //  cmd.Parameters.AddWithValue("@EnterByUser_ID", UserID);


                SqlParameter pLastInsertedID = new SqlParameter("@VisitorID", SqlDbType.Int);
                pLastInsertedID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pLastInsertedID);
                pLastInsertedID.Value = "@VisitorID";
                SqlParameter pLastInsertedID1 = new SqlParameter("@VisitID", SqlDbType.Int);
                pLastInsertedID1.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pLastInsertedID1);
                pLastInsertedID1.Value = "@VisitID";
             


                   int result = Convert.ToInt32(cmd.ExecuteNonQuery());

                 VisiterID = Convert.ToInt32(pLastInsertedID.Value);
                VisitID = Convert.ToInt32(pLastInsertedID1.Value);
                DatabaseConnections.CloseConnection();

                return result;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return 0;

            }
        }


        public int UpdateCheckIn()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("usp_updateVisitornChkIN", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VisitorName", Name);
                cmd.Parameters.AddWithValue("@VisitorCNIC", CNIC);
                cmd.Parameters.AddWithValue("@ContactNo", Contact);
                cmd.Parameters.AddWithValue("@BadgeNo", BadgeNo);
                //  cmd.Parameters.AddWithValue("@Admin_NonAdmin", Admin_NonAdmin_ID);
                cmd.Parameters.AddWithValue("@VisitPurpose", VisitPurpose);
                cmd.Parameters.AddWithValue("@VisitorAddress", adress);
                cmd.Parameters.AddWithValue("@EnterByUser_ID", UserID);
                cmd.Parameters.AddWithValue("@VisitorID", VisiterID);

                cmd.Parameters.AddWithValue("@Office_ID", 3);
                cmd.Parameters.AddWithValue("@HostName", "test");
                cmd.Parameters.AddWithValue("@VisitID", VisitID);
                cmd.Parameters.AddWithValue("@EnterByUser_ID", UserData.uid);


                //SqlParameter pLastInsertedID = new SqlParameter("@VisitorID", SqlDbType.Int);
                //pLastInsertedID.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(pLastInsertedID);
                //pLastInsertedID.Value = "@VisitorID";
                //SqlParameter pLastInsertedID1 = new SqlParameter("@VisitID", SqlDbType.Int);
                //pLastInsertedID1.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(pLastInsertedID1);
                //pLastInsertedID1.Value = "@VisitID";



                int result = Convert.ToInt32(cmd.ExecuteNonQuery());

               // VisiterID = Convert.ToInt32(pLastInsertedID.Value);
               // VisitID = Convert.ToInt32(pLastInsertedID1.Value);
                DatabaseConnections.CloseConnection();

                return result;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return 0;

            }
        }


        public DataTable GetAllVisitPurpose()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_getAllVisitPurpose", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter pDriverId = new SqlParameter("@TripId", TripId);
                //cmd.Parameters.Add(pDriverId);
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
        public DataTable GetAllCheckIN()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("getallCheckIN", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter pDriverId = new SqlParameter("@TripId", TripId);
                //cmd.Parameters.Add(pDriverId);
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

        public DataTable GetAllCheckINToday()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("getallCheckINToday", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter pDriverId = new SqlParameter("@TripId", TripId);
                //cmd.Parameters.Add(pDriverId);
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

        public int CheckBadgeIssuance(int bno)
        {
            DataTable ds = new DataTable();
            try
            {
                int result;
                SqlCommand cmd = new SqlCommand("usp_CheckBadgeIssuedOnDate", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pFrom = new SqlParameter("@From",DateTime.Now.Date);
                SqlParameter pTo = new SqlParameter("@To", DateTime.Now.Date);
                SqlParameter pBadge = new SqlParameter("@BadgeNo",bno);
                cmd.Parameters.Add(pFrom);
                cmd.Parameters.Add(pTo);
                cmd.Parameters.Add(pBadge);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);

                DatabaseConnections.CloseConnection();
                if(Convert.ToInt32(ds.Rows[0][0]) == 1)
                {
                    result = 1; // badge is free
                }
                else
                {
                    result = 0; //badge is not free
                }
                return result ;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
        public DataTable SearchByCNIC()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("SearchByCNIC", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pDriverId = new SqlParameter("@CNIC", CNIC);
                cmd.Parameters.Add(pDriverId);
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
