using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Will
{
    public partial class NPage1 : Form
    {

        ToolTip buttonToolTip = new ToolTip();


        private SoundPlayer soundPlayer;
        public NPage1()
        {
            InitializeComponent();
            
        }


        private void NPage1_Load(object sender, EventArgs e)
        {
           
            panel1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "Zero";
            NPage1 np1 = new NPage1();
             panel1.Show();
            panel1.BringToFront();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_0.wav");
            player.Play();
         
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            label2.Text = "One";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_1.wav");
            player.Play();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
            label2.Text = "Two";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_2.wav");
            player.Play();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
            label2.Text = "Three";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_3.wav");
            player.Play();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
            label2.Text = "Four";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_4.wav");
            player.Play();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
            label2.Text = "Five";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_5.wav");
            player.Play();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
            label2.Text = "Six";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_6.wav");
            player.Play();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "2";
            label2.Text = "Two";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_2.wav");
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
            panel1.Hide();
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            NPage2 np2 = new NPage2();
            np2.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numbers num = new Numbers();
            num.Show();
            this.Hide();
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
            buttonToolTip.SetToolTip(pictureBox13, "Click on a number to start learning \nClick next to move to the next set of numbers");
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"v2.wav");
            player.Play();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Numbers numb = new Numbers();
            numb.Show();
            this.Hide();
        }
    }
}
