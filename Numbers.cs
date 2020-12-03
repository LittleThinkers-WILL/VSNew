
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Will
{
    public partial class Numbers : Form
    {
        public static IFirebaseClient client;


        public Numbers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NPage1 n1 = new NPage1();
            n1.Show();
            this.Hide();

            MessageBox.Show("Click on a number to start learning \nClick next to move to the next set of numbers");
        }

        private void Numbers_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(Registration.config);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentForm sfrm = new StudentForm();
            sfrm.Show();
            this.Close();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
          

            NumbersActivity na = new NumbersActivity();
            na.Show();

        }



       
    }
}
