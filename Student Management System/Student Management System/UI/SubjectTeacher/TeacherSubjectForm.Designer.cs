namespace Student_Management_System.UI.SubjectTeacher
{
    partial class TeacherSubjectForm
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
            this.lblteachersubject = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lvwsubject = new System.Windows.Forms.ListView();
            this.txtserch = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblteachersubject
            // 
            this.lblteachersubject.BackColor = System.Drawing.Color.DarkBlue;
            this.lblteachersubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblteachersubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblteachersubject.ForeColor = System.Drawing.Color.White;
            this.lblteachersubject.Location = new System.Drawing.Point(0, 0);
            this.lblteachersubject.Name = "lblteachersubject";
            this.lblteachersubject.Size = new System.Drawing.Size(494, 51);
            this.lblteachersubject.TabIndex = 63;
            this.lblteachersubject.Text = "Teacher\'s Subject";
            this.lblteachersubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnclose.Location = new System.Drawing.Point(372, 401);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(99, 45);
            this.btnclose.TabIndex = 59;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrefresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnrefresh.Location = new System.Drawing.Point(267, 401);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(99, 45);
            this.btnrefresh.TabIndex = 60;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btndelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btndelete.Location = new System.Drawing.Point(158, 401);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 45);
            this.btndelete.TabIndex = 61;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnadd.Location = new System.Drawing.Point(50, 401);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(99, 45);
            this.btnadd.TabIndex = 62;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // lvwsubject
            // 
            this.lvwsubject.HideSelection = false;
            this.lvwsubject.Location = new System.Drawing.Point(28, 130);
            this.lvwsubject.Name = "lvwsubject";
            this.lvwsubject.Size = new System.Drawing.Size(434, 235);
            this.lvwsubject.TabIndex = 58;
            this.lvwsubject.UseCompatibleStateImageBehavior = false;
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(28, 87);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(183, 22);
            this.txtserch.TabIndex = 57;
            this.txtserch.Text = "search";
            // 
            // TeacherSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 457);
            this.Controls.Add(this.lblteachersubject);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lvwsubject);
            this.Controls.Add(this.txtserch);
            this.Name = "TeacherSubjectForm";
            this.Text = "TeacherSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblteachersubject;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ListView lvwsubject;
        private System.Windows.Forms.TextBox txtserch;
    }
}