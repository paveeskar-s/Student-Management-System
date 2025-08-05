namespace Student_Management_System.UI.Teachers
{
    partial class EditTeachersForm
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
            this.lblteacheredit = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtpdate_of_birth = new System.Windows.Forms.DateTimePicker();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelephone_no = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtnic_no = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.lblnic_no = new System.Windows.Forms.Label();
            this.lbldate_of_birth = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblteacheredit
            // 
            this.lblteacheredit.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblteacheredit.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblteacheredit.Font = new System.Drawing.Font("Mongolian Baiti", 16.8F, System.Drawing.FontStyle.Bold);
            this.lblteacheredit.ForeColor = System.Drawing.Color.White;
            this.lblteacheredit.Location = new System.Drawing.Point(0, 0);
            this.lblteacheredit.Name = "lblteacheredit";
            this.lblteacheredit.Size = new System.Drawing.Size(404, 51);
            this.lblteacheredit.TabIndex = 42;
            this.lblteacheredit.Text = "Teacher\'s Edit";
            this.lblteacheredit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Student_Management_System.Properties.Resources.close35;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(301, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 59);
            this.button1.TabIndex = 65;
            this.button1.Text = "        Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::Student_Management_System.Properties.Resources.rest30;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(185, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 59);
            this.button2.TabIndex = 63;
            this.button2.Text = "     Reset";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = global::Student_Management_System.Properties.Resources._30save;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(69, 411);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 59);
            this.button3.TabIndex = 64;
            this.button3.Text = "        Save";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dtpdate_of_birth
            // 
            this.dtpdate_of_birth.Font = new System.Drawing.Font("Plantagenet Cherokee", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdate_of_birth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate_of_birth.Location = new System.Drawing.Point(162, 233);
            this.dtpdate_of_birth.Name = "dtpdate_of_birth";
            this.dtpdate_of_birth.Size = new System.Drawing.Size(240, 30);
            this.dtpdate_of_birth.TabIndex = 62;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(268, 154);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(74, 20);
            this.rdofemale.TabIndex = 61;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(162, 154);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(58, 20);
            this.rdomale.TabIndex = 60;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(162, 364);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(240, 34);
            this.txtemail.TabIndex = 57;
            // 
            // txttelephone_no
            // 
            this.txttelephone_no.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelephone_no.Location = new System.Drawing.Point(162, 320);
            this.txttelephone_no.Name = "txttelephone_no";
            this.txttelephone_no.Size = new System.Drawing.Size(240, 34);
            this.txttelephone_no.TabIndex = 59;
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(162, 278);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(240, 34);
            this.txtaddress.TabIndex = 56;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(15, 370);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 28);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "Email";
            // 
            // txtnic_no
            // 
            this.txtnic_no.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic_no.Location = new System.Drawing.Point(162, 187);
            this.txtnic_no.Name = "txtnic_no";
            this.txtnic_no.Size = new System.Drawing.Size(240, 34);
            this.txtnic_no.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 52;
            this.label2.Text = "Telephone No";
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(162, 103);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(240, 34);
            this.txtlastname.TabIndex = 55;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(10, 284);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(83, 28);
            this.lbladdress.TabIndex = 51;
            this.lbladdress.Text = "Address";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstname.Location = new System.Drawing.Point(162, 58);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(240, 34);
            this.txtfirstname.TabIndex = 54;
            // 
            // lblnic_no
            // 
            this.lblnic_no.AutoSize = true;
            this.lblnic_no.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnic_no.Location = new System.Drawing.Point(11, 193);
            this.lblnic_no.Name = "lblnic_no";
            this.lblnic_no.Size = new System.Drawing.Size(82, 28);
            this.lblnic_no.TabIndex = 50;
            this.lblnic_no.Text = "NIC No";
            // 
            // lbldate_of_birth
            // 
            this.lbldate_of_birth.AutoSize = true;
            this.lbldate_of_birth.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate_of_birth.Location = new System.Drawing.Point(10, 236);
            this.lbldate_of_birth.Name = "lbldate_of_birth";
            this.lbldate_of_birth.Size = new System.Drawing.Size(127, 28);
            this.lbldate_of_birth.TabIndex = 48;
            this.lbldate_of_birth.Text = "Date of Birth";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(10, 149);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(78, 28);
            this.lblgender.TabIndex = 47;
            this.lblgender.Text = "Gender";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(10, 109);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(108, 28);
            this.lbllastname.TabIndex = 46;
            this.lbllastname.Text = "Last Name";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(10, 64);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(110, 28);
            this.lblfirstname.TabIndex = 53;
            this.lblfirstname.Text = "First Name";
            // 
            // EditTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 469);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dtpdate_of_birth);
            this.Controls.Add(this.rdofemale);
            this.Controls.Add(this.rdomale);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelephone_no);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtnic_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.lblnic_no);
            this.Controls.Add(this.lbldate_of_birth);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lblteacheredit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditTeachersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblteacheredit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtpdate_of_birth;
        private System.Windows.Forms.RadioButton rdofemale;
        private System.Windows.Forms.RadioButton rdomale;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelephone_no;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtnic_no;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label lblnic_no;
        private System.Windows.Forms.Label lbldate_of_birth;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblfirstname;
    }
}