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
    public partial class NPage4 : Form
    {
        public NPage4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            label1.Text = "15";
            label2.Text = "Fifteen";
            NPage4 np4 = new NPage4();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_15.wav");
            player.Play();
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            label1.Text = "16";
            label2.Text = "Sixteen";
            NPage4 np4 = new NPage4();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_16.wav");
            player.Play();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            label1.Text = "17";
            label2.Text = "Seventeen";
            NPage4 np4 = new NPage4();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_17.wav");
            player.Play();
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            label1.Text = "18";
            label2.Text = "Eighteen";
            NPage4 np4 = new NPage4();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_18.wav");
            player.Play();
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            label1.Text = "19";
            label2.Text = "Nineteen";
            NPage4 np4 = new NPage4();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_19.wav");
            player.Play();
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            label1.Text = "20";
            label2.Text = "Twenty";
            NPage4 np4 = new NPage4();
            panel1.Show();
            panel1.BringToFront();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"converted_20.wav");
            player.Play();
        }

        private void NPage4_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NPage3 n3 = new NPage3();
            n3.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Numbers n = new Numbers();
            n.Show();
            this.Hide();

            MessageBox.Show("Well Done!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Numbers num = new Numbers();
            num.Show();
            this.Hide();
        }
    }
}
