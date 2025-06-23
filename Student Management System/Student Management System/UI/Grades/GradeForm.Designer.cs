namespace Student_Management_System.UI.Grades
{
    partial class GradeForm
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
            this.txtgradename = new System.Windows.Forms.TextBox();
            this.lblfirstname = new System.Windows.Forms.Label();
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
            this.lblgrade.Size = new System.Drawing.Size(434, 51);
            this.lblgrade.TabIndex = 42;
            this.lblgrade.Text = "Grade";
            this.lblgrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnclose.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnclose.Location = new System.Drawing.Point(304, 156);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 39);
            this.btnclose.TabIndex = 41;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnrest.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnrest.Location = new System.Drawing.Point(177, 156);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(111, 39);
            this.btnrest.TabIndex = 40;
            this.btnrest.Text = "Rest";
            this.btnrest.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnsave.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsave.Location = new System.Drawing.Point(48, 156);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(111, 39);
            this.btnsave.TabIndex = 39;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // txtgradename
            // 
            this.txtgradename.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgradename.Location = new System.Drawing.Point(175, 73);
            this.txtgradename.Name = "txtgradename";
            this.txtgradename.Size = new System.Drawing.Size(240, 34);
            this.txtgradename.TabIndex = 34;
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(23, 79);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(124, 28);
            this.lblfirstname.TabIndex = 33;
            this.lblfirstname.Text = "Grade Name";
            // 
            // GradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 214);
            this.Controls.Add(this.lblgrade);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtgradename);
            this.Controls.Add(this.lblfirstname);
            this.Name = "GradeForm";
            this.Text = "GradeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgrade;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtgradename;
        private System.Windows.Forms.Label lblfirstname;
    }
}