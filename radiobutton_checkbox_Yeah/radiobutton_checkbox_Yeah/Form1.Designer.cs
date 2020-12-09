namespace radiobutton_checkbox_Yeah
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.rb_mus1 = new System.Windows.Forms.RadioButton();
            this.fb_music = new System.Windows.Forms.GroupBox();
            this.rb_stop = new System.Windows.Forms.RadioButton();
            this.rb_mus5 = new System.Windows.Forms.RadioButton();
            this.rb_mus4 = new System.Windows.Forms.RadioButton();
            this.rb_mus3 = new System.Windows.Forms.RadioButton();
            this.rb_mus2 = new System.Windows.Forms.RadioButton();
            this.rb_mus6 = new System.Windows.Forms.RadioButton();
            this.cb_gif1 = new System.Windows.Forms.CheckBox();
            this.cb_gif2 = new System.Windows.Forms.CheckBox();
            this.cb_gif3 = new System.Windows.Forms.CheckBox();
            this.cb_gif4 = new System.Windows.Forms.CheckBox();
            this.cb_gif5 = new System.Windows.Forms.CheckBox();
            this.cb_gif6 = new System.Windows.Forms.CheckBox();
            this.NP = new System.Windows.Forms.PictureBox();
            this.Masuda = new System.Windows.Forms.PictureBox();
            this.Nightcall = new System.Windows.Forms.PictureBox();
            this.Brut = new System.Windows.Forms.PictureBox();
            this.Orax = new System.Windows.Forms.PictureBox();
            this.Plenka = new System.Windows.Forms.PictureBox();
            this.fb_music.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Masuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nightcall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plenka)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_mus1
            // 
            this.rb_mus1.AutoSize = true;
            this.rb_mus1.Location = new System.Drawing.Point(18, 31);
            this.rb_mus1.Name = "rb_mus1";
            this.rb_mus1.Size = new System.Drawing.Size(93, 28);
            this.rb_mus1.TabIndex = 0;
            this.rb_mus1.Text = "Nu Pogodi!";
            this.rb_mus1.UseVisualStyleBackColor = true;
            this.rb_mus1.CheckedChanged += new System.EventHandler(this.letsplay1);
            // 
            // fb_music
            // 
            this.fb_music.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.fb_music.Controls.Add(this.cb_gif6);
            this.fb_music.Controls.Add(this.cb_gif5);
            this.fb_music.Controls.Add(this.cb_gif4);
            this.fb_music.Controls.Add(this.cb_gif3);
            this.fb_music.Controls.Add(this.cb_gif2);
            this.fb_music.Controls.Add(this.cb_gif1);
            this.fb_music.Controls.Add(this.rb_mus6);
            this.fb_music.Controls.Add(this.rb_stop);
            this.fb_music.Controls.Add(this.rb_mus5);
            this.fb_music.Controls.Add(this.rb_mus4);
            this.fb_music.Controls.Add(this.rb_mus3);
            this.fb_music.Controls.Add(this.rb_mus2);
            this.fb_music.Controls.Add(this.rb_mus1);
            this.fb_music.Font = new System.Drawing.Font("Bodoni MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fb_music.ForeColor = System.Drawing.Color.Snow;
            this.fb_music.Location = new System.Drawing.Point(43, 50);
            this.fb_music.Name = "fb_music";
            this.fb_music.Size = new System.Drawing.Size(317, 315);
            this.fb_music.TabIndex = 1;
            this.fb_music.TabStop = false;
            this.fb_music.Text = "Композиции";
            this.fb_music.Enter += new System.EventHandler(this.fb_music_Enter);
            // 
            // rb_stop
            // 
            this.rb_stop.AutoSize = true;
            this.rb_stop.Checked = true;
            this.rb_stop.Location = new System.Drawing.Point(18, 272);
            this.rb_stop.Name = "rb_stop";
            this.rb_stop.Size = new System.Drawing.Size(263, 28);
            this.rb_stop.TabIndex = 6;
            this.rb_stop.TabStop = true;
            this.rb_stop.Text = "Остановить воспроизведение.";
            this.rb_stop.UseVisualStyleBackColor = true;
            this.rb_stop.CheckedChanged += new System.EventHandler(this.stop);
            // 
            // rb_mus5
            // 
            this.rb_mus5.AutoSize = true;
            this.rb_mus5.Location = new System.Drawing.Point(18, 167);
            this.rb_mus5.Name = "rb_mus5";
            this.rb_mus5.Size = new System.Drawing.Size(55, 28);
            this.rb_mus5.TabIndex = 4;
            this.rb_mus5.Text = "Orax";
            this.rb_mus5.UseVisualStyleBackColor = true;
            this.rb_mus5.CheckedChanged += new System.EventHandler(this.letsplay5);
            // 
            // rb_mus4
            // 
            this.rb_mus4.AutoSize = true;
            this.rb_mus4.Location = new System.Drawing.Point(18, 133);
            this.rb_mus4.Name = "rb_mus4";
            this.rb_mus4.Size = new System.Drawing.Size(116, 28);
            this.rb_mus4.TabIndex = 3;
            this.rb_mus4.Text = "Carpenter Brut";
            this.rb_mus4.UseVisualStyleBackColor = true;
            this.rb_mus4.CheckedChanged += new System.EventHandler(this.letsplay4);
            // 
            // rb_mus3
            // 
            this.rb_mus3.AutoSize = true;
            this.rb_mus3.Location = new System.Drawing.Point(18, 99);
            this.rb_mus3.Name = "rb_mus3";
            this.rb_mus3.Size = new System.Drawing.Size(81, 28);
            this.rb_mus3.TabIndex = 2;
            this.rb_mus3.Text = "Nightcall";
            this.rb_mus3.UseVisualStyleBackColor = true;
            this.rb_mus3.CheckedChanged += new System.EventHandler(this.letsplay3);
            // 
            // rb_mus2
            // 
            this.rb_mus2.AutoSize = true;
            this.rb_mus2.Location = new System.Drawing.Point(18, 65);
            this.rb_mus2.Name = "rb_mus2";
            this.rb_mus2.Size = new System.Drawing.Size(122, 28);
            this.rb_mus2.TabIndex = 1;
            this.rb_mus2.Text = "Toshiro Masuda";
            this.rb_mus2.UseVisualStyleBackColor = true;
            this.rb_mus2.CheckedChanged += new System.EventHandler(this.letsplay2);
            // 
            // rb_mus6
            // 
            this.rb_mus6.AutoSize = true;
            this.rb_mus6.Location = new System.Drawing.Point(18, 201);
            this.rb_mus6.Name = "rb_mus6";
            this.rb_mus6.Size = new System.Drawing.Size(67, 28);
            this.rb_mus6.TabIndex = 7;
            this.rb_mus6.Text = "Plenka";
            this.rb_mus6.UseVisualStyleBackColor = true;
            this.rb_mus6.CheckedChanged += new System.EventHandler(this.letsplay6);
            // 
            // cb_gif1
            // 
            this.cb_gif1.AutoSize = true;
            this.cb_gif1.Location = new System.Drawing.Point(201, 31);
            this.cb_gif1.Name = "cb_gif1";
            this.cb_gif1.Size = new System.Drawing.Size(79, 28);
            this.cb_gif1.TabIndex = 0;
            this.cb_gif1.Text = "Гифка";
            this.cb_gif1.UseVisualStyleBackColor = true;
            this.cb_gif1.CheckedChanged += new System.EventHandler(this.gifNP);
            // 
            // cb_gif2
            // 
            this.cb_gif2.AutoSize = true;
            this.cb_gif2.Location = new System.Drawing.Point(201, 65);
            this.cb_gif2.Name = "cb_gif2";
            this.cb_gif2.Size = new System.Drawing.Size(79, 28);
            this.cb_gif2.TabIndex = 8;
            this.cb_gif2.Text = "Гифка";
            this.cb_gif2.UseVisualStyleBackColor = true;
            this.cb_gif2.CheckedChanged += new System.EventHandler(this.gifMasuda);
            // 
            // cb_gif3
            // 
            this.cb_gif3.AutoSize = true;
            this.cb_gif3.Location = new System.Drawing.Point(201, 99);
            this.cb_gif3.Name = "cb_gif3";
            this.cb_gif3.Size = new System.Drawing.Size(79, 28);
            this.cb_gif3.TabIndex = 9;
            this.cb_gif3.Text = "Гифка";
            this.cb_gif3.UseVisualStyleBackColor = true;
            this.cb_gif3.CheckedChanged += new System.EventHandler(this.gifNc);
            // 
            // cb_gif4
            // 
            this.cb_gif4.AutoSize = true;
            this.cb_gif4.Location = new System.Drawing.Point(201, 133);
            this.cb_gif4.Name = "cb_gif4";
            this.cb_gif4.Size = new System.Drawing.Size(79, 28);
            this.cb_gif4.TabIndex = 10;
            this.cb_gif4.Text = "Гифка";
            this.cb_gif4.UseVisualStyleBackColor = true;
            this.cb_gif4.CheckedChanged += new System.EventHandler(this.gifBru);
            // 
            // cb_gif5
            // 
            this.cb_gif5.AutoSize = true;
            this.cb_gif5.Location = new System.Drawing.Point(201, 167);
            this.cb_gif5.Name = "cb_gif5";
            this.cb_gif5.Size = new System.Drawing.Size(79, 28);
            this.cb_gif5.TabIndex = 11;
            this.cb_gif5.Text = "Гифка";
            this.cb_gif5.UseVisualStyleBackColor = true;
            this.cb_gif5.CheckedChanged += new System.EventHandler(this.gifOra);
            // 
            // cb_gif6
            // 
            this.cb_gif6.AutoSize = true;
            this.cb_gif6.Location = new System.Drawing.Point(201, 201);
            this.cb_gif6.Name = "cb_gif6";
            this.cb_gif6.Size = new System.Drawing.Size(79, 28);
            this.cb_gif6.TabIndex = 12;
            this.cb_gif6.Text = "Гифка";
            this.cb_gif6.UseVisualStyleBackColor = true;
            this.cb_gif6.CheckedChanged += new System.EventHandler(this.gifPlen);
            // 
            // NP
            // 
            this.NP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NP.BackgroundImage")));
            this.NP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NP.Image = ((System.Drawing.Image)(resources.GetObject("NP.Image")));
            this.NP.Location = new System.Drawing.Point(385, 50);
            this.NP.Name = "NP";
            this.NP.Size = new System.Drawing.Size(277, 214);
            this.NP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NP.TabIndex = 2;
            this.NP.TabStop = false;
            this.NP.Visible = false;
            // 
            // Masuda
            // 
            this.Masuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Masuda.BackgroundImage")));
            this.Masuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Masuda.Image = ((System.Drawing.Image)(resources.GetObject("Masuda.Image")));
            this.Masuda.Location = new System.Drawing.Point(681, 50);
            this.Masuda.Name = "Masuda";
            this.Masuda.Size = new System.Drawing.Size(320, 229);
            this.Masuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Masuda.TabIndex = 3;
            this.Masuda.TabStop = false;
            this.Masuda.Visible = false;
            // 
            // Nightcall
            // 
            this.Nightcall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nightcall.BackgroundImage")));
            this.Nightcall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Nightcall.Image = ((System.Drawing.Image)(resources.GetObject("Nightcall.Image")));
            this.Nightcall.Location = new System.Drawing.Point(43, 391);
            this.Nightcall.Name = "Nightcall";
            this.Nightcall.Size = new System.Drawing.Size(306, 170);
            this.Nightcall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Nightcall.TabIndex = 4;
            this.Nightcall.TabStop = false;
            this.Nightcall.Visible = false;
            // 
            // Brut
            // 
            this.Brut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Brut.BackgroundImage")));
            this.Brut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Brut.Image = ((System.Drawing.Image)(resources.GetObject("Brut.Image")));
            this.Brut.Location = new System.Drawing.Point(43, 584);
            this.Brut.Name = "Brut";
            this.Brut.Size = new System.Drawing.Size(306, 178);
            this.Brut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Brut.TabIndex = 5;
            this.Brut.TabStop = false;
            this.Brut.Visible = false;
            // 
            // Orax
            // 
            this.Orax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Orax.BackgroundImage")));
            this.Orax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Orax.Image = ((System.Drawing.Image)(resources.GetObject("Orax.Image")));
            this.Orax.Location = new System.Drawing.Point(385, 347);
            this.Orax.Name = "Orax";
            this.Orax.Size = new System.Drawing.Size(488, 339);
            this.Orax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Orax.TabIndex = 6;
            this.Orax.TabStop = false;
            this.Orax.Visible = false;
            // 
            // Plenka
            // 
            this.Plenka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Plenka.BackgroundImage")));
            this.Plenka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Plenka.Image = ((System.Drawing.Image)(resources.GetObject("Plenka.Image")));
            this.Plenka.Location = new System.Drawing.Point(1050, 50);
            this.Plenka.Name = "Plenka";
            this.Plenka.Size = new System.Drawing.Size(245, 229);
            this.Plenka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plenka.TabIndex = 7;
            this.Plenka.TabStop = false;
            this.Plenka.Visible = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1342, 774);
            this.Controls.Add(this.Plenka);
            this.Controls.Add(this.Orax);
            this.Controls.Add(this.Brut);
            this.Controls.Add(this.Nightcall);
            this.Controls.Add(this.Masuda);
            this.Controls.Add(this.NP);
            this.Controls.Add(this.fb_music);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Form";
            this.Text = "Music  for  programming";
            this.fb_music.ResumeLayout(false);
            this.fb_music.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Masuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nightcall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Orax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plenka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_mus1;
        private System.Windows.Forms.GroupBox fb_music;
        private System.Windows.Forms.RadioButton rb_stop;
        private System.Windows.Forms.RadioButton rb_mus5;
        private System.Windows.Forms.RadioButton rb_mus4;
        private System.Windows.Forms.RadioButton rb_mus3;
        private System.Windows.Forms.RadioButton rb_mus2;
        private System.Windows.Forms.RadioButton rb_mus6;
        private System.Windows.Forms.CheckBox cb_gif1;
        private System.Windows.Forms.CheckBox cb_gif6;
        private System.Windows.Forms.CheckBox cb_gif5;
        private System.Windows.Forms.CheckBox cb_gif4;
        private System.Windows.Forms.CheckBox cb_gif3;
        private System.Windows.Forms.CheckBox cb_gif2;
        private System.Windows.Forms.PictureBox NP;
        private System.Windows.Forms.PictureBox Masuda;
        private System.Windows.Forms.PictureBox Nightcall;
        private System.Windows.Forms.PictureBox Brut;
        private System.Windows.Forms.PictureBox Orax;
        private System.Windows.Forms.PictureBox Plenka;
    }
}

