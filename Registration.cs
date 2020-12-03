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
using System.Net.Mail;
using System.Net;

namespace Will
{
    public partial class Registration : Form
    {
        public static int ID ;
        String UserRole ,ParentEmailAddress =" ";
       public static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "XN7rBhKx0fHhK9W9wJa7PN1wWYq02MAe4LAQX8rF",
            BasePath = "https://will-firebase-10701.firebaseio.com/"

        };

        public static IFirebaseClient client;
        public Registration()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var m = new LoginForm();
            m.Show();
            this.Hide();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
           


            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Connected to database");
            }
          
            radioButton2.Checked = true;
            groupBox2.Visible = false;
            button1.Visible = false;
            txtCName.Clear();
            txtCPass.Clear();
            txtCUser.Clear();
            txtEmail.Clear();
            txtName.Clear();
            txtNumber.Clear();
            txtPass.Clear();
            txtSurname.Clear();
            txtUser.Clear();

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            txtReg.Text = " Registering , please wait...";
            if (radioButton2.Checked == true)
            {
                var data = new Data
                {
                    name = txtName.Text,
                    surname = txtSurname.Text,
                    date_of_birth = dtpDOB.Value.ToString("yyyy-MM-dd"),
                    contact_no = txtNumber.Text,
                    email = txtEmail.Text,
                    username = txtUser.Text,
                    password = txtPass.Text,
                    user_role = UserRole
                    };
                

                if (UserRole == " ")
                {
                    UserRole = "Parent";
                }


                SetResponse response = await client.SetTaskAsync("Registration Information/" + txtUser.Text, data);
                Data result = response.ResultAs<Data>();
                ParentEmailAddress = result.email;
                String message = result.name + ", you have been successfully registered as a " + result.user_role + "\nYour username : " + result.username + "\nYour password : " + result.password ;
                SendEmail(message, result.email);
                txtReg.Text = "";
                MessageBox.Show("Registration successful , check your email for your login credentials.\nPlease enter your childs information next");
                groupBox2.Visible = true;
                groupBox1.Enabled = false;
                button1.Visible = true;
                btnRegister.Enabled = false;
                  
            }
            else
            {
                var data = new Data
                {
                    name = txtName.Text,
                    surname = txtSurname.Text,
                    date_of_birth = dtpDOB.Value.ToString("yyyy-MM-dd"),
                    contact_no = txtNumber.Text,
                    email = txtEmail.Text,
                    username = txtUser.Text,
                    password = txtPass.Text,
                    user_role = UserRole


                };


               

                if (UserRole == " ")
                {
                    UserRole = "Parent";
                }

               


                SetResponse response = await client.SetTaskAsync("Registration Information/" + txtUser.Text, data);
                
                Data result = response.ResultAs<Data>();
               
               
                String message = result.name + ", you have been successfully registered as a " + result.user_role + "\nYour username : " + result.username + "\nYour password : " + result.password;
                SendEmail(message, data.email);
                txtReg.Text = "";
                MessageBox.Show("Registration successful , please check your email");
               

            }
           

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox1.Text = " Teacher's information";
            UserRole = "Teacher";
            if (groupBox1.Enabled == false)
            {
                groupBox1.Enabled = true;
            }
          
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
            groupBox2.Enabled = true;
            groupBox1.Text = " Parent's information";
            UserRole = "Parent";
            if (groupBox1.Enabled == false)
            {
                groupBox1.Enabled = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ID++;
            txtReg1.Text = " Registering , please wait...";

            var data = new Data
            {

                name = txtCName.Text,
                surname = txtSurname.Text,
                date_of_birth = dtpCDOB.Value.ToString("yyyy-MM-dd"),
                contact_no = txtNumber.Text,
                email = txtEmail.Text,
                username = txtCUser.Text,
                password = txtCPass.Text,
                user_role = "Student",
                number_level = "1",
                Points = "0"
            };


            //
           

            var data2 = new Data
            {

                name = txtName.Text,
                surname = txtSurname.Text,
                date_of_birth = dtpDOB.Value.ToString("yyyy-MM-dd"),
                contact_no = txtNumber.Text,
                email = txtEmail.Text,
                username = txtUser.Text,
                password = txtPass.Text,
                user_role = UserRole,
                ChildsName = txtCUser.Text
               


            };

            FirebaseResponse response2 = await client.UpdateTaskAsync("Registration Information/" + txtUser.Text+ "/", data2);

            Data result2 = response2.ResultAs<Data>();
            //


            var data3 = new Data
            {

               
                 username = txtCUser.Text
               



            };

            if (UserRole == " ")
            {
                UserRole = "Parent";
            };


            SetResponse response = await client.SetTaskAsync("Registration Information/" + txtCUser.Text, data);
            SetResponse response3 = await client.SetTaskAsync("StudentList/" + ID, data3);
            Data result = response.ResultAs<Data>();
           String message = "Your child, " + result.name +" has been successfully registered as a " + result.user_role + "\nTheir username : " + result.username + "\nTheir password : " + result.password;
            SendEmail(message, ParentEmailAddress);
            txtReg1.Text = "";
            MessageBox.Show("Registration successful , please check your email for your child's login credentails");
           






        }


        public static void SendEmail(String message ,String rec)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("keagilemaripane@gmail.com");
                mail.To.Add(rec);
                mail.Subject = "Little Thinkers - Successful registration";
                mail.Body = message;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("keagilemaripane@gmail.com", "Batha1998*");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
