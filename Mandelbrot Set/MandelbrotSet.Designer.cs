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
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.characterEncodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.helpToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuBar);
            // 
            // fractalToolStripMenuItem
            // 
            this.fractalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.cloneToolStripMenuItem,
            this.characterEncodingToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fractalToolStripMenuItem.Name = "fractalToolStripMenuItem";
            this.fractalToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fractalToolStripMenuItem.Text = "Fractal";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("startToolStripMenuItem.Image")));
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stopToolStripMenuItem.Image")));
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("restartToolStripMenuItem.Image")));
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reloadToolStripMenuItem.Image")));
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // cloneToolStripMenuItem
            // 
            this.cloneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cloneToolStripMenuItem.Image")));
            this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
            this.cloneToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cloneToolStripMenuItem.Text = "Clone";
            // 
            // characterEncodingToolStripMenuItem
            // 
            this.characterEncodingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("characterEncodingToolStripMenuItem.Image")));
            this.characterEncodingToolStripMenuItem.Name = "characterEncodingToolStripMenuItem";
            this.characterEncodingToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.characterEncodingToolStripMenuItem.Text = "Character Encoding";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem.Image")));
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.infoToolStripMenuItem.Text = "App Info";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // infoToolStripMenuItem1
            // 
            this.infoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("infoToolStripMenuItem1.Image")));
            this.infoToolStripMenuItem1.Name = "infoToolStripMenuItem1";
            this.infoToolStripMenuItem1.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem1.Text = "Info";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // MandelbrotSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 541);
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
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem characterEncodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
    }
}

