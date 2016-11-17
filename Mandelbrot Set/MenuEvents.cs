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


        private void startMandelbrot_Click(object sender, EventArgs e)
        {        
            mandelbrot(); 
        }

        private void stopMandelbrot_Click(object sender, EventArgs e)
        {
            this.stop();
        }



        private void reloadMandelbrot_Click(object sender, EventArgs e)
        {
            this.stop();
            start();
        }



        private void cloneMandelbrot_Click(object sender, EventArgs e)
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


        private void restartMandelbrot_Click(object sender, EventArgs e)
        {
            this.stop();
            mandelbrot();
        }



        private void saveMandelbrot_Click(object sender, EventArgs e)
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

        private void infoApplication_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mandelbrot Application v0.1 with customization. Thank You.");

        }




        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureOutputBox.Image, 0, 0);
        }


        private void printMandelbrot_Click(object sender, EventArgs e)
        {
            PrintDocument mandelbrot = new PrintDocument();
            mandelbrot.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            mandelbrot.Print();
        }



        private void closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void quitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void stop() {
            pictureOutputBox.Image = null;

        }
    }
}
