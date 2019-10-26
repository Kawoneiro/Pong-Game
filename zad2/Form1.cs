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
            ball.Location = new Point(10, 10);
            listBalls.Add(ball);
            panel1.Controls.Add(ball);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int dx = 0;
            int dy = 0;
            foreach(Ball ball in listBalls)
            {
                dy = ball.Top + Convert.ToInt32(ball.Vy);
                dx = ball.Left + Convert.ToInt32(ball.Vx);

                if (dx < 0) 
                {
                    dx = 0;
                    ball.Vx = ball.Vx * -1;
                }
                if (dx > panel1.Width - ball.Width)
                {
                    dx = panel1.Width - ball.Width;
                    ball.Vx = ball.Vx * -1;
                }
                if (dy < 0)
                {
                    dy = 0;
                    ball.Vy = ball.Vy * -1;
                }
                if (dy > panel1.Height - ball.Height)
                {
                    dy = panel1.Height - ball.Height;
                    ball.Vy = ball.Vy * -1;
                }
                ball.Location = new Point(dx, dy);
            }
        }
    }
}
