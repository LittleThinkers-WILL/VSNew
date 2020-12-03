using FireSharp.Response;
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
    public partial class NumbersActivity : Form
    {

        ToolTip buttonToolTip = new ToolTip();

        public NumbersActivity()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            L4 l4 = new L4();
            l4.Show();
            this.Hide();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            L1 l1 = new L1();
            l1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            L2 l2 = new L2();
            l2.Show();
            this.Hide();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            L3 l3 = new L3();
            l3.Show();
            this.Hide();


          
        }

        private void NumbersActivity_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            FirebaseResponse res = Numbers.client.Get("Registration Information/" + LoginForm.CurrLogin );

            //look at how login is doing its validation and implement that ( comparing using res)
            try
            {
                Data ResUser = res.ResultAs<Data>(); // database result
               
                if (ResUser.number_level == "2")
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                else
                    if (ResUser.number_level == "3")
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                }
                else
                    if (ResUser.number_level == "4")
                {
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                }








            }
            catch (Exception x)
            {
                MessageBox.Show("Username does not exist");
            }









        }

        private void button5_Click(object sender, EventArgs e)
        {
            Numbers numbers = new Numbers();
            numbers.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
