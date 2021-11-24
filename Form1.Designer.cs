namespace IW4x_Server_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxServerIP = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDirectConnect = new System.Windows.Forms.Button();
            this.buttonOpenServerConfig = new System.Windows.Forms.Button();
            this.buttonOpenLobbyConfig = new System.Windows.Forms.Button();
            this.textBoxNetport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPlaylist = new System.Windows.Forms.ComboBox();
            this.comboBoxLAN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMod = new System.Windows.Forms.ComboBox();
            this.buttonDedicatedServer = new System.Windows.Forms.Button();
            this.buttonPartyServer = new System.Windows.Forms.Button();
            this.buttonMultiplayer = new System.Windows.Forms.Button();
            this.buttonSingleplayer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textboxServerIP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonDirectConnect);
            this.panel1.Controls.Add(this.buttonOpenServerConfig);
            this.panel1.Controls.Add(this.buttonOpenLobbyConfig);
            this.panel1.Controls.Add(this.textBoxNetport);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxPlaylist);
            this.panel1.Controls.Add(this.comboBoxLAN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxMod);
            this.panel1.Controls.Add(this.buttonDedicatedServer);
            this.panel1.Controls.Add(this.buttonPartyServer);
            this.panel1.Controls.Add(this.buttonMultiplayer);
            this.panel1.Controls.Add(this.buttonSingleplayer);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("BankGothic Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 374);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // textboxServerIP
            // 
            this.textboxServerIP.Location = new System.Drawing.Point(116, 240);
            this.textboxServerIP.Name = "textboxServerIP";
            this.textboxServerIP.Size = new System.Drawing.Size(233, 21);
            this.textboxServerIP.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 24;
            this.label2.Text = "SERVER IP";
            // 
            // buttonDirectConnect
            // 
            this.buttonDirectConnect.BackColor = System.Drawing.Color.Black;
            this.buttonDirectConnect.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonDirectConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDirectConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDirectConnect.Location = new System.Drawing.Point(363, 238);
            this.buttonDirectConnect.Name = "buttonDirectConnect";
            this.buttonDirectConnect.Size = new System.Drawing.Size(190, 25);
            this.buttonDirectConnect.TabIndex = 22;
            this.buttonDirectConnect.Text = "DIRECT CONNECT";
            this.buttonDirectConnect.UseVisualStyleBackColor = false;
            this.buttonDirectConnect.Click += new System.EventHandler(this.buttonDirectConnect_Click);
            // 
            // buttonOpenServerConfig
            // 
            this.buttonOpenServerConfig.BackColor = System.Drawing.Color.Black;
            this.buttonOpenServerConfig.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonOpenServerConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenServerConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenServerConfig.Location = new System.Drawing.Point(11, 285);
            this.buttonOpenServerConfig.Name = "buttonOpenServerConfig";
            this.buttonOpenServerConfig.Size = new System.Drawing.Size(254, 26);
            this.buttonOpenServerConfig.TabIndex = 21;
            this.buttonOpenServerConfig.Text = "OPEN SERVER CONFIG";
            this.buttonOpenServerConfig.UseVisualStyleBackColor = false;
            this.buttonOpenServerConfig.Click += new System.EventHandler(this.buttonOpenServerConfig_Click);
            // 
            // buttonOpenLobbyConfig
            // 
            this.buttonOpenLobbyConfig.BackColor = System.Drawing.Color.Black;
            this.buttonOpenLobbyConfig.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.buttonOpenLobbyConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenLobbyConfig.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOpenLobbyConfig.Location = new System.Drawing.Point(271, 285);
            this.buttonOpenLobbyConfig.Name = "buttonOpenLobbyConfig";
            this.buttonOpenLobbyConfig.Size = new System.Drawing.Size(283, 26);
            this.buttonOpenLobbyConfig.TabIndex = 20;
            this.buttonOpenLobbyConfig.Text = "OPEN LOBBY SERVER CONFIG";
            this.buttonOpenLobbyConfig.UseVisualStyleBackColor = false;
            this.buttonOpenLobbyConfig.Click += new System.EventHandler(this.buttonOpenLobbyConfig_Click);
            // 
            // textBoxNetport
            // 
            this.textBoxNetport.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxNetport.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNetport.Location = new System.Drawing.Point(446, 163);
            this.textBoxNetport.MaxLength = 5;
            this.textBoxNetport.Name = "textBoxNetport";
            this.textBoxNetport.Size = new System.Drawing.Size(107, 21);
            this.textBoxNetport.TabIndex = 19;
            this.textBoxNetport.Text = "28960";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "LAN MODE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "NET PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "GAME MODE";
            // 
            // comboBoxPlaylist
            // 
            this.comboBoxPlaylist.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPlaylist.FormattingEnabled = true;
            this.comboBoxPlaylist.Location = new System.Drawing.Point(116, 193);
            this.comboBoxPlaylist.Name = "comboBoxPlaylist";
            this.comboBoxPlaylist.Size = new System.Drawing.Size(233, 21);
            this.comboBoxPlaylist.TabIndex = 11;
            // 
            // comboBoxLAN
            // 
            this.comboBoxLAN.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLAN.FormattingEnabled = true;
            this.comboBoxLAN.Items.AddRange(new object[] {
            "LAN",
            "ONLINE"});
            this.comboBoxLAN.Location = new System.Drawing.Point(445, 193);
            this.comboBoxLAN.Name = "comboBoxLAN";
            this.comboBoxLAN.Size = new System.Drawing.Size(108, 21);
            this.comboBoxLAN.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "MOD";
            // 
            // comboBoxMod
            // 
            this.comboBoxMod.Font = new System.Drawing.Font("BankGothic Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMod.FormattingEnabled = true;
            this.comboBoxMod.Items.AddRange(new object[] {
            "none"});
            this.comboBoxMod.Location = new System.Drawing.Point(116, 162);
            this.comboBoxMod.Name = "comboBoxMod";
            this.comboBoxMod.Size = new System.Drawing.Size(233, 21);
            this.comboBoxMod.TabIndex = 7;
            // 
            // buttonDedicatedServer
            // 
            this.buttonDedicatedServer.BackColor = System.Drawing.Color.Black;
            this.buttonDedicatedServer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonDedicatedServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDedicatedServer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDedicatedServer.Location = new System.Drawing.Point(11, 317);
            this.buttonDedicatedServer.Name = "buttonDedicatedServer";
            this.buttonDedicatedServer.Size = new System.Drawing.Size(254, 41);
            this.buttonDedicatedServer.TabIndex = 6;
            this.buttonDedicatedServer.Text = "START DEDICATED SERVER";
            this.buttonDedicatedServer.UseVisualStyleBackColor = false;
            this.buttonDedicatedServer.Click += new System.EventHandler(this.buttonDedicatedServer_Click);
            // 
            // buttonPartyServer
            // 
            this.buttonPartyServer.BackColor = System.Drawing.Color.Black;
            this.buttonPartyServer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonPartyServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPartyServer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPartyServer.Location = new System.Drawing.Point(271, 317);
            this.buttonPartyServer.Name = "buttonPartyServer";
            this.buttonPartyServer.Size = new System.Drawing.Size(283, 41);
            this.buttonPartyServer.TabIndex = 5;
            this.buttonPartyServer.Text = "START DEDICATED PARTY SERVER";
            this.buttonPartyServer.UseVisualStyleBackColor = false;
            this.buttonPartyServer.Click += new System.EventHandler(this.buttonPartyServer_Click);
            // 
            // buttonMultiplayer
            // 
            this.buttonMultiplayer.BackColor = System.Drawing.Color.Black;
            this.buttonMultiplayer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonMultiplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiplayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMultiplayer.Location = new System.Drawing.Point(175, 11);
            this.buttonMultiplayer.Name = "buttonMultiplayer";
            this.buttonMultiplayer.Size = new System.Drawing.Size(158, 43);
            this.buttonMultiplayer.TabIndex = 3;
            this.buttonMultiplayer.Text = "MULTIPLAYER";
            this.buttonMultiplayer.UseVisualStyleBackColor = false;
            this.buttonMultiplayer.Click += new System.EventHandler(this.buttonMultiplayer_Click);
            // 
            // buttonSingleplayer
            // 
            this.buttonSingleplayer.BackColor = System.Drawing.Color.Black;
            this.buttonSingleplayer.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonSingleplayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingleplayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSingleplayer.Location = new System.Drawing.Point(11, 11);
            this.buttonSingleplayer.Name = "buttonSingleplayer";
            this.buttonSingleplayer.Size = new System.Drawing.Size(158, 43);
            this.buttonSingleplayer.TabIndex = 2;
            this.buttonSingleplayer.Text = "SINGLEPLAYER";
            this.buttonSingleplayer.UseVisualStyleBackColor = false;
            this.buttonSingleplayer.Click += new System.EventHandler(this.buttonSingleplayer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(524, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 374);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IW4x Launcher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDedicatedServer;
        private System.Windows.Forms.Button buttonPartyServer;
        private System.Windows.Forms.Button buttonMultiplayer;
        private System.Windows.Forms.Button buttonSingleplayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPlaylist;
        private System.Windows.Forms.ComboBox comboBoxLAN;
        private System.Windows.Forms.TextBox textBoxNetport;
        private System.Windows.Forms.Button buttonOpenServerConfig;
        private System.Windows.Forms.Button buttonOpenLobbyConfig;
        private System.Windows.Forms.Button buttonDirectConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox textboxServerIP;
    }
}

