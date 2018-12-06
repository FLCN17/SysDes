using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
        }
        private void StudentUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_systemDBV2_NewDataSet.Certify' table. You can move, or remove it, as needed.
            this.certifyTableAdapter.Fill(this._systemDBV2_NewDataSet.Certify);
            // TODO: This line of code loads data into the '_systemDBV2_NewDataSet.Certification' table. You can move, or remove it, as needed.
            this.certificationTableAdapter.Fill(this._systemDBV2_NewDataSet.Certification);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstCerts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lstCertSelections.Items.Contains(lstCerts.Text) &&
                (lstCerts.SelectedItem != null))
            {
                var cert = lstCerts.Text.ToString();
                var item = lstCertSelections.Items.Add(cert);
                lstCertSelections.ValueMember.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lstCertSelections.Items.Clear();
        }

        private void lstCertSelections_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtEnterCert.Text != string.Empty)
            {
                txtEnterCert.Clear();
                MessageBox.Show("Your certification has been submitted for review.","Success");
            }
            else
            {
                MessageBox.Show("Please Enter Your Certification","Error");
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (lstCertSelections.Items.Count == 0)
            {
                MessageBox.Show("Please enter your selections", "Error");
            }
            else
            {
                lstCertSelections.Items.Clear();
                MessageBox.Show("Your certifications have been updated.","Success");
            }
            
        }
    }
}
