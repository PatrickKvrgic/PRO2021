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
            x = x + Math.Cos(alpha * Math.PI / 180);
            y = y + Math.Sin(alpha * Math.PI / 180);
            int x1 = drawX(oldX);
            int y1 = drawY(oldY);
            int x2 = drawX(x);
            int y2 = drawY(y);
            Pen p = new Pen(Color.Black, 3);
            g.DrawLine(p, x1, y1, x2, y2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            x = 0.5;
            y = 0.5;
            alpha = 0;
            Movement(0.5, g);
        }
    }
}
