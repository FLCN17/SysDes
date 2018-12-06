using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentUI
{
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();
        }

        private void studentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._systemDBV2_NewDataSet);

        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_systemDBV2_NewDataSet.Students_Query' table. You can move, or remove it, as needed.
            this.students_QueryTableAdapter.Fill(this._systemDBV2_NewDataSet.Students_Query);
        }

        private void studentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        //Export Results using stream writer. 
        private void btnExportResults_Click(object sender, EventArgs e)
        {

        }

        private void students_QueryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
