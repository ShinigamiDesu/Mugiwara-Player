using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;


namespace MugiwaraMusic
{
    public partial class Audio : UserControl
    {
        private MainPage mainPage;
        private string _Name;
        private string _AudioID;
        private string _AudioPath;
        private string _PlaylistID;
        private Playlist playlist1;
        WMPLib.WindowsMediaPlayer soundPlayer = new WMPLib.WindowsMediaPlayer();

        public string Name { get { return _Name; } set { _Name = value; lbl_name.Text = value; } }
        public string PlaylistID { get { return _PlaylistID; } set { _PlaylistID = value; } }
        public string AudioID { get { return _AudioID; } set { _AudioID = value; } }
        public string AudioPath { get { return _AudioPath; } set { _AudioPath = value; } }

        DataIO dataIO = new DataIO();

        public Audio(Playlist playlist)
        {
            InitializeComponent();
            this.playlist1 = playlist;
        }

        private void Audio_Click(object sender, EventArgs e)
        {
            playlist1.StopAudio();
            playlist1.setActionButton(true);
            playlist1.PlaySelectedAudio(_Name, _AudioPath);
        }

        private void Audio_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(52, 52, 52);
        }

        private void Audio_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void pic_settings_Click(object sender, EventArgs e)
        {
            if(btn_Remove.Visible == true) 
            { 
                btn_Remove.Visible = false;
            }
            else 
            {
                btn_Remove.Visible = true;
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int playID = int.Parse(_PlaylistID);
            int audID = int.Parse(_AudioID);
            dataIO.DeleteAudio(playID, audID);
            playlist1.GenerateAudios();
        }
    }
}











//playlist1.AudioPath = _AudioPath;
//// Only set the URL if it's not already set to the correct audio path
//if (soundPlayer.URL != _AudioPath)
//{
//    // IF the audio changed send the current one to playlist so we can terminate the audio
//    playlist1.SetCurrentAudioPlayer(this);
//    soundPlayer.URL = _AudioPath;
//}