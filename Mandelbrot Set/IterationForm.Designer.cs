namespace Mandelbrot_Set
{
    partial class IterationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reloadMandelbrot = new System.Windows.Forms.Button();
            this.customValue = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reloadMandelbrot
            // 
            this.reloadMandelbrot.Location = new System.Drawing.Point(140, 38);
            this.reloadMandelbrot.Name = "reloadMandelbrot";
            this.reloadMandelbrot.Size = new System.Drawing.Size(75, 23);
            this.reloadMandelbrot.TabIndex = 0;
            this.reloadMandelbrot.Text = "Reload";
            this.reloadMandelbrot.UseVisualStyleBackColor = true;
            this.reloadMandelbrot.Click += new System.EventHandler(this.reloadMandelbrot_Click);
            // 
            // customValue
            // 
            this.customValue.Location = new System.Drawing.Point(24, 39);
            this.customValue.Name = "customValue";
            this.customValue.Size = new System.Drawing.Size(100, 20);
            this.customValue.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(21, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Custom Iterate Value";
            // 
            // IterationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 86);
            this.Controls.Add(this.label);
            this.Controls.Add(this.customValue);
            this.Controls.Add(this.reloadMandelbrot);
            this.Name = "IterationForm";
            this.Text = "Custom Iteration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reloadMandelbrot;
        private System.Windows.Forms.TextBox customValue;
        private System.Windows.Forms.Label label;
    }
}