using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Will
{
    public partial class Social_stories : Form
    {
        ToolTip buttonToolTip = new ToolTip();
        public Social_stories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocialAngry SA = new SocialAngry();
            SA.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SocialCrossing SC = new SocialCrossing();
            SC.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SocialPlaying SP = new SocialPlaying();
            SP.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SocialHitting SH = new SocialHitting();
            SH.Show();
            this.Hide();


            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Welcome";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.AutoPopDelay = 15000;
            buttonToolTip.InitialDelay = 0;
            buttonToolTip.ReshowDelay = 500;
            buttonToolTip.SetToolTip(pictureBox3, "Hi! \nWelcome to social stories.\nYou may proceed to click on any of the buttons. ");

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"WelcomeSocial.wav");
            player.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StudentForm sfrm = new StudentForm();
            sfrm.Show();
            this.Hide();
        }
    }
}
