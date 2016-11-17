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


        private void keyboardShortcuts(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {

                switch (e.KeyCode)
                {
                    case Keys.S:
                        mandelbrotSave();
                        break;
                    case Keys.C:
                        mandelbrotClone();
                        break;
                    case Keys.P:
                        mandelbrotPrint();
                        break;
                }

            }
            else if (e.Alt)
            {
                switch (e.KeyCode)
                {
                    case Keys.C:
                        this.Close();
                        break;
                    case Keys.Q:
                        Application.Exit();
                        break;
                }

            }
            else{
                switch (e.KeyCode)
                {
                    case Keys.F10:
                        setDefaultIterateValue();
                        break;
                    case Keys.F11:
                        showCustomIterationForm();
                        break;
                    case Keys.F5:
                        stop();
                        start();
                        break;
                }
            }
        }

    }
}
