namespace Student_Management_System.UI.Students
{
    partial class EditStudentForm
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
            this.lbledit = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.dtpdate_of_addmission = new System.Windows.Forms.DateTimePicker();
            this.dtpdate_of_birth = new System.Windows.Forms.DateTimePicker();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelephone_no = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtadmission = new System.Windows.Forms.TextBox();
            this.lbldateofaddmission = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbldate_of_birth = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbltelephoneno = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lbladmission_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbledit
            // 
            this.lbledit.BackColor = System.Drawing.SystemColors.GrayText;
            this.lbledit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbledit.Font = new System.Drawing.Font("Mongolian Baiti", 16.8F, System.Drawing.FontStyle.Bold);
            this.lbledit.ForeColor = System.Drawing.Color.White;
            this.lbledit.Location = new System.Drawing.Point(0, 0);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(448, 51);
            this.lbledit.TabIndex = 20;
            this.lbledit.Text = "Pavi\'s Edit";
            this.lbledit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Image = global::Student_Management_System.Properties.Resources.close35;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(336, 460);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(105, 59);
            this.btnclose.TabIndex = 61;
            this.btnclose.Text = "        Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // dtpdate_of_addmission
            // 
            this.dtpdate_of_addmission.Font = new System.Drawing.Font("Plantagenet Cherokee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate_of_addmission.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate_of_addmission.Location = new System.Drawing.Point(201, 411);
            this.dtpdate_of_addmission.Name = "dtpdate_of_addmission";
            this.dtpdate_of_addmission.Size = new System.Drawing.Size(240, 30);
            this.dtpdate_of_addmission.TabIndex = 60;
            // 
            // dtpdate_of_birth
            // 
            this.dtpdate_of_birth.Font = new System.Drawing.Font("Plantagenet Cherokee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate_of_birth.Location = new System.Drawing.Point(201, 365);
            this.dtpdate_of_birth.Name = "dtpdate_of_birth";
            this.dtpdate_of_birth.Size = new System.Drawing.Size(240, 30);
            this.dtpdate_of_birth.TabIndex = 59;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(355, 200);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(74, 20);
            this.rdofemale.TabIndex = 58;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(208, 198);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(58, 20);
            this.rdomale.TabIndex = 57;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrest.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrest.Image = global::Student_Management_System.Properties.Resources.rest30;
            this.btnrest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrest.Location = new System.Drawing.Point(220, 460);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(105, 59);
            this.btnrest.TabIndex = 56;
            this.btnrest.Text = "     Reset";
            this.btnrest.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsave.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Image = global::Student_Management_System.Properties.Resources._30save;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(104, 460);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(105, 59);
            this.btnsave.TabIndex = 55;
            this.btnsave.Text = "        Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(201, 315);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(240, 34);
            this.txtaddress.TabIndex = 53;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(201, 275);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(240, 34);
            this.txtemail.TabIndex = 52;
            // 
            // txttelephone_no
            // 
            this.txttelephone_no.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelephone_no.Location = new System.Drawing.Point(203, 229);
            this.txttelephone_no.Name = "txttelephone_no";
            this.txttelephone_no.Size = new System.Drawing.Size(240, 34);
            this.txttelephone_no.TabIndex = 54;
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(201, 149);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(240, 34);
            this.txtlastname.TabIndex = 51;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(201, 104);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(240, 34);
            this.txtfirstname.TabIndex = 50;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(10, 316);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(83, 28);
            this.lbladdress.TabIndex = 47;
            this.lbladdress.Text = "Address";
            // 
            // txtadmission
            // 
            this.txtadmission.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmission.Location = new System.Drawing.Point(201, 62);
            this.txtadmission.Name = "txtadmission";
            this.txtadmission.Size = new System.Drawing.Size(240, 34);
            this.txtadmission.TabIndex = 49;
            // 
            // lbldateofaddmission
            // 
            this.lbldateofaddmission.AutoSize = true;
            this.lbldateofaddmission.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofaddmission.Location = new System.Drawing.Point(6, 412);
            this.lbldateofaddmission.Name = "lbldateofaddmission";
            this.lbldateofaddmission.Size = new System.Drawing.Size(188, 28);
            this.lbldateofaddmission.TabIndex = 46;
            this.lbldateofaddmission.Text = "Date of Addmission";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(10, 276);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(64, 28);
            this.lblemail.TabIndex = 45;
            this.lblemail.Text = "Email";
            // 
            // lbldate_of_birth
            // 
            this.lbldate_of_birth.AutoSize = true;
            this.lbldate_of_birth.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate_of_birth.Location = new System.Drawing.Point(6, 366);
            this.lbldate_of_birth.Name = "lbldate_of_birth";
            this.lbldate_of_birth.Size = new System.Drawing.Size(127, 28);
            this.lbldate_of_birth.TabIndex = 44;
            this.lbldate_of_birth.Text = "Date of Birth";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(8, 193);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(78, 28);
            this.lblgender.TabIndex = 43;
            this.lblgender.Text = "Gender";
            // 
            // lbltelephoneno
            // 
            this.lbltelephoneno.AutoSize = true;
            this.lbltelephoneno.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelephoneno.Location = new System.Drawing.Point(10, 233);
            this.lbltelephoneno.Name = "lbltelephoneno";
            this.lbltelephoneno.Size = new System.Drawing.Size(106, 28);
            this.lbltelephoneno.TabIndex = 42;
            this.lbltelephoneno.Text = "Telephone";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(8, 153);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(108, 28);
            this.lbllastname.TabIndex = 41;
            this.lbllastname.Text = "Last Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(8, 108);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(110, 28);
            this.lblfirstname.TabIndex = 48;
            this.lblfirstname.Text = "First Name";
            // 
            // lbladmission_no
            // 
            this.lbladmission_no.AutoSize = true;
            this.lbladmission_no.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladmission_no.Location = new System.Drawing.Point(8, 66);
            this.lbladmission_no.Name = "lbladmission_no";
            this.lbladmission_no.Size = new System.Drawing.Size(139, 28);
            this.lbladmission_no.TabIndex = 40;
            this.lbladmission_no.Text = "Admission No";
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 522);
            this.ControlBox = false;
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dtpdate_of_addmission);
            this.Controls.Add(this.dtpdate_of_birth);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelephone_no);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtadmission);
            this.Controls.Add(this.lbldateofaddmission);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lbldate_of_birth);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbltelephoneno);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lbladmission_no);
            this.Controls.Add(this.lbledit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditStudentForm";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbledit;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DateTimePicker dtpdate_of_addmission;
        private System.Windows.Forms.DateTimePicker dtpdate_of_birth;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelephone_no;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtadmission;
        private System.Windows.Forms.Label lbldateofaddmission;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbldate_of_birth;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbltelephoneno;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lbladmission_no;
    }
}