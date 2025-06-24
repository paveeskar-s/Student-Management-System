namespace Student_Management_System.UI.Teachers
{
    partial class ListTeachersForm
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
            this.txtnum_of_cout = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.TextBox();
            this.dgvteachersdetails = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnshowsubject = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvteachersdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnum_of_cout
            // 
            this.txtnum_of_cout.AutoSize = true;
            this.txtnum_of_cout.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum_of_cout.Location = new System.Drawing.Point(977, 115);
            this.txtnum_of_cout.Name = "txtnum_of_cout";
            this.txtnum_of_cout.Size = new System.Drawing.Size(194, 28);
            this.txtnum_of_cout.TabIndex = 32;
            this.txtnum_of_cout.Text = "Number of Teachers";
            // 
            // t
            // 
            this.t.BackColor = System.Drawing.SystemColors.Control;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(39, 115);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(217, 30);
            this.t.TabIndex = 33;
            this.t.Text = "search ";
            // 
            // dgvteachersdetails
            // 
            this.dgvteachersdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvteachersdetails.Location = new System.Drawing.Point(22, 176);
            this.dgvteachersdetails.Name = "dgvteachersdetails";
            this.dgvteachersdetails.RowHeadersWidth = 51;
            this.dgvteachersdetails.RowTemplate.Height = 24;
            this.dgvteachersdetails.Size = new System.Drawing.Size(1218, 442);
            this.dgvteachersdetails.TabIndex = 31;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 710);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1262, 5);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management_System.Properties.Resources.serch20;
            this.pictureBox1.Location = new System.Drawing.Point(223, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnshowsubject
            // 
            this.btnshowsubject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshowsubject.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnshowsubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshowsubject.Image = global::Student_Management_System.Properties.Resources.subject30;
            this.btnshowsubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshowsubject.Location = new System.Drawing.Point(1087, 634);
            this.btnshowsubject.Name = "btnshowsubject";
            this.btnshowsubject.Size = new System.Drawing.Size(153, 59);
            this.btnshowsubject.TabIndex = 22;
            this.btnshowsubject.Text = "     Add Subject";
            this.btnshowsubject.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Image = global::Student_Management_System.Properties.Resources.close35;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(954, 635);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(115, 59);
            this.btnclose.TabIndex = 23;
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
            this.btnrefresh.Location = new System.Drawing.Point(821, 635);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(115, 59);
            this.btnrefresh.TabIndex = 24;
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
            this.btnshow.Location = new System.Drawing.Point(688, 635);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(115, 59);
            this.btnshow.TabIndex = 25;
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
            this.btndelete.Location = new System.Drawing.Point(555, 635);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 59);
            this.btndelete.TabIndex = 26;
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
            this.btnedit.Location = new System.Drawing.Point(422, 635);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(115, 59);
            this.btnedit.TabIndex = 27;
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
            this.btnadd.Location = new System.Drawing.Point(289, 635);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 59);
            this.btnadd.TabIndex = 28;
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
            this.btnprint.Location = new System.Drawing.Point(156, 635);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(115, 59);
            this.btnprint.TabIndex = 29;
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
            this.btnexport.Location = new System.Drawing.Point(39, 633);
            this.btnexport.Name = "btnexport";
            this.btnexport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnexport.Size = new System.Drawing.Size(115, 59);
            this.btnexport.TabIndex = 30;
            this.btnexport.Text = "     Export";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(584, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Teachers Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(552, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Student Management System";
            // 
            // ListTeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 715);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtnum_of_cout);
            this.Controls.Add(this.t);
            this.Controls.Add(this.dgvteachersdetails);
            this.Controls.Add(this.btnshowsubject);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnexport);
            this.Name = "ListTeachersForm";
            this.Text = "ListStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvteachersdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtnum_of_cout;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.DataGridView dgvteachersdetails;
        private System.Windows.Forms.Button btnshowsubject;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}