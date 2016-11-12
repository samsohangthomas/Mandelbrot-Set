﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot_Set
{
    public partial class MandelbrotSet : Form
    {

        HSB HSBcolor = new HSB();//HSB to RGB Converter Class -- return r , g , b value
        private const int MAX = 256;      // max iterations
        private const double SX = -2.025; // start value real
        private const double SY = -1.125; // start value imaginary
        private const double EX = 0.6;    // end value real
        private const double EY = 1.125;  // end value imaginary
        private static int x1, y1, xs, ys, xe, ye;
        private static double xstart, ystart, xende, yende, xzoom, yzoom;
        private static Boolean action, mousePressed, rectangle, finished, first = true;
        private static float xy;



        //Bitmap and graphics 
        private Bitmap picture;
        private Graphics g1;
        private Cursor c1, c2;


        private void pictureOutputBox_MouseDown(object sender, MouseEventArgs e)
        {
            //e.consume();
            if (action)
            {
                mousePressed = true;
                xs = e.X;
                ys = e.Y;
            }
        }

        private void pictureOutputBox_MouseMove(object sender, MouseEventArgs e)
        {
            //e.consume();
            if (action && mousePressed)
            {
                xe = e.X;
                ye = e.Y;
                rectangle = true;
                pictureOutputBox.Refresh();
            }
        }

        private void pictureOutputBox_MouseUp(object sender, MouseEventArgs e)
        {
            int z, w;

            //e.consume();
            if (action && mousePressed)
            {
                xe = e.X;
                ye = e.Y;
                if (xs > xe)
                {
                    z = xs;
                    xs = xe;
                    xe = z;
                }
                if (ys > ye)
                {
                    z = ys;
                    ys = ye;
                    ye = z;
                }
                w = (xe - xs);
                z = (ye - ys);
                if ((w < 2) && (z < 2)) initvalues();
                else
                {
                    if (((float)w > (float)z * xy)) ye = (int)((float)ys + (float)w / xy);
                    else xe = (int)((float)xs + (float)z * xy);
                    xende = xstart + xzoom * (double)xe;
                    yende = ystart + yzoom * (double)ye;
                    xstart += xzoom * (double)xs;
                    ystart += yzoom * (double)ys;
                }
                xzoom = (xende - xstart) / (double)x1;
                yzoom = (yende - ystart) / (double)y1;
                mandelbrot();
                rectangle = false;
                pictureOutputBox.Refresh();
                mousePressed = false;
            }
        }

        

        public MandelbrotSet()
        {
            InitializeComponent();
            setPictureBoxSize(640, 480);
            init();
        }



        private void pictureOutputBox_Paint(object sender, PaintEventArgs e)
        {
            update();
        }


        private void setPictureBoxSize(int width, int height)
        {
            this.pictureOutputBox.Size = new System.Drawing.Size(width, height);
        }



        public void init()
        {
            finished = false;
            c1 = Cursors.WaitCursor;
            c2 = Cursors.Cross;
            x1 = pictureOutputBox.Width;
            y1 = pictureOutputBox.Height;
            xy = (float)x1 / (float)y1;
            picture = new Bitmap(pictureOutputBox.Width, pictureOutputBox.Height);
            g1 = Graphics.FromImage(picture);
            finished = true;
            start();
        }



        public void start()
        {
            action = false;
            rectangle = false;
            initvalues();
            xzoom = (xende - xstart) / (double)x1;
            yzoom = (yende - ystart) / (double)y1;
            mandelbrot();
        }



        private void initvalues() // reset start values
        {
            xstart = SX;
            ystart = SY;
            xende = EX;
            yende = EY;
            if ((float)((xende - xstart) / (yende - ystart)) != xy)
                xstart = xende - (yende - ystart) * (double)xy;
        }


        public void destroy() // delete all instances 
        {
            if (finished)
            {
                picture = null;
                g1 = null;
                c1 = null;
                c2 = null;
                GC.Collect(); // garbage collection
            }
        }


        public void update()
        {
            Bitmap picInstance = (Bitmap)picture.Clone();
            Graphics g = Graphics.FromImage(picInstance);
            Rectangle rect;

            if (rectangle)
            {
                Pen pen = new Pen(Color.White);

                if (xs < xe)
                {
                    rect = (ys < ye) ? new Rectangle(xs, ys, (xe - xs), (ye - ys)) : new Rectangle(xs, ye, (xe - xs), (ys - ye));
                }
                else
                {
                    rect = (ys < ye) ? new Rectangle(xe, ys, (xs - xe), (ye - ys)) : new Rectangle(xe, ye, (xs - xe), (ys - ye));
                }

                g.DrawRectangle(pen, rect);
                pictureOutputBox.Image = picInstance;

            }
        }


        private void mandelbrot() // calculate all points
        {
            int x, y;
            float h, b, alt = 0.0f;
            Pen pen = new Pen(Color.White);

            action = false;
            this.Cursor = c1;
            if (first == true)
            {
                showStatus("Mandelbrot Application Started");
            }
            if (first == false)
            {
                showStatus("Mandelbrot-Set will be produced - please wait...");
            }



            for (x = 0; x < x1; x += 2)
            {
                for (y = 0; y < y1; y++)
                {
                    h = pointcolour(xstart + xzoom * (double)x, ystart + yzoom * (double)y); // hue value

                    if (h != alt)
                    {
                        b = 1.0f - h * h; // brightness

                        HSBcolor.HSBTORGB(h, 0.8f, b); //convert hsb to rgb then make a Java Color
                        Color col = Color.FromArgb(Convert.ToByte(HSBcolor.rChan), Convert.ToByte(HSBcolor.gChan), Convert.ToByte(HSBcolor.bChan));

                        pen = new Pen(col);

                        //djm end
                        //djm added to convert to RGB from HSB

                        alt = h;
                    }
                    g1.DrawLine(pen, new Point(x, y), new Point(x + 1, y)); // drawing pixel
                }

            }
            if (first == false)
            {
                showStatus("Mandelbrot-Set ready - please select zoom area with pressed mouse.");
            }
            first = false;
            this.Cursor = c2;
            action = true;

            pictureOutputBox.Image = picture;
        }


        private float pointcolour(double xwert, double ywert) // color value from 0.0 to 1.0 by iterations
        {
            double r = 0.0, i = 0.0, m = 0.0;
            int j = 0;

            while ((j < MAX) && (m < 4.0))
            {
                j++;
                m = r * r - i * i; // x^2 - y^2
                i = 2.0 * r * i + ywert; // 2xy + c
                r = m + xwert;
            }
            return (float)j / (float)MAX;
        }





        public void showStatus(String status)
        {
            appStatus.Text = status;
        }




        class HSB
        {
            public float rChan, gChan, bChan;
            public HSB()
            {
                rChan = gChan = bChan = 0;
            }
            public void HSBTORGB(float h, float s, float b)
            {
                if (s == 0)
                {
                    rChan = gChan = bChan = (int)(b * 255.0f + 0.5f);
                }
                else
                {
                    h = (h - (float)Math.Floor(h)) * 6.0f;
                    float f = h - (float)Math.Floor(h);
                    float p = b * (1.0f - s);
                    float q = b * (1.0f - s * f);
                    float t = b * (1.0f - (s * (1.0f - f)));
                    switch ((int)h)
                    {
                        case 0:
                            rChan = (int)(b * 255.0f + 0.5f);
                            gChan = (int)(t * 255.0f + 0.5f);
                            bChan = (int)(p * 255.0f + 0.5f);
                            break;
                        case 1:
                            rChan = (int)(q * 255.0f + 0.5f);
                            gChan = (int)(b * 255.0f + 0.5f);
                            bChan = (int)(p * 255.0f + 0.5f);
                            break;
                        case 2:
                            rChan = (int)(p * 255.0f + 0.5f);
                            gChan = (int)(b * 255.0f + 0.5f);
                            bChan = (int)(t * 255.0f + 0.5f);
                            break;
                        case 3:
                            rChan = (int)(p * 255.0f + 0.5f);
                            gChan = (int)(q * 255.0f + 0.5f);
                            bChan = (int)(b * 255.0f + 0.5f);
                            break;
                        case 4:
                            rChan = (int)(t * 255.0f + 0.5f);
                            gChan = (int)(p * 255.0f + 0.5f);
                            bChan = (int)(b * 255.0f + 0.5f);
                            break;
                        case 5:
                            rChan = (int)(b * 255.0f + 0.5f);
                            gChan = (int)(p * 255.0f + 0.5f);
                            bChan = (int)(q * 255.0f + 0.5f);
                            break;
                    }
                }
            }
        }




    }
}
