using BHU.BussinessClasses;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMS.FORMS
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        BC_USERS obj = new BC_USERS();
        private void buttonX1_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("insertUser", DatabaseConnections.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", textBoxX1.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxX2.Text);
            cmd.Parameters.AddWithValue("@RoleID",1);
            // con.Open();
            int result = cmd.ExecuteNonQuery();

            DatabaseConnections.CloseConnection();
            if (result == 1)
            {
                MessageBox.Show("Record Inserted successfully ", "Record Insertion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                refresh();

            }
            else
            {
                MessageBox.Show("Record Not Inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void refresh()
        {
            textBoxX1.Text = "";
            textBoxX2.Text = "";
           // cmbRole.SelectedIndex = -1;
            dataGridViewX1.DataSource = obj.getAllUsers();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("usp_UpdateUser", DatabaseConnections.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", textBoxX1.Text);
            cmd.Parameters.AddWithValue("@Password", textBoxX2.Text);
            cmd.Parameters.AddWithValue("@RoleID", 1);
            cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(lblID.Text));
            // con.Open();
            int result = cmd.ExecuteNonQuery();

            DatabaseConnections.CloseConnection();
            if (result == 1)
            {
                MessageBox.Show("Record Updated successfully ", "Record Updation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                refresh();

            }
            else
            {
                MessageBox.Show("Record Not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void dataGridViewX1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxX1.Text = dataGridViewX1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            textBoxX2.Text = dataGridViewX1.Rows[e.RowIndex].Cells["Password"].Value.ToString();
           // cmbRole.SelectedIndex = Convert.ToInt32(dataGridViewX1.Rows[e.RowIndex].Cells["RoleID"].Value.ToString()) - 1;
            lblID.Text = dataGridViewX1.Rows[e.RowIndex].Cells["UserID"].Value.ToString();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "")
            {

                MessageBox.Show("Please Select a record form table");
            }
            else
            {

                SqlCommand cmd = new SqlCommand("usp_deleteUser", DatabaseConnections.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(lblID.Text));

                // con.Open();
                int result = cmd.ExecuteNonQuery();

                DatabaseConnections.CloseConnection();
                if (result == 1)
                {
                    MessageBox.Show("Record Deleted successfully ", "Record Insertion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    refresh();
                }
                else
                {
                    MessageBox.Show("Record Not Deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVisManDataSet2.usp_GetAllUsers' table. You can move, or remove it, as needed.
            this.usp_GetAllUsersTableAdapter.Fill(this.dbVisManDataSet2.usp_GetAllUsers);
            dataGridViewX1.DataSource = obj.getAllUsers();
        }
    }
}
