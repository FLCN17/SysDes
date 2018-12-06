using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentUI;

namespace UI
{
    public partial class frmUI : Form
    {
        public frmUI()
        {
            InitializeComponent();
        }

        //Reset Button
        private void btnReset_Click(object sender, EventArgs e)
        {
            lstSelections.Items.Clear();
        }

        //Form Load
        private void frmUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_systemDBV2_NewDataSet.Certify' table. You can move, or remove it, as needed.
            this.certifyTableAdapter.Fill(this._systemDBV2_NewDataSet.Certify);
            // TODO: This line of code loads data into the '_systemDBV2_NewDataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this._systemDBV2_NewDataSet.Courses);
            // TODO: This line of code loads data into the '_systemDBV2_NewDataSet.Certification' table. You can move, or remove it, as needed.
            this.certificationTableAdapter.Fill(this._systemDBV2_NewDataSet.Certification);

        }

        //Change (click) event on Major.
        private void lstMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lstSelections.Items.Contains(lstMajor.Text)&& 
                (lstMajor.SelectedItem != null))
            {
                var major = lstMajor.Text.ToString();
                var item = lstSelections.Items.Add(major);
                lstSelections.ValueMember.ToString();
            } 
        }

        //Exit button clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }       

        //Change (click) event on Course.
        private void lstCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!lstSelections.Items.Contains(lstCourse.Text) &&
                (lstCourse.SelectedItem != null))
            {
                var course = lstCourse.Text.ToString();
                var item = lstSelections.Items.Add(course);
                lstSelections.ValueMember.ToString();
            }
        }

        //Change (click) event on Certifications.
        private void lstCert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lstSelections.Items.Contains(lstCert.Text) &&
                (lstCert.SelectedItem != null))
            {
                var cert = lstCert.Text.ToString();
                var item = lstSelections.Items.Add(cert);
                lstSelections.ValueMember.ToString();
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.certificationTableAdapter.Fill(this._systemDBV2_NewDataSet.Certification);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //Search Button Clicked.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(lstSelections.Items.Count != 0)
            {
                SearchResults sResults = new SearchResults();
                sResults.Show();
            }
            else
            {
                MessageBox.Show("Enter Search Criteria", "Error");
            }
            
        }

        //Hidden Shortcut to studentView for CCRI Website
        private void btnStudentView_Click(object sender, EventArgs e)
        {
            CCRIStudentView ccriStudentView = new CCRIStudentView();
            ccriStudentView.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lstConcentration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lstSelections.Items.Contains(lstConcentration.Text) &&
                (lstMajor.SelectedItem != null))
            {
                var concentration = lstConcentration.Text.ToString();
                var item = lstSelections.Items.Add(concentration);
                lstSelections.ValueMember.ToString();
            }
        }
    }
}
