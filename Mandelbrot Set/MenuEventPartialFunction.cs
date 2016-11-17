using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot_Set
{
    partial class MandelbrotSet
    {


        // Prtial function 



        public void mandelbrotClone()
        {
            MandelbrotSet obj = new MandelbrotSet();

            obj.xstart = this.xstart;
            obj.ystart = this.ystart;
            obj.xende = this.xende;
            obj.yende = this.yende;
            obj.xzoom = this.xzoom;
            obj.yzoom = this.yzoom;
            obj.Show();
            obj.mandelbrot();
        }

        public void mandelbrotSave()
        {
            System.Windows.Forms.SaveFileDialog fileDestination = new SaveFileDialog();
            fileDestination.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (fileDestination.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(fileDestination.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureOutputBox.Image.Save(fileDestination.FileName, format);
                MessageBox.Show("Successfully saved. Thank you.");
            }

        }


        public void mandelbrotPrint()
        {

            PrintDocument mandelbrot = new PrintDocument();
            mandelbrot.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            mandelbrot.Print();
        }



        public void setDefaultIterateValue()
        {
            MAX = 256;
            start();
            iterateStat("Default Iteration 256 Times");
        }


    }
}
