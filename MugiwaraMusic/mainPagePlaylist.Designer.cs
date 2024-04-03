namespace MugiwaraMusic
{
    partial class mainPagePlaylist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_playlist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_playlist
            // 
            this.txt_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_playlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_playlist.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_playlist.ForeColor = System.Drawing.Color.White;
            this.txt_playlist.Location = new System.Drawing.Point(11, 39);
            this.txt_playlist.Multiline = true;
            this.txt_playlist.Name = "txt_playlist";
            this.txt_playlist.Size = new System.Drawing.Size(374, 20);
            this.txt_playlist.TabIndex = 9;
            this.txt_playlist.TextChanged += new System.EventHandler(this.txt_playlist_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Playlists";
            // 
            // pic_search
            // 
            this.pic_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pic_search.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_search.Image = global::MugiwaraMusic.Properties.Resources.Search;
            this.pic_search.Location = new System.Drawing.Point(362, 39);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(23, 20);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_search.TabIndex = 12;
            this.pic_search.TabStop = false;
            // 
            // mainPagePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pic_search);
            this.Controls.Add(this.txt_playlist);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "mainPagePlaylist";
            this.Size = new System.Drawing.Size(395, 66);
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_playlist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pic_search;
    }
}
