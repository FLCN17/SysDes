namespace DepartmentUI
{
    partial class CCRIStudentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCRIStudentView));
            this.btnUpdateCerts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdateCerts
            // 
            this.btnUpdateCerts.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCerts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateCerts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateCerts.FlatAppearance.BorderSize = 0;
            this.btnUpdateCerts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnUpdateCerts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdateCerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCerts.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCerts.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpdateCerts.Location = new System.Drawing.Point(30, 1035);
            this.btnUpdateCerts.Name = "btnUpdateCerts";
            this.btnUpdateCerts.Size = new System.Drawing.Size(143, 29);
            this.btnUpdateCerts.TabIndex = 0;
            this.btnUpdateCerts.Text = "Update Certifications";
            this.btnUpdateCerts.UseVisualStyleBackColor = false;
            this.btnUpdateCerts.Click += new System.EventHandler(this.btnUpdateCerts_Click);
            // 
            // CCRIStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1507, 1179);
            this.Controls.Add(this.btnUpdateCerts);
            this.Name = "CCRIStudentView";
            this.Text = "CCRIStudentView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCerts;
    }
}