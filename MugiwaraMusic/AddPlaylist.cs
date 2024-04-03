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
    public partial class AddPlaylist : Form
    {
        string path;
        byte[] img;
        DataIO dataIO = new DataIO();
        private MainPage mainPage;

        public AddPlaylist(MainPage mainPage)
        {
            this.mainPage = mainPage;
            InitializeComponent();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            string ImagePath = "";

            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = Dialog.FileName.ToString();
                pic_img.ImageLocation = ImagePath;
                path = ImagePath; 
                byte[] imagebyte = null;
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                imagebyte = br.ReadBytes((int)fs.Length);
                img = imagebyte;
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_name.Text != "") 
            {
                if (dataIO.checkPlaylist(txt_name.Text)) 
                {
                    lbl_error.Visible = true;
                    lbl_error.Text = "Playlist Already Exists.";
                }
                else 
                {
                    if (pic_img.Image != null)
                    {
                        dataIO.SavePlaylist(txt_name.Text, img);
                        lbl_error.Visible = true;
                        lbl_error.Text = "Playlist Added.";
                        lbl_error.ForeColor = Color.Green;
                        txt_name.Text = "";
                        pic_img.Image = null;
                    }
                    else
                    {
                        byte[] DefaultPic;
                        MemoryStream ms = new MemoryStream();
                        pic_defaultimg.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        DefaultPic = ms.ToArray();
                        dataIO.SavePlaylist(txt_name.Text, DefaultPic);
                        lbl_error.Visible = true;
                        lbl_error.Text = "Playlist Added.";
                        lbl_error.ForeColor = Color.Green;
                        txt_name.Text = "";
                        pic_img.Image = null;
                        mainPage.GeneratePlaylist();
                    }
                }

            }
            else 
            {
                lbl_error.Text = "Name Required";
                lbl_error.Visible = true;
            }

        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
