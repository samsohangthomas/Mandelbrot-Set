using System;
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
    public partial class IterationForm : Form
    {
        private MandelbrotSet app;
        private int MAXi;
        public string msg;
        Boolean error = false, isNumber;


        public IterationForm(MandelbrotSet app)
        {
            InitializeComponent();
            this.app = app;
        }

        //relaoding mandelbrot with provided iteration value 

        private void reloadMandelbrot_Click(object sender, EventArgs e)
        {
            //validating form
            this.validate("Iteration Value", customValue.Text, "numeric");
         
            if (error == true)
            {
                MessageBox.Show(msg);
                msg = null;
                error = false;
            }
            else
            {
                MAXi = int.Parse(customValue.Text);
                app.redraw(MAXi);
                app.iterateStat("Custom Iteration " + MAXi + " Times");
                this.Close();
            }




          
        }


        
        private void validate(string fieldName, string data, string param)
        {
            //Validation logic

            switch (param)
            {
                case "required":
                    if (data == "")
                    {
                        msg += fieldName + " Field Cannot be Empty. \n";
                        error = true;
                    }
                    break;
                case "numeric":
                    isNumber = this.isNumeric(data);
                    if (isNumber == false)
                    {
                        msg += fieldName + " Field must be Numeric or not empty. \n";
                        error = true;
                    }


                    break;
            }

        }


        //trying to parse value from the given string
        private Boolean isNumeric(String val)
        {
            double a = 0;
            return double.TryParse(val, out a);
        }




    }
}
