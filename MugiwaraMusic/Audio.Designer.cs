namespace MugiwaraMusic
{
    partial class Audio
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
            this.pic_audio = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_settings = new System.Windows.Forms.PictureBox();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_audio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_settings)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(79, 26);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(68, 21);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "StarBoy";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.pic_audio);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 68);
            this.panel1.TabIndex = 7;
            // 
            // pic_audio
            // 
            this.pic_audio.Image = global::MugiwaraMusic.Properties.Resources.Music;
            this.pic_audio.Location = new System.Drawing.Point(0, 0);
            this.pic_audio.Name = "pic_audio";
            this.pic_audio.Size = new System.Drawing.Size(69, 65);
            this.pic_audio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_audio.TabIndex = 4;
            this.pic_audio.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(78, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 10);
            this.panel2.TabIndex = 10;
            // 
            // pic_settings
            // 
            this.pic_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_settings.Image = global::MugiwaraMusic.Properties.Resources.Ellipsis_11;
            this.pic_settings.Location = new System.Drawing.Point(347, 22);
            this.pic_settings.Name = "pic_settings";
            this.pic_settings.Size = new System.Drawing.Size(22, 27);
            this.pic_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_settings.TabIndex = 6;
            this.pic_settings.TabStop = false;
            this.pic_settings.Click += new System.EventHandler(this.pic_settings_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.White;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Remove.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Location = new System.Drawing.Point(254, 22);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(87, 27);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Visible = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Audio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_settings);
            this.Controls.Add(this.lbl_name);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Audio";
            this.Size = new System.Drawing.Size(372, 75);
            this.Click += new System.EventHandler(this.Audio_Click);
            this.MouseEnter += new System.EventHandler(this.Audio_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Audio_MouseLeave);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_audio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_settings;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.PictureBox pic_audio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Remove;
    }
}
