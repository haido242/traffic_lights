using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        circles[] c = new circles[6];


        //time state
        int time = 80;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //countdown timer 20 seconds and display it in the circle, reset the timer when it reaches 0
            time--;
            Console.WriteLine(time.ToString());

            if (time == 0)
            {
                time = 200;
                flag = !flag;
            }

            //redraw
            Invalidate();


        }

        bool flag = true;
        Color[] gradient = {Color.Green, Color.White};

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // draw 6 circles 3x2 and fit them in the picture box with gray background color and black border 3px
            c[0] = new circles(10, 10, 100);
            c[1] = new circles(120, 10, 100);
            c[2] = new circles(10, 120, 100);
            c[3] = new circles(120, 120, 100);
            c[4] = new circles(10, 230, 100);
            c[5] = new circles(120, 230, 100);
            timer1.Start();
            

                    GraphicsPath path = new GraphicsPath();
            if (flag)
            {

                //c0
               if(time > 50){
                    //  g.FillEllipse(Brushes.Green, c[0].x, c[0].y, c[0].r, c[0].r);
                    //color gradient from green to white and change the color center to outside
                    path.AddEllipse(c[0].x, c[0].y, c[0].r, c[0].r);
                    PathGradientBrush pthGrBrush = new PathGradientBrush(path);

                    // Set the color at the center of the path to blue.
                    pthGrBrush.CenterColor = Color.FromArgb(255, 0, 130, 50);

                    // Set the color along the entire boundary
                    // of the path to aqua.
                    Color[] colors = { Color.FromArgb(150, 32, 250, 116) };
                    pthGrBrush.SurroundColors = colors;

                    e.Graphics.FillEllipse(pthGrBrush, c[0].x, c[0].y, c[0].r, c[0].r);


                    g.DrawString((time / 10).ToString(), new Font("Arial", 20), Brushes.White, c[0].x + 30, c[0].y + 30);
               }
                else{
                g.FillEllipse(Brushes.Gray, c[0].x, c[0].y, c[0].r, c[0].r);
                g.DrawEllipse(Pens.Black, c[0].x, c[0].y, c[0].r, c[0].r);
                }


                //c1
                g.FillEllipse(Brushes.Gray, c[1].x, c[1].y, c[1].r, c[1].r);
                g.DrawEllipse(Pens.Black, c[1].x, c[1].y, c[1].r, c[1].r);


                //c2
                if (time < 50)
                {
                    path.AddEllipse(c[2].x, c[2].y, c[2].r, c[2].r);
                    PathGradientBrush pthGrBrush = new PathGradientBrush(path);

                    // Set the color at the center of the path to blue.
                    pthGrBrush.CenterColor = Color.FromArgb(255, 255, 255, 0);

                    // Set the color along the entire boundary
                    // of the path to aqua.
                    Color[] colors = { Color.FromArgb(90, 255, 255, 0) };
                    pthGrBrush.SurroundColors = colors;

                    e.Graphics.FillEllipse(pthGrBrush, c[2].x, c[2].y, c[2].r, c[2].r);


                }
                else
                {
                    g.FillEllipse(Brushes.Gray, c[2].x, c[2].y, c[2].r, c[2].r);
                    g.DrawEllipse(Pens.Black, c[2].x, c[2].y, c[2].r, c[2].r);
                }

                //c3
                g.FillEllipse(Brushes.Gray, c[3].x, c[3].y, c[3].r, c[3].r);
                g.DrawEllipse(Pens.Black, c[3].x, c[3].y, c[3].r, c[3].r);

 

                //c4
                g.FillEllipse(Brushes.Gray, c[4].x, c[4].y, c[4].r, c[4].r);
                g.DrawEllipse(Pens.Black, c[4].x, c[4].y, c[4].r, c[4].r);


                //c5
                path.AddEllipse(c[5].x, c[5].y, c[5].r, c[5].r);
                PathGradientBrush pthGrBrush2 = new PathGradientBrush(path);
            

                    // Set the color at the center of the path to blue.
                    pthGrBrush2.CenterColor = Color.FromArgb(255, 255,0,  0);

                    // Set the color along the entire boundary
                    // of the path to aqua.
                    Color[] colors2 = { Color.FromArgb(90, 255, 255, 255) };
                    pthGrBrush2.SurroundColors = colors2;

                    e.Graphics.FillEllipse(pthGrBrush2, c[5].x, c[5].y, c[5].r, c[5].r);


                g.DrawString((time / 10).ToString(), new Font("Arial", 20), Brushes.White, c[5].x + 30, c[5].y + 30);
            }
            else
            {
                  //c0
               if(time > 50){
                    path.AddEllipse(c[1].x, c[1].y, c[1].r, c[1].r);
                    PathGradientBrush pthGrBrush = new PathGradientBrush(path);

                    // Set the color at the center of the path to blue.
                    pthGrBrush.CenterColor = Color.FromArgb(255, 0, 255, 0);

                    // Set the color along the entire boundary
                    // of the path to aqua.
                    Color[] colors = { Color.FromArgb(50, 0, 255, 0) };
                    pthGrBrush.SurroundColors = colors;

                    e.Graphics.FillEllipse(pthGrBrush, c[1].x, c[1].y, c[1].r, c[1].r);

                    g.DrawString((time / 10).ToString(), new Font("Arial", 20), Brushes.White, c[1].x + 30, c[1].y + 30);
               }
                else{
                g.FillEllipse(Brushes.Gray, c[1].x, c[1].y, c[1].r, c[1].r);
                g.DrawEllipse(Pens.Black, c[1].x, c[1].y, c[1].r, c[1].r);
                }


                //c1
                g.FillEllipse(Brushes.Gray, c[0].x, c[0].y, c[0].r, c[0].r);
                g.DrawEllipse(Pens.Black, c[0].x, c[0].y, c[0].r, c[0].r);


                //c2
                if (time < 50)
                {
                    path.AddEllipse(c[3].x, c[3].y, c[3].r, c[3].r);
                    PathGradientBrush pthGrBrush = new PathGradientBrush(path);

                    // Set the color at the center of the path to blue.
                    pthGrBrush.CenterColor = Color.FromArgb(255, 255, 255, 0);

                    // Set the color along the entire boundary
                    // of the path to aqua.
                    Color[] colors = { Color.FromArgb(90, 255, 255, 0) };
                    pthGrBrush.SurroundColors = colors;

                    e.Graphics.FillEllipse(pthGrBrush, c[3].x, c[3].y, c[3].r, c[3].r);

                }
                else
                {
                    g.FillEllipse(Brushes.Gray, c[3].x, c[3].y, c[3].r, c[3].r);
                }
                    g.DrawEllipse(Pens.Black, c[3].x, c[3].y, c[3].r, c[3].r);

                //c3
                g.FillEllipse(Brushes.Gray, c[2].x, c[2].y, c[2].r, c[2].r);
                g.DrawEllipse(Pens.Black, c[2].x, c[2].y, c[2].r, c[3].r);

 

                //c4
                g.FillEllipse(Brushes.Gray, c[5].x, c[5].y, c[5].r, c[5].r);
                g.DrawEllipse(Pens.Black, c[5].x, c[5].y, c[5].r, c[5].r);


                //c5
                path.AddEllipse(c[4].x, c[4].y, c[4].r, c[4].r);
                PathGradientBrush pthGrBrush2 = new PathGradientBrush(path);
            

                    // Set the color at the center of the path to blue.
                    pthGrBrush2.CenterColor = Color.FromArgb(255, 255,0,  0);

                    // Set the color along the entire boundary
                    // of the path to aqua.
                    Color[] colors2 = { Color.FromArgb(90, 255, 0, 0) };
                    pthGrBrush2.SurroundColors = colors2;

                    e.Graphics.FillEllipse(pthGrBrush2, c[4].x, c[4].y, c[4].r, c[4].r);

                g.DrawString((time / 10).ToString(), new Font("Arial", 20), Brushes.White, c[4].x + 30, c[4].y + 30);
            }



        }

    }
}
