using BHU.BussinessClasses;
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

namespace VMS.FORMS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            BC_USERS bcUser = new BC_USERS();
            Control[] ctl = new Control[2];
            ctl[0] = tbUser;
            ctl[1] = tbPassword;
            if (ValidateContorl(ctl))
            {
                DataTable dt = new DataTable();
                this.Hide();

                bcUser.UserName = tbUser.Text.ToLower();
                bcUser.Password = tbPassword.Text;
                dt = bcUser.SelectUser();

                if (dt.Rows.Count > 0)
                {
                    UserData.uid = Convert.ToInt32(dt.Rows[0][0]);

                    int role = Convert.ToInt32(dt.Rows[0][3].ToString());

                    if (role == 1)
                    {
                        frmMainFrom mainForm = new frmMainFrom();
                        mainForm.Show();

                    }
                    else if (role == 2)
                    {


                        frmCheckIn adj = new frmCheckIn();
                        adj.Show();

                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);


                }
            }
        }


          private bool ValidateContorl(Control[] ctl)
        {
            bool checkValidate = true;
            foreach (Control control in ctl)
            {
                if (!superValidator1.Validate(control))
                {
                    checkValidate = false;
                }
            }
            return checkValidate;
        }
    }
    }

