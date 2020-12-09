namespace Testing
{
    partial class HereTheTestBegins
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HereTheTestBegins));
            this.lbQ = new System.Windows.Forms.ListBox();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.panAnswers = new System.Windows.Forms.Panel();
            this.butNext = new System.Windows.Forms.Button();
            this.butEndTest = new System.Windows.Forms.Button();
            this.butChange = new System.Windows.Forms.Button();
            this.labtime = new System.Windows.Forms.Label();
            this.butPause = new System.Windows.Forms.Button();
            this.labNumberQ = new System.Windows.Forms.Label();
            this.labQNumber = new System.Windows.Forms.Label();
            this.labAllQ = new System.Windows.Forms.Label();
            this.labAmountQ = new System.Windows.Forms.Label();
            this.chbTime = new System.Windows.Forms.CheckBox();
            this.labHowManyTime = new System.Windows.Forms.Label();
            this.chbTimePB = new System.Windows.Forms.CheckBox();
            this.timerRestOfTime = new System.Windows.Forms.Timer(this.components);
            this.pb = new System.Windows.Forms.PictureBox();
            this.fsPB = new Testing.FsProgressBar();
            this.SecondPB = new Testing.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQ
            // 
            this.lbQ.FormattingEnabled = true;
            this.lbQ.ItemHeight = 22;
            this.lbQ.Location = new System.Drawing.Point(3, 45);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(134, 664);
            this.lbQ.TabIndex = 1;
            this.lbQ.SelectedIndexChanged += new System.EventHandler(this.lbQ_SelectedIndexChanged);
            // 
            // tbQ
            // 
            this.tbQ.Enabled = false;
            this.tbQ.Location = new System.Drawing.Point(143, 89);
            this.tbQ.Multiline = true;
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(721, 164);
            this.tbQ.TabIndex = 2;
            // 
            // panAnswers
            // 
            this.panAnswers.BackColor = System.Drawing.Color.LightGray;
            this.panAnswers.Location = new System.Drawing.Point(143, 259);
            this.panAnswers.Name = "panAnswers";
            this.panAnswers.Size = new System.Drawing.Size(721, 454);
            this.panAnswers.TabIndex = 3;
            // 
            // butNext
            // 
            this.butNext.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butNext.ForeColor = System.Drawing.Color.Green;
            this.butNext.Location = new System.Drawing.Point(1084, 633);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(194, 80);
            this.butNext.TabIndex = 4;
            this.butNext.Text = "Следующий вопрос";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butEndTest
            // 
            this.butEndTest.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEndTest.ForeColor = System.Drawing.Color.DarkOrange;
            this.butEndTest.Location = new System.Drawing.Point(1084, 582);
            this.butEndTest.Name = "butEndTest";
            this.butEndTest.Size = new System.Drawing.Size(194, 45);
            this.butEndTest.TabIndex = 7;
            this.butEndTest.Text = "Завершить";
            this.butEndTest.UseVisualStyleBackColor = true;
            this.butEndTest.Click += new System.EventHandler(this.butEndTest_Click);
            // 
            // butChange
            // 
            this.butChange.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butChange.ForeColor = System.Drawing.Color.Black;
            this.butChange.Location = new System.Drawing.Point(870, 633);
            this.butChange.Name = "butChange";
            this.butChange.Size = new System.Drawing.Size(194, 80);
            this.butChange.TabIndex = 9;
            this.butChange.Text = "Перейти к вопросу";
            this.butChange.UseVisualStyleBackColor = true;
            this.butChange.Click += new System.EventHandler(this.butChange_Click);
            // 
            // labtime
            // 
            this.labtime.AutoSize = true;
            this.labtime.Location = new System.Drawing.Point(910, 54);
            this.labtime.Name = "labtime";
            this.labtime.Size = new System.Drawing.Size(199, 22);
            this.labtime.TabIndex = 10;
            this.labtime.Text = "Оставшееся время:";
            // 
            // butPause
            // 
            this.butPause.BackColor = System.Drawing.Color.Transparent;
            this.butPause.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butPause.ForeColor = System.Drawing.Color.Black;
            this.butPause.Location = new System.Drawing.Point(870, 582);
            this.butPause.Name = "butPause";
            this.butPause.Size = new System.Drawing.Size(194, 45);
            this.butPause.TabIndex = 11;
            this.butPause.Text = "П а у з а ";
            this.butPause.UseVisualStyleBackColor = false;
            this.butPause.Click += new System.EventHandler(this.butPause_Click);
            // 
            // labNumberQ
            // 
            this.labNumberQ.AutoSize = true;
            this.labNumberQ.Location = new System.Drawing.Point(143, 54);
            this.labNumberQ.Name = "labNumberQ";
            this.labNumberQ.Size = new System.Drawing.Size(107, 22);
            this.labNumberQ.TabIndex = 13;
            this.labNumberQ.Text = "Вопрос №";
            // 
            // labQNumber
            // 
            this.labQNumber.AutoSize = true;
            this.labQNumber.Location = new System.Drawing.Point(256, 54);
            this.labQNumber.Name = "labQNumber";
            this.labQNumber.Size = new System.Drawing.Size(32, 22);
            this.labQNumber.TabIndex = 14;
            this.labQNumber.Text = "00";
            // 
            // labAllQ
            // 
            this.labAllQ.AutoSize = true;
            this.labAllQ.Location = new System.Drawing.Point(339, 54);
            this.labAllQ.Name = "labAllQ";
            this.labAllQ.Size = new System.Drawing.Size(32, 22);
            this.labAllQ.TabIndex = 16;
            this.labAllQ.Text = "00";
            // 
            // labAmountQ
            // 
            this.labAmountQ.AutoSize = true;
            this.labAmountQ.Location = new System.Drawing.Point(296, 54);
            this.labAmountQ.Name = "labAmountQ";
            this.labAmountQ.Size = new System.Drawing.Size(30, 22);
            this.labAmountQ.TabIndex = 15;
            this.labAmountQ.Text = "из";
            // 
            // chbTime
            // 
            this.chbTime.AutoSize = true;
            this.chbTime.Location = new System.Drawing.Point(503, 52);
            this.chbTime.Name = "chbTime";
            this.chbTime.Size = new System.Drawing.Size(364, 26);
            this.chbTime.TabIndex = 17;
            this.chbTime.Text = "Скрыть / показать счетчик времени";
            this.chbTime.UseVisualStyleBackColor = true;
            this.chbTime.CheckedChanged += new System.EventHandler(this.chbTime_CheckedChanged);
            // 
            // labHowManyTime
            // 
            this.labHowManyTime.AutoSize = true;
            this.labHowManyTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labHowManyTime.ForeColor = System.Drawing.Color.Black;
            this.labHowManyTime.Location = new System.Drawing.Point(1126, 54);
            this.labHowManyTime.Name = "labHowManyTime";
            this.labHowManyTime.Size = new System.Drawing.Size(86, 23);
            this.labHowManyTime.TabIndex = 18;
            this.labHowManyTime.Text = "00:00:00";
            // 
            // chbTimePB
            // 
            this.chbTimePB.AutoSize = true;
            this.chbTimePB.Location = new System.Drawing.Point(1297, 52);
            this.chbTimePB.Name = "chbTimePB";
            this.chbTimePB.Size = new System.Drawing.Size(15, 14);
            this.chbTimePB.TabIndex = 20;
            this.chbTimePB.UseVisualStyleBackColor = true;
            this.chbTimePB.CheckedChanged += new System.EventHandler(this.chbTimePB_CheckedChanged);
            // 
            // timerRestOfTime
            // 
            this.timerRestOfTime.Tick += new System.EventHandler(this.timerRestOfTime_Tick);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(870, 89);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(408, 487);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 6;
            this.pb.TabStop = false;
            // 
            // fsPB
            // 
            this.fsPB.BackColor = System.Drawing.Color.White;
            this.fsPB.BorderColor = System.Drawing.Color.Black;
            this.fsPB.BorderWidth = 2;
            this.fsPB.ForeColor = System.Drawing.Color.Black;
            this.fsPB.Location = new System.Drawing.Point(3, 4);
            this.fsPB.MaxValue = 1;
            this.fsPB.MinValue = 0;
            this.fsPB.Name = "fsPB";
            this.fsPB.ProgressColor = System.Drawing.Color.Green;
            this.fsPB.ProgressTextType = Testing.FsProgressBar.FsProgressTextType.AsIs;
            this.fsPB.ShowProgressText = true;
            this.fsPB.Size = new System.Drawing.Size(1322, 35);
            this.fsPB.TabIndex = 22;
            this.fsPB.Text = "fsProgressBar1";
            this.fsPB.Value = 0;
            // 
            // SecondPB
            // 
            this.SecondPB.BackColor = System.Drawing.Color.White;
            this.SecondPB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SecondPB.Location = new System.Drawing.Point(1284, 89);
            this.SecondPB.Name = "SecondPB";
            this.SecondPB.Size = new System.Drawing.Size(41, 624);
            this.SecondPB.TabIndex = 21;
            // 
            // HereTheTestBegins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 718);
            this.Controls.Add(this.fsPB);
            this.Controls.Add(this.SecondPB);
            this.Controls.Add(this.chbTimePB);
            this.Controls.Add(this.labHowManyTime);
            this.Controls.Add(this.chbTime);
            this.Controls.Add(this.labAllQ);
            this.Controls.Add(this.labAmountQ);
            this.Controls.Add(this.labQNumber);
            this.Controls.Add(this.labNumberQ);
            this.Controls.Add(this.butPause);
            this.Controls.Add(this.labtime);
            this.Controls.Add(this.butChange);
            this.Controls.Add(this.butEndTest);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.panAnswers);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.lbQ);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "HereTheTestBegins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Here The Test Begins";
            this.Load += new System.EventHandler(this.HereTheTestBegins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbQ;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.Panel panAnswers;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button butEndTest;
        private System.Windows.Forms.Button butChange;
        private System.Windows.Forms.Label labtime;
        private System.Windows.Forms.Button butPause;
        private System.Windows.Forms.Label labNumberQ;
        private System.Windows.Forms.Label labQNumber;
        private System.Windows.Forms.Label labAllQ;
        private System.Windows.Forms.Label labAmountQ;
        private System.Windows.Forms.CheckBox chbTime;
        private System.Windows.Forms.Label labHowManyTime;
        private System.Windows.Forms.CheckBox chbTimePB;
        private System.Windows.Forms.Timer timerRestOfTime;
        private VerticalProgressBar SecondPB;
        private FsProgressBar fsPB;
    }
}