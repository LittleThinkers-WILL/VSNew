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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            label1.Text = "WELCOME, " + LoginForm.CurrLogin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Child;
            FirebaseResponse res = Registration.client.Get("Registration Information/" + LoginForm.CurrLogin);

            
            {
                Data ResUser = res.ResultAs<Data>(); // database result

                Child = ResUser.ChildsName;


                label2.Text = Child;
            }
            {
                FirebaseResponse res2 = Registration.client.Get("Registration Information/" + Child);
                Data ResUser2 = res2.ResultAs<Data>(); // database result
                label3.Text = ResUser2.date_of_birth;
            }
        }
    }
}
// you were trying to figure out increment the ID of the students in the databse