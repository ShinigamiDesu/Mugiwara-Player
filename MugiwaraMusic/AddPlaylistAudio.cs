using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraMusic
{
    public partial class AddPlaylistAudio : Form
    {
        public string PlaylistID { get; set; }
        DataIO dataIO = new DataIO();

        public AddPlaylistAudio()
        {
            InitializeComponent();
        }
        private void AddPlaylistAudio_Load(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getAudios();
            foreach (DataRow row in dt.Rows)
            {
                list_audio.Items.Add(row["audio_Name"].ToString());
                list_id.Items.Add(row["audio_ID"].ToString());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try 
            {
                int index = list_audio.SelectedIndex;
                string ID = list_id.Items[index].ToString();
                int audioID = int.Parse(ID);
                int playlistID = int.Parse(PlaylistID);
                if (list_audio.SelectedIndex == -1)
                {
                    MessageBox.Show("Select A Audio To Add");
                }
                else
                {
                    if (dataIO.checkPlaylistAudio(audioID, playlistID))
                    {
                        MessageBox.Show("Song Exists In Playlist.");
                    }
                    else
                    {
                        dataIO.SavePlaylistAudio(audioID, playlistID);
                        lbl_error.Visible = true;
                    }

                }
            }
            catch(Exception ex) 
            { 
                lbl_error.Visible = false;
            }

            
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_audios_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = dataIO.getSearchedAudios(txt_audios.Text);
            list_audio.Items.Clear();
            list_id.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                list_audio.Items.Add(row["audio_Name"].ToString());
                list_id.Items.Add(row["audio_ID"].ToString());
            }
        }
    }
}
