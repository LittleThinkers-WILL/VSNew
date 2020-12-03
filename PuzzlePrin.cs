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
    public partial class PuzzlePrin : Form
    {
        int inNullSliceIndex, inmoves = 0; //storing the null moves and number of moves made by a player
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
        ToolTip buttonToolTip = new ToolTip();
        public PuzzlePrin()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources.Pr1, Properties.Resources.Pr2, Properties.Resources.Pr3, Properties.Resources.Pr4, Properties.Resources.question });//adding all the puzzel images from the resource file
            lblMovesMade.Text += inmoves; //displaying moves made to label declared on form
            lblTimeElapsed.Text = "00:00:00"; //initializing timer
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 2, 4, });//3 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 4; i++)
                {//shuffling pictuer boxs from 1-4 skipping number 8 as that will be the null pictuer enabling users to move pictuers to complete puzzel
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gbPuzzleBox.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 4) inNullSliceIndex = i;//store empty picture box index
                }
            } while (CheckWin()); //if puzzel is a win state it will be reshuffeled so users can get a random puzzel
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00") // checking if timer has started
            {
                YesOrNo = MessageBox.Show("Are You Sure To RESTART ?", "Princess Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // when a user clicks shuffle while timer has strater they will be prompted if they would like to start again
            }
            if (YesOrNo == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                inmoves = 0;
                lblMovesMade.Text = "Moves Made : 0";
            }
        }

        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit ?", "shapes concentration game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true;// close application
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes) Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);
        }

        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTimeElapsed.Text == "00:00:00") // checking if timer as started
                timer.Start();// timer will be started
            int inPictureBoxIndex = gbPuzzleBox.Controls.IndexOf(sender as Control); //current pictuerbox image will be stored into variable decleard 
            if (inNullSliceIndex != inPictureBoxIndex)// if null pictuer box image is not equal to the pictuerbox index code below will execte
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 4 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 2 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 2 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {// if current pictuer box and blank pictuer box are neighbous images can be swaped
                    ((PictureBox)gbPuzzleBox.Controls[inNullSliceIndex]).Image = ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gbPuzzleBox.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[4]; // setting current box pictuer image into blank picture box image.The setting blank pictuer box into cirrent image
                    inNullSliceIndex = inPictureBoxIndex; // updating the null slice picture box
                    lblMovesMade.Text = "Moves Made : " + (++inmoves); // updating the user on the number of moves the have currently made
                    if (CheckWin()) //checking if it is a win state then timer will stop
                    {
                        timer.Stop();
                        (gbPuzzleBox.Controls[3] as PictureBox).Image = lstOriginalPictureList[3]; // replacing the blank picture with the last slice of the full imagae when if statement is a win state
                        MessageBox.Show("Congratulations...\nThe Princesses are Happy\nTime Elapsed : " + timer.Elapsed.ToString().Remove(8) + "\nTotal Moves Made : " + inmoves, "Princess Puzzle");
                        //After message box all properties will be rest to the intital state and images will be shuffeld for the next try
                        inmoves = 0;
                        lblMovesMade.Text = "Moves Made : 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
        }

        private void PuzzlePrin_Load(object sender, EventArgs e)
        {
            Shuffle();
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
            buttonToolTip.SetToolTip(pictureBox17, "Hi!\nTo complete the puzzle all you need to do is slide the puzzle pieces in the direction you would like to move them,\n until your puzzle looks like the sample picture.\n Click the Play Again button to redo the puzzle. \nHave Fun!");

            /*To complete the puzzle all you need to do is slide the puzzle pieces in the
            direction you would like to move them, until your puzzle looks like the sample picture. 
            Click the Play Again button to redo the puzzle.
             
             */

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"p.wav");
            player.Play();
        }

        bool CheckWin()
        {// checking if a user has won
            int i;
            for (i = 0; i < 3; i++)
            {
                if ((gbPuzzleBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break; //matching first pictuer box with the first picture i the original list.If there is any mis match found for loop wil break
            }
            if (i == 3) return true;
            else return false;
        }

    }
}
