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

        //application submenus event

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
            mandelbrotClone();
        }



        private void restartMandelbrot_Click(object sender, EventArgs e)
        {
            this.stop();
            mandelbrot();
        }



        private void saveMandelbrot_Click(object sender, EventArgs e)
        {
            mandelbrotSave();
          
        }


        

        //About submenus event

        private void infoApplication_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mandelbrot Application v0.1 with customization. Thank You.");

        }


        //window submenus event

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureOutputBox.Image, 0, 0);
        }


        private void printMandelbrot_Click(object sender, EventArgs e)
        {
            mandelbrotPrint();
        }



        private void closeApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void quitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //more submenus event

        private void defaultIteration_Click(object sender, EventArgs e)
        {
            setDefaultIterateValue();
          
        }

        private void customIteration_Click(object sender, EventArgs e)
        {
            showCustomIterationForm();
        }

        public void showCustomIterationForm() {
            IterationForm obj = new IterationForm(this);
            obj.Show();
        }






        public void redraw(int val)
        {
            MAX = val;
            start();
        }

        
        //Other function
        //clearing pictureOutputBox

        private void stop() {
            pictureOutputBox.Image = null;

        }

        // iteration status

        public void iterateStat(String stat)
        {
            iterateStatus.Text = stat;
        }

    }
}
