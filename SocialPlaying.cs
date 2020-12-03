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
    public partial class SocialPlaying : Form
    {
        public SocialPlaying()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Social_stories SS = new Social_stories();
            SS.Show();
            this.Hide();
        }
    }
}
