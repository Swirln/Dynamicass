namespace Dynamicass
{
    partial class NobeliumUserLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NobeliumUserLogin));
            this.nsTheme1 = new Dynamicass.NSTheme();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new Dynamicass.NSButton();
            this.passwordBox = new Dynamicass.NSTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new Dynamicass.NSTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nsButton1 = new Dynamicass.NSButton();
            this.nsTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nsTheme1
            // 
            this.nsTheme1.AccentOffset = 0;
            this.nsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nsTheme1.Colors = new Bloom[0];
            this.nsTheme1.Controls.Add(this.nsButton1);
            this.nsTheme1.Controls.Add(this.label3);
            this.nsTheme1.Controls.Add(this.login);
            this.nsTheme1.Controls.Add(this.passwordBox);
            this.nsTheme1.Controls.Add(this.label2);
            this.nsTheme1.Controls.Add(this.usernameBox);
            this.nsTheme1.Controls.Add(this.label1);
            this.nsTheme1.Customization = "";
            this.nsTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nsTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.nsTheme1.Image = null;
            this.nsTheme1.Location = new System.Drawing.Point(0, 0);
            this.nsTheme1.Movable = true;
            this.nsTheme1.Name = "nsTheme1";
            this.nsTheme1.NoRounding = false;
            this.nsTheme1.Sizable = false;
            this.nsTheme1.Size = new System.Drawing.Size(400, 155);
            this.nsTheme1.SmartBounds = true;
            this.nsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.nsTheme1.TabIndex = 0;
            this.nsTheme1.Text = "Dynamicass";
            this.nsTheme1.TransparencyKey = System.Drawing.Color.Empty;
            this.nsTheme1.Transparent = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log in to Nobelium";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.login.Location = new System.Drawing.Point(15, 111);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(179, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.Location = new System.Drawing.Point(200, 82);
            this.passwordBox.MaxLength = 32767;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.ReadOnly = false;
            this.passwordBox.Size = new System.Drawing.Size(179, 23);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(199, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.Location = new System.Drawing.Point(15, 82);
            this.usernameBox.MaxLength = 32767;
            this.usernameBox.Multiline = false;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.ReadOnly = false;
            this.usernameBox.Size = new System.Drawing.Size(179, 23);
            this.usernameBox.TabIndex = 1;
            this.usernameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameBox.UseSystemPasswordChar = false;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // nsButton1
            // 
            this.nsButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.nsButton1.Location = new System.Drawing.Point(200, 111);
            this.nsButton1.Name = "nsButton1";
            this.nsButton1.Size = new System.Drawing.Size(179, 23);
            this.nsButton1.TabIndex = 6;
            this.nsButton1.Text = "Cancel";
            this.nsButton1.Click += new System.EventHandler(this.nsButton1_Click);
            // 
            // NobeliumUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 155);
            this.Controls.Add(this.nsTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NobeliumUserLogin";
            this.Text = "NobeliumUserLogin";
            this.nsTheme1.ResumeLayout(false);
            this.nsTheme1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme nsTheme1;
        private NSTextBox passwordBox;
        private System.Windows.Forms.Label label2;
        private NSTextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private NSButton login;
        private System.Windows.Forms.Label label3;
        private NSButton nsButton1;
    }
}