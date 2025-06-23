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
            this.btnexport = new System.Windows.Forms.Button();
            this.dgvstudentdetails = new System.Windows.Forms.DataGridView();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnshowsubject = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtnum_of_cout = new System.Windows.Forms.Label();
            this.lblstudentdethails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudentdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnexport.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnexport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnexport.Location = new System.Drawing.Point(23, 635);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(127, 36);
            this.btnexport.TabIndex = 0;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = false;
            // 
            // dgvstudentdetails
            // 
            this.dgvstudentdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudentdetails.Location = new System.Drawing.Point(23, 176);
            this.dgvstudentdetails.Name = "dgvstudentdetails";
            this.dgvstudentdetails.RowHeadersWidth = 51;
            this.dgvstudentdetails.RowTemplate.Height = 24;
            this.dgvstudentdetails.Size = new System.Drawing.Size(1218, 442);
            this.dgvstudentdetails.TabIndex = 2;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnprint.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnprint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnprint.Location = new System.Drawing.Point(157, 635);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(127, 36);
            this.btnprint.TabIndex = 0;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Location = new System.Drawing.Point(290, 635);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(127, 36);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnedit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnedit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnedit.Location = new System.Drawing.Point(423, 635);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(127, 36);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btndelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Location = new System.Drawing.Point(556, 635);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(127, 36);
            this.btndelete.TabIndex = 0;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshow.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnshow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshow.Location = new System.Drawing.Point(689, 635);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(127, 36);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            // 
            // btnrefresh
            // 
            this.btnrefresh.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrefresh.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnrefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrefresh.Location = new System.Drawing.Point(822, 635);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(127, 36);
            this.btnrefresh.TabIndex = 0;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Location = new System.Drawing.Point(955, 635);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(127, 36);
            this.btnclose.TabIndex = 0;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnshowsubject
            // 
            this.btnshowsubject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshowsubject.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnshowsubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshowsubject.Location = new System.Drawing.Point(1088, 635);
            this.btnshowsubject.Name = "btnshowsubject";
            this.btnshowsubject.Size = new System.Drawing.Size(153, 36);
            this.btnshowsubject.TabIndex = 0;
            this.btnshowsubject.Text = "Add Subject";
            this.btnshowsubject.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(40, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 28);
            this.textBox1.TabIndex = 3;
            // 
            // txtnum_of_cout
            // 
            this.txtnum_of_cout.AutoSize = true;
            this.txtnum_of_cout.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_of_cout.Location = new System.Drawing.Point(978, 103);
            this.txtnum_of_cout.Name = "txtnum_of_cout";
            this.txtnum_of_cout.Size = new System.Drawing.Size(184, 28);
            this.txtnum_of_cout.TabIndex = 3;
            this.txtnum_of_cout.Text = "Number of Student";
            this.txtnum_of_cout.Click += new System.EventHandler(this.txtnum_of_cout_Click);
            // 
            // lblstudentdethails
            // 
            this.lblstudentdethails.BackColor = System.Drawing.Color.DarkBlue;
            this.lblstudentdethails.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblstudentdethails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentdethails.ForeColor = System.Drawing.Color.White;
            this.lblstudentdethails.Location = new System.Drawing.Point(0, 0);
            this.lblstudentdethails.Name = "lblstudentdethails";
            this.lblstudentdethails.Size = new System.Drawing.Size(1264, 51);
            this.lblstudentdethails.TabIndex = 21;
            this.lblstudentdethails.Text = "Student Details";
            this.lblstudentdethails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 708);
            this.Controls.Add(this.lblstudentdethails);
            this.Controls.Add(this.txtnum_of_cout);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvstudentdetails);
            this.Controls.Add(this.btnshowsubject);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexport);
            this.Name = "ListStudentsForm";
            this.Text = "ListStudentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudentdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.DataGridView dgvstudentdetails;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnshowsubject;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtnum_of_cout;
        private System.Windows.Forms.Label lblstudentdethails;
    }
}