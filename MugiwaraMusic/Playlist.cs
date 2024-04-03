using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraMusic
{
    public partial class Playlist : UserControl
    {
        DataIO dataIO = new DataIO();
        public Playlist(MainPage mainPage)
        {
            InitializeComponent();
            this.MainPage = mainPage;
        }

        private string _Name;
        private Image _IMG;
        private string _ID;
        private string _AudioName;
        private string _AudioPath;
        private MainPage MainPage;
        private Random random = new Random();
        WMPLib.WindowsMediaPlayer soundPlayer = new WMPLib.WindowsMediaPlayer();
        
        public string ID { get { return _ID; } set {  _ID = value; } }
        public string Name { get { return _Name; } set { _Name = value; lbl_name.Text = value;  } }
        public string AudioName { get { return _AudioName; } set { _AudioName = value; lbl_audio.Text = value; } }
        public Image IMG { get { return _IMG; } set { _IMG = value; pic_playlist.Image = value; } }
        public string AudioPath { 
            get { return _AudioPath; } 
            set { _AudioPath = value; } 
        }




        private void Playlist_Load(object sender, EventArgs e)
        {
            soundPlayer.URL = null;
            DataTable dt = dataIO.getPlaylistAudios(_ID);
            foreach(DataRow row in dt.Rows) 
            {
                list_paths.Items.Add(row["audio_FilePath"].ToString());
                list_audio.Items.Add(row["audio_Name"].ToString());
            }
            string count = dt.Rows.Count.ToString();
            lbl_audioCount.Text = count + " Audio";
            GenerateAudios();
            pic_action.Image = pic_play.Image;
            lbl_audio.Text = "No Audio Playing";
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            if (soundPlayer.URL != null)
            {
                StopAudio();
            }
            MainPage.GeneratePlaylist();
        }

        public void GenerateData(DataTable dt) 
        {
            flow_main.Controls.Clear();
            if (dt != null)
            {
                Audio[] listItems = new Audio[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new Audio(this);
                        // Adding Audio Name
                        string audioName = row["audio_Name"].ToString(); ;
                        string newAudioName = audioName.Replace(".mp3", "");
                        listItems[i].Name = newAudioName;
                        // Adding Playlist ID
                        listItems[i].PlaylistID = _ID;
                        // Adding Audio ID
                        listItems[i].AudioID = row["audio_ID"].ToString();
                        // Adding Audio Path
                        listItems[i].AudioPath = row["audio_FilePath"].ToString();
                        flow_main.Controls.Add(listItems[i]);
                    }
                }
                AddAudioPlaylist audio = new AddAudioPlaylist();
                audio.PlaylistID = ID;
                flow_main.Controls.Add(audio);
            }

        }

        public void GenerateAudios()
        {
            DataTable dt = dataIO.getPlaylistAudios(_ID);
            GenerateData(dt);
        }

        private void pic_settings_Click(object sender, EventArgs e)
        {
            if(panel_Settings.Visible == true) 
            {
                panel_Settings.Visible = false;
            }
            else if(panel_Settings.Visible == false) 
            {
                panel_Settings.Visible = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(_ID);
            dataIO.DeletePlaylist(ID);
            MainPage.GeneratePlaylist();
        }

        private void txt_audio_TextChanged(object sender, EventArgs e)
        {
            if (txt_audio.Text == "")
            {
                DataTable dt = dataIO.getPlaylistAudios(_ID);
                GenerateData(dt);
            }
            else 
            {
                DataTable dt = dataIO.getSearchedPlaylistAudios(_ID, txt_audio.Text);
                GenerateData(dt);
            }
        }

        private void txt_audio_MouseClick(object sender, MouseEventArgs e)
        {
            if(txt_audio.Text == "Search For An Audio") 
            {
                txt_audio.Text = "";
            }
        }

        private void pic_shuffle_Click(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getPlaylistAudios(_ID);
            if (dt.Rows.Count > 0) 
            {
                Shuffle();
                pic_action.Enabled = true;
            }
        }

        public void setActionButton(bool value) 
        {
            pic_action.Enabled = value;
        }

        public void Shuffle()
        {
            pic_action.Image = pic_pause.Image;
            // Get a random index
            int randomIndex = random.Next(list_paths.Items.Count);
            // Get the path at the random index
            string selectedPath = list_paths.Items[randomIndex].ToString();
            // Get Audio Name
            string audioName = list_audio.Items[randomIndex].ToString();
            string newAudioName = audioName.Replace(".mp3", "");
            lbl_audio.Text = newAudioName;
            soundPlayer.URL = selectedPath;
            double durationInSeconds = soundPlayer.currentMedia.duration;
            if (durationInSeconds > 0)
            {
                double durationInMilliseconds = durationInSeconds * 1000;
                if (durationInMilliseconds > 0)
                {
                    NextSongTimer.Interval = (int)durationInMilliseconds;
                    NextSongTimer.Start();
                    soundPlayer.controls.play();
                    pic_action.Image = pic_pause.Image;
                }

            }

        }

        public void StopAudio() 
        { 
            soundPlayer.URL = null;
            soundPlayer.controls.stop();
            pic_action.Image = pic_play.Image;
        }

        public void PlayAudio()
        {
            soundPlayer.controls.play();
        }

        private void pic_action_Click(object sender, EventArgs e)
        {
                double durationInSeconds = soundPlayer.currentMedia.duration;
                double durationInMilliseconds = durationInSeconds * 1000;
                double currentPositionInMilliseconds = soundPlayer.controls.currentPosition * 1000;
                double RemainingMilliSeconds = (durationInMilliseconds - currentPositionInMilliseconds);

                if (pic_action.Image == pic_play.Image)
                {
                    NextSongTimer.Interval = (int)RemainingMilliSeconds;
                    NextSongTimer.Start();
                    soundPlayer.controls.play();
                    pic_action.Image = pic_pause.Image;
                }
                else if (pic_action.Image == pic_pause.Image)
                {
                    NextSongTimer.Stop();
                    soundPlayer.controls.pause();
                    pic_action.Image = pic_play.Image;
                }
            }

        private void pic_next_Click(object sender, EventArgs e)
        {
            Shuffle();
            pic_action.Enabled = true;
        }

        public void PlaySelectedAudio(string Name, string Path) 
        {
            pic_action.Image = pic_pause.Image;
            lbl_audio.Text = Name;
            soundPlayer.URL = Path;
            PlayAudio();
            NextSongTimer.Stop();

        }

        private void NextSongTimer_Tick(object sender, EventArgs e)
        {
            Shuffle();
        }
    }
}









// Draft Code


/// How the logic works for stoping, pausing, and playing audios
/// 1. We play an audio, after we play the audio we send it to this Playlist UserControl
/// 2. When we click the action button we check, did the audio file path change (Meaning that its not the same
/// as the soundplayer.URL, for example URL = path1 and audio path = path2), if yes then we go ahead and run
/// the method setCurrentAudioPlayer, in this method we can access the soundplayer of the usercontrol Audio.cs
/// in general (or the one that is currently being played), if it changed that means we need to terminate the current
/// audio and play the new one (file path), if the path has not been changed, meaning the user has just paused
/// the audio, then we can skip the part where we have to activate the Method here, because if we dont, each time
/// the user pauses it will activate setCurrentPlayer method and terminate the song and plays it again from the start
/// so by checking if the file path changed or no we can control if it stops or terminate the whole audio system.
/// Perviously the issue i faced was when i pause or switch song, each usercontrol Audio.cs was acting 
/// independantly, meaning thta no one is listing to one another, everyone acting on his own / in their own world
/// the setCurrentPlayer method fixed the issue by keeping track of the current Audio path and seeing if it changes


//if (soundPlayer.URL != null)
//{
//    pic_action.Image = pic_pause.Image;
//}
//if (currentAudioPlayer != null)
//{
//    currentAudioPlayer.TerminateAudio();
//    currentAudioPlayer.SetActionButtonPlay();
//}