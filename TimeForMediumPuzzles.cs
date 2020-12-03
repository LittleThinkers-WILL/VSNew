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
    public partial class TimeForMediumPuzzles : Form
    {
        ToolTip buttonToolTip = new ToolTip();
        public TimeForMediumPuzzles()
        {
            InitializeComponent();
        }

        private void MainMenu(object sender, EventArgs e)
        {
            StudentForm stud = new StudentForm();
            this.Close();
            stud.Show();
        }

        private void AdventureTime(object sender, EventArgs e)
        {
            PuzzleAd ad = new PuzzleAd();
            ad.Show();
        }

        private void Chipmunks(object sender, EventArgs e)
        {
            PuzzleChip chip = new PuzzleChip();
            chip.Show();
        }

        private void Simpsons(object sender, EventArgs e)
        {
            PuzzleSimp simp = new PuzzleSimp();
            simp.Show();
        }

        private void Tj(object sender, EventArgs e)
        {
            PuzzleTj tj = new PuzzleTj();
            tj.Show();
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
