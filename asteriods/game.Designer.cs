namespace asteriods
{
    partial class frmgame
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbladdname;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgame));
            this.shipList1 = new System.Windows.Forms.ImageList(this.components);
            this.tmrborders = new System.Windows.Forms.Timer(this.components);
            this.ship = new System.Windows.Forms.PictureBox();
            this.picbullet = new System.Windows.Forms.PictureBox();
            this.tmrbullet = new System.Windows.Forms.Timer(this.components);
            this.pangame = new System.Windows.Forms.Panel();
            this.picborder1 = new System.Windows.Forms.PictureBox();
            this.picenemy = new System.Windows.Forms.PictureBox();
            this.picborder = new System.Windows.Forms.PictureBox();
            this.lbltimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblscore = new System.Windows.Forms.Label();
            this.picexit = new System.Windows.Forms.PictureBox();
            this.picpause = new System.Windows.Forms.PictureBox();
            this.playsong = new System.Windows.Forms.PictureBox();
            this.choosesong = new System.Windows.Forms.PictureBox();
            this.textBox_path = new System.Windows.Forms.Label();
            this.lblhsgame = new System.Windows.Forms.Label();
            this.lbllife = new System.Windows.Forms.Label();
            this.tmrscore = new System.Windows.Forms.Timer(this.components);
            this.lbldle = new System.Windows.Forms.Label();
            this.lblscoreadd = new System.Windows.Forms.Label();
            this.lifetimer = new System.Windows.Forms.Timer(this.components);
            this.picreset = new System.Windows.Forms.PictureBox();
            this.helptxtlbl = new System.Windows.Forms.Label();
            lbladdname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbullet)).BeginInit();
            this.pangame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picborder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picenemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picborder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosesong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).BeginInit();
            this.SuspendLayout();
            // 
            // lbladdname
            // 
            lbladdname.BackColor = System.Drawing.Color.Transparent;
            lbladdname.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbladdname.ForeColor = System.Drawing.Color.Cyan;
            lbladdname.Location = new System.Drawing.Point(602, 196);
            lbladdname.Name = "lbladdname";
            lbladdname.Size = new System.Drawing.Size(110, 58);
            lbladdname.TabIndex = 14;
            lbladdname.Text = "click to enter name";
            lbladdname.Click += new System.EventHandler(this.lbladdname_Click_1);
            // 
            // shipList1
            // 
            this.shipList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("shipList1.ImageStream")));
            this.shipList1.TransparentColor = System.Drawing.Color.Transparent;
            this.shipList1.Images.SetKeyName(0, "ship down.jpg");
            this.shipList1.Images.SetKeyName(1, "ship down-left.jpg");
            this.shipList1.Images.SetKeyName(2, "ship down-right.jpg");
            this.shipList1.Images.SetKeyName(3, "ship left.jpg");
            this.shipList1.Images.SetKeyName(4, "ship right.jpg");
            this.shipList1.Images.SetKeyName(5, "ship up.jpg");
            this.shipList1.Images.SetKeyName(6, "ship up-left.jpg");
            this.shipList1.Images.SetKeyName(7, "ship up-right.jpg");
            // 
            // tmrborders
            // 
            this.tmrborders.Enabled = true;
            this.tmrborders.Tick += new System.EventHandler(this.tmrborders_Tick);
            // 
            // ship
            // 
            this.ship.Image = ((System.Drawing.Image)(resources.GetObject("ship.Image")));
            this.ship.Location = new System.Drawing.Point(282, 278);
            this.ship.Name = "ship";
            this.ship.Size = new System.Drawing.Size(25, 25);
            this.ship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ship.TabIndex = 0;
            this.ship.TabStop = false;
            // 
            // picbullet
            // 
            this.picbullet.BackColor = System.Drawing.Color.Cornsilk;
            this.picbullet.Location = new System.Drawing.Point(289, 264);
            this.picbullet.Name = "picbullet";
            this.picbullet.Size = new System.Drawing.Size(10, 10);
            this.picbullet.TabIndex = 1;
            this.picbullet.TabStop = false;
            this.picbullet.Visible = false;
            // 
            // tmrbullet
            // 
            this.tmrbullet.Enabled = true;
            this.tmrbullet.Tick += new System.EventHandler(this.tmrbullet_Tick);
            // 
            // pangame
            // 
            this.pangame.Controls.Add(this.picborder1);
            this.pangame.Controls.Add(this.picenemy);
            this.pangame.Controls.Add(this.picborder);
            this.pangame.Controls.Add(this.ship);
            this.pangame.Controls.Add(this.picbullet);
            this.pangame.Location = new System.Drawing.Point(1, 1);
            this.pangame.Name = "pangame";
            this.pangame.Size = new System.Drawing.Size(595, 559);
            this.pangame.TabIndex = 2;
            // 
            // picborder1
            // 
            this.picborder1.Image = ((System.Drawing.Image)(resources.GetObject("picborder1.Image")));
            this.picborder1.Location = new System.Drawing.Point(53, 132);
            this.picborder1.Name = "picborder1";
            this.picborder1.Size = new System.Drawing.Size(43, 45);
            this.picborder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picborder1.TabIndex = 4;
            this.picborder1.TabStop = false;
            // 
            // picenemy
            // 
            this.picenemy.Image = ((System.Drawing.Image)(resources.GetObject("picenemy.Image")));
            this.picenemy.Location = new System.Drawing.Point(447, 76);
            this.picenemy.Name = "picenemy";
            this.picenemy.Size = new System.Drawing.Size(73, 66);
            this.picenemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picenemy.TabIndex = 3;
            this.picenemy.TabStop = false;
            // 
            // picborder
            // 
            this.picborder.Image = ((System.Drawing.Image)(resources.GetObject("picborder.Image")));
            this.picborder.Location = new System.Drawing.Point(229, 21);
            this.picborder.Name = "picborder";
            this.picborder.Size = new System.Drawing.Size(40, 38);
            this.picborder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picborder.TabIndex = 2;
            this.picborder.TabStop = false;
            // 
            // lbltimer
            // 
            this.lbltimer.BackColor = System.Drawing.Color.Transparent;
            this.lbltimer.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimer.ForeColor = System.Drawing.Color.Cyan;
            this.lbltimer.Location = new System.Drawing.Point(606, 22);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(300, 48);
            this.lbltimer.TabIndex = 3;
            this.lbltimer.Text = "Time : 0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblscore
            // 
            this.lblscore.BackColor = System.Drawing.Color.Transparent;
            this.lblscore.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.ForeColor = System.Drawing.Color.Cyan;
            this.lblscore.Location = new System.Drawing.Point(606, 61);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(300, 48);
            this.lblscore.TabIndex = 4;
            this.lblscore.Text = "Score : 0";
            // 
            // picexit
            // 
            this.picexit.BackColor = System.Drawing.Color.Transparent;
            this.picexit.Image = ((System.Drawing.Image)(resources.GetObject("picexit.Image")));
            this.picexit.Location = new System.Drawing.Point(818, 500);
            this.picexit.Name = "picexit";
            this.picexit.Size = new System.Drawing.Size(84, 50);
            this.picexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picexit.TabIndex = 5;
            this.picexit.TabStop = false;
            this.picexit.Click += new System.EventHandler(this.picexit_Click);
            // 
            // picpause
            // 
            this.picpause.BackColor = System.Drawing.Color.Transparent;
            this.picpause.Image = ((System.Drawing.Image)(resources.GetObject("picpause.Image")));
            this.picpause.Location = new System.Drawing.Point(624, 500);
            this.picpause.Name = "picpause";
            this.picpause.Size = new System.Drawing.Size(80, 50);
            this.picpause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picpause.TabIndex = 6;
            this.picpause.TabStop = false;
            this.picpause.Click += new System.EventHandler(this.picpause_Click);
            // 
            // playsong
            // 
            this.playsong.BackColor = System.Drawing.Color.Cornsilk;
            this.playsong.Image = ((System.Drawing.Image)(resources.GetObject("playsong.Image")));
            this.playsong.Location = new System.Drawing.Point(811, 386);
            this.playsong.Name = "playsong";
            this.playsong.Size = new System.Drawing.Size(72, 70);
            this.playsong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playsong.TabIndex = 7;
            this.playsong.TabStop = false;
            this.playsong.Click += new System.EventHandler(this.playsong_Click);
            // 
            // choosesong
            // 
            this.choosesong.Image = ((System.Drawing.Image)(resources.GetObject("choosesong.Image")));
            this.choosesong.Location = new System.Drawing.Point(617, 386);
            this.choosesong.Name = "choosesong";
            this.choosesong.Size = new System.Drawing.Size(95, 70);
            this.choosesong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.choosesong.TabIndex = 8;
            this.choosesong.TabStop = false;
            this.choosesong.Click += new System.EventHandler(this.choosesong_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.AutoSize = true;
            this.textBox_path.BackColor = System.Drawing.Color.Transparent;
            this.textBox_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_path.ForeColor = System.Drawing.Color.HotPink;
            this.textBox_path.Location = new System.Drawing.Point(602, 459);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(299, 29);
            this.textBox_path.TabIndex = 9;
            this.textBox_path.Text = "Make sure it\'s a WAV file";
            // 
            // lblhsgame
            // 
            this.lblhsgame.BackColor = System.Drawing.Color.Transparent;
            this.lblhsgame.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhsgame.ForeColor = System.Drawing.Color.Cyan;
            this.lblhsgame.Location = new System.Drawing.Point(600, 254);
            this.lblhsgame.Name = "lblhsgame";
            this.lblhsgame.Size = new System.Drawing.Size(344, 45);
            this.lblhsgame.TabIndex = 10;
            this.lblhsgame.Text = "click for Highscore";
            this.lblhsgame.Click += new System.EventHandler(this.lblhsgame_Click);
            // 
            // lbllife
            // 
            this.lbllife.BackColor = System.Drawing.Color.Transparent;
            this.lbllife.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllife.ForeColor = System.Drawing.Color.Cyan;
            this.lbllife.Location = new System.Drawing.Point(606, 109);
            this.lbllife.Name = "lbllife";
            this.lbllife.Size = new System.Drawing.Size(192, 48);
            this.lbllife.TabIndex = 13;
            this.lbllife.Text = "Lives : 3";
            // 
            // tmrscore
            // 
            this.tmrscore.Enabled = true;
            this.tmrscore.Interval = 1000;
            this.tmrscore.Tick += new System.EventHandler(this.score_Tick);
            // 
            // lbldle
            // 
            this.lbldle.BackColor = System.Drawing.Color.Transparent;
            this.lbldle.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldle.ForeColor = System.Drawing.Color.Cyan;
            this.lbldle.Location = new System.Drawing.Point(806, 196);
            this.lbldle.Name = "lbldle";
            this.lbldle.Size = new System.Drawing.Size(119, 58);
            this.lbldle.TabIndex = 15;
            this.lbldle.Text = "click to clear names";
            this.lbldle.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblscoreadd
            // 
            this.lblscoreadd.BackColor = System.Drawing.Color.Transparent;
            this.lblscoreadd.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscoreadd.ForeColor = System.Drawing.Color.Cyan;
            this.lblscoreadd.Location = new System.Drawing.Point(697, 196);
            this.lblscoreadd.Name = "lblscoreadd";
            this.lblscoreadd.Size = new System.Drawing.Size(110, 58);
            this.lblscoreadd.TabIndex = 16;
            this.lblscoreadd.Text = "click to enter score";
            this.lblscoreadd.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // lifetimer
            // 
            this.lifetimer.Enabled = true;
            this.lifetimer.Tick += new System.EventHandler(this.life123_Tick);
            // 
            // picreset
            // 
            this.picreset.BackColor = System.Drawing.Color.Transparent;
            this.picreset.Image = ((System.Drawing.Image)(resources.GetObject("picreset.Image")));
            this.picreset.Location = new System.Drawing.Point(727, 500);
            this.picreset.Name = "picreset";
            this.picreset.Size = new System.Drawing.Size(65, 50);
            this.picreset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picreset.TabIndex = 17;
            this.picreset.TabStop = false;
            this.picreset.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // helptxtlbl
            // 
            this.helptxtlbl.BackColor = System.Drawing.Color.Transparent;
            this.helptxtlbl.Font = new System.Drawing.Font("Broadway", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helptxtlbl.ForeColor = System.Drawing.Color.MintCream;
            this.helptxtlbl.Location = new System.Drawing.Point(678, 312);
            this.helptxtlbl.Name = "helptxtlbl";
            this.helptxtlbl.Size = new System.Drawing.Size(160, 45);
            this.helptxtlbl.TabIndex = 18;
            this.helptxtlbl.Text = "HELP!!!";
            this.helptxtlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(937, 562);
            this.Controls.Add(this.helptxtlbl);
            this.Controls.Add(this.picreset);
            this.Controls.Add(this.lblscoreadd);
            this.Controls.Add(this.lbldle);
            this.Controls.Add(lbladdname);
            this.Controls.Add(this.lbllife);
            this.Controls.Add(this.lblhsgame);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.choosesong);
            this.Controls.Add(this.playsong);
            this.Controls.Add(this.picpause);
            this.Controls.Add(this.picexit);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lbltimer);
            this.Controls.Add(this.pangame);
            this.Name = "frmgame";
            this.Text = "game";
            this.Load += new System.EventHandler(this.frmgame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmgame_Keydown);
            ((System.ComponentModel.ISupportInitialize)(this.ship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbullet)).EndInit();
            this.pangame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picborder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picenemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picborder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picpause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playsong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosesong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picreset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList shipList1;
        private System.Windows.Forms.Timer tmrborders;
        private System.Windows.Forms.PictureBox ship;
        private System.Windows.Forms.PictureBox picbullet;
        private System.Windows.Forms.Timer tmrbullet;
        private System.Windows.Forms.Panel pangame;
        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.PictureBox picexit;
        private System.Windows.Forms.PictureBox picpause;
        private System.Windows.Forms.PictureBox picborder;
        private System.Windows.Forms.PictureBox picenemy;
        private System.Windows.Forms.PictureBox playsong;
        private System.Windows.Forms.PictureBox choosesong;
        private System.Windows.Forms.Label textBox_path;
        private System.Windows.Forms.Label lblhsgame;
        private System.Windows.Forms.Label lbllife;
        private System.Windows.Forms.Timer tmrscore;
        private System.Windows.Forms.Label lbldle;
        private System.Windows.Forms.Label lblscoreadd;
        private System.Windows.Forms.PictureBox picreset;
        private System.Windows.Forms.PictureBox picborder1;
        private System.Windows.Forms.Timer lifetimer;
        private System.Windows.Forms.Label helptxtlbl;
    }
}

