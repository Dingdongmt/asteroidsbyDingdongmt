namespace asteriods
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.btnlog = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.pictitle = new System.Windows.Forms.PictureBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.lstpass = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlog
            // 
            this.btnlog.Location = new System.Drawing.Point(107, 432);
            this.btnlog.Name = "btnlog";
            this.btnlog.Size = new System.Drawing.Size(203, 83);
            this.btnlog.TabIndex = 0;
            this.btnlog.Text = "LOGIN";
            this.btnlog.UseVisualStyleBackColor = true;
            this.btnlog.Click += new System.EventHandler(this.btnlog_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(326, 355);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(286, 20);
            this.txtpass.TabIndex = 2;
            this.txtpass.Text = "Enter Password";
            this.txtpass.Click += new System.EventHandler(this.txtpass_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.Location = new System.Drawing.Point(161, 250);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(128, 35);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "Username";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Comic Sans MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(161, 342);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(120, 35);
            this.lblpass.TabIndex = 4;
            this.lblpass.Text = "Password";
            // 
            // pictitle
            // 
            this.pictitle.Image = ((System.Drawing.Image)(resources.GetObject("pictitle.Image")));
            this.pictitle.Location = new System.Drawing.Point(124, 12);
            this.pictitle.Name = "pictitle";
            this.pictitle.Size = new System.Drawing.Size(535, 190);
            this.pictitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictitle.TabIndex = 5;
            this.pictitle.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(326, 263);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(286, 20);
            this.txtusername.TabIndex = 12;
            this.txtusername.Text = "Enter Username";
            this.txtusername.Click += new System.EventHandler(this.txtusername_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.Location = new System.Drawing.Point(659, 516);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(113, 34);
            this.exitbtn.TabIndex = 13;
            this.exitbtn.Text = "EXIT";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(426, 432);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(203, 83);
            this.btnregister.TabIndex = 14;
            this.btnregister.Text = "REGISTER";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.register_Click);
            // 
            // lstpass
            // 
            this.lstpass.FormattingEnabled = true;
            this.lstpass.Location = new System.Drawing.Point(651, 247);
            this.lstpass.Name = "lstpass";
            this.lstpass.Size = new System.Drawing.Size(108, 212);
            this.lstpass.TabIndex = 15;
            this.lstpass.Visible = false;
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orchid;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lstpass);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pictitle);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnlog);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmlogin";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlog;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.PictureBox pictitle;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.ListBox lstpass;
    }
}