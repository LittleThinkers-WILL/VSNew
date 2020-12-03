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
    public partial class NPage3 : Form
    {
        public NPage3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void NPage3_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            label1.Text = "10";
            label2.Text = "Ten";
            NPage3 np3 = new NPage3();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_10.wav");
            player.Play();
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            label1.Text = "11";
            label2.Text = "Eleven";
            NPage3 np3 = new NPage3();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_11.wav");
            player.Play();
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            label1.Text = "12";
            label2.Text = "Twelve";
            NPage3 np3 = new NPage3();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_12.wav");
            player.Play();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            label1.Text = "13";
            label2.Text = "Thirteen";
            NPage3 np3 = new NPage3();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_13.wav");
            player.Play();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            label1.Text = "14";
            label2.Text = "Fourteen";
            NPage3 np3 = new NPage3();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_14.wav");
            player.Play();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            label1.Text = "15";
            label2.Text = "Fifteen";
            NPage3 np3 = new NPage3();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_15.wav");
            player.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NPage2 n2 = new NPage2();
            n2.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Numbers num = new Numbers();
            num.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NPage4 n4 = new NPage4();
            n4.Show();
            this.Hide();
        }
    }
    }
