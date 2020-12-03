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
    public partial class NPage2 : Form
    {
        public NPage2()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            label1.Text = "6";
            label2.Text = "Six";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_6.wav");
            player.Play();
        }

        private void NPage2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "7";
            label2.Text = "Seven";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_7.wav");
            player.Play();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            label1.Text = "8";
            label2.Text = "Eight";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_8.wav");
            player.Play();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            label1.Text = "9";
            label2.Text = "Nine";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_9.wav");
            player.Play();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            label1.Text = "10";
            label2.Text = "Ten";
            NPage1 np1 = new NPage1();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_10.wav");
            player.Play();
        }

        private void btnPage2_Click(object sender, EventArgs e)
        {
            this.Close();
            NPage3 np3 = new NPage3();
            np3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.SendToBack();
            panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numbers num = new Numbers();
            num.Show();
            this.Close();
        }

        private void btnBacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            NPage1 np1 = new NPage1();
            np1.Show();
        }
    }
}
