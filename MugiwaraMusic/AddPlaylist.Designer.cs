namespace MugiwaraMusic
{
    partial class AddPlaylist
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
            this.pic_defaultimg = new System.Windows.Forms.PictureBox();
            this.pic_img = new System.Windows.Forms.PictureBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_error = new System.Windows.Forms.Label();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_defaultimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_defaultimg
            // 
            this.pic_defaultimg.Image = global::MugiwaraMusic.Properties.Resources.Playlist;
            this.pic_defaultimg.Location = new System.Drawing.Point(2, 12);
            this.pic_defaultimg.Name = "pic_defaultimg";
            this.pic_defaultimg.Size = new System.Drawing.Size(87, 77);
            this.pic_defaultimg.TabIndex = 1;
            this.pic_defaultimg.TabStop = false;
            this.pic_defaultimg.Visible = false;
            // 
            // pic_img
            // 
            this.pic_img.BackColor = System.Drawing.Color.White;
            this.pic_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_img.Location = new System.Drawing.Point(119, 12);
            this.pic_img.Name = "pic_img";
            this.pic_img.Size = new System.Drawing.Size(118, 110);
            this.pic_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_img.TabIndex = 0;
            this.pic_img.TabStop = false;
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upload.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(119, 129);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(118, 23);
            this.btn_upload.TabIndex = 2;
            this.btn_upload.Text = "UPLOAD";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(119, 244);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(118, 23);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(12, 196);
            this.txt_name.MaxLength = 20;
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(320, 32);
            this.txt_name.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(8, 172);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(116, 21);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Playlist Name:";
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_error.Location = new System.Drawing.Point(8, 274);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(132, 21);
            this.lbl_error.TabIndex = 8;
            this.lbl_error.Text = "Name Required";
            this.lbl_error.Visible = false;
            // 
            // pic_exit
            // 
            this.pic_exit.BackColor = System.Drawing.Color.Transparent;
            this.pic_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_exit.Image = global::MugiwaraMusic.Properties.Resources.X;
            this.pic_exit.Location = new System.Drawing.Point(323, 3);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(31, 32);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_exit.TabIndex = 9;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // AddPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(359, 304);
            this.Controls.Add(this.pic_exit);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.pic_defaultimg);
            this.Controls.Add(this.pic_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPlaylist";
            ((System.ComponentModel.ISupportInitialize)(this.pic_defaultimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_img;
        private System.Windows.Forms.PictureBox pic_defaultimg;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.PictureBox pic_exit;
    }
}