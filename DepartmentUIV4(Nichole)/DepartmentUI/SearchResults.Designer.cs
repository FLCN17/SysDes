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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.students_QueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._systemDBV2_NewDataSet = new DepartmentUI._systemDBV2_NewDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager();
            this.students_QueryTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.Students_QueryTableAdapter();
            this.programmingQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programmingQueryTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.ProgrammingQueryTableAdapter();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExportResults = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmingQueryDataGridView = new System.Windows.Forms.DataGridView();
            this.programmingQueryTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.students_QueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._systemDBV2_NewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingQueryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingQueryTableAdapterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // students_QueryBindingSource
            // 
            this.students_QueryBindingSource.DataMember = "Students Query";
            this.students_QueryBindingSource.DataSource = this._systemDBV2_NewDataSet;
            // 
            // _systemDBV2_NewDataSet
            // 
            this._systemDBV2_NewDataSet.DataSetName = "_systemDBV2_NewDataSet";
            this._systemDBV2_NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this._systemDBV2_NewDataSet;
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
            // students_QueryTableAdapter
            // 
            this.students_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // programmingQueryBindingSource
            // 
            this.programmingQueryBindingSource.DataMember = "ProgrammingQuery";
            this.programmingQueryBindingSource.DataSource = this._systemDBV2_NewDataSet;
            // 
            // programmingQueryTableAdapter
            // 
            this.programmingQueryTableAdapter.ClearBeforeFill = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExit.Location = new System.Drawing.Point(531, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 58);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExportResults
            // 
            this.btnExportResults.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExportResults.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportResults.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnExportResults.Location = new System.Drawing.Point(240, 332);
            this.btnExportResults.Name = "btnExportResults";
            this.btnExportResults.Size = new System.Drawing.Size(198, 58);
            this.btnExportResults.TabIndex = 0;
            this.btnExportResults.Text = "Export Results";
            this.btnExportResults.UseVisualStyleBackColor = false;
            this.btnExportResults.Click += new System.EventHandler(this.btnExportResults_Click);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn13.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 66;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn12.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 66;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn10.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "concentration";
            this.dataGridViewTextBoxColumn5.HeaderText = "Concentration";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 108;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "major";
            this.dataGridViewTextBoxColumn4.HeaderText = "Major";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 63;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "student_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "Student ID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 87;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "f_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 89;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "l_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 88;
            // 
            // programmingQueryDataGridView
            // 
            this.programmingQueryDataGridView.AllowUserToAddRows = false;
            this.programmingQueryDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.programmingQueryDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.programmingQueryDataGridView.AutoGenerateColumns = false;
            this.programmingQueryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.programmingQueryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.programmingQueryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.programmingQueryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.programmingQueryDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.programmingQueryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.programmingQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programmingQueryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.programmingQueryDataGridView.DataSource = this.programmingQueryBindingSource;
            this.programmingQueryDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.programmingQueryDataGridView.Location = new System.Drawing.Point(61, 47);
            this.programmingQueryDataGridView.Name = "programmingQueryDataGridView";
            this.programmingQueryDataGridView.ReadOnly = true;
            this.programmingQueryDataGridView.Size = new System.Drawing.Size(924, 236);
            this.programmingQueryDataGridView.TabIndex = 2;
            this.programmingQueryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.programmingQueryDataGridView_CellContentClick);
            // 
            // programmingQueryTableAdapterBindingSource
            // 
            this.programmingQueryTableAdapterBindingSource.DataSource = typeof(DepartmentUI._systemDBV2_NewDataSetTableAdapters.ProgrammingQueryTableAdapter);
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 455);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.programmingQueryDataGridView);
            this.Controls.Add(this.btnExportResults);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SearchResults";
            this.Text = "Search Results";
            this.Load += new System.EventHandler(this.SearchResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.students_QueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._systemDBV2_NewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingQueryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programmingQueryTableAdapterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private _systemDBV2_NewDataSet _systemDBV2_NewDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private _systemDBV2_NewDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private _systemDBV2_NewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource students_QueryBindingSource;
        private _systemDBV2_NewDataSetTableAdapters.Students_QueryTableAdapter students_QueryTableAdapter;
        private System.Windows.Forms.BindingSource programmingQueryTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource programmingQueryBindingSource;
        private _systemDBV2_NewDataSetTableAdapters.ProgrammingQueryTableAdapter programmingQueryTableAdapter;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExportResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView programmingQueryDataGridView;
    }
}