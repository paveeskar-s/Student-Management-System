namespace Student_Management_System.UI.Students
{
    partial class CreateStudentForm
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
            this.lblcreatestudent = new System.Windows.Forms.Label();
            this.lbladmission_no = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblgrade = new System.Windows.Forms.Label();
            this.lbldate_of_birth = new System.Windows.Forms.Label();
            this.lblsubjects = new System.Windows.Forms.Label();
            this.txtadmission = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.dtpdate_of_birth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblcreatestudent
            // 
            this.lblcreatestudent.BackColor = System.Drawing.Color.DarkBlue;
            this.lblcreatestudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcreatestudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatestudent.ForeColor = System.Drawing.Color.White;
            this.lblcreatestudent.Location = new System.Drawing.Point(0, 0);
            this.lblcreatestudent.Name = "lblcreatestudent";
            this.lblcreatestudent.Size = new System.Drawing.Size(438, 51);
            this.lblcreatestudent.TabIndex = 2;
            this.lblcreatestudent.Text = "Create Student";
            this.lblcreatestudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbladmission_no
            // 
            this.lbladmission_no.AutoSize = true;
            this.lbladmission_no.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmission_no.Location = new System.Drawing.Point(14, 86);
            this.lbladmission_no.Name = "lbladmission_no";
            this.lbladmission_no.Size = new System.Drawing.Size(139, 28);
            this.lbladmission_no.TabIndex = 0;
            this.lbladmission_no.Text = "Admission No";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(14, 128);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(110, 28);
            this.lblfirstname.TabIndex = 0;
            this.lblfirstname.Text = "First Name";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(14, 173);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(108, 28);
            this.lbllastname.TabIndex = 0;
            this.lbllastname.Text = "Last Name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(14, 213);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(78, 28);
            this.lblgender.TabIndex = 0;
            this.lblgender.Text = "Gender";
            // 
            // lblgrade
            // 
            this.lblgrade.AutoSize = true;
            this.lblgrade.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.Location = new System.Drawing.Point(14, 256);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(65, 28);
            this.lblgrade.TabIndex = 0;
            this.lblgrade.Text = "Grade";
            // 
            // lbldate_of_birth
            // 
            this.lbldate_of_birth.AutoSize = true;
            this.lbldate_of_birth.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate_of_birth.Location = new System.Drawing.Point(14, 310);
            this.lbldate_of_birth.Name = "lbldate_of_birth";
            this.lbldate_of_birth.Size = new System.Drawing.Size(127, 28);
            this.lbldate_of_birth.TabIndex = 0;
            this.lbldate_of_birth.Text = "Date of Birth";
            // 
            // lblsubjects
            // 
            this.lblsubjects.AutoSize = true;
            this.lblsubjects.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjects.Location = new System.Drawing.Point(14, 367);
            this.lblsubjects.Name = "lblsubjects";
            this.lblsubjects.Size = new System.Drawing.Size(85, 28);
            this.lblsubjects.TabIndex = 0;
            this.lblsubjects.Text = "Subjects";
            // 
            // txtadmission
            // 
            this.txtadmission.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmission.Location = new System.Drawing.Point(166, 80);
            this.txtadmission.Name = "txtadmission";
            this.txtadmission.Size = new System.Drawing.Size(240, 34);
            this.txtadmission.TabIndex = 1;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(166, 122);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(240, 34);
            this.txtfirstname.TabIndex = 1;
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(166, 167);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(240, 34);
            this.txtlastname.TabIndex = 1;
            // 
            // txtsubject
            // 
            this.txtsubject.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubject.Location = new System.Drawing.Point(166, 364);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(240, 34);
            this.txtsubject.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsave.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Location = new System.Drawing.Point(57, 440);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(111, 39);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrest.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrest.Location = new System.Drawing.Point(186, 440);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(111, 39);
            this.btnrest.TabIndex = 2;
            this.btnrest.Text = "Rest";
            this.btnrest.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Location = new System.Drawing.Point(313, 440);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(166, 218);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(58, 20);
            this.rdomale.TabIndex = 3;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(272, 218);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(74, 20);
            this.rdofemale.TabIndex = 3;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // cmbgrade
            // 
            this.cmbgrade.Font = new System.Drawing.Font("Plantagenet Cherokee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Location = new System.Drawing.Point(164, 256);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(242, 31);
            this.cmbgrade.TabIndex = 4;
            // 
            // dtpdate_of_birth
            // 
            this.dtpdate_of_birth.Font = new System.Drawing.Font("Plantagenet Cherokee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate_of_birth.Location = new System.Drawing.Point(166, 316);
            this.dtpdate_of_birth.Name = "dtpdate_of_birth";
            this.dtpdate_of_birth.Size = new System.Drawing.Size(200, 30);
            this.dtpdate_of_birth.TabIndex = 5;
            // 
            // CreateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(438, 489);
            this.Controls.Add(this.lblcreatestudent);
            this.Controls.Add(this.dtpdate_of_birth);
            this.Controls.Add(this.cmbgrade);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnsave);
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
            this.Name = "CreateStudentForm";
            this.Text = "CreateStudentForm";
            this.Load += new System.EventHandler(this.CreateStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbladmission_no;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Label lbldate_of_birth;
        private System.Windows.Forms.Label lblsubjects;
        private System.Windows.Forms.TextBox txtadmission;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Label lblcreatestudent;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.DateTimePicker dtpdate_of_birth;
    }
}