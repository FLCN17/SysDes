namespace DepartmentUI
{
    partial class SearchResults
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExportResults = new System.Windows.Forms.Button();
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._systemDBV2_NewDataSet = new DepartmentUI._systemDBV2_NewDataSet();
            this.studentsTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._systemDBV2_NewDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportResults
            // 
            this.btnExportResults.Location = new System.Drawing.Point(332, 336);
            this.btnExportResults.Name = "btnExportResults";
            this.btnExportResults.Size = new System.Drawing.Size(171, 50);
            this.btnExportResults.TabIndex = 0;
            this.btnExportResults.Text = "Export Results";
            this.btnExportResults.UseVisualStyleBackColor = true;
            this.btnExportResults.Click += new System.EventHandler(this.btnExportResults_Click);
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(43, 78);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.Size = new System.Drawing.Size(744, 239);
            this.studentsDataGridView.TabIndex = 1;
            this.studentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "l_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "f_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "student_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "major";
            this.dataGridViewTextBoxColumn4.HeaderText = "Major";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "concentration";
            this.dataGridViewTextBoxColumn5.HeaderText = "Concentration";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn12.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn13.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this._systemDBV2_NewDataSet;
            // 
            // _systemDBV2_NewDataSet
            // 
            this._systemDBV2_NewDataSet.DataSetName = "_systemDBV2_NewDataSet";
            this._systemDBV2_NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.CertifyTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.EnrollTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Results";
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(842, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentsDataGridView);
            this.Controls.Add(this.btnExportResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SearchResults";
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.SearchResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._systemDBV2_NewDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _systemDBV2_NewDataSet _systemDBV2_NewDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private _systemDBV2_NewDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private _systemDBV2_NewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnExportResults;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Label label1;
    }
}