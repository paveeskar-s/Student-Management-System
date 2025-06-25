namespace Student_Management_System.UI.User
{
    partial class Loginform
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
            this.lblcreatestudent = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtadmission = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnRegistering = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcreatestudent
            // 
            this.lblcreatestudent.BackColor = System.Drawing.Color.DarkCyan;
            this.lblcreatestudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcreatestudent.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatestudent.ForeColor = System.Drawing.Color.White;
            this.lblcreatestudent.Location = new System.Drawing.Point(0, 0);
            this.lblcreatestudent.Name = "lblcreatestudent";
            this.lblcreatestudent.Size = new System.Drawing.Size(393, 51);
            this.lblcreatestudent.TabIndex = 22;
            this.lblcreatestudent.Text = "User Login";
            this.lblcreatestudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.SlateGray;
            this.txtpassword.Location = new System.Drawing.Point(148, 326);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(240, 34);
            this.txtpassword.TabIndex = 20;
            this.txtpassword.Text = "Password";
            // 
            // txtadmission
            // 
            this.txtadmission.BackColor = System.Drawing.Color.White;
            this.txtadmission.Font = new System.Drawing.Font("Plantagenet Cherokee", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadmission.ForeColor = System.Drawing.Color.SlateGray;
            this.txtadmission.Location = new System.Drawing.Point(148, 282);
            this.txtadmission.Name = "txtadmission";
            this.txtadmission.Size = new System.Drawing.Size(240, 31);
            this.txtadmission.TabIndex = 21;
            this.txtadmission.Text = "Enter your username ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(13, 332);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(101, 28);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.Color.Transparent;
            this.lblusername.Font = new System.Drawing.Font("Plantagenet Cherokee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblusername.Location = new System.Drawing.Point(13, 285);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(121, 28);
            this.lblusername.TabIndex = 17;
            this.lblusername.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Student_Management_System.Properties.Resources.loginp;
            this.pictureBox1.Location = new System.Drawing.Point(96, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnexit.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Image = global::Student_Management_System.Properties.Resources.Exit30;
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.Location = new System.Drawing.Point(291, 380);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 45);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "        Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnlogin.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnlogin.Image = global::Student_Management_System.Properties.Resources.login30;
            this.btnlogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogin.Location = new System.Drawing.Point(187, 380);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 45);
            this.btnlogin.TabIndex = 26;
            this.btnlogin.Text = "     Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // btnRegistering
            // 
            this.btnRegistering.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRegistering.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegistering.Image = global::Student_Management_System.Properties.Resources.register30;
            this.btnRegistering.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistering.Location = new System.Drawing.Point(4, 380);
            this.btnRegistering.Name = "btnRegistering";
            this.btnRegistering.Size = new System.Drawing.Size(110, 45);
            this.btnRegistering.TabIndex = 28;
            this.btnRegistering.Text = "           Register ";
            this.btnRegistering.UseVisualStyleBackColor = false;
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 426);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegistering);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblcreatestudent);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtadmission);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblusername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Loginform";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblcreatestudent;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtadmission;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistering;
    }
}