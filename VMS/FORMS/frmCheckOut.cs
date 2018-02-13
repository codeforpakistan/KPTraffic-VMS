using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMS.BC;

namespace VMS.FORMS
{
    public partial class frmCheckOut : Form
    {
        public frmCheckOut()
        {
            InitializeComponent();
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                BC_CheckOut obj = new BC_CheckOut();
                obj.CNIC = txtCNIC.Text;
                obj.BadgeNo = Convert.ToInt32(txtBatchNo.Text);
                DataTable dt = new DataTable();
                dt = obj.GetCheckoutInfo();
                int result = obj.CheckOut(Convert.ToInt32(dt.Rows[0][0].ToString()), Convert.ToInt32(dt.Rows[0][1].ToString()));

                if (result == 1)
                {
                    pictureBox1.Image = convertByteArrayToImage((byte[])dt.Rows[0][4]);
                    MessageBox.Show("Checked Out ", "Record Insertion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    pictureBox1.Image = null;
                    txtBatchNo.Clear();


                }
                else
                {
                    MessageBox.Show("Record Not Inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox1.Image = null;
                    
                }
                txtBatchNo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Check Network \n Check DateTime \n "+ex.ToString().Substring(0,10));
                
            }

       
        }


        private Image convertByteArrayToImage(byte[] byteArrayIn)
        {
            using (var ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
