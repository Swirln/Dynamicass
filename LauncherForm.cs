using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Net;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Threading;

namespace Dynamicass
{
    public partial class LauncherForm : Form
    {
        public string temp;

        public LauncherForm()
        {
            InitializeComponent();
        }

        private void LauncherFormLoad(object sender, EventArgs e)
        {
            ArrayList jokes = new ArrayList();
            jokes.Add("staff");
            jokes.Add("owner");
            jokes.Add("security");
            jokes.Add("site");
            jokes.Add("places");
            jokes.Add("games");
            jokes.Add("community");
            jokes.Add("web hosting");
            jokes.Add("thumbnail server");
            jokes.Add("developers");
            jokes.Add("domain");
            jokes.Add("existence");
            Random rng = new Random(); // BLESS US, RNG GODS :pray:
            int value = rng.Next(jokes.Count);
            this.jotd.Text = this.jotd.Text + (string)jokes[value];
            this.whomstdve.Text = this.whomstdve.Text.Replace("...", SharedResources.nobeliumUsername);
            /* LAUNCH */
            // 1. Download joinscript
            this.Info.Text = "Downloading Joinscript...";
            string path = Assembly.GetExecutingAssembly().Location;
            using (WebClient h = new WebClient())
            {
                h.Headers.Add("User-Agent", "Dynwbbrhasjr+2");
                string joinscript = h.DownloadString(address: "http://androdome.com/ide/getserverscript.php?vid=" + SharedResources.versionId);
                string folder = Path.Combine(path, @"..\content\dynamicass");
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
                temp = Path.Combine(path, @"..\content\dynamicass\jsTemp.lua");
                if (!File.Exists(temp))
                {
                    File.Create(temp).Dispose();
                }
                File.WriteAllText(temp, joinscript);
            }
            // 2. Decrypt joinscript
            // Quin's code
            this.Info.Text = "Decrypting Joinscript...";
            var done = false;
            var script = File.ReadAllText(Path.Combine(path, @"..\content\dynamicass\jsTemp.lua")).Trim();

            while (!done)
            {
                script = script.Substring(script.IndexOf("loadstring(") + 12);
                script = script.Substring(0, script.Length - 4);

                var bytes = script.Split('\\');

                script = "";

                foreach (string s in bytes)
                {
                    if (s == "") continue;

                    script += (char)(int.Parse(s));
                }

                done = !script.StartsWith("loadstring(");
                File.WriteAllText(temp, script);
            }
            // 3. Add impersonation
            if (SharedResources.impersonation == true)
            {
				// notes from 6/14/2018:
				// apparently impersonation was bork and I never bothered to fix it, sooo....
                this.Info.Text = "Adding impersonation...";
                var scriptTwo = File.ReadAllText(Path.Combine(path, @"..\content\dynamicass\jsTemp.lua")).Trim();
                scriptTwo = scriptTwo.Replace("replicator:RequestCharacter()", "replicator:RequestCharacter()REALTABNEWLINElocal LocalUser = game:GetService('Players').LocalPlayerREALTABNEWLINELocalUser.CharacterAppearance = 'http://androdome.com/ide/profile/getcharacter?id=" + SharedResources.victim + "'REALTABNEWLINELocalUser.Name = '" + SharedResources.victim + "'");
                scriptTwo = scriptTwo.Replace("REALTAB", "\t");
                scriptTwo = scriptTwo.Replace("NEWLINE", Environment.NewLine);
                File.WriteAllText(temp, script);
            }
            // 4. Execute script
            if (SharedResources.executingScript == true)
            {
                this.Info.Text = "Adding script execution...";
                var scriptThree = File.ReadAllText(Path.Combine(path, @"..\content\dynamicass\jsTemp.lua")).Trim();
                scriptThree = scriptThree + "dofile('" + SharedResources.scriptPath + "')";
            }
            // 5. Launch
            if (File.Exists(Path.Combine(path, @"..\content\dynamicass\joinscript.lua")))
                File.Delete(Path.Combine(path, @"..\content\dynamicass\joinscript.lua"));
            File.Move(Path.Combine(path, @"..\content\dynamicass\jsTemp.lua"), Path.Combine(path, @"..\content\dynamicass\joinscript.lua"));
            Process client = new Process();
            client.StartInfo.UseShellExecute = true;
            client.StartInfo.Arguments = "-script dofile('rbxasset://dynamicass/joinscript.lua')";
        }
    }
}
