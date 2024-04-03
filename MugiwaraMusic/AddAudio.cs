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
    public partial class AddAudio : Form
    {
        public string playlistID {  get; set; }
        DataIO dataIO = new DataIO();

        public AddAudio()
        {
            InitializeComponent();
        }

        private void btn_audioUpload_Click(object sender, EventArgs e)
        {
            string audioPath = "";
            string audioName = "";
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Multiselect = true;
            Dialog.Filter = "MP3 files (*.mp3)|*.mp3|All Files (*.*)|*.*";
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in Dialog.FileNames) // Iterate over each selected full file path
                {
                    list_paths.Items.Add(filePath);
                }

                foreach (string fileName in Dialog.SafeFileNames) // Iterate over each selected file name
                {
                    list_audio.Items.Add(fileName);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (list_audio.Items.Count == 0)
            {
                lbl_error.Visible = true;
            }
            else 
            {
                for (int i = 0; i < list_audio.Items.Count; i++)
                {
                    if (dataIO.checkAudio(list_audio.Items[i].ToString()))
                    {
                        MessageBox.Show("The Audio '" + list_audio.Items[i].ToString() + "' Already Exist and Has Not Beed Added.");
                    }
                    else
                    {
                        dataIO.SaveAudio(list_audio.Items[i].ToString(), list_paths.Items[i].ToString());
                        lbl_error.Visible = true;
                        lbl_error.ForeColor = Color.Green;
                        lbl_error.Text = "AUDIO FILES SAVED!";
                    }
                }
                list_audio.Items.Clear();
                list_paths.Items.Clear();

            }
        }

        private void pic_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
