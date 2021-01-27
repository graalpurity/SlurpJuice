using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slurp_Juice.Handler;
using static Slurp_Juice.Handler.APIH;
using static Slurp_Juice.Handler.DiscordH;
using static Slurp_Juice.Handler.Win32;
using System.IO;
using System.Diagnostics;
using System.Net;
using Microsoft.Win32;

namespace Slurp_Juice
{
    public partial class Slurp : Form
    {
        public static string Version = "V7";
        public static string SlurpEditorString;
        public static string scriptsString;
        public static string apistring;
        OpenFileDialog open = new OpenFileDialog();

        public Slurp()
        {
            InitializeComponent();
            apistring = apiLabel.Text;
            apiLabel.Text = "Idle";
            updateLabel.Text = "Updated text editor to Monaco";
        }

        private async void Slurp_Load(object sender, EventArgs e)
        {
            DiscordHandler.DiscordID();
            DiscordHandler.DiscordStart();
            ConsoleH.AllocConsole();
            ConsoleH.Welcome();
            //browser//
            WebClient wc = new WebClient();
            wc.Proxy = null;
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = registryKey.GetValue(friendlyName) == null;
                if (flag2)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
                registryKey = null;
                friendlyName = null;
            }
            catch (Exception)
            {
            }
            webBrowser1.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", System.IO.Path.GetDirectoryName(Application.ExecutablePath)));
            await Task.Delay(500);
            webBrowser1.Document.InvokeScript("SetTheme", new string[]
            {
                   "Dark" 
                   /*
                    There are 2 Themes Dark and Light
                   */
            });
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            webBrowser1.Document.InvokeScript("SetText", new object[]
            {
                 "-- Slurp Juice --"
            });
            //
            ListH.PopulateListBox(scriptsList, @"C:\Visual Studio Projects\Slurp Juice\Lua", "*.lua");
            ListH.PopulateListBox(scriptsList, @"C:\Visual Studio Projects\Slurp Juice\Lua", "*.txt");
            executorPanel.Hide();
            settingsPanel.Hide();
            scriptsPanel.Hide();
            homePanel.Show();
            webBrowser1.Hide();
            CheckVersion();
        }

        //browser//
        WebClient wc = new WebClient();
        private string defPath = Application.StartupPath + "//Monaco//";

        private void addIntel(string label, string kind, string detail, string insertText)
        {
            string text = "\"" + label + "\"";
            string text2 = "\"" + kind + "\"";
            string text3 = "\"" + detail + "\"";
            string text4 = "\"" + insertText + "\"";
            webBrowser1.Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        private void addGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.addIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.addIntel(text, "Function", text, text);
                }
            }
        }

        private void addGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.addIntel(text, "Variable", text, text);
            }
        }

        private void addGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.addIntel(text, "Class", text, text);
            }
        }

        private void addMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.addIntel(text, "Method", text, text);
            }
        }

        private void addBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.addIntel(text, "Keyword", text, text);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Hide();
            DiscordHandler.ShutDown();
            Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void attachBtn_Click(object sender, EventArgs e)
        {
            APIHandler.Attach();
            apiLabel.Text = "Attached";
            ConsoleH.Attached();
            DiscordHandler.AttachState();
        }

        private void executeBtn_Click(object sender, EventArgs e)
        {
            SlurpEditorString = webBrowser1.DocumentText;
            APIHandler.Execute();
            apiLabel.Text = "Executed";
            ConsoleH.Executed();
            DiscordHandler.ExecuteState();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            DiscordHandler.OpenState();
            open.Filter = "Lua File|*.lua";
            open.Title = "Open a file";
            if (open.ShowDialog() == DialogResult.OK)
            {
                DiscordHandler.OpenedState();
                System.IO.StreamReader reader = new System.IO.StreamReader(open.FileName);
                webBrowser1.Document.InvokeScript("SetText", new object[]
                {
                    reader.ReadToEnd()
                });
                reader.Close();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            DiscordHandler.SaveState();
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Lua File|*.lua";
            save.Title = "Save file";
            if (save.ShowDialog() == DialogResult.OK)
            {
                DiscordHandler.SavedState();
                System.IO.StreamWriter save2 = new System.IO.StreamWriter(save.FileName);
                save2.Write(webBrowser1.DocumentText);
                save2.Close();
            }
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
            {
                Win32.ReleaseCapture();
                Win32.SendMessage(Handle, Win32.WM_NCLBUTTONDOWN, Win32.HT_CAPTION, 0);
            }
        }

        private void executorShow_Click(object sender, EventArgs e)
        {
            homePanel.Hide();
            settingsPanel.Hide();
            executorPanel.Show();
            scriptsPanel.Show();
            webBrowser1.Show();
            DiscordHandler.IdleState();
        }

        private void homeShow_Click(object sender, EventArgs e)
        {
            executorPanel.Hide();
            settingsPanel.Hide();
            scriptsPanel.Hide();
            homePanel.Show();
            webBrowser1.Hide();
            DiscordHandler.HomePage();
        }

        private void settingsShow_Click(object sender, EventArgs e)
        {
            executorPanel.Hide();
            homePanel.Hide();
            scriptsPanel.Hide();
            settingsPanel.Show();
            webBrowser1.Hide();
            DiscordHandler.Settings();
        }

        private void refreshScripts_Click(object sender, EventArgs e)
        {
            scriptsList.Items.Clear();
            ListH.PopulateListBox(scriptsList, @"C:\Visual Studio Projects\Slurp Juice\Lua", "*.lua");
            ListH.PopulateListBox(scriptsList, @"C:\Visual Studio Projects\Slurp Juice\Lua", "*.txt");
        }

        public void CheckVersion()
        {
            welcomeversionLabel.Text = (Version);
        }

        private void SlurpJuiceEditor_Load(object sender, EventArgs e)
        {
           
        }

        private void githubLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           Process.Start("https://github.com/graalpurity/SlurpJuice");
        }

        private void discordLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/K8VQZutWkA");
        }

        private void homePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void autoAttachBtn_OnChange(object sender, EventArgs e)
        {
            if(autoAttachBtn.Checked)
            {
                if (Process.GetProcessesByName("RobloxPlayerBeta").Length > 0)
                {
                    APIHandler.Attach();
                }
            }
            else
            {

            }
            
        }

        private void debugConsoleBtn_OnChange(object sender, EventArgs e)
        {
            if(debugConsoleBtn.Checked)
            {
                ConsoleH.hide();
            }
            else
            {

            }
        }


        private void printScriptsBtn_OnChange(object sender, EventArgs e)
        {
            if(printScriptsBtn.Checked)
            {
                Win32.Directory2();
            }
        }

        private void topMostBtn_OnChange(object sender, EventArgs e)
        {
            if(topMostBtn.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void hideScriptBtn_OnChange(object sender, EventArgs e)
        {
            if(hideScriptBtn.Checked)
            {
                scriptsList.Items.Clear();
            }
            else
            {
                scriptsList.Items.Clear();
                ListH.PopulateListBox(scriptsList, @"C:\Visual Studio Projects\Slurp Juice\Lua", "*.lua");
                ListH.PopulateListBox(scriptsList, @"C:\Visual Studio Projects\Slurp Juice\Lua", "*.txt");
            }
        }

        private void discordRPCBtn_OnChange(object sender, EventArgs e)
        {
            if(discordRPCBtn.Checked)
            {
                DiscordHandler.ShutDown();
            }
            else
            {
                DiscordHandler.SettingsStart();
            }
        }

        private void scriptsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scriptsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //dev buttons//
        private void devStatusBtn_Click(object sender, EventArgs e)
        {
            DiscordHandler.DevStatus();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

    }
}
