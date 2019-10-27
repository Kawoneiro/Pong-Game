using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    public partial class Form1 : Form
    {
        private int padx;
        private bool drag;
        bool flaga = true;
        List<Ball> listBalls = new List<Ball>();
        public Form1()
        {
            InitializeComponent();
        }
        private void startbtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (flaga == true)
            {
                timer1.Start();
                flaga = false;
                startbtn.Text = "STOP";
            }
            else
            {
                timer1.Stop();
                flaga = true;
                startbtn.Text = "START";
            }
        }

    private void genbtn_Click(object sender, EventArgs e)
        {
            Ball ball = new Ball();
            ball.Location = new Point(0, 0);
            listBalls.Add(ball);
            panel1.Controls.Add(ball);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Ball ball in listBalls)
            {
                ball.Left += (int)ball.Vx;
                ball.Top += (int)ball.Vy;
                if (ball.Left <= -20) 
                {
                    ball.Vx = ball.Vx * -1;
                }
                if (ball.Left >= panel1.Width - ball.Width + 20)
                {
                    ball.Vx = ball.Vx * -1;
                }
                if (ball.Top < 0)
                {
                    ball.Vy = ball.Vy * -1;
                }
                if (ball.Top > panel1.Height - ball.Height)
                {
                    ball.Vy = ball.Vy * -1;
                }
            }
        }

        private void PadMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            drag = true;
            padx = e.X;
        }

        private void PadMouseUp(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (null == c) return;
            drag = false;
        }

        private void PadMouseMove(object sender, MouseEventArgs e)
        {
            var c = sender as PictureBox;
            if (!drag || null == c) return;
            pad.Left = e.X + pad.Left - padx;
        }
    }
}
