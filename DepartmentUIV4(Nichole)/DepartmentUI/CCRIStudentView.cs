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
using UI;

namespace DepartmentUI
{
    public partial class CCRIStudentView : Form
    {
        public CCRIStudentView()
        {
            InitializeComponent();
        }

        private void btnUpdateCerts_Click(object sender, EventArgs e)
        {
            StudentUI studentUI = new StudentUI();
            studentUI.Show();
        }
    }
}
