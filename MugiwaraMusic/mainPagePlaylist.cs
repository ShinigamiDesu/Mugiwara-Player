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
    public partial class mainPagePlaylist : UserControl
    {
        public mainPagePlaylist(MainPage mainPage)
        {
            InitializeComponent();
            this.mainPage = mainPage;
        }
        private MainPage mainPage;

        private void txt_playlist_TextChanged(object sender, EventArgs e)
        {
                mainPage.generateSearchedPlaylist(txt_playlist.Text);
        }
    }
}
