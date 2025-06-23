namespace Student_Management_System.UI.Students
{
    partial class ShowStudentform
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
            this.lblshowstudent = new System.Windows.Forms.Label();
            this.dtpdate_of_birth = new System.Windows.Forms.DateTimePicker();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtadmission = new System.Windows.Forms.TextBox();
            this.lblsubjects = new System.Windows.Forms.Label();
            this.lbldate_of_birth = new System.Windows.Forms.Label();
            this.lblgrade = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbladmission_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblshowstudent
            // 
            this.lblshowstudent.BackColor = System.Drawing.Color.DarkBlue;
            this.lblshowstudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblshowstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowstudent.ForeColor = System.Drawing.Color.White;
            this.lblshowstudent.Location = new System.Drawing.Point(0, 0);
            this.lblshowstudent.Name = "lblshowstudent";
            this.lblshowstudent.Size = new System.Drawing.Size(493, 51);
            this.lblshowstudent.TabIndex = 35;
            this.lblshowstudent.Text = "Pavi\'s Details";
            this.lblshowstudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpdate_of_birth
            // 
            this.dtpdate_of_birth.Font = new System.Drawing.Font("Plantagenet Cherokee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate_of_birth.Location = new System.Drawing.Point(208, 337);
            this.dtpdate_of_birth.Name = "dtpdate_of_birth";
            this.dtpdate_of_birth.Size = new System.Drawing.Size(200, 30);
            this.dtpdate_of_birth.TabIndex = 39;
            // 
            // cmbgrade
            // 
            this.cmbgrade.Font = new System.Drawing.Font("Plantagenet Cherokee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Location = new System.Drawing.Point(206, 277);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(242, 31);
            this.cmbgrade.TabIndex = 38;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(314, 239);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(74, 20);
            this.rdofemale.TabIndex = 37;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(208, 239);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(58, 20);
            this.rdomale.TabIndex = 36;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Location = new System.Drawing.Point(353, 452);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 34;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnexport.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnexport.Location = new System.Drawing.Point(226, 452);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(111, 39);
            this.btnexport.TabIndex = 33;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnprint.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprint.Location = new System.Drawing.Point(97, 452);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(111, 39);
            this.btnprint.TabIndex = 32;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // txtsubject
            // 
            this.txtsubject.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubject.Location = new System.Drawing.Point(208, 385);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(240, 34);
            this.txtsubject.TabIndex = 31;
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(208, 188);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(240, 34);
            this.txtlastname.TabIndex = 30;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(208, 143);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(240, 34);
            this.txtfirstname.TabIndex = 29;
            // 
            // txtadmission
            // 
            this.txtadmission.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmission.Location = new System.Drawing.Point(208, 101);
            this.txtadmission.Name = "txtadmission";
            this.txtadmission.Size = new System.Drawing.Size(240, 34);
            this.txtadmission.TabIndex = 28;
            // 
            // lblsubjects
            // 
            this.lblsubjects.AutoSize = true;
            this.lblsubjects.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjects.Location = new System.Drawing.Point(56, 388);
            this.lblsubjects.Name = "lblsubjects";
            this.lblsubjects.Size = new System.Drawing.Size(85, 28);
            this.lblsubjects.TabIndex = 26;
            this.lblsubjects.Text = "Subjects";
            // 
            // lbldate_of_birth
            // 
            this.lbldate_of_birth.AutoSize = true;
            this.lbldate_of_birth.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate_of_birth.Location = new System.Drawing.Point(56, 331);
            this.lbldate_of_birth.Name = "lbldate_of_birth";
            this.lbldate_of_birth.Size = new System.Drawing.Size(127, 28);
            this.lbldate_of_birth.TabIndex = 25;
            this.lbldate_of_birth.Text = "Date of Birth";
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(56, 277);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(65, 28);
            this.lblgrade.TabIndex = 24;
            this.lblgrade.Text = "Grade";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(56, 234);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(78, 28);
            this.lblgender.TabIndex = 23;
            this.lblgender.Text = "Gender";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(56, 194);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(108, 28);
            this.lbllastname.TabIndex = 22;
            this.lbllastname.Text = "Last Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(56, 149);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(110, 28);
            this.lblfirstname.TabIndex = 27;
            this.lblfirstname.Text = "First Name";
            // 
            // lbladmission_no
            // 
            this.lbladmission_no.AutoSize = true;
            this.lbladmission_no.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmission_no.Location = new System.Drawing.Point(56, 107);
            this.lbladmission_no.Name = "lbladmission_no";
            this.lbladmission_no.Size = new System.Drawing.Size(139, 28);
            this.lbladmission_no.TabIndex = 21;
            this.lbladmission_no.Text = "Admission No";
            // 
            // ShowStudentform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 514);
            this.Controls.Add(this.lblshowstudent);
            this.Controls.Add(this.dtpdate_of_birth);
            this.Controls.Add(this.cmbgrade);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtadmission);
            this.Controls.Add(this.lblsubjects);
            this.Controls.Add(this.lbldate_of_birth);
            this.Controls.Add(this.lblgrade);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lbladmission_no);
            this.Name = "ShowStudentform";
            this.Text = "ShowStudentform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblshowstudent;
        private System.Windows.Forms.DateTimePicker dtpdate_of_birth;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtadmission;
        private System.Windows.Forms.Label lblsubjects;
        private System.Windows.Forms.Label lbldate_of_birth;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbladmission_no;
    }
}