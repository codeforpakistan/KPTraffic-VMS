using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficPoliceApp2;
using VMS.BC;
using WebCam_Capture;
using System.IO;
using NUML_UNI_ADMISSION.Forms;
namespace VMS.FORMS
{
    public partial class frmCheckIn : Form
    {

        private WebCam webcam;
        private byte[] imgarray;
        private byte[] imgarray1;
        private bool imageflag = false;

        private string fcimgpth = "";// "file:\\" + MngFormOps.folder_path + "\\newimg.jpeg";
        private string fpimgpth = "";
        private string sgimgpth = "";

        int fimage_width = 0;
        int fimage_height = 0;
        int fimage_dpi = 0;
        public frmCheckIn()
        {
            InitializeComponent();
        }

   

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            try
            {
                // Loading webcam
                imgarray = null;
                imgarray1 = null;
                webcam = new WebCam();
                webcam.InitializeWebCam(ref pictureBox1);
                webcam.Start();

               // BC_CheckIn obj = new BC_CheckIn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }


            BC_CheckIn obj = new BC_CheckIn();
            DataTable dt, dt1 = new DataTable();
            dt = obj.GetAllVisitPurpose();
   
            if (dt.Rows.Count > 0)
            {
                cmbPurpose.DataSource = dt;
                cmbPurpose.DisplayMember = "PurposeName";
                cmbPurpose.ValueMember = "id";
            }
            cmbPurpose.SelectedIndex = 0;
           // cmbPurpose.Text = "Select Visit Purpose";

            dataGridViewX1.DataSource = obj.GetAllCheckINToday();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            BC_CheckIn obj = new BC_CheckIn();
            Control[] ctl = new Control[2];
            ctl[0] = txtName;
            ctl[1] = txtCNIC;
            if (ValidateContorl(ctl))
            {

                obj.Name = txtName.Text;
                obj.CNIC = txtCNIC.Text; 
                obj.Contact = txtContact.Text;
                obj.adress = txtAdress.Text;
                obj.BadgeNo = txtBadgeNo.Text;
                obj.VisitPurpose = Convert.ToInt32(cmbPurpose.SelectedValue);
                capture();
                obj.FaceImage = imgarray;
                obj.UserID = 1;
                int result;
                    if (obj.CheckBadgeIssuance(Convert.ToInt32(obj.BadgeNo)) == 1 ) 
                    {
                        result = obj.AddCheckIn();
                        if (result == 1 || result == 2)
                        {
                            MessageBox.Show("Record Inserted successfully ", "Record Insertion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
                           refresh();
                           imgarray=null;

                        }
                        else
                        {
                            MessageBox.Show("Record Not Inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                            imgarray = null;
                        }
                }
                else
                {
                    MessageBox.Show("Please Change Badge Num, BDGE IS ALREADY ISSUED");
                    webcam.Start();
                }
               

            }
        }

        private void refresh()
        {
            BC_CheckIn obj = new BC_CheckIn();
            txtCNIC.Text = "";
            txtName.Text = "";
            txtAdress.Text = "";
            txtBadgeNo.Text = "";
            txtContact.Text = "";
            cmbPurpose.SelectedIndex = 0;
            dataGridViewX1.DataSource = obj.GetAllCheckINToday();
            imgarray = null;
            imgarray1 = null;
            webcam.Start();
            txtCNIC.Focus();


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

        private void buttonX3_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            imgarray =convertImageToByteArray(pictureBox1.Image);
            webcam.Stop();
            imageflag = true;

            pictureBox1.Image = convertByteArrayToImage(imgarray);
            fcimgpth = "file:\\" + MngFormOps.folder_path_fc + "\\newimg.jpeg";
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            string uripath = fcimgpth;  //"file:\\D:\\PrjPics\\newimg.jpeg";\\
            string localpath = new Uri(uripath).LocalPath;
            bmp.Save(localpath);
        }

        private void capture()
        {
            imgarray = convertImageToByteArray(pictureBox1.Image);
            webcam.Stop();
            imageflag = true;

            pictureBox1.Image = convertByteArrayToImage(imgarray);
            fcimgpth = "file:\\" + MngFormOps.folder_path_fc + "\\newimg.jpeg";
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            string uripath = fcimgpth;  //"file:\\D:\\PrjPics\\newimg.jpeg";\\
            string localpath = new Uri(uripath).LocalPath;
            bmp.Save(localpath);

        }
        private Image convertByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
         private byte[] convertImageToByteArray(System.Drawing.Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                // or whatever output format you like
                return ms.ToArray();
            }
        }

         private void pictureBox1_Click(object sender, EventArgs e)
         {

         }

         private void dataGridViewX1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
             //txtEmployeeID.Text = dataGridViewX1.Rows[e.RowIndex].Cells["EmpID"].Value.ToString();
             txtCNIC.Text = dataGridViewX1.Rows[e.RowIndex].Cells["VisitorCNIC"].Value.ToString();
             txtName.Text = dataGridViewX1.Rows[e.RowIndex].Cells["VisitorName"].Value.ToString();
             txtContact.Text = dataGridViewX1.Rows[e.RowIndex].Cells["ContactNo"].Value.ToString();
             txtAdress.Text = dataGridViewX1.Rows[e.RowIndex].Cells["VisitorAddress"].Value.ToString();
             txtBadgeNo.Text = dataGridViewX1.Rows[e.RowIndex].Cells["BadgeNo"].Value.ToString();
            // dateTimeInput1.Value = Convert.ToDateTime(dataGridViewX1.Rows[e.RowIndex].Cells["JoiningDate"].Value.ToString());
             cmbPurpose.SelectedValue = Convert.ToInt32(dataGridViewX1.Rows[e.RowIndex].Cells["VisitPurpose"].Value.ToString());
            // cmbAdmin.SelectedValue = Convert.ToInt32(dataGridViewX1.Rows[e.RowIndex].Cells["Admin_NonAdmin"].Value.ToString());
             lblVisitorID.Text = dataGridViewX1.Rows[e.RowIndex].Cells["VisitorID"].Value.ToString();
             lblVisitID.Text = dataGridViewX1.Rows[e.RowIndex].Cells["VisitID"].Value.ToString();
                 
                // imgarray1= (byte[])(((dataGridViewX1.Rows[e.RowIndex].Cells["VisitorImage"])));
                // pictureBox1.Image = convertByteArrayToImage(imgarray1);
         }

         private void buttonX4_Click(object sender, EventArgs e)
         {
             BC_CheckIn obj = new BC_CheckIn();
             obj.Name = txtCNIC.Text;
             obj.CNIC = txtName.Text;
             obj.Contact = txtContact.Text;
             obj.adress = txtAdress.Text;
             obj.BadgeNo = txtBadgeNo.Text;
             obj.VisitPurpose = Convert.ToInt32(cmbPurpose.SelectedValue);
            // obj.FaceImage = imgarray;
             obj.VisiterID = Convert.ToInt32(lblVisitorID.Text);
             obj.UserID = 1;
             obj.VisitID = Convert.ToInt32(lblVisitID.Text);

             int result = obj.UpdateCheckIn();
             if (result == 1 || result == 2)
             {
                 MessageBox.Show("Record updated successfully ", "Record Insertion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                 refresh();

             }
             else
             {
                 MessageBox.Show("Record Updation failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
             }
         }

         private void txtCNIC_MouseLeave(object sender, EventArgs e)
         {
             DataTable tb = new DataTable();
             BC_CheckIn obj = new BC_CheckIn();
             obj.CNIC = txtCNIC.Text;
             tb=obj.SearchByCNIC();
             if (tb.Rows.Count > 0)
             {
                 txtName.Text = tb.Rows[0][1].ToString();
                 txtContact.Text = tb.Rows[0][4].ToString();
                 txtAdress.Text = tb.Rows[0][3].ToString();

             }
             else
             {
                
             }
             
         }

         private void frmCheckIn_FormClosing(object sender, FormClosingEventArgs e)
         {
             webcam.Stop();
             
         }

         private void btnRef_Click(object sender, EventArgs e)
         {
             refresh();
         }
    }
}
