namespace Student_Management_System.UI.GradeSubject
{
    partial class SubjectGradeForm
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
            this.cmbsubject = new System.Windows.Forms.ComboBox();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.lblSubjectGrade = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbsubject
            // 
            this.cmbsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubject.FormattingEnabled = true;
            this.cmbsubject.Location = new System.Drawing.Point(153, 77);
            this.cmbsubject.Name = "cmbsubject";
            this.cmbsubject.Size = new System.Drawing.Size(228, 28);
            this.cmbsubject.TabIndex = 56;
            // 
            // cmbgrade
            // 
            this.cmbgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Location = new System.Drawing.Point(153, 129);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(228, 28);
            this.cmbgrade.TabIndex = 57;
            // 
            // lblSubjectGrade
            // 
            this.lblSubjectGrade.BackColor = System.Drawing.Color.DarkBlue;
            this.lblSubjectGrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubjectGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectGrade.ForeColor = System.Drawing.Color.White;
            this.lblSubjectGrade.Location = new System.Drawing.Point(0, 0);
            this.lblSubjectGrade.Name = "lblSubjectGrade";
            this.lblSubjectGrade.Size = new System.Drawing.Size(410, 51);
            this.lblSubjectGrade.TabIndex = 55;
            this.lblSubjectGrade.Text = "Subject Grade";
            this.lblSubjectGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Location = new System.Drawing.Point(280, 181);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 54;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrest.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrest.Location = new System.Drawing.Point(153, 181);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(111, 39);
            this.btnrest.TabIndex = 53;
            this.btnrest.Text = "Rest";
            this.btnrest.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsave.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Location = new System.Drawing.Point(24, 181);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(111, 39);
            this.btnsave.TabIndex = 52;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Subject";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(33, 129);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(65, 28);
            this.lblfirstname.TabIndex = 51;
            this.lblfirstname.Text = "Grade";
            // 
            // SubjectGradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 236);
            this.Controls.Add(this.cmbsubject);
            this.Controls.Add(this.cmbgrade);
            this.Controls.Add(this.lblSubjectGrade);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfirstname);
            this.Name = "SubjectGradeForm";
            this.Text = "SubjectGrade";
            this.Load += new System.EventHandler(this.SubjectGradeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbsubject;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.Label lblSubjectGrade;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblfirstname;
    }
}