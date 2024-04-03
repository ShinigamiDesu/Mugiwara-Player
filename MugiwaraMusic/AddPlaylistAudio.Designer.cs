namespace MugiwaraMusic
{
    partial class AddPlaylistAudio
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_audios = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.list_audio = new System.Windows.Forms.ListBox();
            this.list_id = new System.Windows.Forms.ListBox();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.lbl_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_audios
            // 
            this.txt_audios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_audios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_audios.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_audios.ForeColor = System.Drawing.Color.White;
            this.txt_audios.Location = new System.Drawing.Point(0, -1);
            this.txt_audios.Margin = new System.Windows.Forms.Padding(0);
            this.txt_audios.Multiline = true;
            this.txt_audios.Name = "txt_audios";
            this.txt_audios.Size = new System.Drawing.Size(337, 57);
            this.txt_audios.TabIndex = 10;
            this.txt_audios.TextChanged += new System.EventHandler(this.txt_audios_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(106, 361);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 23);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // list_audio
            // 
            this.list_audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_audio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_audio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_audio.ForeColor = System.Drawing.Color.White;
            this.list_audio.FormattingEnabled = true;
            this.list_audio.ItemHeight = 24;
            this.list_audio.Location = new System.Drawing.Point(0, 56);
            this.list_audio.Margin = new System.Windows.Forms.Padding(0);
            this.list_audio.Name = "list_audio";
            this.list_audio.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_audio.Size = new System.Drawing.Size(337, 266);
            this.list_audio.TabIndex = 8;
            // 
            // list_id
            // 
            this.list_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_id.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_id.ForeColor = System.Drawing.Color.White;
            this.list_id.FormattingEnabled = true;
            this.list_id.ItemHeight = 24;
            this.list_id.Location = new System.Drawing.Point(156, 56);
            this.list_id.Margin = new System.Windows.Forms.Padding(0);
            this.list_id.Name = "list_id";
            this.list_id.Size = new System.Drawing.Size(159, 288);
            this.list_id.TabIndex = 11;
            this.list_id.Visible = false;
            // 
            // pic_exit
            // 
            this.pic_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pic_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_exit.Image = global::MugiwaraMusic.Properties.Resources.X;
            this.pic_exit.Location = new System.Drawing.Point(294, 12);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(31, 32);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_exit.TabIndex = 12;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Lime;
            this.lbl_error.Location = new System.Drawing.Point(109, 337);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(115, 21);
            this.lbl_error.TabIndex = 13;
            this.lbl_error.Text = "Added To List";
            this.lbl_error.Visible = false;
            // 
            // AddPlaylistAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(337, 396);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.pic_exit);
            this.Controls.Add(this.list_id);
            this.Controls.Add(this.txt_audios);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.list_audio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPlaylistAudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPlaylistAudio";
            this.Load += new System.EventHandler(this.AddPlaylistAudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_audios;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ListBox list_audio;
        private System.Windows.Forms.ListBox list_id;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.Label lbl_error;
    }
}