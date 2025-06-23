namespace Student_Management_System.UI.StudentSubject
{
    partial class StudentSubjectForm
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
            this.txtserch = new System.Windows.Forms.TextBox();
            this.lvwsubject = new System.Windows.Forms.ListView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.lblgrade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtserch
            // 
            this.txtserch.Location = new System.Drawing.Point(28, 75);
            this.txtserch.Name = "txtserch";
            this.txtserch.Size = new System.Drawing.Size(183, 22);
            this.txtserch.TabIndex = 1;
            this.txtserch.Text = "search";
            // 
            // lvwsubject
            // 
            this.lvwsubject.HideSelection = false;
            this.lvwsubject.Location = new System.Drawing.Point(28, 118);
            this.lvwsubject.Name = "lvwsubject";
            this.lvwsubject.Size = new System.Drawing.Size(434, 235);
            this.lvwsubject.TabIndex = 2;
            this.lvwsubject.UseCompatibleStateImageBehavior = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnadd.Location = new System.Drawing.Point(50, 389);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(99, 45);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btndelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btndelete.Location = new System.Drawing.Point(158, 389);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(99, 45);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrefresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnrefresh.Location = new System.Drawing.Point(267, 389);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(99, 45);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnclose.Location = new System.Drawing.Point(372, 389);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(99, 45);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // lblgrade
            // 
            this.lblgrade.BackColor = System.Drawing.Color.DarkBlue;
            this.lblgrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgrade.ForeColor = System.Drawing.Color.White;
            this.lblgrade.Location = new System.Drawing.Point(0, 0);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(512, 51);
            this.lblgrade.TabIndex = 49;
            this.lblgrade.Text = "Pavi\'s Subject";
            this.lblgrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StudentSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 500);
            this.Controls.Add(this.lblgrade);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lvwsubject);
            this.Controls.Add(this.txtserch);
            this.Name = "StudentSubjectForm";
            this.Text = "StudentSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtserch;
        private System.Windows.Forms.ListView lvwsubject;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label lblgrade;
    }
}