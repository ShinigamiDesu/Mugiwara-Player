using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MugiwaraMusic
{
    public partial class MainPage : Form
    {
        bool drag = false;
        Point start_point = new Point(0, 0);
        DataIO dataIO = new DataIO();

        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            GeneratePlaylist();
        }

        public void generateData(DataTable dt) 
        {
            mainPagePlaylist playlist = new mainPagePlaylist(this);
            mainPagePlaylistAdd addplaylist = new mainPagePlaylistAdd(this);
            flow_main.Controls.Clear();
            flow_main.Controls.Add(playlist);
            flow_main.Controls.Add(addplaylist);
            if (dt != null)
            {
                PlaylistDesign[] listItems = new PlaylistDesign[dt.Rows.Count];
                for (int i = 0; i < 1; i++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        listItems[i] = new PlaylistDesign(this);
                        // Adding Playlist Image
                        MemoryStream ms = new MemoryStream((byte[])row["playlist_img"]);
                        listItems[i].IMG = new Bitmap(ms);
                        // Adding Playlist Name
                        listItems[i].Name = row["playlist_name"].ToString();
                        // Adding Playlist ID
                        listItems[i].ID = row["playlist_ID"].ToString();
                        flow_main.Controls.Add(listItems[i]);
                    }
                }
            }
        }

        public void GeneratePlaylist() 
        {
            DataTable dt = dataIO.getPlaylists();
            generateData(dt);
        }
        
        private void pic_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowPlaylist(Playlist play) 
        {
            flow_main.Controls.Clear();
            flow_main.Controls.Add(play);
        }

        #region ToolBar
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
        #endregion

        private void pic_addAudio_Click(object sender, EventArgs e)
        {
            AddAudio add = new AddAudio();
            add.ShowDialog();
        }

        public void generateSearchedPlaylist(string name) 
        { 
            DataTable dt = dataIO.getSearchedPlaylist(name);
            generateData(dt);
        }

    }
}
