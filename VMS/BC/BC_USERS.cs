using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace BHU.BussinessClasses
{
    class BC_USERS
    {
        public String UserName { get; set; }
        public string Password { get; set; }
        public DataTable SelectUser()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_SelectUser", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter pUserName = new SqlParameter("@userName", UserName);
                cmd.Parameters.Add(pUserName);
                SqlParameter pPassword = new SqlParameter("@password", Password);
                cmd.Parameters.Add(pPassword);
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


        public DataTable getAllUsers()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_GetAllUsers", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter pDriverId = new SqlParameter("@VehicleId", VehicleId);
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

        public DataTable getAllRoles()
        {
            DataTable ds = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("getAllRole", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                //SqlParameter pDriverId = new SqlParameter("@VehicleId", VehicleId);
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
    }
}
