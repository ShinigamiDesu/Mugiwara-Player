namespace MugiwaraMusic
{
    partial class AddAudio
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_audioUpload = new System.Windows.Forms.Button();
            this.list_audio = new System.Windows.Forms.ListBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.list_paths = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.label4.Location = new System.Drawing.Point(-1, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "* MP3";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(239, 254);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_audioUpload
            // 
            this.btn_audioUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btn_audioUpload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_audioUpload.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_audioUpload.Location = new System.Drawing.Point(2, 254);
            this.btn_audioUpload.Name = "btn_audioUpload";
            this.btn_audioUpload.Size = new System.Drawing.Size(118, 23);
            this.btn_audioUpload.TabIndex = 8;
            this.btn_audioUpload.Text = "UPLOAD AUDIO";
            this.btn_audioUpload.UseVisualStyleBackColor = false;
            this.btn_audioUpload.Click += new System.EventHandler(this.btn_audioUpload_Click);
            // 
            // list_audio
            // 
            this.list_audio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_audio.FormattingEnabled = true;
            this.list_audio.ItemHeight = 17;
            this.list_audio.Location = new System.Drawing.Point(2, 40);
            this.list_audio.Name = "list_audio";
            this.list_audio.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.list_audio.Size = new System.Drawing.Size(355, 208);
            this.list_audio.TabIndex = 7;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_error.Location = new System.Drawing.Point(138, 279);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(76, 16);
            this.lbl_error.TabIndex = 11;
            this.lbl_error.Text = "ADD AUDIO";
            this.lbl_error.Visible = false;
            // 
            // pic_exit
            // 
            this.pic_exit.BackColor = System.Drawing.Color.Transparent;
            this.pic_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_exit.Image = global::MugiwaraMusic.Properties.Resources.X;
            this.pic_exit.Location = new System.Drawing.Point(326, 2);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(31, 32);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_exit.TabIndex = 12;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // list_paths
            // 
            this.list_paths.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_paths.FormattingEnabled = true;
            this.list_paths.ItemHeight = 17;
            this.list_paths.Location = new System.Drawing.Point(84, 40);
            this.list_paths.Name = "list_paths";
            this.list_paths.Size = new System.Drawing.Size(273, 208);
            this.list_paths.TabIndex = 13;
            this.list_paths.Visible = false;
            // 
            // AddAudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(359, 304);
            this.Controls.Add(this.list_paths);
            this.Controls.Add(this.pic_exit);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_audioUpload);
            this.Controls.Add(this.list_audio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAudio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAudio";
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_audioUpload;
        private System.Windows.Forms.ListBox list_audio;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.ListBox list_paths;
    }
}