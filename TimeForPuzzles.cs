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
    public partial class TimeForPuzzles : Form
    {
        ToolTip buttonToolTip = new ToolTip();
        public TimeForPuzzles()
        {
            InitializeComponent();
        }

        private void MIcky(object sender, EventArgs e)
        {
            PuzzleM m = new PuzzleM();
            m.Show();
        }

        private void Princess(object sender, EventArgs e)
        {
            PuzzlePrin p = new PuzzlePrin();
            p.Show();
        }

        private void Paw(object sender, EventArgs e)
        {
            PuzzlePaw p = new PuzzlePaw();
            p.Show();
        }

        private void Frozen(object sender, EventArgs e)
        {
            PuzzleF f = new PuzzleF();
            f.Show();
        }

        private void MainMenu(object sender, EventArgs e)
        {
            StudentForm stud = new StudentForm();
            this.Close();
            stud.Show();
        
        }

        private void Help(object sender, EventArgs e)
        {

            buttonToolTip.ToolTipTitle = "Welcome";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.AutoPopDelay = 15000;
            buttonToolTip.InitialDelay = 0;
            buttonToolTip.ReshowDelay = 500;
            buttonToolTip.SetToolTip(pictureBox17, "Hi!,Click on a picture to start the puzzle have fun!");

          

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"wp.wav");
            player.Play();
        }
    }
}
