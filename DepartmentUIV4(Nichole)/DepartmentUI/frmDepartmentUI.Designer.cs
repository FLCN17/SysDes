namespace UI
{
    partial class frmUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstCourse = new System.Windows.Forms.ListBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._systemDBV2_NewDataSet = new DepartmentUI._systemDBV2_NewDataSet();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.certificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lstMajor = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstSelections = new System.Windows.Forms.ListBox();
            this.certificationTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.CertificationTableAdapter();
            this.tableAdapterManager = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager();
            this.certifyTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.CertifyTableAdapter();
            this.coursesTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.CoursesTableAdapter();
            this.certificationCertifyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certificationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lstCert = new System.Windows.Forms.ListBox();
            this.btnStudentView = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lstConcentration = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._systemDBV2_NewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationCertifyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(275, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Certification:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkGreen;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Major";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkGreen;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(499, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Your Selections:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lstCourse
            // 
            this.lstCourse.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.coursesBindingSource, "Course Number", true));
            this.lstCourse.DataSource = this.coursesBindingSource1;
            this.lstCourse.DisplayMember = "Course Number";
            this.lstCourse.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCourse.ItemHeight = 20;
            this.lstCourse.Location = new System.Drawing.Point(47, 418);
            this.lstCourse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(194, 184);
            this.lstCourse.TabIndex = 18;
            this.lstCourse.ValueMember = "Course Number";
            this.lstCourse.SelectedIndexChanged += new System.EventHandler(this.lstCourse_SelectedIndexChanged_1);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this._systemDBV2_NewDataSet;
            // 
            // _systemDBV2_NewDataSet
            // 
            this._systemDBV2_NewDataSet.DataSetName = "_systemDBV2_NewDataSet";
            this._systemDBV2_NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "Courses";
            this.coursesBindingSource1.DataSource = this._systemDBV2_NewDataSet;
            // 
            // certificationBindingSource
            // 
            this.certificationBindingSource.DataMember = "Certification";
            this.certificationBindingSource.DataSource = this._systemDBV2_NewDataSet;
            // 
            // lstMajor
            // 
            this.lstMajor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMajor.FormattingEnabled = true;
            this.lstMajor.ItemHeight = 20;
            this.lstMajor.Items.AddRange(new object[] {
            "Computer Studies",
            "General Education"});
            this.lstMajor.Location = new System.Drawing.Point(47, 178);
            this.lstMajor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMajor.Name = "lstMajor";
            this.lstMajor.Size = new System.Drawing.Size(194, 184);
            this.lstMajor.Sorted = true;
            this.lstMajor.TabIndex = 11;
            this.lstMajor.SelectedIndexChanged += new System.EventHandler(this.lstMajor_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnReset.Location = new System.Drawing.Point(717, 259);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(156, 49);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.Location = new System.Drawing.Point(717, 179);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(156, 51);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(749, 459);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 33);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstSelections
            // 
            this.lstSelections.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSelections.FormattingEnabled = true;
            this.lstSelections.ItemHeight = 20;
            this.lstSelections.Location = new System.Drawing.Point(499, 180);
            this.lstSelections.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstSelections.MultiColumn = true;
            this.lstSelections.Name = "lstSelections";
            this.lstSelections.Size = new System.Drawing.Size(194, 424);
            this.lstSelections.TabIndex = 16;
            // 
            // certificationTableAdapter
            // 
            this.certificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = this.certificationTableAdapter;
            this.tableAdapterManager.CertifyTableAdapter = this.certifyTableAdapter;
            this.tableAdapterManager.CoursesTableAdapter = this.coursesTableAdapter;
            this.tableAdapterManager.EnrollTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // certifyTableAdapter
            // 
            this.certifyTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // certificationCertifyBindingSource
            // 
            this.certificationCertifyBindingSource.DataMember = "CertificationCertify";
            this.certificationCertifyBindingSource.DataSource = this.certificationBindingSource;
            // 
            // certificationBindingSource1
            // 
            this.certificationBindingSource1.DataMember = "Certification";
            this.certificationBindingSource1.DataSource = this._systemDBV2_NewDataSet;
            // 
            // lstCert
            // 
            this.lstCert.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstCert.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.certificationBindingSource1, "cert_name", true));
            this.lstCert.DataSource = this.certificationBindingSource;
            this.lstCert.DisplayMember = "cert_name";
            this.lstCert.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCert.ItemHeight = 20;
            this.lstCert.Location = new System.Drawing.Point(275, 418);
            this.lstCert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstCert.Name = "lstCert";
            this.lstCert.Size = new System.Drawing.Size(194, 184);
            this.lstCert.TabIndex = 17;
            this.lstCert.ValueMember = "cert_name";
            this.lstCert.SelectedIndexChanged += new System.EventHandler(this.lstCert_SelectedIndexChanged);
            // 
            // btnStudentView
            // 
            this.btnStudentView.BackColor = System.Drawing.Color.DarkGray;
            this.btnStudentView.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnStudentView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentView.Location = new System.Drawing.Point(911, 611);
            this.btnStudentView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStudentView.Name = "btnStudentView";
            this.btnStudentView.Size = new System.Drawing.Size(11, 13);
            this.btnStudentView.TabIndex = 19;
            this.btnStudentView.UseVisualStyleBackColor = false;
            this.btnStudentView.Click += new System.EventHandler(this.btnStudentView_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(356, 40);
            this.label5.TabIndex = 20;
            this.label5.Text = "Select Your Search Criteria ";
            // 
            // lstConcentration
            // 
            this.lstConcentration.FormattingEnabled = true;
            this.lstConcentration.ItemHeight = 20;
            this.lstConcentration.Items.AddRange(new object[] {
            "Computer Programming",
            "Cybersecurity"});
            this.lstConcentration.Location = new System.Drawing.Point(275, 178);
            this.lstConcentration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstConcentration.Name = "lstConcentration";
            this.lstConcentration.Size = new System.Drawing.Size(194, 184);
            this.lstConcentration.TabIndex = 21;
            this.lstConcentration.SelectedIndexChanged += new System.EventHandler(this.lstConcentration_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(271, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Concentration";
            // 
            // frmUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(921, 623);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstConcentration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnStudentView);
            this.Controls.Add(this.lstSelections);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lstMajor);
            this.Controls.Add(this.lstCert);
            this.Controls.Add(this.lstCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUI";
            this.Text = "Reporting System";
            this.Load += new System.EventHandler(this.frmUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._systemDBV2_NewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationCertifyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstCourse;
        private System.Windows.Forms.ListBox lstMajor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstSelections;
        private DepartmentUI._systemDBV2_NewDataSet _systemDBV2_NewDataSet;
        private System.Windows.Forms.BindingSource certificationBindingSource;
        private DepartmentUI._systemDBV2_NewDataSetTableAdapters.CertificationTableAdapter certificationTableAdapter;
        private DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DepartmentUI._systemDBV2_NewDataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
        private DepartmentUI._systemDBV2_NewDataSetTableAdapters.CertifyTableAdapter certifyTableAdapter;
        private System.Windows.Forms.BindingSource certificationCertifyBindingSource;
        private System.Windows.Forms.BindingSource certificationBindingSource1;
        private System.Windows.Forms.ListBox lstCert;
        private System.Windows.Forms.Button btnStudentView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstConcentration;
        private System.Windows.Forms.Label label6;
    }
}

