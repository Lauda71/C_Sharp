namespace formTimer
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btStart = new System.Windows.Forms.Button();
            this.bgMain = new System.Windows.Forms.GroupBox();
            this.btAnswer3 = new System.Windows.Forms.Button();
            this.btAnswer2 = new System.Windows.Forms.Button();
            this.btAnswer1 = new System.Windows.Forms.Button();
            this.labQuestion = new System.Windows.Forms.Label();
            this.pbBomb = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.pbPlus = new System.Windows.Forms.PictureBox();
            this.pbMinus = new System.Windows.Forms.PictureBox();
            this.pbHeart1 = new System.Windows.Forms.PictureBox();
            this.pbHeart2 = new System.Windows.Forms.PictureBox();
            this.pbHeart3 = new System.Windows.Forms.PictureBox();
            this.bgMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Silver;
            this.btStart.Font = new System.Drawing.Font("Felix Titling", 20.75F);
            this.btStart.ForeColor = System.Drawing.Color.DarkRed;
            this.btStart.Location = new System.Drawing.Point(16, 15);
            this.btStart.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(191, 63);
            this.btStart.TabIndex = 0;
            this.btStart.Text = "Н А Ч А Т Ь";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // bgMain
            // 
            this.bgMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bgMain.Controls.Add(this.btAnswer3);
            this.bgMain.Controls.Add(this.btAnswer2);
            this.bgMain.Controls.Add(this.btAnswer1);
            this.bgMain.Controls.Add(this.labQuestion);
            this.bgMain.Location = new System.Drawing.Point(16, 90);
            this.bgMain.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bgMain.Name = "bgMain";
            this.bgMain.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bgMain.Size = new System.Drawing.Size(467, 185);
            this.bgMain.TabIndex = 1;
            this.bgMain.TabStop = false;
            this.bgMain.Text = "Выберете вариант ответа:";
            // 
            // btAnswer3
            // 
            this.btAnswer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btAnswer3.Enabled = false;
            this.btAnswer3.Location = new System.Drawing.Point(329, 115);
            this.btAnswer3.Name = "btAnswer3";
            this.btAnswer3.Size = new System.Drawing.Size(128, 34);
            this.btAnswer3.TabIndex = 3;
            this.btAnswer3.Text = "Ответ3";
            this.btAnswer3.UseVisualStyleBackColor = false;
            this.btAnswer3.Click += new System.EventHandler(this.btAnswer3_Click);
            // 
            // btAnswer2
            // 
            this.btAnswer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btAnswer2.Enabled = false;
            this.btAnswer2.Location = new System.Drawing.Point(329, 75);
            this.btAnswer2.Name = "btAnswer2";
            this.btAnswer2.Size = new System.Drawing.Size(128, 34);
            this.btAnswer2.TabIndex = 2;
            this.btAnswer2.Text = "Ответ2";
            this.btAnswer2.UseVisualStyleBackColor = false;
            this.btAnswer2.Click += new System.EventHandler(this.btAnswer2_Click);
            // 
            // btAnswer1
            // 
            this.btAnswer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btAnswer1.Enabled = false;
            this.btAnswer1.Location = new System.Drawing.Point(329, 35);
            this.btAnswer1.Name = "btAnswer1";
            this.btAnswer1.Size = new System.Drawing.Size(128, 34);
            this.btAnswer1.TabIndex = 1;
            this.btAnswer1.Text = "Ответ1";
            this.btAnswer1.UseVisualStyleBackColor = false;
            this.btAnswer1.Click += new System.EventHandler(this.btAnswer1_Click);
            // 
            // labQuestion
            // 
            this.labQuestion.AutoSize = true;
            this.labQuestion.Font = new System.Drawing.Font("Felix Titling", 19.75F);
            this.labQuestion.Location = new System.Drawing.Point(22, 77);
            this.labQuestion.Name = "labQuestion";
            this.labQuestion.Size = new System.Drawing.Size(107, 32);
            this.labQuestion.TabIndex = 0;
            this.labQuestion.Text = "Впорос";
            // 
            // pbBomb
            // 
            this.pbBomb.Image = ((System.Drawing.Image)(resources.GetObject("pbBomb.Image")));
            this.pbBomb.Location = new System.Drawing.Point(16, 284);
            this.pbBomb.Name = "pbBomb";
            this.pbBomb.Size = new System.Drawing.Size(369, 292);
            this.pbBomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBomb.TabIndex = 2;
            this.pbBomb.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.Font = new System.Drawing.Font("Arial", 17.75F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.Maroon;
            this.labelTime.Location = new System.Drawing.Point(401, 284);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(72, 29);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "00:00";
            // 
            // mainTimer
            // 
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // pbPlus
            // 
            this.pbPlus.BackColor = System.Drawing.Color.Transparent;
            this.pbPlus.Image = ((System.Drawing.Image)(resources.GetObject("pbPlus.Image")));
            this.pbPlus.Location = new System.Drawing.Point(235, 12);
            this.pbPlus.Name = "pbPlus";
            this.pbPlus.Size = new System.Drawing.Size(97, 65);
            this.pbPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlus.TabIndex = 5;
            this.pbPlus.TabStop = false;
            this.pbPlus.Visible = false;
            // 
            // pbMinus
            // 
            this.pbMinus.BackColor = System.Drawing.Color.Transparent;
            this.pbMinus.Image = ((System.Drawing.Image)(resources.GetObject("pbMinus.Image")));
            this.pbMinus.Location = new System.Drawing.Point(366, 12);
            this.pbMinus.Name = "pbMinus";
            this.pbMinus.Size = new System.Drawing.Size(97, 65);
            this.pbMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinus.TabIndex = 6;
            this.pbMinus.TabStop = false;
            this.pbMinus.Visible = false;
            // 
            // pbHeart1
            // 
            this.pbHeart1.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart1.Image = ((System.Drawing.Image)(resources.GetObject("pbHeart1.Image")));
            this.pbHeart1.Location = new System.Drawing.Point(406, 355);
            this.pbHeart1.Name = "pbHeart1";
            this.pbHeart1.Size = new System.Drawing.Size(67, 53);
            this.pbHeart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart1.TabIndex = 7;
            this.pbHeart1.TabStop = false;
            // 
            // pbHeart2
            // 
            this.pbHeart2.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart2.Image = ((System.Drawing.Image)(resources.GetObject("pbHeart2.Image")));
            this.pbHeart2.Location = new System.Drawing.Point(406, 414);
            this.pbHeart2.Name = "pbHeart2";
            this.pbHeart2.Size = new System.Drawing.Size(67, 53);
            this.pbHeart2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart2.TabIndex = 8;
            this.pbHeart2.TabStop = false;
            // 
            // pbHeart3
            // 
            this.pbHeart3.BackColor = System.Drawing.Color.Transparent;
            this.pbHeart3.Image = ((System.Drawing.Image)(resources.GetObject("pbHeart3.Image")));
            this.pbHeart3.Location = new System.Drawing.Point(406, 473);
            this.pbHeart3.Name = "pbHeart3";
            this.pbHeart3.Size = new System.Drawing.Size(67, 53);
            this.pbHeart3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHeart3.TabIndex = 9;
            this.pbHeart3.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 589);
            this.Controls.Add(this.pbHeart3);
            this.Controls.Add(this.pbHeart2);
            this.Controls.Add(this.pbHeart1);
            this.Controls.Add(this.pbMinus);
            this.Controls.Add(this.pbPlus);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pbBomb);
            this.Controls.Add(this.bgMain);
            this.Controls.Add(this.btStart);
            this.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "mainForm";
            this.Text = "Тест";
            this.bgMain.ResumeLayout(false);
            this.bgMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.GroupBox bgMain;
        private System.Windows.Forms.Button btAnswer3;
        private System.Windows.Forms.Button btAnswer2;
        private System.Windows.Forms.Button btAnswer1;
        private System.Windows.Forms.Label labQuestion;
        private System.Windows.Forms.PictureBox pbBomb;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.PictureBox pbPlus;
        private System.Windows.Forms.PictureBox pbMinus;
        private System.Windows.Forms.PictureBox pbHeart1;
        private System.Windows.Forms.PictureBox pbHeart2;
        private System.Windows.Forms.PictureBox pbHeart3;
    }
}

