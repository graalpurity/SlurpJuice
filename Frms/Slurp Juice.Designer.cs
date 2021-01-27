namespace Slurp_Juice
{
    partial class Slurp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slurp));
            this.topPanel = new System.Windows.Forms.Panel();
            this.apiLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.executorPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panels = new System.Windows.Forms.Panel();
            this.refreshScripts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingsShow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homeShow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.executorShow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.attachBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.executeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.saveBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.homePanel = new System.Windows.Forms.Panel();
            this.discordLabel = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.githubLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.updateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.welcomeversionLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.devStatusBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.discordRPCBtn = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label13 = new System.Windows.Forms.Label();
            this.hideScriptBtn = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label10 = new System.Windows.Forms.Label();
            this.topMostBtn = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label12 = new System.Windows.Forms.Label();
            this.printScriptsBtn = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label11 = new System.Windows.Forms.Label();
            this.debugConsoleBtn = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.autoAttachBtn = new Bunifu.Framework.UI.BunifuCheckbox();
            this.scriptsPanel = new System.Windows.Forms.Panel();
            this.scriptsList = new System.Windows.Forms.ListBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panels.SuspendLayout();
            this.homePanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.scriptsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.topPanel.Controls.Add(this.apiLabel);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.executorPanel);
            this.topPanel.Controls.Add(this.minimizeBtn);
            this.topPanel.Controls.Add(this.exitBtn);
            this.topPanel.Location = new System.Drawing.Point(0, -3);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1034, 45);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            // 
            // apiLabel
            // 
            this.apiLabel.AutoSize = true;
            this.apiLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apiLabel.ForeColor = System.Drawing.Color.White;
            this.apiLabel.Location = new System.Drawing.Point(463, 5);
            this.apiLabel.Name = "apiLabel";
            this.apiLabel.Size = new System.Drawing.Size(24, 23);
            this.apiLabel.TabIndex = 7;
            this.apiLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(404, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "API -";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-24, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // executorPanel
            // 
            this.executorPanel.Location = new System.Drawing.Point(0, 106);
            this.executorPanel.Name = "executorPanel";
            this.executorPanel.Size = new System.Drawing.Size(915, 447);
            this.executorPanel.TabIndex = 2;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeBtn.BorderRadius = 0;
            this.minimizeBtn.ButtonText = "bunifuFlatButton1";
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.minimizeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Iconimage")));
            this.minimizeBtn.Iconimage_right = null;
            this.minimizeBtn.Iconimage_right_Selected = null;
            this.minimizeBtn.Iconimage_Selected = null;
            this.minimizeBtn.IconMarginLeft = 0;
            this.minimizeBtn.IconMarginRight = 0;
            this.minimizeBtn.IconRightVisible = true;
            this.minimizeBtn.IconRightZoom = 0D;
            this.minimizeBtn.IconVisible = true;
            this.minimizeBtn.IconZoom = 90D;
            this.minimizeBtn.IsTab = false;
            this.minimizeBtn.Location = new System.Drawing.Point(975, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.minimizeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.minimizeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.minimizeBtn.selected = false;
            this.minimizeBtn.Size = new System.Drawing.Size(25, 25);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "bunifuFlatButton1";
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeBtn.Textcolor = System.Drawing.Color.White;
            this.minimizeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.BorderRadius = 0;
            this.exitBtn.ButtonText = "bunifuFlatButton1";
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.exitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.exitBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("exitBtn.Iconimage")));
            this.exitBtn.Iconimage_right = null;
            this.exitBtn.Iconimage_right_Selected = null;
            this.exitBtn.Iconimage_Selected = null;
            this.exitBtn.IconMarginLeft = 0;
            this.exitBtn.IconMarginRight = 0;
            this.exitBtn.IconRightVisible = true;
            this.exitBtn.IconRightZoom = 0D;
            this.exitBtn.IconVisible = true;
            this.exitBtn.IconZoom = 90D;
            this.exitBtn.IsTab = false;
            this.exitBtn.Location = new System.Drawing.Point(1006, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.exitBtn.selected = false;
            this.exitBtn.Size = new System.Drawing.Size(25, 25);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "bunifuFlatButton1";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Textcolor = System.Drawing.Color.White;
            this.exitBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // panels
            // 
            this.panels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panels.Controls.Add(this.refreshScripts);
            this.panels.Controls.Add(this.settingsShow);
            this.panels.Controls.Add(this.homeShow);
            this.panels.Controls.Add(this.executorShow);
            this.panels.Location = new System.Drawing.Point(0, 38);
            this.panels.Name = "panels";
            this.panels.Size = new System.Drawing.Size(1034, 59);
            this.panels.TabIndex = 2;
            // 
            // refreshScripts
            // 
            this.refreshScripts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.refreshScripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.refreshScripts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshScripts.BorderRadius = 0;
            this.refreshScripts.ButtonText = "🔄";
            this.refreshScripts.Cursor = System.Windows.Forms.Cursors.Default;
            this.refreshScripts.DisabledColor = System.Drawing.Color.Gray;
            this.refreshScripts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.refreshScripts.Iconcolor = System.Drawing.Color.Transparent;
            this.refreshScripts.Iconimage = null;
            this.refreshScripts.Iconimage_right = null;
            this.refreshScripts.Iconimage_right_Selected = null;
            this.refreshScripts.Iconimage_Selected = null;
            this.refreshScripts.IconMarginLeft = 0;
            this.refreshScripts.IconMarginRight = 0;
            this.refreshScripts.IconRightVisible = true;
            this.refreshScripts.IconRightZoom = 0D;
            this.refreshScripts.IconVisible = true;
            this.refreshScripts.IconZoom = 90D;
            this.refreshScripts.IsTab = false;
            this.refreshScripts.Location = new System.Drawing.Point(253, 1);
            this.refreshScripts.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.refreshScripts.Name = "refreshScripts";
            this.refreshScripts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.refreshScripts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.refreshScripts.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshScripts.selected = false;
            this.refreshScripts.Size = new System.Drawing.Size(85, 57);
            this.refreshScripts.TabIndex = 15;
            this.refreshScripts.Text = "🔄";
            this.refreshScripts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshScripts.Textcolor = System.Drawing.Color.White;
            this.refreshScripts.TextFont = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold);
            this.refreshScripts.Click += new System.EventHandler(this.refreshScripts_Click);
            // 
            // settingsShow
            // 
            this.settingsShow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.settingsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.settingsShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsShow.BorderRadius = 0;
            this.settingsShow.ButtonText = "⚙️";
            this.settingsShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.settingsShow.DisabledColor = System.Drawing.Color.Gray;
            this.settingsShow.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsShow.Iconimage = null;
            this.settingsShow.Iconimage_right = null;
            this.settingsShow.Iconimage_right_Selected = null;
            this.settingsShow.Iconimage_Selected = null;
            this.settingsShow.IconMarginLeft = 0;
            this.settingsShow.IconMarginRight = 0;
            this.settingsShow.IconRightVisible = true;
            this.settingsShow.IconRightZoom = 0D;
            this.settingsShow.IconVisible = true;
            this.settingsShow.IconZoom = 90D;
            this.settingsShow.IsTab = false;
            this.settingsShow.Location = new System.Drawing.Point(173, 1);
            this.settingsShow.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.settingsShow.Name = "settingsShow";
            this.settingsShow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.settingsShow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.settingsShow.OnHoverTextColor = System.Drawing.Color.White;
            this.settingsShow.selected = false;
            this.settingsShow.Size = new System.Drawing.Size(94, 57);
            this.settingsShow.TabIndex = 3;
            this.settingsShow.Text = "⚙️";
            this.settingsShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingsShow.Textcolor = System.Drawing.Color.White;
            this.settingsShow.TextFont = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold);
            this.settingsShow.Click += new System.EventHandler(this.settingsShow_Click);
            // 
            // homeShow
            // 
            this.homeShow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.homeShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.homeShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeShow.BorderRadius = 0;
            this.homeShow.ButtonText = "🏠";
            this.homeShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.homeShow.DisabledColor = System.Drawing.Color.Gray;
            this.homeShow.Iconcolor = System.Drawing.Color.Transparent;
            this.homeShow.Iconimage = null;
            this.homeShow.Iconimage_right = null;
            this.homeShow.Iconimage_right_Selected = null;
            this.homeShow.Iconimage_Selected = null;
            this.homeShow.IconMarginLeft = 0;
            this.homeShow.IconMarginRight = 0;
            this.homeShow.IconRightVisible = true;
            this.homeShow.IconRightZoom = 0D;
            this.homeShow.IconVisible = true;
            this.homeShow.IconZoom = 90D;
            this.homeShow.IsTab = false;
            this.homeShow.Location = new System.Drawing.Point(-1, 1);
            this.homeShow.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.homeShow.Name = "homeShow";
            this.homeShow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.homeShow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.homeShow.OnHoverTextColor = System.Drawing.Color.White;
            this.homeShow.selected = false;
            this.homeShow.Size = new System.Drawing.Size(94, 57);
            this.homeShow.TabIndex = 2;
            this.homeShow.Text = "🏠";
            this.homeShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeShow.Textcolor = System.Drawing.Color.White;
            this.homeShow.TextFont = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeShow.Click += new System.EventHandler(this.homeShow_Click);
            // 
            // executorShow
            // 
            this.executorShow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.executorShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.executorShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.executorShow.BorderRadius = 0;
            this.executorShow.ButtonText = "💉";
            this.executorShow.Cursor = System.Windows.Forms.Cursors.Default;
            this.executorShow.DisabledColor = System.Drawing.Color.Gray;
            this.executorShow.Iconcolor = System.Drawing.Color.Transparent;
            this.executorShow.Iconimage = null;
            this.executorShow.Iconimage_right = null;
            this.executorShow.Iconimage_right_Selected = null;
            this.executorShow.Iconimage_Selected = null;
            this.executorShow.IconMarginLeft = 0;
            this.executorShow.IconMarginRight = 0;
            this.executorShow.IconRightVisible = true;
            this.executorShow.IconRightZoom = 0D;
            this.executorShow.IconVisible = true;
            this.executorShow.IconZoom = 90D;
            this.executorShow.IsTab = false;
            this.executorShow.Location = new System.Drawing.Point(84, 1);
            this.executorShow.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.executorShow.Name = "executorShow";
            this.executorShow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.executorShow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.executorShow.OnHoverTextColor = System.Drawing.Color.White;
            this.executorShow.selected = false;
            this.executorShow.Size = new System.Drawing.Size(94, 57);
            this.executorShow.TabIndex = 0;
            this.executorShow.Text = "💉";
            this.executorShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.executorShow.Textcolor = System.Drawing.Color.White;
            this.executorShow.TextFont = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold);
            this.executorShow.Click += new System.EventHandler(this.executorShow_Click);
            // 
            // attachBtn
            // 
            this.attachBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.attachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.attachBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.attachBtn.BorderRadius = 0;
            this.attachBtn.ButtonText = "⚡";
            this.attachBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.attachBtn.DisabledColor = System.Drawing.Color.Gray;
            this.attachBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.attachBtn.Iconimage = null;
            this.attachBtn.Iconimage_right = null;
            this.attachBtn.Iconimage_right_Selected = null;
            this.attachBtn.Iconimage_Selected = null;
            this.attachBtn.IconMarginLeft = 0;
            this.attachBtn.IconMarginRight = 0;
            this.attachBtn.IconRightVisible = true;
            this.attachBtn.IconRightZoom = 0D;
            this.attachBtn.IconVisible = true;
            this.attachBtn.IconZoom = 90D;
            this.attachBtn.IsTab = false;
            this.attachBtn.Location = new System.Drawing.Point(0, 450);
            this.attachBtn.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.attachBtn.Name = "attachBtn";
            this.attachBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.attachBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.attachBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.attachBtn.selected = false;
            this.attachBtn.Size = new System.Drawing.Size(85, 57);
            this.attachBtn.TabIndex = 3;
            this.attachBtn.Text = "⚡";
            this.attachBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.attachBtn.Textcolor = System.Drawing.Color.White;
            this.attachBtn.TextFont = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.attachBtn.Click += new System.EventHandler(this.attachBtn_Click);
            // 
            // executeBtn
            // 
            this.executeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.executeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.executeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.executeBtn.BorderRadius = 0;
            this.executeBtn.ButtonText = "💉";
            this.executeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.executeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.executeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.executeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.executeBtn.Iconimage = null;
            this.executeBtn.Iconimage_right = null;
            this.executeBtn.Iconimage_right_Selected = null;
            this.executeBtn.Iconimage_Selected = null;
            this.executeBtn.IconMarginLeft = 0;
            this.executeBtn.IconMarginRight = 0;
            this.executeBtn.IconRightVisible = true;
            this.executeBtn.IconRightZoom = 0D;
            this.executeBtn.IconVisible = true;
            this.executeBtn.IconZoom = 90D;
            this.executeBtn.IsTab = false;
            this.executeBtn.Location = new System.Drawing.Point(99, 450);
            this.executeBtn.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.executeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.executeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.executeBtn.selected = false;
            this.executeBtn.Size = new System.Drawing.Size(85, 57);
            this.executeBtn.TabIndex = 4;
            this.executeBtn.Text = "💉";
            this.executeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.executeBtn.Textcolor = System.Drawing.Color.White;
            this.executeBtn.TextFont = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.executeBtn.Click += new System.EventHandler(this.executeBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openBtn.BorderRadius = 0;
            this.openBtn.ButtonText = "📂";
            this.openBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.openBtn.DisabledColor = System.Drawing.Color.Gray;
            this.openBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.openBtn.Iconimage = null;
            this.openBtn.Iconimage_right = null;
            this.openBtn.Iconimage_right_Selected = null;
            this.openBtn.Iconimage_Selected = null;
            this.openBtn.IconMarginLeft = 0;
            this.openBtn.IconMarginRight = 0;
            this.openBtn.IconRightVisible = true;
            this.openBtn.IconRightZoom = 0D;
            this.openBtn.IconVisible = true;
            this.openBtn.IconZoom = 90D;
            this.openBtn.IsTab = false;
            this.openBtn.Location = new System.Drawing.Point(198, 450);
            this.openBtn.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.openBtn.Name = "openBtn";
            this.openBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.openBtn.selected = false;
            this.openBtn.Size = new System.Drawing.Size(85, 57);
            this.openBtn.TabIndex = 5;
            this.openBtn.Text = "📂";
            this.openBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openBtn.Textcolor = System.Drawing.Color.White;
            this.openBtn.TextFont = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveBtn.BorderRadius = 0;
            this.saveBtn.ButtonText = "💾";
            this.saveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveBtn.DisabledColor = System.Drawing.Color.Gray;
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.saveBtn.Iconimage = null;
            this.saveBtn.Iconimage_right = null;
            this.saveBtn.Iconimage_right_Selected = null;
            this.saveBtn.Iconimage_Selected = null;
            this.saveBtn.IconMarginLeft = 0;
            this.saveBtn.IconMarginRight = 0;
            this.saveBtn.IconRightVisible = true;
            this.saveBtn.IconRightZoom = 0D;
            this.saveBtn.IconVisible = true;
            this.saveBtn.IconZoom = 90D;
            this.saveBtn.IsTab = false;
            this.saveBtn.Location = new System.Drawing.Point(298, 450);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.saveBtn.selected = false;
            this.saveBtn.Size = new System.Drawing.Size(85, 57);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "💾";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveBtn.Textcolor = System.Drawing.Color.White;
            this.saveBtn.TextFont = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.discordLabel);
            this.homePanel.Controls.Add(this.label7);
            this.homePanel.Controls.Add(this.label6);
            this.homePanel.Controls.Add(this.githubLabel);
            this.homePanel.Controls.Add(this.label5);
            this.homePanel.Controls.Add(this.updateLabel);
            this.homePanel.Controls.Add(this.label4);
            this.homePanel.Controls.Add(this.welcomeversionLabel);
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Location = new System.Drawing.Point(0, 103);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(1034, 444);
            this.homePanel.TabIndex = 5;
            this.homePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homePanel_Paint);
            // 
            // discordLabel
            // 
            this.discordLabel.AutoSize = true;
            this.discordLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.discordLabel.Location = new System.Drawing.Point(379, 224);
            this.discordLabel.Name = "discordLabel";
            this.discordLabel.Size = new System.Drawing.Size(90, 23);
            this.discordLabel.TabIndex = 12;
            this.discordLabel.TabStop = true;
            this.discordLabel.Text = "Discord";
            this.discordLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.discordLabel_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(250, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Slurp Juice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(250, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "Slurp Juice";
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.githubLabel.Location = new System.Drawing.Point(379, 147);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(82, 23);
            this.githubLabel.TabIndex = 9;
            this.githubLabel.TabStop = true;
            this.githubLabel.Text = "Github";
            this.githubLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLabel_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(250, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(373, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Slurrpin on da juice 24/7 for free";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.White;
            this.updateLabel.Location = new System.Drawing.Point(94, 412);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(24, 23);
            this.updateLabel.TabIndex = 7;
            this.updateLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Update:";
            // 
            // welcomeversionLabel
            // 
            this.welcomeversionLabel.AutoSize = true;
            this.welcomeversionLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeversionLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeversionLabel.Location = new System.Drawing.Point(536, 5);
            this.welcomeversionLabel.Name = "welcomeversionLabel";
            this.welcomeversionLabel.Size = new System.Drawing.Size(24, 23);
            this.welcomeversionLabel.TabIndex = 5;
            this.welcomeversionLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome to Slurp Juice -";
            // 
            // settingsPanel
            // 
            this.settingsPanel.Controls.Add(this.devStatusBtn);
            this.settingsPanel.Controls.Add(this.discordRPCBtn);
            this.settingsPanel.Controls.Add(this.label13);
            this.settingsPanel.Controls.Add(this.hideScriptBtn);
            this.settingsPanel.Controls.Add(this.label10);
            this.settingsPanel.Controls.Add(this.topMostBtn);
            this.settingsPanel.Controls.Add(this.label12);
            this.settingsPanel.Controls.Add(this.printScriptsBtn);
            this.settingsPanel.Controls.Add(this.label11);
            this.settingsPanel.Controls.Add(this.debugConsoleBtn);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Controls.Add(this.label8);
            this.settingsPanel.Controls.Add(this.autoAttachBtn);
            this.settingsPanel.Location = new System.Drawing.Point(0, 103);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1034, 447);
            this.settingsPanel.TabIndex = 13;
            // 
            // devStatusBtn
            // 
            this.devStatusBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.devStatusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.devStatusBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.devStatusBtn.BorderRadius = 0;
            this.devStatusBtn.ButtonText = "Dev Status";
            this.devStatusBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.devStatusBtn.DisabledColor = System.Drawing.Color.Gray;
            this.devStatusBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.devStatusBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.devStatusBtn.Iconimage = null;
            this.devStatusBtn.Iconimage_right = null;
            this.devStatusBtn.Iconimage_right_Selected = null;
            this.devStatusBtn.Iconimage_Selected = null;
            this.devStatusBtn.IconMarginLeft = 0;
            this.devStatusBtn.IconMarginRight = 0;
            this.devStatusBtn.IconRightVisible = true;
            this.devStatusBtn.IconRightZoom = 0D;
            this.devStatusBtn.IconVisible = true;
            this.devStatusBtn.IconZoom = 90D;
            this.devStatusBtn.IsTab = false;
            this.devStatusBtn.Location = new System.Drawing.Point(6, 75);
            this.devStatusBtn.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.devStatusBtn.Name = "devStatusBtn";
            this.devStatusBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.devStatusBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.devStatusBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.devStatusBtn.selected = false;
            this.devStatusBtn.Size = new System.Drawing.Size(51, 32);
            this.devStatusBtn.TabIndex = 17;
            this.devStatusBtn.Text = "Dev Status";
            this.devStatusBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.devStatusBtn.Textcolor = System.Drawing.Color.White;
            this.devStatusBtn.TextFont = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devStatusBtn.Click += new System.EventHandler(this.devStatusBtn_Click);
            // 
            // discordRPCBtn
            // 
            this.discordRPCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.discordRPCBtn.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.discordRPCBtn.Checked = false;
            this.discordRPCBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.discordRPCBtn.ForeColor = System.Drawing.Color.White;
            this.discordRPCBtn.Location = new System.Drawing.Point(584, 22);
            this.discordRPCBtn.Name = "discordRPCBtn";
            this.discordRPCBtn.Size = new System.Drawing.Size(20, 20);
            this.discordRPCBtn.TabIndex = 14;
            this.discordRPCBtn.OnChange += new System.EventHandler(this.discordRPCBtn_OnChange);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(581, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 14);
            this.label13.TabIndex = 13;
            this.label13.Text = "Discord RPC";
            // 
            // hideScriptBtn
            // 
            this.hideScriptBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hideScriptBtn.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hideScriptBtn.Checked = false;
            this.hideScriptBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.hideScriptBtn.ForeColor = System.Drawing.Color.White;
            this.hideScriptBtn.Location = new System.Drawing.Point(467, 22);
            this.hideScriptBtn.Name = "hideScriptBtn";
            this.hideScriptBtn.Size = new System.Drawing.Size(20, 20);
            this.hideScriptBtn.TabIndex = 12;
            this.hideScriptBtn.OnChange += new System.EventHandler(this.hideScriptBtn_OnChange);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(464, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 14);
            this.label10.TabIndex = 11;
            this.label10.Text = "Hide Scripts";
            // 
            // topMostBtn
            // 
            this.topMostBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.topMostBtn.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.topMostBtn.Checked = false;
            this.topMostBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.topMostBtn.ForeColor = System.Drawing.Color.White;
            this.topMostBtn.Location = new System.Drawing.Point(375, 22);
            this.topMostBtn.Name = "topMostBtn";
            this.topMostBtn.Size = new System.Drawing.Size(20, 20);
            this.topMostBtn.TabIndex = 10;
            this.topMostBtn.OnChange += new System.EventHandler(this.topMostBtn_OnChange);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(372, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 14);
            this.label12.TabIndex = 9;
            this.label12.Text = "Top Most";
            // 
            // printScriptsBtn
            // 
            this.printScriptsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.printScriptsBtn.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.printScriptsBtn.Checked = false;
            this.printScriptsBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.printScriptsBtn.ForeColor = System.Drawing.Color.White;
            this.printScriptsBtn.Location = new System.Drawing.Point(254, 22);
            this.printScriptsBtn.Name = "printScriptsBtn";
            this.printScriptsBtn.Size = new System.Drawing.Size(20, 20);
            this.printScriptsBtn.TabIndex = 8;
            this.printScriptsBtn.OnChange += new System.EventHandler(this.printScriptsBtn_OnChange);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(251, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 14);
            this.label11.TabIndex = 7;
            this.label11.Text = "Print Scripts";
            // 
            // debugConsoleBtn
            // 
            this.debugConsoleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.debugConsoleBtn.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.debugConsoleBtn.Checked = false;
            this.debugConsoleBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.debugConsoleBtn.ForeColor = System.Drawing.Color.White;
            this.debugConsoleBtn.Location = new System.Drawing.Point(112, 22);
            this.debugConsoleBtn.Name = "debugConsoleBtn";
            this.debugConsoleBtn.Size = new System.Drawing.Size(20, 20);
            this.debugConsoleBtn.TabIndex = 6;
            this.debugConsoleBtn.OnChange += new System.EventHandler(this.debugConsoleBtn_OnChange);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(109, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 14);
            this.label9.TabIndex = 5;
            this.label9.Text = "Debug Console";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 14);
            this.label8.TabIndex = 4;
            this.label8.Text = "Auto Attach";
            // 
            // autoAttachBtn
            // 
            this.autoAttachBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.autoAttachBtn.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.autoAttachBtn.Checked = false;
            this.autoAttachBtn.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.autoAttachBtn.ForeColor = System.Drawing.Color.White;
            this.autoAttachBtn.Location = new System.Drawing.Point(6, 22);
            this.autoAttachBtn.Name = "autoAttachBtn";
            this.autoAttachBtn.Size = new System.Drawing.Size(20, 20);
            this.autoAttachBtn.TabIndex = 0;
            this.autoAttachBtn.OnChange += new System.EventHandler(this.autoAttachBtn_OnChange);
            // 
            // scriptsPanel
            // 
            this.scriptsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.scriptsPanel.Controls.Add(this.scriptsList);
            this.scriptsPanel.Location = new System.Drawing.Point(746, 103);
            this.scriptsPanel.Name = "scriptsPanel";
            this.scriptsPanel.Size = new System.Drawing.Size(288, 339);
            this.scriptsPanel.TabIndex = 14;
            this.scriptsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.scriptsPanel_Paint);
            // 
            // scriptsList
            // 
            this.scriptsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.scriptsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptsList.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptsList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.scriptsList.FormattingEnabled = true;
            this.scriptsList.ItemHeight = 21;
            this.scriptsList.Location = new System.Drawing.Point(0, 0);
            this.scriptsList.Name = "scriptsList";
            this.scriptsList.Size = new System.Drawing.Size(288, 339);
            this.scriptsList.TabIndex = 0;
            this.scriptsList.SelectedIndexChanged += new System.EventHandler(this.scriptsList_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 103);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(740, 339);
            this.webBrowser1.TabIndex = 15;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Slurp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1035, 547);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.scriptsPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.homePanel);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.attachBtn);
            this.Controls.Add(this.panels);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Slurp";
            this.Text = "Slurp Juice";
            this.Load += new System.EventHandler(this.Slurp_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panels.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.scriptsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private Bunifu.Framework.UI.BunifuFlatButton exitBtn;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeBtn;
        private System.Windows.Forms.Panel executorPanel;
        private System.Windows.Forms.Panel panels;
        private Bunifu.Framework.UI.BunifuFlatButton executorShow;
        private Bunifu.Framework.UI.BunifuFlatButton attachBtn;
        private Bunifu.Framework.UI.BunifuFlatButton executeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton openBtn;
        private Bunifu.Framework.UI.BunifuFlatButton saveBtn;
        private Bunifu.Framework.UI.BunifuFlatButton homeShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label apiLabel;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Label welcomeversionLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel githubLabel;
        private System.Windows.Forms.LinkLabel discordLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel settingsPanel;
        private Bunifu.Framework.UI.BunifuFlatButton settingsShow;
        private Bunifu.Framework.UI.BunifuCheckbox autoAttachBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCheckbox debugConsoleBtn;
        private System.Windows.Forms.Panel scriptsPanel;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuCheckbox printScriptsBtn;
        private Bunifu.Framework.UI.BunifuCheckbox topMostBtn;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ListBox scriptsList;
        private Bunifu.Framework.UI.BunifuFlatButton refreshScripts;
        private Bunifu.Framework.UI.BunifuCheckbox hideScriptBtn;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuCheckbox discordRPCBtn;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton devStatusBtn;
        public System.Windows.Forms.WebBrowser webBrowser1;
    }
}

