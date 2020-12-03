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
    public partial class UploadPictures : Form

    {
        ToolTip buttonToolTip = new ToolTip();
        public UploadPictures()
        {
            InitializeComponent();
        }

        private void UpdImg(object sender, EventArgs e)
        {
            String imgLocation = "";
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = open.FileName;

                    pbImage1.ImageLocation = imgLocation;

                }
            }
            catch(Exception)
            {
                MessageBox.Show("An Error Occurred","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void SaveAndExit(object sender, EventArgs e)
        {
            StudentForm std = new StudentForm();
            std.Show();
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
            buttonToolTip.SetToolTip(pictureBox17, "Hi!\nClick on the 'upload button' to select a picture of your choice\nFinish off by clicking the 'save and exit' button. ");

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"ImgUp.wav");
            player.Play();
        }
    }
}
