using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad2
{
    class Ball : PictureBox
    {
        private double vx = 15;
        private double vy = 15;
        public double Vx { get { return vx; } set { vx = value; } }
        public double Vy { get { return vy; } set { vy = value; } }
        public Ball()
        {
            Image img = Image.FromFile( @"C:\Users\Laptop\Desktop\Visual Studio Programowanie\C# Obierak\2\zad2\zad2\Resources\soccer_ball_clip_art_13012.jpg");
            this.Image = img;
            this.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
