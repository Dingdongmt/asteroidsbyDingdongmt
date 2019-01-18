using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;


namespace asteriods
{
    public partial class frmhigh : Form
    {
        // \\ igonre meaning of the next backslash and chracters. makes the file correct
        string file_name = Directory.GetCurrentDirectory() + "\\name.txt";
        //for score file
        string file_score = Directory.GetCurrentDirectory() + "\\score.txt";
        public frmhigh()
        {

            InitializeComponent();
        }
        private void lbladdname_Click(object sender, EventArgs e)
        {
            {
                string name = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("please import your name"));
                MessageBox.Show(file_name);
                StreamWriter sw = new StreamWriter(file_name, true);
                sw.WriteLine(name);
                sw.Close();
                MessageBox.Show("name added");
            }
        }
        private void lbldle_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(file_name);
                MessageBox.Show(file_score);
                StreamWriter sw = new StreamWriter(file_name, false);
                StreamWriter ssw = new StreamWriter(file_score, false);
                sw.Close();
                ssw.Close();
                MessageBox.Show("file cleared");
            }
        }
        private void lblprint_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show(file_name);
                MessageBox.Show(file_score);
                StreamReader sr = new StreamReader(file_name);
                StreamReader ssr = new StreamReader(file_score);
                string name;
                string score;
                while ((name = sr.ReadLine()) != null)
                {
                    MessageBox.Show(name);
                    lstname.Items.Add(name);
                    
                }
                while ((score = ssr.ReadLine()) != null)
                {
                    MessageBox.Show(score);
                    lstscore.Items.Add(score);
                }
                sr.Close();
                ssr.Close();
            }

        }
        private void lbladdscore_Click(object sender, EventArgs e)
        {
            string score = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("please import your score"));
            MessageBox.Show(file_score);

            StreamWriter sw = new StreamWriter(file_score, true);
            sw.WriteLine(score);
            sw.Close();
            MessageBox.Show("score added");
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            Process.Start(Directory.GetCurrentDirectory() + "\\certificate.pdf");
        }
        private void gamespage_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmgame ss = new frmgame();
            ss.Show();
        }
    }
}
