using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractals
{
    public partial class Form1 : Form
    {
        private double x;       //turtles position
        private double y;       
        private double alpha;   //angle based on x
        public Form1()
        {
            InitializeComponent();
        }
        private int drawX(double xr)
        {
            return (int)Math.Round(this.Width * xr);
        }
        private int drawY(double yr)
        {
            return (int)Math.Round(this.Height - this.Height * yr);
        }
        public void TurnLeft(double angle)
        {
            alpha = alpha + angle;
        }
        public void Movement(double d, Graphics g)
        {
            double oldX = x;
            double oldY = y;
            x = x + d *Math.Cos(alpha * Math.PI / 180);
            y = y + d *Math.Sin(alpha * Math.PI / 180);
            int x1 = drawX(oldX);
            int y1 = drawY(oldY);
            int x2 = drawX(x);
            int y2 = drawY(y);
            Pen p = new Pen(Color.Black, 3);
            g.DrawLine(p, x1, y1, x2, y2);
        }

        public void Koch(int n, double step, Graphics g)
        {
            if (n == 0)
            {
                Movement(step, g);
                return;
            }
            Koch(n - 1, step, g);
            TurnLeft(60);
            Koch(n - 1, step, g);
            TurnLeft(-120);
            Koch(n - 1, step, g);
            TurnLeft(60);
            Koch(n - 1, step, g);
        }

        public void Drevo(int n, double x, double y, double a, double dolžina, Graphics g)
        {
            int kot = 30;
            double pojemek = 0.5;
            double cx = x + dolžina * Math.Cos(a * Math.PI / 180);
            double cy = y + dolžina * Math.Sin(a * Math.PI / 180);
            int x1 = drawX(cx);
            int y1 = drawY(cy);
            int x2 = drawX(x);
            int y2 = drawY(y);

            Random r = new Random();
            Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));

            Pen p = new Pen(c, (float)Math.Pow(n, r.Next(2)));
            g.DrawLine(p, x1, y1, x2, y2);
            if (n == 0)
            {
                return;
            }
            Drevo(n - 1, cx, cy, a - kot, dolžina * pojemek, g);
            Drevo(n - 1, cx, cy, a + kot, dolžina * pojemek, g);
            Drevo(n - 1, cx, cy, a, dolžina * (1 - pojemek), g);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //x = 0.2;
            //y = 0.9;
            //alpha = 0;
            //for (int k = 0; k < 4; k++)
            //{
            //    double step = 0.1;
            //    Movement(step, g);
            //    TurnLeft(-360 / 4);
            //}

            //Random r = new Random();
            //x = 0.5;
            //y = 0.5;
            //alpha = 0;
            //for (int k = 0; k < 10000; k++)
            //{
            //    TurnLeft(r.Next(360));
            //    Movement(0.01, g);
            //}

            //x = 0.3;
            //y = 0.9;
            //for (int k = 0; k < 6; k++)
            //{
            //    int n = 6;
            //    Koch(n, 1 / Math.Pow(3, n) * 0.1, g);
            //    TurnLeft(-360 / n);
            //}

            //int n = 10;
            //Drevo(n, 0.5, 0, 90, 0.5, g);
        }
    }
}
