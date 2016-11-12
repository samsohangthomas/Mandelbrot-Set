using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot_Set
{
    partial class MandelbrotSet
    {

        // mouse Events 
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

    }
}
