namespace UI
{
    partial class StudentUI
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterCert = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this._systemDBV2_NewDataSet = new DepartmentUI._systemDBV2_NewDataSet();
            this.certificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certificationTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.CertificationTableAdapter();
            this.tableAdapterManager = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager();
            this.lstCerts = new System.Windows.Forms.ListBox();
            this.certificationBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.certificationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.certificationCertifyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.certifyTableAdapter = new DepartmentUI._systemDBV2_NewDataSetTableAdapters.CertifyTableAdapter();
            this.lstCertSelections = new System.Windows.Forms.ListBox();
            this.certificationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.certificationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._systemDBV2_NewDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationCertifyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 41);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Certification";
            // 
            // txtEnterCert
            // 
            this.txtEnterCert.Location = new System.Drawing.Point(33, 279);
            this.txtEnterCert.Multiline = true;
            this.txtEnterCert.Name = "txtEnterCert";
            this.txtEnterCert.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEnterCert.Size = new System.Drawing.Size(401, 109);
            this.txtEnterCert.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(452, 152);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Other: Enter Certification";
            // 
            // _systemDBV2_NewDataSet
            // 
            this._systemDBV2_NewDataSet.DataSetName = "_systemDBV2_NewDataSet";
            this._systemDBV2_NewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // certificationBindingSource
            // 
            this.certificationBindingSource.DataMember = "Certification";
            this.certificationBindingSource.DataSource = this._systemDBV2_NewDataSet;
            // 
            // certificationTableAdapter
            // 
            this.certificationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = this.certificationTableAdapter;
            this.tableAdapterManager.CertifyTableAdapter = null;
            this.tableAdapterManager.CoursesTableAdapter = null;
            this.tableAdapterManager.EnrollTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lstCerts
            // 
            this.lstCerts.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.certificationBindingSource4, "cert_name", true));
            this.lstCerts.DataSource = this.certificationBindingSource3;
            this.lstCerts.DisplayMember = "cert_name";
            this.lstCerts.FormattingEnabled = true;
            this.lstCerts.ItemHeight = 17;
            this.lstCerts.Location = new System.Drawing.Point(33, 54);
            this.lstCerts.Name = "lstCerts";
            this.lstCerts.Size = new System.Drawing.Size(191, 140);
            this.lstCerts.TabIndex = 8;
            this.lstCerts.ValueMember = "cert_name";
            this.lstCerts.SelectedIndexChanged += new System.EventHandler(this.lstCerts_SelectedIndexChanged);
            // 
            // certificationBindingSource4
            // 
            this.certificationBindingSource4.DataMember = "Certification";
            this.certificationBindingSource4.DataSource = this._systemDBV2_NewDataSet;
            // 
            // certificationBindingSource3
            // 
            this.certificationBindingSource3.DataMember = "Certification";
            this.certificationBindingSource3.DataSource = this._systemDBV2_NewDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(243, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Your Selections";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(452, 101);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 45);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(452, 343);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 45);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // certificationCertifyBindingSource
            // 
            this.certificationCertifyBindingSource.DataMember = "CertificationCertify";
            this.certificationCertifyBindingSource.DataSource = this.certificationBindingSource;
            // 
            // certifyTableAdapter
            // 
            this.certifyTableAdapter.ClearBeforeFill = true;
            // 
            // lstCertSelections
            // 
            this.lstCertSelections.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.certificationBindingSource, "cert_name", true));
            this.lstCertSelections.FormattingEnabled = true;
            this.lstCertSelections.ItemHeight = 17;
            this.lstCertSelections.Location = new System.Drawing.Point(243, 54);
            this.lstCertSelections.Name = "lstCertSelections";
            this.lstCertSelections.Size = new System.Drawing.Size(191, 140);
            this.lstCertSelections.TabIndex = 9;
            this.lstCertSelections.SelectedIndexChanged += new System.EventHandler(this.lstCertSelections_SelectedIndexChanged);
            // 
            // certificationBindingSource1
            // 
            this.certificationBindingSource1.DataMember = "Certification";
            // 
            // certificationBindingSource2
            // 
            this.certificationBindingSource2.DataMember = "Certification";
            this.certificationBindingSource2.DataSource = this._systemDBV2_NewDataSet;
            // 
            // StudentUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 429);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstCertSelections);
            this.Controls.Add(this.lstCerts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtEnterCert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StudentUI";
            this.Text = "Student View";
            this.Load += new System.EventHandler(this.StudentUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this._systemDBV2_NewDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationCertifyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterCert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private DepartmentUI._systemDBV2_NewDataSet _systemDBV2_NewDataSet;
        private System.Windows.Forms.BindingSource certificationBindingSource;
        private DepartmentUI._systemDBV2_NewDataSetTableAdapters.CertificationTableAdapter certificationTableAdapter;
        private DepartmentUI._systemDBV2_NewDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ListBox lstCerts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.BindingSource certificationCertifyBindingSource;
        private DepartmentUI._systemDBV2_NewDataSetTableAdapters.CertifyTableAdapter certifyTableAdapter;
        private System.Windows.Forms.ListBox lstCertSelections;
        private System.Windows.Forms.BindingSource certificationBindingSource1;
        private System.Windows.Forms.BindingSource certificationBindingSource2;
        private System.Windows.Forms.BindingSource certificationBindingSource4;
        private System.Windows.Forms.BindingSource certificationBindingSource3;
    }
}