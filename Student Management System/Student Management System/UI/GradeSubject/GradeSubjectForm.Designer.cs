namespace Student_Management_System.UI.GradeSubject
{
    partial class GradeSubjectForm
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
            this.lblgrade = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbgrade = new System.Windows.Forms.ComboBox();
            this.cmbsubject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblgrade
            // 
            this.lblgrade.BackColor = System.Drawing.Color.DarkBlue;
            this.lblgrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.ForeColor = System.Drawing.Color.White;
            this.lblgrade.Location = new System.Drawing.Point(0, 0);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(417, 51);
            this.lblgrade.TabIndex = 48;
            this.lblgrade.Text = "Grade Subject";
            this.lblgrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Location = new System.Drawing.Point(289, 215);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 47;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrest.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrest.Location = new System.Drawing.Point(162, 215);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(111, 39);
            this.btnrest.TabIndex = 46;
            this.btnrest.Text = "Rest";
            this.btnrest.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsave.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Location = new System.Drawing.Point(33, 215);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(111, 39);
            this.btnsave.TabIndex = 45;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(45, 92);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(65, 28);
            this.lblfirstname.TabIndex = 43;
            this.lblfirstname.Text = "Grade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Subject";
            // 
            // cmbgrade
            // 
            this.cmbgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgrade.FormattingEnabled = true;
            this.cmbgrade.Location = new System.Drawing.Point(165, 92);
            this.cmbgrade.Name = "cmbgrade";
            this.cmbgrade.Size = new System.Drawing.Size(192, 28);
            this.cmbgrade.TabIndex = 49;
            // 
            // cmbsubject
            // 
            this.cmbsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsubject.FormattingEnabled = true;
            this.cmbsubject.Location = new System.Drawing.Point(165, 151);
            this.cmbsubject.Name = "cmbsubject";
            this.cmbsubject.Size = new System.Drawing.Size(192, 28);
            this.cmbsubject.TabIndex = 49;
            // 
            // GradeSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 281);
            this.Controls.Add(this.cmbsubject);
            this.Controls.Add(this.cmbgrade);
            this.Controls.Add(this.lblgrade);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfirstname);
            this.Name = "GradeSubjectForm";
            this.Text = "GradeSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbgrade;
        private System.Windows.Forms.ComboBox cmbsubject;
    }
}