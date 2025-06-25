namespace Student_Management_System.UI.SubjectTeacher
{
    partial class SubjectTeacherForm
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
            this.lvwsubject = new System.Windows.Forms.ListView();
            this.lblsubjectteacher = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwsubject
            // 
            this.lvwsubject.HideSelection = false;
            this.lvwsubject.Location = new System.Drawing.Point(3, 96);
            this.lvwsubject.Name = "lvwsubject";
            this.lvwsubject.Size = new System.Drawing.Size(698, 235);
            this.lvwsubject.TabIndex = 87;
            this.lvwsubject.UseCompatibleStateImageBehavior = false;
            // 
            // lblsubjectteacher
            // 
            this.lblsubjectteacher.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblsubjectteacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblsubjectteacher.Font = new System.Drawing.Font("Mongolian Baiti", 16.8F, System.Drawing.FontStyle.Bold);
            this.lblsubjectteacher.ForeColor = System.Drawing.Color.White;
            this.lblsubjectteacher.Location = new System.Drawing.Point(0, 0);
            this.lblsubjectteacher.Name = "lblsubjectteacher";
            this.lblsubjectteacher.Size = new System.Drawing.Size(704, 51);
            this.lblsubjectteacher.TabIndex = 86;
            this.lblsubjectteacher.Text = "Subject Teacher";
            this.lblsubjectteacher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.SystemColors.Control;
            this.t.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(3, 61);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(217, 29);
            this.t.TabIndex = 94;
            this.t.Text = "Search ";
            // 
            // btnsearch
            // 
            this.btnsearch.Image = global::Student_Management_System.Properties.Resources.serch201;
            this.btnsearch.Location = new System.Drawing.Point(216, 61);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(54, 31);
            this.btnsearch.TabIndex = 95;
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Image = global::Student_Management_System.Properties.Resources.close35;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(586, 337);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(115, 59);
            this.btnclose.TabIndex = 88;
            this.btnclose.Text = "      Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrefresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnrefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrefresh.Image = global::Student_Management_System.Properties.Resources._40refresh;
            this.btnrefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrefresh.Location = new System.Drawing.Point(469, 337);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(115, 59);
            this.btnrefresh.TabIndex = 89;
            this.btnrefresh.Text = "        Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btndelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Image = global::Student_Management_System.Properties.Resources.delete30;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(351, 337);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 59);
            this.btndelete.TabIndex = 90;
            this.btndelete.Text = "    Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Image = global::Student_Management_System.Properties.Resources.add40;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(2, 334);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 59);
            this.btnadd.TabIndex = 91;
            this.btnadd.Text = "      Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnprint.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprint.Image = global::Student_Management_System.Properties.Resources.print50;
            this.btnprint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnprint.Location = new System.Drawing.Point(234, 337);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(115, 59);
            this.btnprint.TabIndex = 92;
            this.btnprint.Text = "         Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnexport.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnexport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnexport.Image = global::Student_Management_System.Properties.Resources._30;
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexport.Location = new System.Drawing.Point(117, 335);
            this.btnexport.Name = "btnexport";
            this.btnexport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnexport.Size = new System.Drawing.Size(115, 59);
            this.btnexport.TabIndex = 93;
            this.btnexport.Text = "     Export";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.UseVisualStyleBackColor = false;
            // 
            // SubjectTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 399);
            this.ControlBox = false;
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.t);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.lvwsubject);
            this.Controls.Add(this.lblsubjectteacher);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SubjectTeacherForm";
            this.Load += new System.EventHandler(this.SubjectTeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.ListView lvwsubject;
        private System.Windows.Forms.Label lblsubjectteacher;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox t;
    }
}