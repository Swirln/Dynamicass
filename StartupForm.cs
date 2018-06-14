using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Dynamicass
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void StartupForm_Load(object sender, EventArgs e)
        {
            this.whomstdve.Text = this.whomstdve.Text.Replace("...", SharedResources.nobeliumUsername);
            if (SharedResources.version == 2010)
            {
                this.nsTextBox1.Text = "e897896b661763b2dfb53cf2f3ce40c7c2194296";
                SharedResources.versionId = "e897896b661763b2dfb53cf2f3ce40c7c2194296";
                this.label6.Text = this.label6.Text.Replace("...", "2010");
            }
            else if (SharedResources.version == 2008)
            {
                this.nsTextBox1.Text = "5224f010f967c67a8040903a48f6681874b8e644";
                SharedResources.versionId = "5224f010f967c67a8040903a48f6681874b8e644";
                this.label6.Text = this.label6.Text.Replace("...", "2008");
            }
        }

        private void chooseFile_Click(object sender, EventArgs e)
        {
            Stream reader = null;

            OpenFileDialog script = new OpenFileDialog();
            script.InitialDirectory = "c:\\";
            script.Filter = "Lua source (*.lua)|*.lua|All files (*.*)|*.*";
            script.FilterIndex = 2;
            script.RestoreDirectory = true;

            if (script.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((reader = script.OpenFile()) != null)
                    {
                        // We did it, now declare it as our script!!!
                        SharedResources.scriptPath = script.FileName;
                        scriptPath.Text = script.FileName;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Failed to choose script! Error:" + err.ToString(), "Dynamicass");
                }
            }
        }

        private void impersonationBox_TextChanged(object sender, EventArgs e)
        {
            SharedResources.victim = impersonationBox.Text;
        }

        private void scriptPath_TextChanged(object sender, EventArgs e)
        {
            SharedResources.scriptPath = scriptPath.Text;
        }

        private void impersonationCheck_CheckedChanged(object sender)
        {
            SharedResources.impersonation = impersonationCheck.Checked;
        }

        private void nsCheckBox1_CheckedChanged(object sender)
        {
            SharedResources.executingScript = nsCheckBox1.Checked;
        }

        private void nsButton3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void nsButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form launcher = new LauncherForm();
            launcher.Show();
        }

        private void nsTextBox1_TextChanged(object sender, EventArgs e)
        {
            SharedResources.versionId = nsTextBox1.Text;
        }
    }
}
