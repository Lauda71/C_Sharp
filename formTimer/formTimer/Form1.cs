using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace formTimer
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        public int a = 0, b = 0, c = 0;
        public int right = 0;
        public int timer = 0;
        public int act = 0;
        public int heartCount = 3;
        public string whatAct = "";
        public int good = 0;

        Random ran = new Random();

        public int msec = 70;

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (msec==1)
            {
                pbHeart1.Visible = false;
                pbHeart2.Visible = false;
                pbHeart3.Visible = false;
                msec = 0;
                labelTime.Text = Convert.ToString(msec / 10) + ":" + Convert.ToString(msec % 10);
                mainTimer.Enabled = false;
                MessageBox.Show("Время кончилось :(\nВыш счет: " + good, "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);                
                this.Close();
            }
            if (timer == 0)
            {
                msec--;

                if (msec == 0) msec = 69;


                labelTime.AutoSize = true;
                labelTime.Text = Convert.ToString(msec / 10) + ":" + Convert.ToString(msec % 10);
            }
            else
            {
                labelTime.Text = Convert.ToString(msec / 10) + ":" + Convert.ToString(msec % 10);
            }
            
        }

        private void btAnswer1_Click(object sender, EventArgs e)
        {
            if (right == 1)
            {
                good++;
                pbPlus.Visible = true;
                pbPlus.Update();
                timer = 1;
                Thread.Sleep(1000);
                timer = 0;
                pbPlus.Visible = false;
            }
            else
            {
                pbMinus.Visible = true;                
                pbMinus.Update();
                timer = 1;
                Thread.Sleep(1000);
                timer = 0;
                pbMinus.Visible = false;

                heartCount--;
                heart();
            }
            btStart_Click(null, null);
        }

        private void btAnswer2_Click(object sender, EventArgs e)
        {
            if (right == 2)
            {
                good++;
                pbPlus.Visible = true;
                pbPlus.Update();
                timer = 1;
                Thread.Sleep(1000);
                timer = 0;
                pbPlus.Visible = false;
            }
            else
            {
                pbMinus.Visible = true;
                pbMinus.Update();
                timer = 1;
                Thread.Sleep(1000);
                timer = 0;
                pbMinus.Visible = false;

                heartCount--;
                heart();
            }
            btStart_Click(null, null);
        }

        private void btAnswer3_Click(object sender, EventArgs e)
        {
            if (right == 3)
            {
                good++;
                pbPlus.Visible = true;
                pbPlus.Update();
                timer = 1;
                Thread.Sleep(1000);
                timer = 0;
                pbPlus.Visible = false;
            }
            else
            {
                pbMinus.Visible = true;
                pbMinus.Update();
                timer = 1;
                Thread.Sleep(1000);
                timer = 0;
                pbMinus.Visible = false;

                heartCount--;
                heart();
            }
            btStart_Click(null, null);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (a == 0 & b == 0 & c == 0) btStart.Enabled = false;

            btAnswer1.Enabled = true;
            btAnswer2.Enabled = true;
            btAnswer3.Enabled = true;

            int answer = 0;
            msec = 70;

            mainTimer.Enabled = true;
            mainTimer.Start();

            a = ran.Next(1, 25);
            b = ran.Next(1, 25);
            c = ran.Next(1, 25);

            labQuestion.Text = Convert.ToString(a);
            act = ran.Next(1, 3);
            if (act == 1)
            {
                answer = a + b;
                whatAct = " + ";
                labQuestion.Text = labQuestion.Text + whatAct + Convert.ToString(b);
            }
            else
            {
                answer = a - b;
                whatAct = " – ";
                labQuestion.Text = labQuestion.Text + whatAct + Convert.ToString(b);
            }

            act = ran.Next(1, 3);
            if (act == 1)
            {
                answer = answer + c;
                whatAct = " + ";
                labQuestion.Text = labQuestion.Text + whatAct + Convert.ToString(c) + " = ";
            }
            else
            {
                answer = answer - c;
                whatAct = " – ";
                labQuestion.Text = labQuestion.Text + whatAct + Convert.ToString(c) + " = ";
            }
            int ok = answer;

            a = ran.Next(1, 4);
            b = ran.Next(1, 7);
            c = ran.Next(1, 7);

            if (a == 1)
            {
                btAnswer1.Text = Convert.ToString(answer);
                right = 1;
                answer = ran.Next(1, 5);
                answers(answer, 1, ok);
            }
            else if (a == 2)
            {
                btAnswer2.Text = Convert.ToString(answer);
                right = 2;
                answer = ran.Next(1, 5);
                answers(answer, 2, ok);
            }
            else if (a == 3)
            {
                btAnswer3.Text = Convert.ToString(answer);
                right = 3;
                answer = ran.Next(1, 5);
                answers(answer, 3, ok);
            }



        }

        public void answers(int answer, int button, int ok)
        { 
            if (button == 1)
            {
                if (answer == 1)
                {
                    btAnswer2.Text = Convert.ToString(ok - b);
                    btAnswer3.Text = Convert.ToString(ok - c);
                }
                else if (answer == 2)
                {
                    btAnswer2.Text = Convert.ToString(ok + b);
                    btAnswer3.Text = Convert.ToString(ok - c);
                }
                else if (answer == 3)
                {
                    btAnswer2.Text = Convert.ToString(ok - b);
                    btAnswer3.Text = Convert.ToString(ok + c);
                }
                else
                {
                    btAnswer2.Text = Convert.ToString(ok + b);
                    btAnswer3.Text = Convert.ToString(ok + c);
                }
            }
            else if (button == 2)
            {
                if (answer == 1)
                {
                    btAnswer1.Text = Convert.ToString(ok - b);
                    btAnswer3.Text = Convert.ToString(ok - c);
                }
                else if (answer == 2)
                {
                    btAnswer1.Text = Convert.ToString(ok + b);
                    btAnswer3.Text = Convert.ToString(ok - c);
                }
                else if (answer == 3)
                {
                    btAnswer1.Text = Convert.ToString(ok - b);
                    btAnswer3.Text = Convert.ToString(ok + c);
                }
                else
                {
                    btAnswer1.Text = Convert.ToString(ok + b);
                    btAnswer3.Text = Convert.ToString(ok + c);
                }
            }
            else if (button == 3)
            {
                if (answer == 1)
                {
                    btAnswer1.Text = Convert.ToString(ok - b);
                    btAnswer2.Text = Convert.ToString(ok - c);
                }
                else if (answer == 2)
                {
                    btAnswer1.Text = Convert.ToString(ok + b);
                    btAnswer2.Text = Convert.ToString(ok - c);
                }
                else if (answer == 3)
                {
                    btAnswer1.Text = Convert.ToString(ok - b);
                    btAnswer2.Text = Convert.ToString(ok + c);
                }
                else
                {
                    btAnswer1.Text = Convert.ToString(ok + b);
                    btAnswer2.Text = Convert.ToString(ok + c);
                }
            }            
        }

        public void heart()
        {            
            if (heartCount == 2)
            {
                pbHeart3.Visible = false;
            }
            else if (heartCount == 1)
            {
                pbHeart2.Visible = false;
            }
            else
            {
                pbHeart1.Visible = false;
                labelTime.Text = Convert.ToString(msec / 10) + ":" + Convert.ToString(msec % 10);
                mainTimer.Enabled = false;
                MessageBox.Show("Вы проиграли :(\nВыш счет: " + good, "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                this.Close();
            }
        }

    }
}
