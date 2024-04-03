namespace MugiwaraMusic
{
    partial class PlaylistDesign
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_view = new System.Windows.Forms.PictureBox();
            this.pic_playlist = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playlist)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(71, 29);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(60, 21);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Playlist";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 1);
            this.panel1.TabIndex = 2;
            // 
            // pic_view
            // 
            this.pic_view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_view.Image = global::MugiwaraMusic.Properties.Resources.More_Than;
            this.pic_view.Location = new System.Drawing.Point(344, 15);
            this.pic_view.Name = "pic_view";
            this.pic_view.Size = new System.Drawing.Size(43, 47);
            this.pic_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_view.TabIndex = 3;
            this.pic_view.TabStop = false;
            this.pic_view.Click += new System.EventHandler(this.pic_view_Click);
            // 
            // pic_playlist
            // 
            this.pic_playlist.Image = global::MugiwaraMusic.Properties.Resources.Playlist;
            this.pic_playlist.Location = new System.Drawing.Point(10, 10);
            this.pic_playlist.Name = "pic_playlist";
            this.pic_playlist.Size = new System.Drawing.Size(58, 55);
            this.pic_playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_playlist.TabIndex = 0;
            this.pic_playlist.TabStop = false;
            // 
            // PlaylistDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pic_view);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pic_playlist);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PlaylistDesign";
            this.Size = new System.Drawing.Size(390, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pic_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_playlist;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_view;
    }
}
