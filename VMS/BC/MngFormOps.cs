using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NUML_UNI_ADMISSION.Forms
{
    public static class MngFormOps
    {
        #region Form operations

        public const string proceed_msg = "Do You Want To Proceed";
        public const string update_msg = "Do You Want To Update";
        public const string delete_msg = "Do You Want To Delete";
        public const string success_msg = "Row inserted successfully";
        public const string failure_msg = "Unsuccessful";
        public static string folder_path_fc = "C:\\Pics";
        //public static string folder_path_fp = "D:\\TrfcPrjPics\\Fps";
        //public static string folder_path_sn = "D:\\TrfcPrjPics\\Signs";

        public static bool check_open_forms(string fname)
        {
            FormCollection fc = Application.OpenForms;
            bool formfound = false;

            foreach (Form f in fc)
            {
                if (f.Name.Equals(fname))
                {
                    if (f.WindowState == FormWindowState.Minimized)
                    {
                        f.WindowState = FormWindowState.Normal;
                       
                    }

                    f.Activate();
                    formfound = true;
                    break;
                }

            }

            return formfound;
        }

        public static bool check_empty_textboxes(Form f)
        {
            bool myFlag = false;

            //ControlCollection cc = new ControlCollection(this);
            foreach (Control cc in f.Controls)
            {
                foreach (Control c in cc.Controls)
                    if (c is TextBox)
                        if (!((TextBox)c).ReadOnly)     // Value in Textboxes which are Readonly, e.g tbId, is not entered by User, therfore they are not checked..                               //if( !c.Name.Equals("tbId") )       // not generic, do something for it.  
                            if (c.Text.Trim().Length.Equals(0))
                            {
                                MessageBox.Show(" Textbox Is Empty  \n\n Or You Are Typing Blank Spaces \n\n Please Check ");
                                c.Focus();
                                myFlag = true;
                                break;
                            }

            }

            if (myFlag)
                return true;
            else
                return false;

            //var tb = from controls in this.Controls.ofType(

        }

        public static bool check_wrong_input(TextBox t)
        {
            if (t.Text == "0" || t.Text.Contains("-") || t.Text == " ")
            {
                MessageBox.Show("You cannot enter 0 or negative number");
                t.Clear();
                t.Focus();
                return false;
            }
            else
                return true;
        }
        # endregion
    }
}
