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
            this.lblsubject = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtsubjectname = new System.Windows.Forms.TextBox();
            this.lblsubjectname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsubject
            // 
            this.lblsubject.BackColor = System.Drawing.Color.DarkBlue;
            this.lblsubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblsubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubject.ForeColor = System.Drawing.Color.White;
            this.lblsubject.Location = new System.Drawing.Point(0, 0);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(427, 51);
            this.lblsubject.TabIndex = 48;
            this.lblsubject.Text = "Subject";
            this.lblsubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Location = new System.Drawing.Point(293, 163);
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
            this.btnrest.Location = new System.Drawing.Point(166, 163);
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
            this.btnsave.Location = new System.Drawing.Point(37, 163);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(111, 39);
            this.btnsave.TabIndex = 45;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // txtsubjectname
            // 
            this.txtsubjectname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubjectname.Location = new System.Drawing.Point(164, 80);
            this.txtsubjectname.Name = "txtsubjectname";
            this.txtsubjectname.Size = new System.Drawing.Size(240, 34);
            this.txtsubjectname.TabIndex = 44;
            // 
            // lblsubjectname
            // 
            this.lblsubjectname.AutoSize = true;
            this.lblsubjectname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubjectname.Location = new System.Drawing.Point(12, 86);
            this.lblsubjectname.Name = "lblsubjectname";
            this.lblsubjectname.Size = new System.Drawing.Size(136, 28);
            this.lblsubjectname.TabIndex = 43;
            this.lblsubjectname.Text = "Subject Name";
            // 
            // SubjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 239);
            this.Controls.Add(this.lblsubject);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtsubjectname);
            this.Controls.Add(this.lblsubjectname);
            this.Name = "SubjectsForm";
            this.Text = "SubjectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtsubjectname;
        private System.Windows.Forms.Label lblsubjectname;
    }
}