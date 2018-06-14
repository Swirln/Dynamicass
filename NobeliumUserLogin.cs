using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;

namespace Dynamicass
{
    public partial class NobeliumUserLogin : Form
    {
        private string usernameAuth;
        private string password;

        public NobeliumUserLogin()
        {
            InitializeComponent();
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            if (usernameBox.Text == "")
                usernameAuth = "h";
            else
                usernameAuth = WebUtility.UrlEncode(usernameBox.Text);
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text == "")
                password = "h";
            else
                password = WebUtility.UrlEncode(passwordBox.Text);
        }

        private void login_Click(object sender, EventArgs e)
        {
			// lol no
			// P.S: N* api for logging in is hecking DEAD anyway so
            MessageBox.Show("Welcome " + SharedResources.nobeliumUsername + "!", "Dynamicass");
            this.Hide();
            Form next = new StartupForm();
        }

        private void nsButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
