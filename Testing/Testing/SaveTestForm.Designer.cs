namespace Testing
{
    partial class SaveTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaveTestForm));
            this.tbNameTest = new System.Windows.Forms.TextBox();
            this.labNameTest = new System.Windows.Forms.Label();
            this.labTopic = new System.Windows.Forms.Label();
            this.labTimeLim = new System.Windows.Forms.Label();
            this.labTryLimit = new System.Windows.Forms.Label();
            this.labComment = new System.Windows.Forms.Label();
            this.tbTopicTest = new System.Windows.Forms.TextBox();
            this.chbTime = new System.Windows.Forms.CheckBox();
            this.chbTry = new System.Windows.Forms.CheckBox();
            this.tbTimeLim = new System.Windows.Forms.TextBox();
            this.labMin = new System.Windows.Forms.Label();
            this.cbTryLim = new System.Windows.Forms.ComboBox();
            this.tbCommentTest = new System.Windows.Forms.TextBox();
            this.labAmountQ = new System.Windows.Forms.Label();
            this.labDateCreate = new System.Windows.Forms.Label();
            this.labAmountQQ = new System.Windows.Forms.Label();
            this.labDateCreateQ = new System.Windows.Forms.Label();
            this.butSaveTest = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.butClearAll = new System.Windows.Forms.Button();
            this.cbReturnAbility = new System.Windows.Forms.ComboBox();
            this.chbReturnAbility = new System.Windows.Forms.CheckBox();
            this.labReturnAbility = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNameTest
            // 
            this.tbNameTest.Location = new System.Drawing.Point(383, 31);
            this.tbNameTest.Multiline = true;
            this.tbNameTest.Name = "tbNameTest";
            this.tbNameTest.Size = new System.Drawing.Size(340, 31);
            this.tbNameTest.TabIndex = 0;
            // 
            // labNameTest
            // 
            this.labNameTest.AutoSize = true;
            this.labNameTest.Location = new System.Drawing.Point(115, 34);
            this.labNameTest.Margin = new System.Windows.Forms.Padding(25);
            this.labNameTest.Name = "labNameTest";
            this.labNameTest.Size = new System.Drawing.Size(240, 22);
            this.labNameTest.TabIndex = 1;
            this.labNameTest.Text = "Введите название теста:";
            // 
            // labTopic
            // 
            this.labTopic.AutoSize = true;
            this.labTopic.Location = new System.Drawing.Point(151, 106);
            this.labTopic.Margin = new System.Windows.Forms.Padding(25);
            this.labTopic.Name = "labTopic";
            this.labTopic.Size = new System.Drawing.Size(204, 22);
            this.labTopic.TabIndex = 2;
            this.labTopic.Text = "Укажите тему теста:";
            // 
            // labTimeLim
            // 
            this.labTimeLim.AutoSize = true;
            this.labTimeLim.Enabled = false;
            this.labTimeLim.Location = new System.Drawing.Point(82, 178);
            this.labTimeLim.Margin = new System.Windows.Forms.Padding(25);
            this.labTimeLim.Name = "labTimeLim";
            this.labTimeLim.Size = new System.Drawing.Size(273, 22);
            this.labTimeLim.TabIndex = 3;
            this.labTimeLim.Text = "Ограничение  по  времени:";
            this.labTimeLim.Click += new System.EventHandler(this.labTimeLim_Click);
            // 
            // labTryLimit
            // 
            this.labTryLimit.AutoSize = true;
            this.labTryLimit.Enabled = false;
            this.labTryLimit.Location = new System.Drawing.Point(84, 250);
            this.labTryLimit.Margin = new System.Windows.Forms.Padding(25);
            this.labTryLimit.Name = "labTryLimit";
            this.labTryLimit.Size = new System.Drawing.Size(271, 22);
            this.labTryLimit.TabIndex = 4;
            this.labTryLimit.Text = "Ограничение по попыткам:";
            this.labTryLimit.Click += new System.EventHandler(this.labTryLimit_Click);
            // 
            // labComment
            // 
            this.labComment.AutoSize = true;
            this.labComment.Location = new System.Drawing.Point(203, 518);
            this.labComment.Margin = new System.Windows.Forms.Padding(25);
            this.labComment.Name = "labComment";
            this.labComment.Size = new System.Drawing.Size(152, 22);
            this.labComment.TabIndex = 5;
            this.labComment.Text = "Комментарий:";
            // 
            // tbTopicTest
            // 
            this.tbTopicTest.Location = new System.Drawing.Point(383, 103);
            this.tbTopicTest.Multiline = true;
            this.tbTopicTest.Name = "tbTopicTest";
            this.tbTopicTest.Size = new System.Drawing.Size(340, 31);
            this.tbTopicTest.TabIndex = 2;
            // 
            // chbTime
            // 
            this.chbTime.AutoSize = true;
            this.chbTime.Location = new System.Drawing.Point(59, 183);
            this.chbTime.Name = "chbTime";
            this.chbTime.Size = new System.Drawing.Size(15, 14);
            this.chbTime.TabIndex = 7;
            this.chbTime.TabStop = false;
            this.chbTime.UseVisualStyleBackColor = true;
            this.chbTime.CheckedChanged += new System.EventHandler(this.chbTime_CheckedChanged);
            // 
            // chbTry
            // 
            this.chbTry.AutoSize = true;
            this.chbTry.Location = new System.Drawing.Point(60, 255);
            this.chbTry.Name = "chbTry";
            this.chbTry.Size = new System.Drawing.Size(15, 14);
            this.chbTry.TabIndex = 8;
            this.chbTry.TabStop = false;
            this.chbTry.UseVisualStyleBackColor = true;
            this.chbTry.CheckedChanged += new System.EventHandler(this.chbTry_CheckedChanged);
            // 
            // tbTimeLim
            // 
            this.tbTimeLim.Enabled = false;
            this.tbTimeLim.Location = new System.Drawing.Point(383, 175);
            this.tbTimeLim.Multiline = true;
            this.tbTimeLim.Name = "tbTimeLim";
            this.tbTimeLim.Size = new System.Drawing.Size(144, 31);
            this.tbTimeLim.TabIndex = 3;
            this.tbTimeLim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTimeLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTimeLim_KeyPress);
            // 
            // labMin
            // 
            this.labMin.AutoSize = true;
            this.labMin.Enabled = false;
            this.labMin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labMin.Location = new System.Drawing.Point(545, 178);
            this.labMin.Margin = new System.Windows.Forms.Padding(25);
            this.labMin.Name = "labMin";
            this.labMin.Size = new System.Drawing.Size(99, 22);
            this.labMin.TabIndex = 10;
            this.labMin.Text = "(м и н у т)";
            // 
            // cbTryLim
            // 
            this.cbTryLim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTryLim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTryLim.Enabled = false;
            this.cbTryLim.FormattingEnabled = true;
            this.cbTryLim.Location = new System.Drawing.Point(383, 247);
            this.cbTryLim.Name = "cbTryLim";
            this.cbTryLim.Size = new System.Drawing.Size(144, 32);
            this.cbTryLim.TabIndex = 4;
            this.cbTryLim.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbh_DrawItem);
            this.cbTryLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTryLim_KeyPress);
            // 
            // tbCommentTest
            // 
            this.tbCommentTest.Location = new System.Drawing.Point(383, 515);
            this.tbCommentTest.Multiline = true;
            this.tbCommentTest.Name = "tbCommentTest";
            this.tbCommentTest.Size = new System.Drawing.Size(340, 133);
            this.tbCommentTest.TabIndex = 6;
            // 
            // labAmountQ
            // 
            this.labAmountQ.AutoSize = true;
            this.labAmountQ.Location = new System.Drawing.Point(191, 387);
            this.labAmountQ.Margin = new System.Windows.Forms.Padding(25);
            this.labAmountQ.Name = "labAmountQ";
            this.labAmountQ.Size = new System.Drawing.Size(164, 22);
            this.labAmountQ.TabIndex = 13;
            this.labAmountQ.Text = "Всего вопросов:";
            // 
            // labDateCreate
            // 
            this.labDateCreate.AutoSize = true;
            this.labDateCreate.Location = new System.Drawing.Point(200, 446);
            this.labDateCreate.Margin = new System.Windows.Forms.Padding(25);
            this.labDateCreate.Name = "labDateCreate";
            this.labDateCreate.Size = new System.Drawing.Size(155, 22);
            this.labDateCreate.TabIndex = 14;
            this.labDateCreate.Text = "Дата создания:";
            // 
            // labAmountQQ
            // 
            this.labAmountQQ.AutoSize = true;
            this.labAmountQQ.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labAmountQQ.Location = new System.Drawing.Point(379, 387);
            this.labAmountQQ.Margin = new System.Windows.Forms.Padding(25);
            this.labAmountQQ.Name = "labAmountQQ";
            this.labAmountQQ.Size = new System.Drawing.Size(32, 22);
            this.labAmountQQ.TabIndex = 15;
            this.labAmountQQ.Text = "00";
            // 
            // labDateCreateQ
            // 
            this.labDateCreateQ.AutoSize = true;
            this.labDateCreateQ.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDateCreateQ.Location = new System.Drawing.Point(379, 446);
            this.labDateCreateQ.Margin = new System.Windows.Forms.Padding(25);
            this.labDateCreateQ.Name = "labDateCreateQ";
            this.labDateCreateQ.Size = new System.Drawing.Size(102, 22);
            this.labDateCreateQ.TabIndex = 16;
            this.labDateCreateQ.Text = "дд.мм.гггг";
            // 
            // butSaveTest
            // 
            this.butSaveTest.ForeColor = System.Drawing.Color.Black;
            this.butSaveTest.Location = new System.Drawing.Point(319, 680);
            this.butSaveTest.Name = "butSaveTest";
            this.butSaveTest.Size = new System.Drawing.Size(163, 41);
            this.butSaveTest.TabIndex = 8;
            this.butSaveTest.Text = "Сохранить";
            this.butSaveTest.UseVisualStyleBackColor = true;
            this.butSaveTest.Click += new System.EventHandler(this.butSaveTest_Click);
            // 
            // butCancel
            // 
            this.butCancel.ForeColor = System.Drawing.Color.Black;
            this.butCancel.Location = new System.Drawing.Point(558, 680);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(144, 41);
            this.butCancel.TabIndex = 9;
            this.butCancel.Text = "Отмена";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // butClearAll
            // 
            this.butClearAll.ForeColor = System.Drawing.Color.Black;
            this.butClearAll.Location = new System.Drawing.Point(38, 680);
            this.butClearAll.Name = "butClearAll";
            this.butClearAll.Size = new System.Drawing.Size(202, 41);
            this.butClearAll.TabIndex = 7;
            this.butClearAll.Text = "Очистить все поля";
            this.butClearAll.UseVisualStyleBackColor = true;
            this.butClearAll.Click += new System.EventHandler(this.butClearAll_Click);
            // 
            // cbReturnAbility
            // 
            this.cbReturnAbility.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbReturnAbility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReturnAbility.Enabled = false;
            this.cbReturnAbility.FormattingEnabled = true;
            this.cbReturnAbility.Location = new System.Drawing.Point(383, 314);
            this.cbReturnAbility.Name = "cbReturnAbility";
            this.cbReturnAbility.Size = new System.Drawing.Size(144, 32);
            this.cbReturnAbility.TabIndex = 5;
            this.cbReturnAbility.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbh_DrawItem);
            // 
            // chbReturnAbility
            // 
            this.chbReturnAbility.AutoSize = true;
            this.chbReturnAbility.Location = new System.Drawing.Point(23, 321);
            this.chbReturnAbility.Name = "chbReturnAbility";
            this.chbReturnAbility.Size = new System.Drawing.Size(15, 14);
            this.chbReturnAbility.TabIndex = 21;
            this.chbReturnAbility.TabStop = false;
            this.chbReturnAbility.UseVisualStyleBackColor = true;
            this.chbReturnAbility.CheckedChanged += new System.EventHandler(this.chbReturnAbility_CheckedChanged);
            // 
            // labReturnAbility
            // 
            this.labReturnAbility.AutoSize = true;
            this.labReturnAbility.Enabled = false;
            this.labReturnAbility.Location = new System.Drawing.Point(46, 317);
            this.labReturnAbility.Margin = new System.Windows.Forms.Padding(25);
            this.labReturnAbility.Name = "labReturnAbility";
            this.labReturnAbility.Size = new System.Drawing.Size(310, 22);
            this.labReturnAbility.TabIndex = 20;
            this.labReturnAbility.Text = "Лимит по возврату к вопросам:";
            this.labReturnAbility.Click += new System.EventHandler(this.labReturnAbility_Click);
            // 
            // SaveTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(747, 740);
            this.Controls.Add(this.cbReturnAbility);
            this.Controls.Add(this.chbReturnAbility);
            this.Controls.Add(this.labReturnAbility);
            this.Controls.Add(this.butClearAll);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSaveTest);
            this.Controls.Add(this.labDateCreateQ);
            this.Controls.Add(this.labAmountQQ);
            this.Controls.Add(this.labDateCreate);
            this.Controls.Add(this.labAmountQ);
            this.Controls.Add(this.tbCommentTest);
            this.Controls.Add(this.cbTryLim);
            this.Controls.Add(this.labMin);
            this.Controls.Add(this.tbTimeLim);
            this.Controls.Add(this.chbTry);
            this.Controls.Add(this.chbTime);
            this.Controls.Add(this.tbTopicTest);
            this.Controls.Add(this.labComment);
            this.Controls.Add(this.labTryLimit);
            this.Controls.Add(this.labTimeLim);
            this.Controls.Add(this.labTopic);
            this.Controls.Add(this.labNameTest);
            this.Controls.Add(this.tbNameTest);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "SaveTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaveTestForm";
            this.Load += new System.EventHandler(this.SaveTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNameTest;
        private System.Windows.Forms.Label labNameTest;
        private System.Windows.Forms.Label labTopic;
        private System.Windows.Forms.Label labTimeLim;
        private System.Windows.Forms.Label labTryLimit;
        private System.Windows.Forms.Label labComment;
        private System.Windows.Forms.TextBox tbTopicTest;
        private System.Windows.Forms.CheckBox chbTime;
        private System.Windows.Forms.CheckBox chbTry;
        private System.Windows.Forms.TextBox tbTimeLim;
        private System.Windows.Forms.Label labMin;
        private System.Windows.Forms.ComboBox cbTryLim;
        private System.Windows.Forms.TextBox tbCommentTest;
        private System.Windows.Forms.Label labAmountQ;
        private System.Windows.Forms.Label labDateCreate;
        private System.Windows.Forms.Label labAmountQQ;
        private System.Windows.Forms.Label labDateCreateQ;
        private System.Windows.Forms.Button butSaveTest;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Button butClearAll;
        private System.Windows.Forms.ComboBox cbReturnAbility;
        private System.Windows.Forms.CheckBox chbReturnAbility;
        private System.Windows.Forms.Label labReturnAbility;
    }
}