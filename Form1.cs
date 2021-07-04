using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IW4x_Server_Launcher
{
    public partial class Form1 : Form
    {
        private string arg_fs_game          = "none";
        private string arg_sv_lanonly       = "1";
        private string arg_net_port         = "28960";
        private string arg_party_enable     = "0";
        private string arg_playlist         = "0";
        private string arg_playlistFilename = "playlists_launcher.info";
        private string arg_serverFilename   = "server.cfg";

        private string argument_string_party = "";
        private string argument_string_dedicated = "";
        private string arg_server_ip         = "";
        private string arg_minplayers       ="";

        public Form1()
        {
            InitializeComponent();

            if(!File.Exists("iw4x.exe"))
            {
                MessageBox.Show("Please make sure you place this launcher in the same folder as iw4x.exe");
                Environment.Exit(0);
            }

            if(!File.Exists("iw4sp.exe"))
            {
                buttonSingleplayer.Visible = false;
            }

            get_mods();
            get_gamemodes();
            get_saved_details();

            comboBoxLAN.DropDownStyle      = ComboBoxStyle.DropDownList;
            comboBoxMod.DropDownStyle      = ComboBoxStyle.DropDownList;
            comboBoxPlaylist.DropDownStyle = ComboBoxStyle.DropDownList;

            textboxServerIP.ValidatingType = typeof(System.Net.IPAddress);
            textboxServerIP.Text = arg_server_ip;
            textBoxNetport.Text = arg_net_port;
            comboBoxPlayers.Text = arg_minplayers;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Click anywhere to move hack
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void buttonSingleplayer_Click(object sender, EventArgs e)
        {
            if (!File.Exists("iw4sp.exe")) return;

            Process.Start("iw4sp.exe");
            Environment.Exit(0);
        }

        private void buttonMultiplayer_Click(object sender, EventArgs e)
        {
            if (!File.Exists("iw4x.exe")) return;

            update_arguments();
            save_details();


            if (comboBoxMod.SelectedItem.ToString() != "none")
            {
                arg_fs_game = "mods/" + comboBoxMod.SelectedItem.ToString();
            }
            else
            {
                arg_fs_game = "";
            }

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath("iw4x.exe");
            p.StartInfo.Arguments = "+set fs_game \"" + arg_fs_game + "\"";
            p.Start();
            Environment.Exit(0);

        }

        private void buttonDedicatedServer_Click(object sender, EventArgs e)
        {
            if (!File.Exists("iw4x.exe")) return;

            arg_party_enable = "0";
            update_arguments();
            save_details();

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath("iw4x.exe");
            p.StartInfo.Arguments = argument_string_dedicated;
            p.Start();
        }

        private void buttonPartyServer_Click(object sender, EventArgs e)
        {
            if (!File.Exists("iw4x.exe")) return;

            arg_party_enable = "1";
            arg_serverFilename = "partyserver.cfg";
            update_arguments();
            save_details();

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath("iw4x.exe");
            p.StartInfo.Arguments = argument_string_party;
            p.Start();
        }

        public void update_arguments()
        {
            arg_net_port = textBoxNetport.Text;
            arg_server_ip = textboxServerIP.Text;
            arg_minplayers = comboBoxPlayers.SelectedItem.ToString();

            string playlist_id = "1";

            if (comboBoxMod.SelectedItem.ToString() != "none")
            {
                arg_fs_game = "mods/" + comboBoxMod.SelectedItem.ToString();
            }
            else
            {
                arg_fs_game = "";
            }

            if (comboBoxLAN.SelectedItem.ToString().ToUpper() == "LAN") arg_sv_lanonly = "1";
            if (comboBoxLAN.SelectedItem.ToString().ToUpper() == "ONLINE") arg_sv_lanonly = "0";

            if (File.Exists(@"userraw\partyserver.cfg"))
            {
                foreach (Match id in Regex.Matches(comboBoxPlaylist.SelectedItem.ToString(), @"\[(.*?)\]"))
                {
                    playlist_id = id.Groups[1].ToString();
                }

                // Playlists are always -1 of the selected value for some reason..
                if (int.Parse(playlist_id) > 0)
                {
                    int int_playlist_id = int.Parse(playlist_id);
                    int_playlist_id = int_playlist_id - 1;
                    playlist_id = int_playlist_id.ToString();
                }

                arg_playlist = playlist_id;

                argument_string_party = "-dedicated +set fs_game \"" + arg_fs_game +
                       "\" +set sv_lanonly \"" + arg_sv_lanonly +
                       "\" +set net_port \"" + arg_net_port +
                       "\" +exec \"" + arg_serverFilename +
                       "\" +set party_minplayers " + arg_minplayers +
                       " +set party_enable \"" + arg_party_enable +
                       "\" +playlist \"" + arg_playlist +
                       "\" +set playlistFilename \"" + arg_playlistFilename + "\"";
            }

            if (File.Exists(@"userraw\server.cfg"))
            {
                argument_string_dedicated = "-dedicated +set fs_game \"" + arg_fs_game +
                       "\" +set sv_lanonly \"" + arg_sv_lanonly +
                       "\" +set net_port \"" + arg_net_port +
                       "\" +exec \"" + arg_serverFilename +
                       "\" +set party_enable \"" + arg_party_enable +
                       "\"";
            }

        }

        public void get_mods()
        {
            if(Directory.Exists("mods") && !IsDirectoryEmpty("mods"))
            {
                foreach(string modfolder in Directory.GetDirectories("mods"))
                {
                    comboBoxMod.Items.Add(Path.GetFileName(modfolder));
                }
            }
        }

        public bool IsDirectoryEmpty(string path)
        {
            IEnumerable<string> items = Directory.EnumerateFileSystemEntries(path);
            using (IEnumerator<string> en = items.GetEnumerator())
            {
                return !en.MoveNext();
            }
        }

        private void buttonOpenServerConfig_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"userraw\server.cfg"))
            {
                MessageBox.Show(@"userraw\server.cfg does not exist, please create the file before trying to open it with this launcher");
                return;
            }

            Process.Start(@"userraw\server.cfg");
        }

        private void buttonOpenLobbyConfig_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"userraw\partyserver.cfg"))
            {
                MessageBox.Show(@"userraw\partyserver.cfg does not exist, please create the file before trying to open it with this launcher");
                return;
            }
            
            Process.Start(@"userraw\partyserver.cfg");
        }

        private void get_gamemodes()
        {
            if (!File.Exists("launcher.ini"))
            {
                using (StreamWriter w = File.AppendText("launcher.ini")) ;
            }

            var ConfigFile = Path.GetFullPath("launcher.ini");
            arg_playlist = IniFile.ReadValue(ConfigFile, "launcher", "playlist");

            if (!File.Exists("userraw\\server.cfg"))
            {
                buttonDedicatedServer.Visible = false;
                buttonOpenServerConfig.Visible = false;
            }

            if (!File.Exists("userraw\\playlists_launcher.info"))
            {
                label4.Visible = false;
                comboBoxPlaylist.Visible = false;
                buttonPartyServer.Visible = false;
                buttonOpenLobbyConfig.Visible = false;
                return;
            }

            string[] playlist_lines = File.ReadAllLines("userraw\\playlists_launcher.info");
            comboBoxPlaylist.Items.Clear();
            int i = 1;
            string last_line = "";
            foreach (string line in playlist_lines)
            {
                if (last_line.Length > 9 && last_line.Substring(0, 9) == "playlist ")
                {

                    var playlist_value = last_line.Split(' ', '	').Skip(1).FirstOrDefault();
                    var playlist_string = "[" + playlist_value + "] " + line.Remove(0, 13).Replace("\"", "").ToUpper();
                    comboBoxPlaylist.Items.Add(playlist_string);
                    
                    if (playlist_value == arg_playlist)
                    {
                        comboBoxPlaylist.SelectedItem = playlist_string;
                    }
                        
                }

                i++;
                last_line = line;
            }
            if (comboBoxPlaylist.Items.Count > 0 && comboBoxPlaylist.SelectedItem == null)
            {
                comboBoxPlaylist.SelectedIndex = 0;
            }
        }

        public void get_saved_details()
        {
            if (!File.Exists("launcher.ini"))
            {
                using (StreamWriter w = File.AppendText("launcher.ini")) ;
            }
                
            var ConfigFile = Path.GetFullPath("launcher.ini");

            arg_fs_game = IniFile.ReadValue(ConfigFile, "launcher", "mod");
            comboBoxMod.SelectedItem = arg_fs_game;
            if (arg_fs_game.Length == 0)
                comboBoxMod.SelectedIndex = 0;

            arg_sv_lanonly = IniFile.ReadValue(ConfigFile, "launcher", "lanmode");
            comboBoxLAN.SelectedIndex = 1;
            if (arg_sv_lanonly == "1")
                comboBoxLAN.SelectedItem = "LAN";

            arg_net_port = IniFile.ReadValue(ConfigFile, "launcher", "netport");
            if (arg_net_port.Length == 0)
                arg_net_port = "28960";

            arg_server_ip = IniFile.ReadValue(ConfigFile, "launcher", "server_ip");
            if (arg_server_ip.Length == 0)
                arg_server_ip = "127.0.0.1";

            arg_minplayers = IniFile.ReadValue(ConfigFile, "launcher", "minplayers");
            if (arg_minplayers.Length == 0)
                arg_minplayers = "2";

        }

        public void save_details()
        {
            var ConfigFile = Path.GetFullPath("launcher.ini");

            if (File.Exists("userraw\\playlists_launcher.info"))
            {
                foreach (Match id in Regex.Matches(comboBoxPlaylist.SelectedItem.ToString(), @"\[(.*?)\]"))
                {
                    var playlist_id = id.Groups[1].ToString();
                    IniFile.WriteValue(ConfigFile, "launcher", "playlist", playlist_id);
                }
            }


            string mod = comboBoxMod.SelectedItem.ToString();
            if (arg_fs_game.Contains("mods/")) mod = arg_fs_game.Substring(5);

            IniFile.WriteValue(ConfigFile, "launcher", "mod", mod);
            if (File.Exists("userraw\\playlists_launcher.info") || File.Exists("userraw\\server.cfg"))
            {
                IniFile.WriteValue(ConfigFile, "launcher", "lanmode", arg_sv_lanonly);
                IniFile.WriteValue(ConfigFile, "launcher", "netport", arg_net_port);
                IniFile.WriteValue(ConfigFile, "launcher", "minplayers", arg_minplayers);
            }

            IniFile.WriteValue(ConfigFile, "launcher", "server_ip", arg_server_ip);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDirectConnect_Click(object sender, EventArgs e)
        {
            if (!File.Exists("iw4x.exe")) return;

            update_arguments();
            save_details();


            if (comboBoxMod.SelectedItem.ToString() != "none")
            {
                arg_fs_game = "mods/" + comboBoxMod.SelectedItem.ToString();
            }
            else
            {
                arg_fs_game = "";
            }

            var p = new Process();
            p.StartInfo.FileName = Path.GetFullPath("iw4x.exe");
            p.StartInfo.Arguments = "+set fs_game \"" + arg_fs_game + "\"";
            p.StartInfo.Arguments = "+set net_port \""+ arg_net_port+"\"";
            p.StartInfo.Arguments = "+connect \"" + arg_server_ip + "\"";
            p.Start();
            Environment.Exit(0);
        }
    }
}
