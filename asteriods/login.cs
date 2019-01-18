using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace asteriods
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
                
        private void btnlog_Click(object sender, EventArgs e)
        {
            //check the file "txtusername and txtpass.text"
            string username = txtusername.Text;
            string password = txtpass.Text;

            int numberofusers = lstpass.Items.Count;
            //using loop cheeck the files 
            for (int count = 0; count < numberofusers; count++)
            {
                if (lstpass.Items[count].ToString() == (username + password))
                {
                    MessageBox.Show("logged in as " + username);
                    this.Hide();
                    frmgame ss = new frmgame();
                    ss.Show();
                    break;
                } 
            }
            MessageBox.Show("wrong password or username. please register.");
        }
        private void txtusername_Click(object sender, EventArgs e)
        {
            //make the text dissipare
            txtusername.Text = "";
        }
        private void txtpass_Click(object sender, EventArgs e)
        {
            //make the text dissipare
            txtpass.Text = "";
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            //exit the frmlogin
            this.Hide();
        }
        private void register_Click(object sender, EventArgs e)
        {
            //save the username and files to you "txtusername and txtpass.text"
            string username = txtusername.Text;
            string password = txtpass.Text;
            lstpass.Items.Add(username + password);
            MessageBox.Show("Registerd " + username);
        }
    }
}
