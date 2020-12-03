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
    public partial class MathsActivity : Form
    {
        public static int Round;
        public MathsActivity()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Maths btn = new Maths();
            btn.Show();
            this.Hide();
        }

        private void pnlAdd1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MathsActivity_Load(object sender, EventArgs e)
        {
            pnlAdd1.BringToFront();
            pnlAdd1.Size = new Size(1296, 583);
            pnlAdd1.Location = new Point(3, 2);
            Round = 1;
            pnlAdd2.Visible = false;
            pnlSub1.Visible = false;
            pnlSub2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            Round += 1;

            if (Round == 2)
            {
                pnlAdd2.BringToFront();
                pnlAdd2.Size = new Size(1296, 583);
                pnlAdd2.Location = new Point(3, 2);
                pnlAdd2.Visible = true;
                pnlAdd1.SendToBack();
                pnlAdd1.Visible = false;
               
            }
            else
            if (Round == 3)
            {
                pnlSub1.BringToFront();
                pnlSub1.Size = new Size(1296, 583);
                pnlSub1.Location = new Point(3, 2);
                pnlSub1.Visible = true;
                pnlAdd2.SendToBack();
                pnlAdd2.Visible = false;
            }
            else
            if (Round == 4)
            {
                pnlSub2.BringToFront();
                pnlSub2.Size = new Size(1296, 583);
                pnlSub2.Location = new Point(3, 2);
                pnlSub2.Visible = true;
                pnlSub1.SendToBack();
                pnlSub1.Visible = false;
            }
            if (Round == 5)
            {
                MessageBox.Show("Well done! You have successfully completed the maths activites\nFeel feel to play again if you want to.\nYou will now be returned to the menu");
                Maths m = new Maths();
                m.Show();
                this.Close();
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt1.Text == "2")
            {
                txt1.BackColor = Color.Green;
            }
            else
            {
                txt1.BackColor = Color.Red; ;
            };
            if (txt2.Text == "4")
            {
                txt2.BackColor = Color.Green;
            }
            else
            {
                txt2.BackColor = Color.Red; ;
            };
            if (txt3.Text == "6")
            {
                txt3.BackColor = Color.Green;
            }
            else
            {
                txt3.BackColor = Color.Red; ;
            };
            
            if ((txt1.BackColor == Color.Red) || (txt2.BackColor == Color.Red) || (txt3.BackColor == Color.Red))
            {
                MessageBox.Show("Oops. You did not get all the answeres correct , please try again");
            }
            else
            {
                MessageBox.Show("Well done! You got them all correct\nClick next to do more sums or click the back button to quit the game");
                button3.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "5")
            {
                textBox8.BackColor = Color.Green;
            }
            else
            {
                textBox8.BackColor = Color.Red; ;
            };
            if (textBox7.Text == "8")
            {
                textBox7.BackColor = Color.Green;
            }
            else
            {
                textBox7.BackColor = Color.Red; ;
            };
            if (textBox6.Text == "9")
            {
                textBox6.BackColor = Color.Green;
            }
            else
            {
                textBox6.BackColor = Color.Red; ;
            };

            if ((textBox8.BackColor == Color.Red) || (textBox7.BackColor == Color.Red) || (textBox6.BackColor == Color.Red))
            {
                MessageBox.Show("Oops. You did not get all the answeres correct , please try again");
            }
            else
            {
                MessageBox.Show("Well done! You got them all correct\nClick next to do more sums or click the back button to quit the game");
                button5.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "0")
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red; ;
            };
            if (textBox4.Text == "2")
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red; ;
            };
            if (textBox3.Text == "2")
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red; ;
            };

            if ((textBox5.BackColor == Color.Red) || (textBox4.BackColor == Color.Red) || (textBox3.BackColor == Color.Red))
            {
                MessageBox.Show("Oops. You did not get all the answeres correct , please try again");
            }
            else
            {
                MessageBox.Show("Well done! You got them all correct\nClick next to do more sums or click the back button to quit the game");
                button4.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "1")
            {
                textBox11.BackColor = Color.Green;
            }
            else
            {
                textBox11.BackColor = Color.Red; ;
            };
            if (textBox10.Text == "2")
            {
                textBox10.BackColor = Color.Green;
            }
            else
            {
                textBox10.BackColor = Color.Red; ;
            };
            if (textBox9.Text == "0")
            {
                textBox9.BackColor = Color.Green;
            }
            else
            {
                textBox9.BackColor = Color.Red; ;
            };

            if ((textBox11.BackColor == Color.Red) || (textBox10.BackColor == Color.Red) || (textBox9.BackColor == Color.Red))
            {
                MessageBox.Show("Oops. You did not get all the answeres correct , please try again");
            }
            else
            {
                MessageBox.Show("Well done! You got them all correct\nClick next to do more sums or click the back button to quit the game");
                button6.Enabled = false;
            }
        }
    }
}
