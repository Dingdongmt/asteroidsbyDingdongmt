using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//library to allow threading which allows thow things to work sepretaly
using System.Threading;
//input and out put 
using System.IO;
using System.Diagnostics;


namespace asteriods
{
    public partial class frmgame : Form
    {
        // \\ igonre meaning of the next backslash and chracters. makes the file correct
        string file_name = Directory.GetCurrentDirectory() + "\\name.txt";
        // add score
        string file_score = Directory.GetCurrentDirectory() + "\\score.txt";
        //bullet
        bool bullet = false;
        char buttonpressed = '0';
        char buttonpressvisible='r';
        //time & score
        int time = 0;
        int scorelbl = 0;
        //life
        int life123 = 3;
        //speed for bolders
        int speedx = 10;
        int speedy =-10;
        int speedx1 = 10;
        int speedy1 = 10;
        //speed for enemyship
        int speedX = 5;
        int speedY = 6;
        int shipx = 282;
        int shipy = 278;
        public frmgame()
        {
            InitializeComponent();
        }
        private void tmrborders_Tick(object sender, EventArgs e)
        {
            //make borders move
            int Xposborder=0;
            int Yposborder=0;
            int Xposborder1=0;
            int Yposborder1=0;
            int Xposenemy=0;
            int Yposenemy=0;
            // generate a random nimber between 0-10
            Random rnd = new Random();
            int randomspeed = rnd.Next(0,10);
            //locations of the enemy ship
            Xposenemy = picenemy.Location.X + speedX;
            Yposenemy = picenemy.Location.Y + speedY;
            //locations of the boulder number 2
            Xposborder1 = picborder1.Location.X + speedx1;
            Yposborder1 = picborder1.Location.Y + speedy1;
            //locations of the boulder number 1
            Xposborder = picborder.Location.X + speedx;
            Yposborder = picborder.Location.Y + speedy;
            //so that the boulder no1 doesnt move in a same spot or sit still
            if (speedx == 0)
            {speedx = 10;}
            if (speedy == 0)
            {speedy = -10;}
            //so that the boulders doesnt move in a same spot or sit still
            if (speedx1 == 0)
            { speedx1 = 10; }
            if (speedy1 == 0)
            { speedy1 = -10; }
            //so that the enemyship doesnt move in a same spot or sit still
            if (speedX == 0)
            { speedX = 10; }
            if (speedY == 0)
            { speedY = -10; }
            // border 1 movement
            if ((Xposborder < pangame.Width - picborder.Width) && (Xposborder > 0))
            {
                picborder.SetBounds(Xposborder, Yposborder, picborder.Width, picborder.Height);
            }
            else
            {
                speedx = -(speedx);
                randomspeed = rnd.Next(-1, 1);
                speedy = -speedy * randomspeed; ;
            }
            if ((Yposborder < pangame.Height- picborder.Height) && (Yposborder > 0 ))
            {
                picborder.SetBounds(Xposborder, Yposborder, picborder.Width, picborder.Height);              
            }
            else
            { 
                randomspeed = rnd.Next(-1, 1);     
                speedx = -(speedx) *randomspeed;
                speedy = -speedy ;
            }
            //boulder number 1 hite by bullet
            if (picbullet.Bounds.IntersectsWith(picborder.Bounds) && picborder.Visible == true)
            {
                picborder.Visible = false;
                scorelbl=scorelbl + 10;
            }
            else if (picborder.Visible == false)
            {
                picborder.SetBounds(12, 2, picborder.Width, picborder.Height);
                picborder.Visible = true;
            }
            // border 2 movement
            if ((Xposborder1 < pangame.Width - picborder1.Width) && (Xposborder1 > 0))
            {
                picborder1.SetBounds(Xposborder1, Yposborder1, picborder1.Width, picborder1.Height);
            }
            else
            {
                speedx1 = -(speedx1);
                randomspeed = rnd.Next(-1, 1);
                speedy1 = -speedy1 * randomspeed; ;
            }
            if ((Yposborder1 < pangame.Height - picborder1.Height) && (Yposborder1 > 0))
            {
                picborder1.SetBounds(Xposborder1, Yposborder1, picborder1.Width, picborder1.Height);
            }
            else
            {
                randomspeed = rnd.Next(-1, 1);
                speedx1 = -(speedx1) * randomspeed;
                speedy1 = -speedy1;
            }
            //boulder no2 hit by bullet
            if (picbullet.Bounds.IntersectsWith(picborder1.Bounds) && picborder1.Visible == true)
            {
                picborder1.Visible = false;
                scorelbl = scorelbl + 10;
            }
            else if (picborder1.Visible == false)
            {
                picborder1.SetBounds(500, 400, picborder1.Width, picborder1.Height);
                picborder1.Visible = true;
            }
            // enemy movement
            if ((Xposenemy < pangame.Width - picenemy.Width) && (Xposenemy > 0))
            {
                picenemy.SetBounds(Xposenemy, Yposenemy, picenemy.Width, picenemy.Height);
            }
            else
            {
                speedX = -(speedX);
                randomspeed = rnd.Next(-1, 1);
                speedY = -speedY * randomspeed; ;
            }

            if ((Yposenemy < pangame.Height - picenemy.Height) && (Yposenemy > 0))
            {
                picenemy.SetBounds(Xposenemy, Yposenemy, picenemy.Width, picenemy.Height);
            }
            else
            {
                randomspeed = rnd.Next(-1, 1);
                speedX = -(speedX) * randomspeed;
                speedY = -speedY;
            }
            //enemyship hit by bullet
            if (picbullet.Bounds.IntersectsWith(picenemy.Bounds) && picenemy.Visible == true)
            {
                picenemy.Visible = false;
                scorelbl = scorelbl + 20;
            }
            else if (picenemy.Visible == false)
            {
                picenemy.SetBounds(100,400, picenemy.Width, picenemy.Height);
                picenemy.Visible = true;
            }
            //ship intersecting with the boulder and enemyship
            if (picborder.Bounds.IntersectsWith(ship.Bounds) && ship.Visible == true)
            {
                ship.Visible = false;
                scorelbl = scorelbl - 20;
            }
            else if (ship.Visible == false)
            {
                ship.SetBounds(shipx, shipy, ship.Width, ship.Height);
                ship.Visible = true;
            }
            if (picborder1.Bounds.IntersectsWith(ship.Bounds) && ship.Visible == true)
            {
                ship.Visible = false;
                scorelbl = scorelbl - 20;
            }
            else if (ship.Visible == false)
            {
                ship.SetBounds(shipx, shipy, ship.Width, ship.Height);
                ship.Visible = true;
            }
            if (picenemy.Bounds.IntersectsWith(ship.Bounds) && ship.Visible == true)
            {
                ship.Visible = false;
                scorelbl = scorelbl - 20;
            }
            else if (ship.Visible == false)
            {
                ship.SetBounds(shipx, shipy, ship.Width, ship.Height);
                ship.Visible = true;
            }
        }
        private void frmgame_Keydown(object sender, KeyEventArgs e)
        {
            // player controlling the ship and also the bullet following the ship
            if (e.KeyCode == Keys.Right)
            {
                ship.Image = shipList1.Images[4];
                ship.SetBounds(ship.Location.X + 10, ship.Location.Y, ship.Width, ship.Height);
                buttonpressvisible = 'r'; 
                if (bullet == false)
                {
                    buttonpressed = 'r';
                    picbullet.SetBounds(ship.Location.X + 10, ship.Location.Y, picbullet.Width, picbullet.Height);
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                ship.Image = shipList1.Images[3];
                ship.SetBounds(ship.Location.X - 10, ship.Location.Y, ship.Width, ship.Height);
                buttonpressvisible = 'l'; 
                if (bullet == false)
                {
                    buttonpressed = 'l';
                    picbullet.SetBounds(ship.Location.X - 10, ship.Location.Y, picbullet.Width, picbullet.Height);
                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                ship.Image = shipList1.Images[5];
                ship.SetBounds(ship.Location.X, ship.Location.Y - 10, ship.Width, ship.Height);
                buttonpressvisible = 'u'; 
                if (bullet == false)
                {
                    buttonpressed = 'u';
                    picbullet.SetBounds(ship.Location.X, ship.Location.Y - 10, picbullet.Width, picbullet.Height);
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                ship.Image = shipList1.Images[0];
                ship.SetBounds(ship.Location.X, ship.Location.Y + 10, ship.Width, ship.Height);

                buttonpressvisible = 'd'; 
                if (bullet == false)
                {
                    buttonpressed = 'd';
                    picbullet.SetBounds(ship.Location.X, ship.Location.Y + 10, picbullet.Width, picbullet.Height);
                }
            }
                // bullet fired form the ship.
            else if ((e.KeyCode == Keys.Space) )
            {
                bullet = true;
                picbullet.Visible = true;
            }
        }
        private void tmrbullet_Tick(object sender, EventArgs e)
        {
            //location of my bullet
            int Xpos;
            int Ypos;
            Xpos = picbullet.Location.X;
            Ypos = picbullet.Location.Y;
            if (bullet == false)
            {
                if (buttonpressvisible == 'd')
                { buttonpressed = 'd'; }
                else if (buttonpressvisible == 'u')
                { buttonpressed = 'u'; }
                else if (buttonpressvisible == 'l')
                { buttonpressed = 'l'; }
                else if (buttonpressvisible == 'r')
                { buttonpressed = 'r'; }
                //bullet moves
            }else
            {
                //button pressed ("left, right, up or down) are and if the ship is facing that way it moves that way
                if (buttonpressed == 'r')
                {
                   picbullet.SetBounds(picbullet.Location.X + 20, picbullet.Location.Y, picbullet.Width, picbullet.Height);
                }
                else if (buttonpressed == 'l')
                {
                    picbullet.SetBounds(picbullet.Location.X - 20, picbullet.Location.Y, picbullet.Width, picbullet.Height);
                }
                else if (buttonpressed == 'u')
                {
                    picbullet.SetBounds(picbullet.Location.X, picbullet.Location.Y - 20, picbullet.Width, picbullet.Height);
                }
                else if (buttonpressed == 'd')
                {
                    picbullet.SetBounds(picbullet.Location.X, picbullet.Location.Y + 20, picbullet.Width, picbullet.Height);
                }
            }
            // set the bullet to the location
            if ((Xpos > pangame.Width - picbullet.Width) || (Xpos < 0))
            {
                picbullet.Visible = false;
                bullet = false;
                picbullet.SetBounds(ship.Location.X + 20, ship.Location.Y + 20, picbullet.Width, picbullet.Height);
            }
            if ((Ypos > pangame.Height - picbullet.Height) || (Ypos < 0))
            {
                picbullet.Visible = false;
                bullet = false;
                picbullet.SetBounds(ship.Location.X + 20, ship.Location.Y + 20, picbullet.Width, picbullet.Height);
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //timer display in my gameform.
            time++;
            lbltimer.Text= "Time : " + time;
        }
        private void picexit_Click(object sender, EventArgs e)
        {
            //exit button for the form to hide
            this.Hide();
            frmlogin ss = new frmlogin();
            ss.Show(); 
         }
        private void picpause_Click(object sender, EventArgs e)
        {
           //pause for timr on the screen
            if (timer.Enabled == false)
            {
                timer.Enabled = true;
            }
            else
            {
                timer.Enabled = false;
            }
            // pauses stops the bullet form mooving
            if (tmrbullet.Enabled == false)
            {
                tmrbullet.Enabled = true;
            }
            else
            {
                tmrbullet.Enabled = false;
            }
            //stip all the enemies
            if (tmrborders.Enabled == false)
            {
                tmrborders.Enabled = true;
            }
            else
            {
                tmrborders.Enabled = false;
            }
            //stop score
            if (tmrscore.Enabled == false)
            {
                tmrscore.Enabled = true;
            }
            else
            {
                tmrscore.Enabled = false;
            }
        }
        private void choosesong_Click(object sender, EventArgs e)
        {
            //open windows expoler
            OpenFileDialog openfileDialog1 = new OpenFileDialog();
            if (openfileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox_path.Text = openfileDialog1.FileName;
            }
        }
        private void playsong_Click(object sender, EventArgs e)
        {
            //start a new thread to play the song
           Thread t = new Thread(playsound);       
           t.Start();
        }
       private void playsound()
       {
            try 
            {
                //play sound
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.SoundLocation = this.textBox_path.Text;
                player.Load();
                player.PlaySync();
            }
            catch (Win32Exception ex) 
            {
                //stop form crashing
                MessageBox.Show(ex.Message);
            }
        }
        private void score_Tick(object sender, EventArgs e)
        {
            //score counter for my game
            scorelbl++;
            lblscore.Text = "Score : " + scorelbl;
            //score adds when enemies are killed
            if (picborder1.Visible == false)
            {
                lblscore.Text = "Score : " + (scorelbl);
            }
            if (picenemy.Visible == false)
            {
                lblscore.Text = "Score : " + (scorelbl);
            }
            if (picborder.Visible == false)
            {
                lblscore.Text = "Score : " + (scorelbl);
            }
            //score subracts when you die
            if (ship.Visible == false)
            {
                lblscore.Text = "Score : " + (scorelbl);
            }
        }
        private void lbladdname_Click_1(object sender, EventArgs e)
        {
            string name = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("please import your name"));
            MessageBox.Show(file_name);
            StreamWriter sw = new StreamWriter(file_name, true);
            sw.WriteLine(name);
            sw.Close();
            MessageBox.Show("name added");
        }
        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(file_name);
            StreamWriter sw = new StreamWriter(file_name,false);
            sw.Close();
            MessageBox.Show("file cleared");
        }
        private void lblhsgame_Click(object sender, EventArgs e)
        {
            //hide this form and open another one
            this.Hide();
            frmhigh ss = new frmhigh();
            ss.Show();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {
            string score = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("please import your score"));
            MessageBox.Show(file_score);
            StreamWriter sw = new StreamWriter(file_score, true);
            sw.WriteLine(score);
            sw.Close();
            MessageBox.Show("score added");
        }
        private void life123_Tick(object sender, EventArgs e)
        {
            //life of the player ship
            lbllife.Text = "life " + life123;
                if (picborder.Bounds.IntersectsWith(ship.Bounds))
                {
                    life123 = life123 - 1;
                    lbllife.Text = "life " + (life123);
                }
                if (picborder1.Bounds.IntersectsWith(ship.Bounds))
                {
                    life123 = life123 - 1;
                    lbllife.Text = "life " + (life123);
                }
                if (picenemy.Bounds.IntersectsWith(ship.Bounds))
                {
                    life123 = life123 - 1;
                    lbllife.Text = "life " + (life123);
                }
            if (life123 == 0)
            {
                //when you die 3 game ends
                tmrborders.Enabled = false;
                timer.Enabled = false;
                lifetimer.Enabled = false;
                tmrscore.Enabled=false;
                MessageBox.Show("Your score is " + scorelbl); 
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //reset the game
            {
                ship.SetBounds(shipx, shipy, ship.Width, ship.Height);
            }
            {
                scorelbl = 0;
                lblscore.Text = "Score : " + scorelbl;
            }
            {
                time = 0;
                lbltimer.Text = "Time : " + time;
            }
            {
                picborder.SetBounds(229, 21 , picborder.Width, picborder.Height);
            }
            {
                picborder1.SetBounds(53, 132  , picborder1.Width, picborder1.Height);
            }
            {
                picenemy.SetBounds(447, 76, picenemy.Width, picenemy.Height);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // open help text file to help
            Process.Start(Directory.GetCurrentDirectory() + "\\help.txt");
        }

        private void frmgame_Load(object sender, EventArgs e)
        {

        }
    }    
        }
    
