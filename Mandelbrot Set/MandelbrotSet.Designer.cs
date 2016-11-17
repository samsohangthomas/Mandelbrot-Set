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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MandelbrotSet));
            this.pictureOutputBox = new System.Windows.Forms.PictureBox();
            this.appStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fractalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMandelbrot = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMandelbrot = new System.Windows.Forms.ToolStripMenuItem();
            this.restartMandelbrot = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadMandelbrot = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneMandelbrot = new System.Windows.Forms.ToolStripMenuItem();
            this.characterEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMandelbrot = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMandelbrot = new System.Windows.Forms.ToolStripMenuItem();
            this.closeApp = new System.Windows.Forms.ToolStripMenuItem();
            this.quitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iterationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultIteration = new System.Windows.Forms.ToolStripMenuItem();
            this.customIteration = new System.Windows.Forms.ToolStripMenuItem();
            this.iterateStatus = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutputBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.pictureOutputBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureOutputBox_MouseDown);
            this.pictureOutputBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureOutputBox_MouseMove);
            this.pictureOutputBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureOutputBox_MouseUp);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fractalToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuBarEnter);
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuBarLeave);
            // 
            // fractalToolStripMenuItem
            // 
            this.fractalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMandelbrot,
            this.stopMandelbrot,
            this.restartMandelbrot,
            this.reloadMandelbrot,
            this.cloneMandelbrot,
            this.characterEncodingToolStripMenuItem,
            this.saveMandelbrot});
            this.fractalToolStripMenuItem.Name = "fractalToolStripMenuItem";
            this.fractalToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fractalToolStripMenuItem.Text = "Application";
            // 
            // startMandelbrot
            // 
            this.startMandelbrot.Image = ((System.Drawing.Image)(resources.GetObject("startMandelbrot.Image")));
            this.startMandelbrot.Name = "startMandelbrot";
            this.startMandelbrot.Size = new System.Drawing.Size(178, 22);
            this.startMandelbrot.Text = "Start";
            this.startMandelbrot.Click += new System.EventHandler(this.startMandelbrot_Click);
            // 
            // stopMandelbrot
            // 
            this.stopMandelbrot.Image = ((System.Drawing.Image)(resources.GetObject("stopMandelbrot.Image")));
            this.stopMandelbrot.Name = "stopMandelbrot";
            this.stopMandelbrot.Size = new System.Drawing.Size(178, 22);
            this.stopMandelbrot.Text = "Stop";
            this.stopMandelbrot.Click += new System.EventHandler(this.stopMandelbrot_Click);
            // 
            // restartMandelbrot
            // 
            this.restartMandelbrot.Image = ((System.Drawing.Image)(resources.GetObject("restartMandelbrot.Image")));
            this.restartMandelbrot.Name = "restartMandelbrot";
            this.restartMandelbrot.Size = new System.Drawing.Size(178, 22);
            this.restartMandelbrot.Text = "Restart";
            this.restartMandelbrot.Click += new System.EventHandler(this.restartMandelbrot_Click);
            // 
            // reloadMandelbrot
            // 
            this.reloadMandelbrot.Image = ((System.Drawing.Image)(resources.GetObject("reloadMandelbrot.Image")));
            this.reloadMandelbrot.Name = "reloadMandelbrot";
            this.reloadMandelbrot.Size = new System.Drawing.Size(178, 22);
            this.reloadMandelbrot.Text = "Reload";
            this.reloadMandelbrot.Click += new System.EventHandler(this.reloadMandelbrot_Click);
            // 
            // cloneMandelbrot
            // 
            this.cloneMandelbrot.Image = ((System.Drawing.Image)(resources.GetObject("cloneMandelbrot.Image")));
            this.cloneMandelbrot.Name = "cloneMandelbrot";
            this.cloneMandelbrot.Size = new System.Drawing.Size(178, 22);
            this.cloneMandelbrot.Text = "Clone";
            this.cloneMandelbrot.Click += new System.EventHandler(this.cloneMandelbrot_Click);
            // 
            // characterEncodingToolStripMenuItem
            // 
            this.characterEncodingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("characterEncodingToolStripMenuItem.Image")));
            this.characterEncodingToolStripMenuItem.Name = "characterEncodingToolStripMenuItem";
            this.characterEncodingToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.characterEncodingToolStripMenuItem.Text = "Character Encoding";
            // 
            // saveMandelbrot
            // 
            this.saveMandelbrot.Image = ((System.Drawing.Image)(resources.GetObject("saveMandelbrot.Image")));
            this.saveMandelbrot.Name = "saveMandelbrot";
            this.saveMandelbrot.Size = new System.Drawing.Size(178, 22);
            this.saveMandelbrot.Text = "Save";
            this.saveMandelbrot.Click += new System.EventHandler(this.saveMandelbrot_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoApplication});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoApplication
            // 
            this.infoApplication.Image = ((System.Drawing.Image)(resources.GetObject("infoApplication.Image")));
            this.infoApplication.Name = "infoApplication";
            this.infoApplication.Size = new System.Drawing.Size(162, 22);
            this.infoApplication.Text = "App Information";
            this.infoApplication.Click += new System.EventHandler(this.infoApplication_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printMandelbrot,
            this.closeApp,
            this.quitApp});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // printMandelbrot
            // 
            this.printMandelbrot.Image = ((System.Drawing.Image)(resources.GetObject("printMandelbrot.Image")));
            this.printMandelbrot.Name = "printMandelbrot";
            this.printMandelbrot.Size = new System.Drawing.Size(103, 22);
            this.printMandelbrot.Text = "Print";
            this.printMandelbrot.Click += new System.EventHandler(this.printMandelbrot_Click);
            // 
            // closeApp
            // 
            this.closeApp.Image = ((System.Drawing.Image)(resources.GetObject("closeApp.Image")));
            this.closeApp.Name = "closeApp";
            this.closeApp.Size = new System.Drawing.Size(103, 22);
            this.closeApp.Text = "Close";
            this.closeApp.Click += new System.EventHandler(this.closeApp_Click);
            // 
            // quitApp
            // 
            this.quitApp.Image = ((System.Drawing.Image)(resources.GetObject("quitApp.Image")));
            this.quitApp.Name = "quitApp";
            this.quitApp.Size = new System.Drawing.Size(103, 22);
            this.quitApp.Text = "Quit";
            this.quitApp.Click += new System.EventHandler(this.quitApp_Click);
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iterationToolStripMenuItem});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            // 
            // iterationToolStripMenuItem
            // 
            this.iterationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultIteration,
            this.customIteration});
            this.iterationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iterationToolStripMenuItem.Image")));
            this.iterationToolStripMenuItem.Name = "iterationToolStripMenuItem";
            this.iterationToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iterationToolStripMenuItem.Text = "Iteration";
            // 
            // defaultIteration
            // 
            this.defaultIteration.Image = ((System.Drawing.Image)(resources.GetObject("defaultIteration.Image")));
            this.defaultIteration.Name = "defaultIteration";
            this.defaultIteration.Size = new System.Drawing.Size(152, 22);
            this.defaultIteration.Text = "Set Default";
            this.defaultIteration.Click += new System.EventHandler(this.defaultIteration_Click);
            // 
            // customIteration
            // 
            this.customIteration.Image = ((System.Drawing.Image)(resources.GetObject("customIteration.Image")));
            this.customIteration.Name = "customIteration";
            this.customIteration.Size = new System.Drawing.Size(152, 22);
            this.customIteration.Text = "Set Custom";
            this.customIteration.Click += new System.EventHandler(this.customIteration_Click);
            // 
            // iterateStatus
            // 
            this.iterateStatus.AutoSize = true;
            this.iterateStatus.Location = new System.Drawing.Point(461, 7);
            this.iterateStatus.Name = "iterateStatus";
            this.iterateStatus.Size = new System.Drawing.Size(137, 13);
            this.iterateStatus.TabIndex = 3;
            this.iterateStatus.Text = "Default Iteration 256 Times ";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // MandelbrotSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 541);
            this.Controls.Add(this.iterateStatus);
            this.Controls.Add(this.appStatus);
            this.Controls.Add(this.pictureOutputBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MandelbrotSet";
            this.Text = "Mandelbrot Set";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOutputBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOutputBox;
        private System.Windows.Forms.Label appStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fractalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMandelbrot;
        private System.Windows.Forms.ToolStripMenuItem stopMandelbrot;
        private System.Windows.Forms.ToolStripMenuItem restartMandelbrot;
        private System.Windows.Forms.ToolStripMenuItem reloadMandelbrot;
        private System.Windows.Forms.ToolStripMenuItem cloneMandelbrot;
        private System.Windows.Forms.ToolStripMenuItem characterEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMandelbrot;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoApplication;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMandelbrot;
        private System.Windows.Forms.ToolStripMenuItem closeApp;
        private System.Windows.Forms.ToolStripMenuItem quitApp;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iterationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultIteration;
        private System.Windows.Forms.ToolStripMenuItem customIteration;
        private System.Windows.Forms.Label iterateStatus;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}

