namespace MugiwaraMusic
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_addAudio = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_exit = new System.Windows.Forms.PictureBox();
            this.flow_main = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pic_addAudio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pic_exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pic_addAudio
            // 
            this.pic_addAudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_addAudio.Image = global::MugiwaraMusic.Properties.Resources.Add_1;
            this.pic_addAudio.Location = new System.Drawing.Point(81, 6);
            this.pic_addAudio.Name = "pic_addAudio";
            this.pic_addAudio.Size = new System.Drawing.Size(27, 29);
            this.pic_addAudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_addAudio.TabIndex = 13;
            this.pic_addAudio.TabStop = false;
            this.pic_addAudio.Click += new System.EventHandler(this.pic_addAudio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Audio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(2, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 1);
            this.panel2.TabIndex = 4;
            // 
            // pic_exit
            // 
            this.pic_exit.BackColor = System.Drawing.Color.Black;
            this.pic_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_exit.Image = global::MugiwaraMusic.Properties.Resources.X;
            this.pic_exit.Location = new System.Drawing.Point(359, 3);
            this.pic_exit.Name = "pic_exit";
            this.pic_exit.Size = new System.Drawing.Size(31, 32);
            this.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_exit.TabIndex = 3;
            this.pic_exit.TabStop = false;
            this.pic_exit.Click += new System.EventHandler(this.pic_exit_Click);
            // 
            // flow_main
            // 
            this.flow_main.AutoScroll = true;
            this.flow_main.BackColor = System.Drawing.Color.Black;
            this.flow_main.Location = new System.Drawing.Point(0, 40);
            this.flow_main.Margin = new System.Windows.Forms.Padding(0);
            this.flow_main.Name = "flow_main";
            this.flow_main.Size = new System.Drawing.Size(395, 561);
            this.flow_main.TabIndex = 1;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 601);
            this.Controls.Add(this.flow_main);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_addAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flow_main;
        private System.Windows.Forms.PictureBox pic_exit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_addAudio;
        private System.Windows.Forms.Label label1;
    }
}

