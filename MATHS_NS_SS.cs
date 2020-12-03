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
    public partial class MATHS_NS_SS : Form
    {
        ToolTip buttonToolTip = new ToolTip();
        public MATHS_NS_SS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm sfrm = new StudentForm();
            sfrm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Welcome";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.AutoPopDelay = 15000;
            buttonToolTip.InitialDelay = 0;
            buttonToolTip.ReshowDelay = 500;
            buttonToolTip.SetToolTip(pictureBox1, "Hi! \nWelcome to the Maths,Ns and SS activity.Click on which ever activity you would like to start\nHave fun ");

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"WelcomeSocial.wav");
            player.Play();
        }
    }
}
