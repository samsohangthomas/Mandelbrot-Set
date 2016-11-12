namespace Mandelbrot_Set
{
    partial class MandelbrotSet
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
            this.pictureOutputBox = new System.Windows.Forms.PictureBox();
            this.appStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutputBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOutputBox
            // 
            this.pictureOutputBox.Location = new System.Drawing.Point(1, 26);
            this.pictureOutputBox.Name = "pictureOutputBox";
            this.pictureOutputBox.Size = new System.Drawing.Size(640, 480);
            this.pictureOutputBox.TabIndex = 0;
            this.pictureOutputBox.TabStop = false;
            this.pictureOutputBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureOutputBox_Paint);
            // 
            // appStatus
            // 
            this.appStatus.AutoSize = true;
            this.appStatus.Location = new System.Drawing.Point(13, 517);
            this.appStatus.Name = "appStatus";
            this.appStatus.Size = new System.Drawing.Size(152, 13);
            this.appStatus.TabIndex = 1;
            this.appStatus.Text = "Mandelbrot Application Started";
            // 
            // MandelbrotSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 541);
            this.Controls.Add(this.appStatus);
            this.Controls.Add(this.pictureOutputBox);
            this.Name = "MandelbrotSet";
            this.Text = "Mandelbrot Set";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutputBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOutputBox;
        private System.Windows.Forms.Label appStatus;
    }
}

