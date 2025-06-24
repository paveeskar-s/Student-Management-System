namespace Student_Management_System.UI.Students
{
    partial class ListStudentsForm
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
            this.lblstudentdethails = new System.Windows.Forms.Label();
            this.txtnum_of_cout = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.TextBox();
            this.dgvteachersdetails = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnshowsubject = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteachersdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblstudentdethails
            // 
            this.lblstudentdethails.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblstudentdethails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstudentdethails.Font = new System.Drawing.Font("Mongolian Baiti", 16.8F, System.Drawing.FontStyle.Bold);
            this.lblstudentdethails.ForeColor = System.Drawing.Color.White;
            this.lblstudentdethails.Location = new System.Drawing.Point(0, 0);
            this.lblstudentdethails.Name = "lblstudentdethails";
            this.lblstudentdethails.Size = new System.Drawing.Size(1113, 59);
            this.lblstudentdethails.TabIndex = 21;
            this.lblstudentdethails.Text = "Student Details";
            this.lblstudentdethails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnum_of_cout
            // 
            this.txtnum_of_cout.AutoSize = true;
            this.txtnum_of_cout.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_of_cout.Location = new System.Drawing.Point(856, 70);
            this.txtnum_of_cout.Name = "txtnum_of_cout";
            this.txtnum_of_cout.Size = new System.Drawing.Size(194, 28);
            this.txtnum_of_cout.TabIndex = 47;
            this.txtnum_of_cout.Text = "Number of Teachers";
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.SystemColors.Control;
            this.t.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(23, 67);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(217, 29);
            this.t.TabIndex = 48;
            this.t.Text = "Search ";
            // 
            // dgvteachersdetails
            // 
            this.dgvteachersdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteachersdetails.Location = new System.Drawing.Point(6, 107);
            this.dgvteachersdetails.Name = "dgvteachersdetails";
            this.dgvteachersdetails.RowHeadersWidth = 51;
            this.dgvteachersdetails.RowTemplate.Height = 24;
            this.dgvteachersdetails.Size = new System.Drawing.Size(1099, 442);
            this.dgvteachersdetails.TabIndex = 46;
            // 
            // btnsearch
            // 
            this.btnsearch.Image = global::Student_Management_System.Properties.Resources.serch201;
            this.btnsearch.Location = new System.Drawing.Point(236, 67);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(54, 31);
            this.btnsearch.TabIndex = 58;
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnshowsubject
            // 
            this.btnshowsubject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshowsubject.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnshowsubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshowsubject.Image = global::Student_Management_System.Properties.Resources._30sub;
            this.btnshowsubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshowsubject.Location = new System.Drawing.Point(950, 555);
            this.btnshowsubject.Name = "btnshowsubject";
            this.btnshowsubject.Size = new System.Drawing.Size(153, 59);
            this.btnshowsubject.TabIndex = 57;
            this.btnshowsubject.Text = "     Show Subject";
            this.btnshowsubject.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Image = global::Student_Management_System.Properties.Resources.close35;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(835, 556);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(115, 59);
            this.btnclose.TabIndex = 38;
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
            this.btnrefresh.Location = new System.Drawing.Point(719, 556);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(115, 59);
            this.btnrefresh.TabIndex = 39;
            this.btnrefresh.Text = "        Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshow.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnshow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshow.Image = global::Student_Management_System.Properties.Resources.show40;
            this.btnshow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshow.Location = new System.Drawing.Point(601, 555);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(115, 59);
            this.btnshow.TabIndex = 40;
            this.btnshow.Text = "       Show";
            this.btnshow.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btndelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Image = global::Student_Management_System.Properties.Resources.delete30;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(484, 555);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 59);
            this.btndelete.TabIndex = 41;
            this.btndelete.Text = "    Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnedit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnedit.Image = global::Student_Management_System.Properties.Resources._30edit;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(366, 555);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(115, 59);
            this.btnedit.TabIndex = 42;
            this.btnedit.Text = "     Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Image = global::Student_Management_System.Properties.Resources.add40;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(245, 556);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 59);
            this.btnadd.TabIndex = 43;
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
            this.btnprint.Location = new System.Drawing.Point(125, 556);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(115, 59);
            this.btnprint.TabIndex = 44;
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
            this.btnexport.Location = new System.Drawing.Point(5, 556);
            this.btnexport.Name = "btnexport";
            this.btnexport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnexport.Size = new System.Drawing.Size(115, 59);
            this.btnexport.TabIndex = 45;
            this.btnexport.Text = "     Export";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.UseVisualStyleBackColor = false;
            // 
            // ListStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 615);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnshowsubject);
            this.Controls.Add(this.txtnum_of_cout);
            this.Controls.Add(this.t);
            this.Controls.Add(this.dgvteachersdetails);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.lblstudentdethails);
            this.Name = "ListStudentsForm";
            this.Text = "ListStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvteachersdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblstudentdethails;
        private System.Windows.Forms.Label txtnum_of_cout;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.DataGridView dgvteachersdetails;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnshowsubject;
        private System.Windows.Forms.Button btnsearch;
    }
}