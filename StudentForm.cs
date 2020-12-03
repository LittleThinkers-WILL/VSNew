using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Will
{
    public partial class StudentForm : Form
    { 
        ToolTip buttonToolTip = new ToolTip();
        
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            label1.Text = "WELCOME, " + LoginForm.CurrLogin;
            groupBox1.Size = new Size(1228, 28);
            groupBox2.Size = new Size(1228, 28);




           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Numbers number = new Numbers();
            number.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Size = new Size(1478, 441);
            groupBox1.Text = "Please select an activity";
            groupBox2.Text = "";
            groupBox2.Size = new Size(1228, 28);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Size = new Size(1478, 441);
            groupBox2.Text = "Please select an activity";
            groupBox1.Text = "";
            groupBox1.Size = new Size(1228, 28);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
           
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            buttonToolTip.ToolTipTitle = "Welcome";
            buttonToolTip.UseFading = true;
            buttonToolTip.UseAnimation = true;
            buttonToolTip.IsBalloon = true;
            buttonToolTip.ShowAlways = true;
            buttonToolTip.AutoPopDelay = 15000;
            buttonToolTip.InitialDelay = 0;
            buttonToolTip.ReshowDelay = 500;
            buttonToolTip.SetToolTip(pictureBox13, "Hi! \nWelcome to the main screen.\nChoose a difficulty, then click a picture to start learning. \nHave Fun!");

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"v1.wav");
            player.Play();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Shapes sh = new Shapes();
            sh.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Colours cl = new Colours();
            cl.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            LifeSkills LS = new LifeSkills();
            LS.Show();
            this.Hide();
        }

        private void UpdPictures(object sender, EventArgs e)
        {
            UploadPictures up = new UploadPictures();
            up.Show();
            this.Hide();
        }

        private void MediumPuzzles(object sender, EventArgs e)
        {
            TimeForMediumPuzzles mediumPuzzles = new TimeForMediumPuzzles();
            mediumPuzzles.Show();
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Social_stories SS = new Social_stories();
            SS.Show();
            this.Hide();
        }

        private void Sentences(object sender, EventArgs e)
        {
            SentenceTime time = new SentenceTime();
            time.Show();
            this.Hide();
        }
    }
}
