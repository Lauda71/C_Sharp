namespace Testing
{
    partial class CreateTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTestForm));
            this.lbQ = new System.Windows.Forms.ListBox();
            this.panQ = new System.Windows.Forms.Panel();
            this.DUDAnswers = new System.Windows.Forms.DomainUpDown();
            this.labQVal = new System.Windows.Forms.Label();
            this.butDelQ = new System.Windows.Forms.Button();
            this.butAddQ = new System.Windows.Forms.Button();
            this.panQQ = new System.Windows.Forms.Panel();
            this.rbPicWordInput = new System.Windows.Forms.RadioButton();
            this.rbPicNumberInput = new System.Windows.Forms.RadioButton();
            this.rbPicConform = new System.Windows.Forms.RadioButton();
            this.rbPicFew = new System.Windows.Forms.RadioButton();
            this.rbPicOne = new System.Windows.Forms.RadioButton();
            this.rbPic = new System.Windows.Forms.RadioButton();
            this.rbWordInput = new System.Windows.Forms.RadioButton();
            this.rbNumberInput = new System.Windows.Forms.RadioButton();
            this.rbConform = new System.Windows.Forms.RadioButton();
            this.rbFew = new System.Windows.Forms.RadioButton();
            this.rbOne = new System.Windows.Forms.RadioButton();
            this.labInfo = new System.Windows.Forms.Label();
            this.mainTS = new System.Windows.Forms.ToolStrip();
            this.tsbAddField = new System.Windows.Forms.ToolStripButton();
            this.tsbDelField = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAndExit = new System.Windows.Forms.ToolStripButton();
            this.tsbDel = new System.Windows.Forms.ToolStripButton();
            this.tslDate = new System.Windows.Forms.ToolStripLabel();
            this.panAnswers = new System.Windows.Forms.Panel();
            this.tbQ = new System.Windows.Forms.TextBox();
            this.timerButAddStop = new System.Windows.Forms.Timer(this.components);
            this.panQ.SuspendLayout();
            this.panQQ.SuspendLayout();
            this.mainTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQ
            // 
            this.lbQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbQ.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbQ.FormattingEnabled = true;
            this.lbQ.ItemHeight = 22;
            this.lbQ.Location = new System.Drawing.Point(0, 0);
            this.lbQ.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lbQ.Name = "lbQ";
            this.lbQ.Size = new System.Drawing.Size(111, 640);
            this.lbQ.TabIndex = 0;
            this.lbQ.SelectedIndexChanged += new System.EventHandler(this.lbQ_SelectedIndexChanged);
            // 
            // panQ
            // 
            this.panQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panQ.Controls.Add(this.butAddQ);
            this.panQ.Controls.Add(this.DUDAnswers);
            this.panQ.Controls.Add(this.labQVal);
            this.panQ.Controls.Add(this.butDelQ);
            this.panQ.Controls.Add(this.panQQ);
            this.panQ.Controls.Add(this.rbPic);
            this.panQ.Controls.Add(this.rbWordInput);
            this.panQ.Controls.Add(this.rbNumberInput);
            this.panQ.Controls.Add(this.rbConform);
            this.panQ.Controls.Add(this.rbFew);
            this.panQ.Controls.Add(this.rbOne);
            this.panQ.Controls.Add(this.labInfo);
            this.panQ.Location = new System.Drawing.Point(836, 0);
            this.panQ.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panQ.Name = "panQ";
            this.panQ.Size = new System.Drawing.Size(318, 642);
            this.panQ.TabIndex = 1;
            // 
            // DUDAnswers
            // 
            this.DUDAnswers.Location = new System.Drawing.Point(202, 540);
            this.DUDAnswers.Name = "DUDAnswers";
            this.DUDAnswers.ReadOnly = true;
            this.DUDAnswers.Size = new System.Drawing.Size(79, 31);
            this.DUDAnswers.TabIndex = 12;
            this.DUDAnswers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labQVal
            // 
            this.labQVal.AutoSize = true;
            this.labQVal.Location = new System.Drawing.Point(12, 542);
            this.labQVal.Name = "labQVal";
            this.labQVal.Size = new System.Drawing.Size(181, 22);
            this.labQVal.TabIndex = 11;
            this.labQVal.Text = "Вариантов ответа:";
            // 
            // butDelQ
            // 
            this.butDelQ.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDelQ.ForeColor = System.Drawing.Color.Green;
            this.butDelQ.Image = global::Testing.Properties.Resources.DelSuperSmall;
            this.butDelQ.Location = new System.Drawing.Point(167, 577);
            this.butDelQ.Name = "butDelQ";
            this.butDelQ.Size = new System.Drawing.Size(130, 57);
            this.butDelQ.TabIndex = 10;
            this.butDelQ.UseVisualStyleBackColor = true;
            this.butDelQ.Click += new System.EventHandler(this.butDelQ_Click);
            // 
            // butAddQ
            // 
            this.butAddQ.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butAddQ.ForeColor = System.Drawing.Color.Green;
            this.butAddQ.Image = global::Testing.Properties.Resources.addSuperSmall;
            this.butAddQ.Location = new System.Drawing.Point(19, 577);
            this.butAddQ.Name = "butAddQ";
            this.butAddQ.Size = new System.Drawing.Size(130, 57);
            this.butAddQ.TabIndex = 2;
            this.butAddQ.UseVisualStyleBackColor = true;
            this.butAddQ.Click += new System.EventHandler(this.butAddQ_Click);
            // 
            // panQQ
            // 
            this.panQQ.Controls.Add(this.rbPicWordInput);
            this.panQQ.Controls.Add(this.rbPicNumberInput);
            this.panQQ.Controls.Add(this.rbPicConform);
            this.panQQ.Controls.Add(this.rbPicFew);
            this.panQQ.Controls.Add(this.rbPicOne);
            this.panQQ.Enabled = false;
            this.panQQ.Location = new System.Drawing.Point(36, 305);
            this.panQQ.Name = "panQQ";
            this.panQQ.Size = new System.Drawing.Size(277, 224);
            this.panQQ.TabIndex = 9;
            // 
            // rbPicWordInput
            // 
            this.rbPicWordInput.AutoSize = true;
            this.rbPicWordInput.Location = new System.Drawing.Point(15, 188);
            this.rbPicWordInput.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbPicWordInput.Name = "rbPicWordInput";
            this.rbPicWordInput.Size = new System.Drawing.Size(151, 26);
            this.rbPicWordInput.TabIndex = 12;
            this.rbPicWordInput.TabStop = true;
            this.rbPicWordInput.Text = "Ответ - слово";
            this.rbPicWordInput.UseVisualStyleBackColor = true;
            // 
            // rbPicNumberInput
            // 
            this.rbPicNumberInput.AutoSize = true;
            this.rbPicNumberInput.Location = new System.Drawing.Point(15, 144);
            this.rbPicNumberInput.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbPicNumberInput.Name = "rbPicNumberInput";
            this.rbPicNumberInput.Size = new System.Drawing.Size(151, 26);
            this.rbPicNumberInput.TabIndex = 11;
            this.rbPicNumberInput.TabStop = true;
            this.rbPicNumberInput.Text = "Ответ - число";
            this.rbPicNumberInput.UseVisualStyleBackColor = true;
            // 
            // rbPicConform
            // 
            this.rbPicConform.AutoSize = true;
            this.rbPicConform.Location = new System.Drawing.Point(15, 100);
            this.rbPicConform.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbPicConform.Name = "rbPicConform";
            this.rbPicConform.Size = new System.Drawing.Size(220, 26);
            this.rbPicConform.TabIndex = 10;
            this.rbPicConform.TabStop = true;
            this.rbPicConform.Text = "Взаимосоответствия";
            this.rbPicConform.UseVisualStyleBackColor = true;
            // 
            // rbPicFew
            // 
            this.rbPicFew.AutoSize = true;
            this.rbPicFew.Location = new System.Drawing.Point(15, 56);
            this.rbPicFew.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbPicFew.Name = "rbPicFew";
            this.rbPicFew.Size = new System.Drawing.Size(194, 26);
            this.rbPicFew.TabIndex = 9;
            this.rbPicFew.TabStop = true;
            this.rbPicFew.Text = "Несколько оветов";
            this.rbPicFew.UseVisualStyleBackColor = true;
            // 
            // rbPicOne
            // 
            this.rbPicOne.AutoSize = true;
            this.rbPicOne.Location = new System.Drawing.Point(15, 12);
            this.rbPicOne.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbPicOne.Name = "rbPicOne";
            this.rbPicOne.Size = new System.Drawing.Size(132, 26);
            this.rbPicOne.TabIndex = 8;
            this.rbPicOne.TabStop = true;
            this.rbPicOne.Text = "Один ответ";
            this.rbPicOne.UseVisualStyleBackColor = true;
            // 
            // rbPic
            // 
            this.rbPic.AutoSize = true;
            this.rbPic.Location = new System.Drawing.Point(15, 273);
            this.rbPic.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbPic.Name = "rbPic";
            this.rbPic.Size = new System.Drawing.Size(226, 26);
            this.rbPic.TabIndex = 8;
            this.rbPic.TabStop = true;
            this.rbPic.Text = "Вопрос с картинкой:";
            this.rbPic.UseVisualStyleBackColor = true;
            this.rbPic.CheckedChanged += new System.EventHandler(this.rbPic_CheckedChanged);
            // 
            // rbWordInput
            // 
            this.rbWordInput.AutoSize = true;
            this.rbWordInput.Location = new System.Drawing.Point(16, 229);
            this.rbWordInput.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbWordInput.Name = "rbWordInput";
            this.rbWordInput.Size = new System.Drawing.Size(151, 26);
            this.rbWordInput.TabIndex = 7;
            this.rbWordInput.TabStop = true;
            this.rbWordInput.Text = "Ответ - слово";
            this.rbWordInput.UseVisualStyleBackColor = true;
            // 
            // rbNumberInput
            // 
            this.rbNumberInput.AutoSize = true;
            this.rbNumberInput.Location = new System.Drawing.Point(16, 185);
            this.rbNumberInput.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbNumberInput.Name = "rbNumberInput";
            this.rbNumberInput.Size = new System.Drawing.Size(151, 26);
            this.rbNumberInput.TabIndex = 6;
            this.rbNumberInput.TabStop = true;
            this.rbNumberInput.Text = "Ответ - число";
            this.rbNumberInput.UseVisualStyleBackColor = true;
            // 
            // rbConform
            // 
            this.rbConform.AutoSize = true;
            this.rbConform.Location = new System.Drawing.Point(16, 141);
            this.rbConform.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbConform.Name = "rbConform";
            this.rbConform.Size = new System.Drawing.Size(220, 26);
            this.rbConform.TabIndex = 5;
            this.rbConform.TabStop = true;
            this.rbConform.Text = "Взаимосоответствия";
            this.rbConform.UseVisualStyleBackColor = true;
            // 
            // rbFew
            // 
            this.rbFew.AutoSize = true;
            this.rbFew.Location = new System.Drawing.Point(16, 97);
            this.rbFew.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbFew.Name = "rbFew";
            this.rbFew.Size = new System.Drawing.Size(194, 26);
            this.rbFew.TabIndex = 4;
            this.rbFew.TabStop = true;
            this.rbFew.Text = "Несколько оветов";
            this.rbFew.UseVisualStyleBackColor = true;
            // 
            // rbOne
            // 
            this.rbOne.AutoSize = true;
            this.rbOne.Location = new System.Drawing.Point(16, 53);
            this.rbOne.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.rbOne.Name = "rbOne";
            this.rbOne.Size = new System.Drawing.Size(132, 26);
            this.rbOne.TabIndex = 3;
            this.rbOne.TabStop = true;
            this.rbOne.Text = "Один ответ";
            this.rbOne.UseVisualStyleBackColor = true;
            // 
            // labInfo
            // 
            this.labInfo.AutoSize = true;
            this.labInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInfo.Location = new System.Drawing.Point(45, 16);
            this.labInfo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labInfo.Name = "labInfo";
            this.labInfo.Size = new System.Drawing.Size(231, 23);
            this.labInfo.TabIndex = 2;
            this.labInfo.Text = "Выберите тип вопроса";
            // 
            // mainTS
            // 
            this.mainTS.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainTS.Dock = System.Windows.Forms.DockStyle.None;
            this.mainTS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddField,
            this.tsbDelField,
            this.tsbSaveAndExit,
            this.tsbDel,
            this.tslDate});
            this.mainTS.Location = new System.Drawing.Point(116, 611);
            this.mainTS.Name = "mainTS";
            this.mainTS.Size = new System.Drawing.Size(717, 29);
            this.mainTS.TabIndex = 2;
            this.mainTS.Text = "toolStrip1";
            // 
            // tsbAddField
            // 
            this.tsbAddField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsbAddField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAddField.ForeColor = System.Drawing.Color.Black;
            this.tsbAddField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddField.Name = "tsbAddField";
            this.tsbAddField.Size = new System.Drawing.Size(85, 26);
            this.tsbAddField.Text = " + поле ";
            this.tsbAddField.Click += new System.EventHandler(this.tsbAddField_Click);
            // 
            // tsbDelField
            // 
            this.tsbDelField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tsbDelField.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelField.ForeColor = System.Drawing.Color.Black;
            this.tsbDelField.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelField.Image")));
            this.tsbDelField.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelField.Name = "tsbDelField";
            this.tsbDelField.Size = new System.Drawing.Size(80, 26);
            this.tsbDelField.Text = " - поле ";
            this.tsbDelField.Click += new System.EventHandler(this.tsbDelField_Click);
            // 
            // tsbSaveAndExit
            // 
            this.tsbSaveAndExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tsbSaveAndExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSaveAndExit.ForeColor = System.Drawing.Color.Black;
            this.tsbSaveAndExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAndExit.Image")));
            this.tsbSaveAndExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAndExit.Name = "tsbSaveAndExit";
            this.tsbSaveAndExit.Size = new System.Drawing.Size(200, 26);
            this.tsbSaveAndExit.Text = " Сохранить и выйти ";
            this.tsbSaveAndExit.Click += new System.EventHandler(this.tsbSaveAndExit_Click);
            // 
            // tsbDel
            // 
            this.tsbDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tsbDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDel.ForeColor = System.Drawing.Color.Black;
            this.tsbDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbDel.Image")));
            this.tsbDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDel.Name = "tsbDel";
            this.tsbDel.Size = new System.Drawing.Size(224, 26);
            this.tsbDel.Text = " Удалить все вопросы ";
            this.tsbDel.Click += new System.EventHandler(this.tsbDel_Click);
            // 
            // tslDate
            // 
            this.tslDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tslDate.ForeColor = System.Drawing.Color.Black;
            this.tslDate.Name = "tslDate";
            this.tslDate.Size = new System.Drawing.Size(116, 26);
            this.tslDate.Text = " дд.мм.гггг ";
            // 
            // panAnswers
            // 
            this.panAnswers.AutoScroll = true;
            this.panAnswers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panAnswers.Location = new System.Drawing.Point(113, 154);
            this.panAnswers.Name = "panAnswers";
            this.panAnswers.Size = new System.Drawing.Size(721, 454);
            this.panAnswers.TabIndex = 4;
            // 
            // tbQ
            // 
            this.tbQ.Location = new System.Drawing.Point(113, 0);
            this.tbQ.Multiline = true;
            this.tbQ.Name = "tbQ";
            this.tbQ.Size = new System.Drawing.Size(721, 151);
            this.tbQ.TabIndex = 0;
            // 
            // timerButAddStop
            // 
            this.timerButAddStop.Tick += new System.EventHandler(this.timerButAddStop_Tick);
            // 
            // CreateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 642);
            this.Controls.Add(this.tbQ);
            this.Controls.Add(this.panAnswers);
            this.Controls.Add(this.mainTS);
            this.Controls.Add(this.panQ);
            this.Controls.Add(this.lbQ);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "CreateTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateTestForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateTestForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateTestForm_Load);
            this.panQ.ResumeLayout(false);
            this.panQ.PerformLayout();
            this.panQQ.ResumeLayout(false);
            this.panQQ.PerformLayout();
            this.mainTS.ResumeLayout(false);
            this.mainTS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbQ;
        private System.Windows.Forms.Panel panQ;
        private System.Windows.Forms.Panel panQQ;
        private System.Windows.Forms.RadioButton rbPicWordInput;
        private System.Windows.Forms.RadioButton rbPicNumberInput;
        private System.Windows.Forms.RadioButton rbPicConform;
        private System.Windows.Forms.RadioButton rbPicFew;
        private System.Windows.Forms.RadioButton rbPicOne;
        private System.Windows.Forms.RadioButton rbPic;
        private System.Windows.Forms.RadioButton rbWordInput;
        private System.Windows.Forms.RadioButton rbNumberInput;
        private System.Windows.Forms.RadioButton rbConform;
        private System.Windows.Forms.RadioButton rbFew;
        private System.Windows.Forms.RadioButton rbOne;
        private System.Windows.Forms.Label labInfo;
        private System.Windows.Forms.Button butAddQ;
        private System.Windows.Forms.Button butDelQ;
        private System.Windows.Forms.ToolStrip mainTS;
        private System.Windows.Forms.ToolStripButton tsbAddField;
        private System.Windows.Forms.ToolStripButton tsbSaveAndExit;
        private System.Windows.Forms.ToolStripButton tsbDel;
        private System.Windows.Forms.ToolStripLabel tslDate;
        private System.Windows.Forms.Panel panAnswers;
        private System.Windows.Forms.TextBox tbQ;
        private System.Windows.Forms.ToolStripButton tsbDelField;
        private System.Windows.Forms.DomainUpDown DUDAnswers;
        private System.Windows.Forms.Label labQVal;
        private System.Windows.Forms.Timer timerButAddStop;
    }
}