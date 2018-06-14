namespace Dynamicass
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.nsTheme1 = new Dynamicass.NSTheme();
            this.Info = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.whomstdve = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jotd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nsTheme1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.Info);
            this.nsTheme1.Controls.Add(this.progressBar1);
            this.nsTheme1.Controls.Add(this.whomstdve);
            this.nsTheme1.Controls.Add(this.label3);
            this.nsTheme1.Controls.Add(this.label2);
            this.nsTheme1.Controls.Add(this.jotd);
            this.nsTheme1.Controls.Add(this.pictureBox1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(485, 432);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "Dynamicass";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Info.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.White;
            this.Info.Location = new System.Drawing.Point(0, 370);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(485, 10);
            this.Info.TabIndex = 17;
            this.Info.Text = "...";
            this.Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(65, 321);
            this.progressBar1.MarqueeAnimationSpeed = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(348, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 16;
            // 
            // whomstdve
            // 
            this.whomstdve.AutoSize = true;
            this.whomstdve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.whomstdve.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whomstdve.ForeColor = System.Drawing.Color.White;
            this.whomstdve.Location = new System.Drawing.Point(8, 399);
            this.whomstdve.Name = "whomstdve";
            this.whomstdve.Size = new System.Drawing.Size(145, 12);
            this.whomstdve.TabIndex = 15;
            this.whomstdve.Text = "Logged in as ... on Nobelium";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 10);
            this.label3.TabIndex = 4;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Launching..";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jotd
            // 
            this.jotd.AutoSize = true;
            this.jotd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.jotd.ForeColor = System.Drawing.Color.White;
            this.jotd.Location = new System.Drawing.Point(7, 411);
            this.jotd.Name = "jotd";
            this.jotd.Size = new System.Drawing.Size(174, 13);
            this.jotd.TabIndex = 2;
            this.jotd.Text = "Joke of the day: Dynamica\'s ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(115, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 253);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 432);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LauncherForm";
            this.Text = "LauncherForm";
            this.Load += new System.EventHandler(this.LauncherFormLoad);
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label jotd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label whomstdve;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Info;
    }
}