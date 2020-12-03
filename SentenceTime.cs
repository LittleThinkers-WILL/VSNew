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
    public partial class SentenceTime : Form
    {
        public SentenceTime()
        {
            InitializeComponent();
        }

        private void CreateSentences(object sender, EventArgs e)
        {
            CreateSentences sentences = new CreateSentences();
            sentences.Show();
            
        }

        private void MainMenu(object sender, EventArgs e)
        {
            StudentForm std = new StudentForm();
            std.Show();
            this.Hide();
        }
    }
}
