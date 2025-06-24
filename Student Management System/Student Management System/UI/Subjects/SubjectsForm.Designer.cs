namespace Student_Management_System.UI.Subjects
{
    partial class SubjectsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblgrade = new System.Windows.Forms.Label();
            this.txtgradename = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnshowteacher = new System.Windows.Forms.Button();
            this.btnshowstudent = new System.Windows.Forms.Button();
            this.btnshowsubject = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 224);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblgrade
            // 
            this.lblgrade.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblgrade.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblgrade.Font = new System.Drawing.Font("Mongolian Baiti", 16.8F, System.Drawing.FontStyle.Bold);
            this.lblgrade.ForeColor = System.Drawing.Color.White;
            this.lblgrade.Location = new System.Drawing.Point(0, 0);
            this.lblgrade.Name = "lblgrade";
            this.lblgrade.Size = new System.Drawing.Size(484, 51);
            this.lblgrade.TabIndex = 51;
            this.lblgrade.Text = "Subjects";
            this.lblgrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtgradename
            // 
            this.txtgradename.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgradename.Location = new System.Drawing.Point(234, 298);
            this.txtgradename.Name = "txtgradename";
            this.txtgradename.Size = new System.Drawing.Size(240, 34);
            this.txtgradename.TabIndex = 50;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(82, 304);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(136, 28);
            this.lblfirstname.TabIndex = 49;
            this.lblfirstname.Text = "Subject Name";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btndelete.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btndelete.Image = global::Student_Management_System.Properties.Resources.delete30;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(131, 343);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 59);
            this.btndelete.TabIndex = 57;
            this.btndelete.Text = "    Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // btnshowteacher
            // 
            this.btnshowteacher.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshowteacher.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnshowteacher.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshowteacher.Image = global::Student_Management_System.Properties.Resources.tea30;
            this.btnshowteacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshowteacher.Location = new System.Drawing.Point(323, 408);
            this.btnshowteacher.Name = "btnshowteacher";
            this.btnshowteacher.Size = new System.Drawing.Size(153, 59);
            this.btnshowteacher.TabIndex = 56;
            this.btnshowteacher.Text = "     Show Teacher";
            this.btnshowteacher.UseVisualStyleBackColor = false;
            // 
            // btnshowstudent
            // 
            this.btnshowstudent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshowstudent.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnshowstudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshowstudent.Image = global::Student_Management_System.Properties.Resources._32student;
            this.btnshowstudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshowstudent.Location = new System.Drawing.Point(164, 408);
            this.btnshowstudent.Name = "btnshowstudent";
            this.btnshowstudent.Size = new System.Drawing.Size(153, 59);
            this.btnshowstudent.TabIndex = 56;
            this.btnshowstudent.Text = "     Show Student";
            this.btnshowstudent.UseVisualStyleBackColor = false;
            // 
            // btnshowsubject
            // 
            this.btnshowsubject.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnshowsubject.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnshowsubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnshowsubject.Image = global::Student_Management_System.Properties.Resources._30sub;
            this.btnshowsubject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnshowsubject.Location = new System.Drawing.Point(5, 408);
            this.btnshowsubject.Name = "btnshowsubject";
            this.btnshowsubject.Size = new System.Drawing.Size(153, 59);
            this.btnshowsubject.TabIndex = 56;
            this.btnshowsubject.Text = "     Show Subject";
            this.btnshowsubject.UseVisualStyleBackColor = false;
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrest.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrest.Image = global::Student_Management_System.Properties.Resources.rest30;
            this.btnrest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrest.Location = new System.Drawing.Point(252, 343);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(105, 59);
            this.btnrest.TabIndex = 55;
            this.btnrest.Text = "     Reset";
            this.btnrest.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::Student_Management_System.Properties.Resources.close35;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(361, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 59);
            this.button1.TabIndex = 53;
            this.button1.Text = "      Close";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnadd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic);
            this.btnadd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnadd.Image = global::Student_Management_System.Properties.Resources.add40;
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(10, 343);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(115, 59);
            this.btnadd.TabIndex = 54;
            this.btnadd.Text = "      Add";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 474);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnshowteacher);
            this.Controls.Add(this.btnshowstudent);
            this.Controls.Add(this.btnshowsubject);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblgrade);
            this.Controls.Add(this.txtgradename);
            this.Controls.Add(this.lblfirstname);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnshowsubject;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.TextBox txtgradename;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Button btnshowstudent;
        private System.Windows.Forms.Button btnshowteacher;
    }
}