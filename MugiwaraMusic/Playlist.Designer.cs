namespace MugiwaraMusic
{
    partial class Playlist
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.list_audio = new System.Windows.Forms.ListBox();
            this.list_paths = new System.Windows.Forms.ListBox();
            this.lbl_Shuffle = new System.Windows.Forms.Label();
            this.pic_shuffle = new System.Windows.Forms.PictureBox();
            this.pic_search = new System.Windows.Forms.PictureBox();
            this.txt_audio = new System.Windows.Forms.TextBox();
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_audioCount = new System.Windows.Forms.Label();
            this.pic_settings = new System.Windows.Forms.PictureBox();
            this.pic_back = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_playlist = new System.Windows.Forms.PictureBox();
            this.flow_main = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pic_play = new System.Windows.Forms.PictureBox();
            this.pic_pause = new System.Windows.Forms.PictureBox();
            this.lbl_audio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.pic_action = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.NextSongTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shuffle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).BeginInit();
            this.panel_Settings.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playlist)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_action)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbl_error);
            this.panel1.Controls.Add(this.list_audio);
            this.panel1.Controls.Add(this.list_paths);
            this.panel1.Controls.Add(this.lbl_Shuffle);
            this.panel1.Controls.Add(this.pic_shuffle);
            this.panel1.Controls.Add(this.pic_search);
            this.panel1.Controls.Add(this.txt_audio);
            this.panel1.Controls.Add(this.panel_Settings);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.pic_settings);
            this.panel1.Controls.Add(this.pic_back);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pic_playlist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 235);
            this.panel1.TabIndex = 0;
            // 
            // list_audio
            // 
            this.list_audio.FormattingEnabled = true;
            this.list_audio.Location = new System.Drawing.Point(297, 171);
            this.list_audio.Name = "list_audio";
            this.list_audio.Size = new System.Drawing.Size(41, 17);
            this.list_audio.TabIndex = 18;
            this.list_audio.Visible = false;
            // 
            // list_paths
            // 
            this.list_paths.FormattingEnabled = true;
            this.list_paths.Location = new System.Drawing.Point(297, 148);
            this.list_paths.Name = "list_paths";
            this.list_paths.Size = new System.Drawing.Size(41, 17);
            this.list_paths.TabIndex = 17;
            this.list_paths.Visible = false;
            // 
            // lbl_Shuffle
            // 
            this.lbl_Shuffle.AutoSize = true;
            this.lbl_Shuffle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.lbl_Shuffle.Location = new System.Drawing.Point(161, 181);
            this.lbl_Shuffle.Name = "lbl_Shuffle";
            this.lbl_Shuffle.Size = new System.Drawing.Size(95, 17);
            this.lbl_Shuffle.TabIndex = 16;
            this.lbl_Shuffle.Text = "Shuffle Playlist";
            // 
            // pic_shuffle
            // 
            this.pic_shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_shuffle.Image = global::MugiwaraMusic.Properties.Resources.Shuffle;
            this.pic_shuffle.Location = new System.Drawing.Point(131, 174);
            this.pic_shuffle.Name = "pic_shuffle";
            this.pic_shuffle.Size = new System.Drawing.Size(28, 30);
            this.pic_shuffle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_shuffle.TabIndex = 15;
            this.pic_shuffle.TabStop = false;
            this.pic_shuffle.Click += new System.EventHandler(this.pic_shuffle_Click);
            // 
            // pic_search
            // 
            this.pic_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pic_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_search.Image = global::MugiwaraMusic.Properties.Resources.Search;
            this.pic_search.Location = new System.Drawing.Point(341, 206);
            this.pic_search.Name = "pic_search";
            this.pic_search.Size = new System.Drawing.Size(23, 20);
            this.pic_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_search.TabIndex = 14;
            this.pic_search.TabStop = false;
            // 
            // txt_audio
            // 
            this.txt_audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_audio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_audio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_audio.ForeColor = System.Drawing.Color.Gray;
            this.txt_audio.Location = new System.Drawing.Point(17, 206);
            this.txt_audio.Multiline = true;
            this.txt_audio.Name = "txt_audio";
            this.txt_audio.Size = new System.Drawing.Size(347, 20);
            this.txt_audio.TabIndex = 13;
            this.txt_audio.Text = "Search For An Audio";
            this.txt_audio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_audio_MouseClick);
            this.txt_audio.TextChanged += new System.EventHandler(this.txt_audio_TextChanged);
            // 
            // panel_Settings
            // 
            this.panel_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_Settings.Controls.Add(this.btn_delete);
            this.panel_Settings.Location = new System.Drawing.Point(197, 3);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(159, 129);
            this.panel_Settings.TabIndex = 8;
            this.panel_Settings.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(23, 22);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 23);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete Playlist";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_name);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lbl_audioCount);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(112, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 29);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(0, 5);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(98, 19);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Da Goat List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "•";
            // 
            // lbl_audioCount
            // 
            this.lbl_audioCount.AutoSize = true;
            this.lbl_audioCount.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_audioCount.ForeColor = System.Drawing.Color.White;
            this.lbl_audioCount.Location = new System.Drawing.Point(112, 7);
            this.lbl_audioCount.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.lbl_audioCount.Name = "lbl_audioCount";
            this.lbl_audioCount.Size = new System.Drawing.Size(59, 16);
            this.lbl_audioCount.TabIndex = 4;
            this.lbl_audioCount.Text = "30 Audio";
            // 
            // pic_settings
            // 
            this.pic_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_settings.Image = global::MugiwaraMusic.Properties.Resources.Menu_Vertical_1;
            this.pic_settings.Location = new System.Drawing.Point(358, 3);
            this.pic_settings.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
            this.pic_settings.Name = "pic_settings";
            this.pic_settings.Size = new System.Drawing.Size(33, 45);
            this.pic_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_settings.TabIndex = 7;
            this.pic_settings.TabStop = false;
            this.pic_settings.Click += new System.EventHandler(this.pic_settings_Click);
            // 
            // pic_back
            // 
            this.pic_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_back.Image = global::MugiwaraMusic.Properties.Resources.Less_Than;
            this.pic_back.Location = new System.Drawing.Point(3, 3);
            this.pic_back.Name = "pic_back";
            this.pic_back.Size = new System.Drawing.Size(45, 45);
            this.pic_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_back.TabIndex = 4;
            this.pic_back.TabStop = false;
            this.pic_back.Click += new System.EventHandler(this.pic_back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(3, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 1);
            this.panel2.TabIndex = 3;
            // 
            // pic_playlist
            // 
            this.pic_playlist.Image = global::MugiwaraMusic.Properties.Resources.wounded_Son_Goku_ultra_instinct;
            this.pic_playlist.Location = new System.Drawing.Point(112, 9);
            this.pic_playlist.Name = "pic_playlist";
            this.pic_playlist.Size = new System.Drawing.Size(163, 139);
            this.pic_playlist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_playlist.TabIndex = 0;
            this.pic_playlist.TabStop = false;
            // 
            // flow_main
            // 
            this.flow_main.AutoScroll = true;
            this.flow_main.BackColor = System.Drawing.Color.Black;
            this.flow_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_main.Location = new System.Drawing.Point(0, 235);
            this.flow_main.Margin = new System.Windows.Forms.Padding(0);
            this.flow_main.Name = "flow_main";
            this.flow_main.Size = new System.Drawing.Size(395, 269);
            this.flow_main.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pic_play);
            this.panel3.Controls.Add(this.pic_pause);
            this.panel3.Controls.Add(this.lbl_audio);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pic_next);
            this.panel3.Controls.Add(this.pic_action);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 504);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 56);
            this.panel3.TabIndex = 2;
            // 
            // pic_play
            // 
            this.pic_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_play.Image = global::MugiwaraMusic.Properties.Resources.Play;
            this.pic_play.Location = new System.Drawing.Point(183, 10);
            this.pic_play.Name = "pic_play";
            this.pic_play.Size = new System.Drawing.Size(47, 39);
            this.pic_play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_play.TabIndex = 23;
            this.pic_play.TabStop = false;
            this.pic_play.Visible = false;
            // 
            // pic_pause
            // 
            this.pic_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_pause.Image = global::MugiwaraMusic.Properties.Resources.Pause;
            this.pic_pause.Location = new System.Drawing.Point(236, 10);
            this.pic_pause.Name = "pic_pause";
            this.pic_pause.Size = new System.Drawing.Size(47, 39);
            this.pic_pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_pause.TabIndex = 22;
            this.pic_pause.TabStop = false;
            this.pic_pause.Visible = false;
            // 
            // lbl_audio
            // 
            this.lbl_audio.AutoSize = true;
            this.lbl_audio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_audio.ForeColor = System.Drawing.Color.White;
            this.lbl_audio.Location = new System.Drawing.Point(56, 20);
            this.lbl_audio.Name = "lbl_audio";
            this.lbl_audio.Size = new System.Drawing.Size(142, 21);
            this.lbl_audio.TabIndex = 21;
            this.lbl_audio.Text = "No Audio Playing";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MugiwaraMusic.Properties.Resources.Music;
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pic_next
            // 
            this.pic_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_next.Image = global::MugiwaraMusic.Properties.Resources.End;
            this.pic_next.Location = new System.Drawing.Point(341, 10);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(47, 39);
            this.pic_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_next.TabIndex = 19;
            this.pic_next.TabStop = false;
            this.pic_next.Click += new System.EventHandler(this.pic_next_Click);
            // 
            // pic_action
            // 
            this.pic_action.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_action.Enabled = false;
            this.pic_action.Image = global::MugiwaraMusic.Properties.Resources.Play1;
            this.pic_action.Location = new System.Drawing.Point(304, 10);
            this.pic_action.Name = "pic_action";
            this.pic_action.Size = new System.Drawing.Size(47, 39);
            this.pic_action.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_action.TabIndex = 18;
            this.pic_action.TabStop = false;
            this.pic_action.Click += new System.EventHandler(this.pic_action_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 1);
            this.panel4.TabIndex = 0;
            // 
            // NextSongTimer
            // 
            this.NextSongTimer.Tick += new System.EventHandler(this.NextSongTimer_Tick);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.lbl_error.Location = new System.Drawing.Point(11, 104);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(95, 17);
            this.lbl_error.TabIndex = 19;
            this.lbl_error.Text = "Shuffle Playlist";
            this.lbl_error.Visible = false;
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flow_main);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(395, 560);
            this.Load += new System.EventHandler(this.Playlist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_shuffle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search)).EndInit();
            this.panel_Settings.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_playlist)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_action)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_playlist;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_back;
        private System.Windows.Forms.FlowLayoutPanel flow_main;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pic_settings;
        private System.Windows.Forms.Panel panel_Settings;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_audio;
        private System.Windows.Forms.PictureBox pic_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_audioCount;
        private System.Windows.Forms.PictureBox pic_shuffle;
        private System.Windows.Forms.Label lbl_Shuffle;
        private System.Windows.Forms.ListBox list_paths;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pic_action;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_audio;
        private System.Windows.Forms.PictureBox pic_pause;
        private System.Windows.Forms.PictureBox pic_play;
        private System.Windows.Forms.ListBox list_audio;
        private System.Windows.Forms.Timer NextSongTimer;
        private System.Windows.Forms.Label lbl_error;
    }
}
