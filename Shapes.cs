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
    public partial class Shapes : Form
    {
        bool allowClick = false;
        PictureBox fstGuess;
        Random rnd = new Random();//creating a new instance of the Random number generator class
        //Timer clkTimer = new Timer();
        //int time = 120;
        //Timer timer = new Timer { Interval = 1000 };
        ToolTip buttonToolTip = new ToolTip();

        public Shapes()
        {
            InitializeComponent();
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private static IEnumerable<Image> images
        {//linking the images which were imported to the resources 
            get
            {
                return new Image[]
                {
                        Properties.Resources.img1,
                        Properties.Resources.img2,
                        Properties.Resources.img3,
                        Properties.Resources.img4,
                        Properties.Resources.img5,
                        Properties.Resources.img6,
                        Properties.Resources.img7,
                        Properties.Resources.img8
                };
            }
        }

        private void startGameTimer()
        {// start the timer and display the remaining time on the label
            //timer.Start();
            //timer.Tick += delegate
            //{
            //    time--;
            //    if (time < 0)
            //    {
            //        timer.Stop();
            //        MessageBox.Show("Out of time! Try again");
            //        RstImages();
            //    }
            //    var ssTime = TimeSpan.FromSeconds(time);
            //    lblTimer.Text = "00: " + time.ToString();
            //};
        }

        private void RstImages()
        {//resetting the picture boxes
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }
            HideImg();
            setRdmImg();
            //time = 120;
            //timer.Start();
        }

        private void HideImg()
        {//run a foreach loop through the form looking for picture box components and it will mask them with the question mark image
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.question;
            }
        }

        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }
            while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }

        private void setRdmImg()
        {//this loop will look for images and try to find a pair of slots where both can be tagged with the same name
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }

        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImg();
            allowClick = true;
           // clkTimer.Stop();
        }

        private void clkImage(object sender, EventArgs e)
        {
            if (!allowClick) return;
            var pic = (PictureBox)sender;
            if (fstGuess == null)
            {
                fstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }
            pic.Image = (Image)pic.Tag;
            if (pic.Image == fstGuess.Image && pic != fstGuess)
            {
                pic.Visible = fstGuess.Visible = false;
                {
                    fstGuess = pic;
                }
                HideImg();
            }
            else
            {
                allowClick = false;
              //  clkTimer.Start();
            }
            fstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            if (MessageBox.Show("Congratulations you have won!.Play Again","Play Again",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            RstImages();
        }

        private void stGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRdmImg();
            HideImg();
            startGameTimer();
            //clkTimer.Interval = 1000;
            //clkTimer.Tick += CLICKTIMER_TICK;
            btnStartGame.Enabled = false;

        }

        private void showReadMe(object sender, EventArgs e)
        {
            //if (lblReadMe.Visible == true)
            //{
            //    lblReadMe.Visible = false;
           // }
           // else
           // {
               // lblReadMe.Visible = true;
          //  }
        }

        private void MianMenu(object sender, EventArgs e)
        {
            StudentForm sfrm = new StudentForm();
            sfrm.Show();
            this.Close();
        }

        private void Shapes_Load(object sender, EventArgs e)
        {

        }

        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit ?", "shapes concentration game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Button != btnQuit && YesOrNO == DialogResult.No) e.Cancel = true;// close application
            if (sender as Button == btnQuit && YesOrNO == DialogResult.Yes) this.Close();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);
           // timer.Stop();
            StudentForm sfrm = new StudentForm();
            sfrm.Show();
            this.Close();

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
            buttonToolTip.SetToolTip(pictureBox17, "Hi! \nWelcome to the shapes concentration game. This game consists of eight shapes.\n Click on  'start game' to begin.. \nAll the cards will be laid in rows, face down.!\nA player will select any two cards of their choice:\n If the cards don’t match , the game turns them back over.\nIf the two cards match , it’s a pair!  the cards will be removed from the screen. \n Once  all the cards disappear, the game is over.\n Players given two minutes to complete the game.\nHave Fun!");

            /*Welcome to the shapes concentration game. This game consists of eight shapes.
                Click on  "start game" to begin.
                All the cards will be laid in rows, face down.
                A player will select any two cards of their choice:
                If the cards don’t match , the game turns them back over.
                If the two cards match , it’s a pair!  the cards will be removed from the screen. 
                Once  all the cards disappear, the game is over.
                Players given two minutes to complete the game.*/

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"v7.wav");
            player.Play();
        }
    }
}

