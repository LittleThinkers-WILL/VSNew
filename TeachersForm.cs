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
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            label1.Text = "WELCOME, " + LoginForm.CurrLogin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Child;
            FirebaseResponse res = Registration.client.Get("Registration Information/");


            {
                Data ResUser = res.ResultAs<Data>(); // database result

               


                label2.Text = ResUser.ChildsName;
            }
            {
                
            }
        }
    }
}
