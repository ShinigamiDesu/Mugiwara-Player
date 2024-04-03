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
    public partial class PlaylistDesign : UserControl
    {
        public PlaylistDesign(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        private MainPage mainPage;
        private string _Name;
        private Image _Pic;
        private string _PlaylistID;

        public string Name { get { return _Name; } set {  _Name = value; lbl_name.Text = value; } }
        public string ID { get { return _PlaylistID; } set { _PlaylistID = value; } }
        public Image IMG { get { return _Pic; } set { _Pic = value; pic_playlist.Image = value; } }

        private void pic_view_Click(object sender, EventArgs e)
        {
            Playlist play = new Playlist(mainPage);
            play.ID = ID;
            play.Name = Name;
            play.IMG = IMG;
            mainPage.ShowPlaylist(play);
        }
    }
}
