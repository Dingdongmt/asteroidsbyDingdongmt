namespace asteriods
{
    partial class frmhigh
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
            this.lblhighscore = new System.Windows.Forms.Label();
            this.tblscore = new System.Windows.Forms.TableLayoutPanel();
            this.lstscore = new System.Windows.Forms.ListBox();
            this.lblrank = new System.Windows.Forms.Label();
            this.lblscores = new System.Windows.Forms.Label();
            this.lblplayer = new System.Windows.Forms.Label();
            this.lstname = new System.Windows.Forms.ListBox();
            this.lstrank = new System.Windows.Forms.ListBox();
            this.btnprint = new System.Windows.Forms.Button();
            this.lblprint = new System.Windows.Forms.Label();
            this.lbladdname = new System.Windows.Forms.Label();
            this.lbldle = new System.Windows.Forms.Label();
            this.lbladdscore = new System.Windows.Forms.Label();
            this.gamespage = new System.Windows.Forms.Button();
            this.tblscore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblhighscore
            // 
            this.lblhighscore.AutoSize = true;
            this.lblhighscore.Font = new System.Drawing.Font("Snap ITC", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhighscore.ForeColor = System.Drawing.Color.Cyan;
            this.lblhighscore.Location = new System.Drawing.Point(261, 9);
            this.lblhighscore.Name = "lblhighscore";
            this.lblhighscore.Size = new System.Drawing.Size(245, 48);
            this.lblhighscore.TabIndex = 0;
            this.lblhighscore.Text = "HighScore";
            // 
            // tblscore
            // 
            this.tblscore.ColumnCount = 3;
            this.tblscore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.1376F));
            this.tblscore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.8624F));
            this.tblscore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tblscore.Controls.Add(this.lstscore, 2, 1);
            this.tblscore.Controls.Add(this.lblrank, 0, 0);
            this.tblscore.Controls.Add(this.lblscores, 2, 0);
            this.tblscore.Controls.Add(this.lblplayer, 1, 0);
            this.tblscore.Controls.Add(this.lstname, 1, 1);
            this.tblscore.Controls.Add(this.lstrank, 0, 1);
            this.tblscore.Location = new System.Drawing.Point(30, 83);
            this.tblscore.Name = "tblscore";
            this.tblscore.RowCount = 2;
            this.tblscore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.79373F));
            this.tblscore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.20627F));
            this.tblscore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblscore.Size = new System.Drawing.Size(718, 430);
            this.tblscore.TabIndex = 1;
            // 
            // lstscore
            // 
            this.lstscore.FormattingEnabled = true;
            this.lstscore.Location = new System.Drawing.Point(568, 58);
            this.lstscore.Name = "lstscore";
            this.lstscore.Size = new System.Drawing.Size(139, 368);
            this.lstscore.TabIndex = 7;
            // 
            // lblrank
            // 
            this.lblrank.AutoSize = true;
            this.lblrank.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrank.ForeColor = System.Drawing.Color.Cyan;
            this.lblrank.Location = new System.Drawing.Point(3, 0);
            this.lblrank.Name = "lblrank";
            this.lblrank.Size = new System.Drawing.Size(80, 31);
            this.lblrank.TabIndex = 4;
            this.lblrank.Text = "Rank";
            // 
            // lblscores
            // 
            this.lblscores.AutoSize = true;
            this.lblscores.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscores.ForeColor = System.Drawing.Color.Cyan;
            this.lblscores.Location = new System.Drawing.Point(568, 0);
            this.lblscores.Name = "lblscores";
            this.lblscores.Size = new System.Drawing.Size(102, 35);
            this.lblscores.TabIndex = 3;
            this.lblscores.Text = "Score";
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer.ForeColor = System.Drawing.Color.Cyan;
            this.lblplayer.Location = new System.Drawing.Point(230, 0);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(115, 35);
            this.lblplayer.TabIndex = 2;
            this.lblplayer.Text = "Player";
            // 
            // lstname
            // 
            this.lstname.FormattingEnabled = true;
            this.lstname.Location = new System.Drawing.Point(230, 58);
            this.lstname.Name = "lstname";
            this.lstname.Size = new System.Drawing.Size(332, 368);
            this.lstname.TabIndex = 6;
            // 
            // lstrank
            // 
            this.lstrank.FormattingEnabled = true;
            this.lstrank.Location = new System.Drawing.Point(3, 58);
            this.lstrank.Name = "lstrank";
            this.lstrank.Size = new System.Drawing.Size(221, 368);
            this.lstrank.TabIndex = 8;
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(663, 517);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(94, 31);
            this.btnprint.TabIndex = 3;
            this.btnprint.Text = "certificate";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // lblprint
            // 
            this.lblprint.BackColor = System.Drawing.Color.Transparent;
            this.lblprint.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprint.ForeColor = System.Drawing.Color.Cyan;
            this.lblprint.Location = new System.Drawing.Point(396, 521);
            this.lblprint.Name = "lblprint";
            this.lblprint.Size = new System.Drawing.Size(90, 34);
            this.lblprint.TabIndex = 17;
            this.lblprint.Text = "Print";
            this.lblprint.Click += new System.EventHandler(this.lblprint_Click);
            // 
            // lbladdname
            // 
            this.lbladdname.BackColor = System.Drawing.Color.Transparent;
            this.lbladdname.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdname.ForeColor = System.Drawing.Color.Cyan;
            this.lbladdname.Location = new System.Drawing.Point(133, 525);
            this.lbladdname.Name = "lbladdname";
            this.lbladdname.Size = new System.Drawing.Size(110, 30);
            this.lbladdname.TabIndex = 18;
            this.lbladdname.Text = "Add name";
            this.lbladdname.Click += new System.EventHandler(this.lbladdname_Click);
            // 
            // lbldle
            // 
            this.lbldle.BackColor = System.Drawing.Color.Transparent;
            this.lbldle.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldle.ForeColor = System.Drawing.Color.Cyan;
            this.lbldle.Location = new System.Drawing.Point(515, 521);
            this.lbldle.Name = "lbldle";
            this.lbldle.Size = new System.Drawing.Size(80, 31);
            this.lbldle.TabIndex = 19;
            this.lbldle.Text = "Clear";
            this.lbldle.Click += new System.EventHandler(this.lbldle_Click);
            // 
            // lbladdscore
            // 
            this.lbladdscore.BackColor = System.Drawing.Color.Transparent;
            this.lbladdscore.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdscore.ForeColor = System.Drawing.Color.Cyan;
            this.lbladdscore.Location = new System.Drawing.Point(264, 525);
            this.lbladdscore.Name = "lbladdscore";
            this.lbladdscore.Size = new System.Drawing.Size(128, 30);
            this.lbladdscore.TabIndex = 20;
            this.lbladdscore.Text = "Add score";
            this.lbladdscore.Click += new System.EventHandler(this.lbladdscore_Click);
            // 
            // gamespage
            // 
            this.gamespage.Location = new System.Drawing.Point(21, 520);
            this.gamespage.Name = "gamespage";
            this.gamespage.Size = new System.Drawing.Size(82, 35);
            this.gamespage.TabIndex = 21;
            this.gamespage.Text = "Game";
            this.gamespage.UseVisualStyleBackColor = true;
            this.gamespage.Click += new System.EventHandler(this.gamespage_Click);
            // 
            // frmhigh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.HotPink;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.gamespage);
            this.Controls.Add(this.lbladdscore);
            this.Controls.Add(this.lbldle);
            this.Controls.Add(this.lbladdname);
            this.Controls.Add(this.lblprint);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.tblscore);
            this.Controls.Add(this.lblhighscore);
            this.Name = "frmhigh";
            this.Text = "hight score";
            this.tblscore.ResumeLayout(false);
            this.tblscore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhighscore;
        private System.Windows.Forms.TableLayoutPanel tblscore;
        private System.Windows.Forms.Label lblscores;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Label lblrank;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.ListBox lstname;
        private System.Windows.Forms.ListBox lstscore;
        private System.Windows.Forms.Label lblprint;
        private System.Windows.Forms.Label lbladdname;
        private System.Windows.Forms.Label lbldle;
        private System.Windows.Forms.Label lbladdscore;
        private System.Windows.Forms.ListBox lstrank;
        private System.Windows.Forms.Button gamespage;
    }
}