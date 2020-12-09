namespace Testing
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.rbT = new System.Windows.Forms.RadioButton();
            this.labEntry = new System.Windows.Forms.Label();
            this.rbS = new System.Windows.Forms.RadioButton();
            this.butEntry = new System.Windows.Forms.Button();
            this.panT = new System.Windows.Forms.Panel();
            this.labPasswordT = new System.Windows.Forms.Label();
            this.labLoginT = new System.Windows.Forms.Label();
            this.tbPasswordT = new System.Windows.Forms.TextBox();
            this.tbLoginT = new System.Windows.Forms.TextBox();
            this.panS = new System.Windows.Forms.Panel();
            this.cbTest = new System.Windows.Forms.ComboBox();
            this.labTest = new System.Windows.Forms.Label();
            this.cbGroupNumber = new System.Windows.Forms.ComboBox();
            this.tbNameS = new System.Windows.Forms.TextBox();
            this.labNumberGr = new System.Windows.Forms.Label();
            this.labFIOS = new System.Windows.Forms.Label();
            this.gbDesignSelection = new System.Windows.Forms.GroupBox();
            this.rbColorLight = new System.Windows.Forms.RadioButton();
            this.rbColorDark = new System.Windows.Forms.RadioButton();
            this.rbColorOrange = new System.Windows.Forms.RadioButton();
            this.rbColorPink = new System.Windows.Forms.RadioButton();
            this.rbColorGreen = new System.Windows.Forms.RadioButton();
            this.rbColorRed = new System.Windows.Forms.RadioButton();
            this.rbColorStandard = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labTCreator = new System.Windows.Forms.Label();
            this.labTeacherCreator = new System.Windows.Forms.Label();
            this.panT.SuspendLayout();
            this.panS.SuspendLayout();
            this.gbDesignSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbT
            // 
            this.rbT.AutoSize = true;
            this.rbT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbT.Location = new System.Drawing.Point(34, 48);
            this.rbT.Name = "rbT";
            this.rbT.Size = new System.Drawing.Size(104, 27);
            this.rbT.TabIndex = 0;
            this.rbT.Text = "Учитель";
            this.rbT.UseVisualStyleBackColor = true;
            this.rbT.CheckedChanged += new System.EventHandler(this.rbT_CheckedChanged);
            // 
            // labEntry
            // 
            this.labEntry.AutoSize = true;
            this.labEntry.Location = new System.Drawing.Point(12, 13);
            this.labEntry.Name = "labEntry";
            this.labEntry.Size = new System.Drawing.Size(102, 22);
            this.labEntry.TabIndex = 1;
            this.labEntry.Text = "Войти как";
            // 
            // rbS
            // 
            this.rbS.AutoSize = true;
            this.rbS.Checked = true;
            this.rbS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbS.Location = new System.Drawing.Point(34, 215);
            this.rbS.Name = "rbS";
            this.rbS.Size = new System.Drawing.Size(109, 27);
            this.rbS.TabIndex = 2;
            this.rbS.TabStop = true;
            this.rbS.Text = "Студент";
            this.rbS.UseVisualStyleBackColor = true;
            // 
            // butEntry
            // 
            this.butEntry.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEntry.ForeColor = System.Drawing.Color.Black;
            this.butEntry.Location = new System.Drawing.Point(519, 371);
            this.butEntry.Name = "butEntry";
            this.butEntry.Size = new System.Drawing.Size(204, 49);
            this.butEntry.TabIndex = 7;
            this.butEntry.Text = "Поехали!";
            this.butEntry.UseVisualStyleBackColor = true;
            this.butEntry.Click += new System.EventHandler(this.butEntry_Click);
            // 
            // panT
            // 
            this.panT.Controls.Add(this.labPasswordT);
            this.panT.Controls.Add(this.labLoginT);
            this.panT.Controls.Add(this.tbPasswordT);
            this.panT.Controls.Add(this.tbLoginT);
            this.panT.Location = new System.Drawing.Point(50, 81);
            this.panT.Name = "panT";
            this.panT.Size = new System.Drawing.Size(448, 112);
            this.panT.TabIndex = 12;
            // 
            // labPasswordT
            // 
            this.labPasswordT.AutoSize = true;
            this.labPasswordT.Location = new System.Drawing.Point(23, 65);
            this.labPasswordT.Name = "labPasswordT";
            this.labPasswordT.Size = new System.Drawing.Size(163, 22);
            this.labPasswordT.TabIndex = 8;
            this.labPasswordT.Text = "Введите пароль:";
            // 
            // labLoginT
            // 
            this.labLoginT.AutoSize = true;
            this.labLoginT.Location = new System.Drawing.Point(23, 18);
            this.labLoginT.Name = "labLoginT";
            this.labLoginT.Size = new System.Drawing.Size(147, 22);
            this.labLoginT.TabIndex = 7;
            this.labLoginT.Text = "Введите логин:";
            // 
            // tbPasswordT
            // 
            this.tbPasswordT.Location = new System.Drawing.Point(190, 56);
            this.tbPasswordT.Name = "tbPasswordT";
            this.tbPasswordT.Size = new System.Drawing.Size(230, 31);
            this.tbPasswordT.TabIndex = 10;
            this.tbPasswordT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPasswordT_KeyPress);
            // 
            // tbLoginT
            // 
            this.tbLoginT.Location = new System.Drawing.Point(190, 9);
            this.tbLoginT.Name = "tbLoginT";
            this.tbLoginT.Size = new System.Drawing.Size(230, 31);
            this.tbLoginT.TabIndex = 9;
            this.tbLoginT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoginT_KeyPress);
            // 
            // panS
            // 
            this.panS.Controls.Add(this.labTeacherCreator);
            this.panS.Controls.Add(this.labTCreator);
            this.panS.Controls.Add(this.cbTest);
            this.panS.Controls.Add(this.labTest);
            this.panS.Controls.Add(this.cbGroupNumber);
            this.panS.Controls.Add(this.tbNameS);
            this.panS.Controls.Add(this.labNumberGr);
            this.panS.Controls.Add(this.labFIOS);
            this.panS.Location = new System.Drawing.Point(50, 248);
            this.panS.Name = "panS";
            this.panS.Size = new System.Drawing.Size(448, 226);
            this.panS.TabIndex = 13;
            // 
            // cbTest
            // 
            this.cbTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTest.FormattingEnabled = true;
            this.cbTest.Location = new System.Drawing.Point(190, 115);
            this.cbTest.MaxDropDownItems = 99;
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(230, 30);
            this.cbTest.TabIndex = 17;
            this.cbTest.SelectedIndexChanged += new System.EventHandler(this.cbTest_SelectedIndexChanged);
            // 
            // labTest
            // 
            this.labTest.AutoSize = true;
            this.labTest.Location = new System.Drawing.Point(23, 123);
            this.labTest.Name = "labTest";
            this.labTest.Size = new System.Drawing.Size(151, 22);
            this.labTest.TabIndex = 16;
            this.labTest.Text = "Выберите тест:";
            // 
            // cbGroupNumber
            // 
            this.cbGroupNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupNumber.FormattingEnabled = true;
            this.cbGroupNumber.Location = new System.Drawing.Point(190, 63);
            this.cbGroupNumber.Name = "cbGroupNumber";
            this.cbGroupNumber.Size = new System.Drawing.Size(230, 30);
            this.cbGroupNumber.TabIndex = 15;
            // 
            // tbNameS
            // 
            this.tbNameS.Location = new System.Drawing.Point(190, 14);
            this.tbNameS.Name = "tbNameS";
            this.tbNameS.Size = new System.Drawing.Size(230, 31);
            this.tbNameS.TabIndex = 14;
            this.tbNameS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNameS_KeyPress);
            // 
            // labNumberGr
            // 
            this.labNumberGr.AutoSize = true;
            this.labNumberGr.Location = new System.Drawing.Point(23, 71);
            this.labNumberGr.Name = "labNumberGr";
            this.labNumberGr.Size = new System.Drawing.Size(152, 22);
            this.labNumberGr.TabIndex = 13;
            this.labNumberGr.Text = "Укажите № гр.:";
            // 
            // labFIOS
            // 
            this.labFIOS.AutoSize = true;
            this.labFIOS.Location = new System.Drawing.Point(23, 23);
            this.labFIOS.Name = "labFIOS";
            this.labFIOS.Size = new System.Drawing.Size(127, 22);
            this.labFIOS.TabIndex = 12;
            this.labFIOS.Text = "Введите имя";
            // 
            // gbDesignSelection
            // 
            this.gbDesignSelection.BackColor = System.Drawing.Color.Transparent;
            this.gbDesignSelection.Controls.Add(this.rbColorLight);
            this.gbDesignSelection.Controls.Add(this.rbColorDark);
            this.gbDesignSelection.Controls.Add(this.rbColorOrange);
            this.gbDesignSelection.Controls.Add(this.rbColorPink);
            this.gbDesignSelection.Controls.Add(this.rbColorGreen);
            this.gbDesignSelection.Controls.Add(this.rbColorRed);
            this.gbDesignSelection.Controls.Add(this.rbColorStandard);
            this.gbDesignSelection.ForeColor = System.Drawing.Color.Black;
            this.gbDesignSelection.Location = new System.Drawing.Point(519, 13);
            this.gbDesignSelection.Name = "gbDesignSelection";
            this.gbDesignSelection.Size = new System.Drawing.Size(204, 347);
            this.gbDesignSelection.TabIndex = 14;
            this.gbDesignSelection.TabStop = false;
            this.gbDesignSelection.Text = "Тема:";
            // 
            // rbColorLight
            // 
            this.rbColorLight.AutoSize = true;
            this.rbColorLight.Location = new System.Drawing.Point(25, 294);
            this.rbColorLight.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.rbColorLight.Name = "rbColorLight";
            this.rbColorLight.Size = new System.Drawing.Size(102, 26);
            this.rbColorLight.TabIndex = 6;
            this.rbColorLight.Text = "Светлая";
            this.rbColorLight.UseVisualStyleBackColor = true;
            this.rbColorLight.CheckedChanged += new System.EventHandler(this.rbColorLight_CheckedChanged);
            // 
            // rbColorDark
            // 
            this.rbColorDark.AutoSize = true;
            this.rbColorDark.Location = new System.Drawing.Point(25, 250);
            this.rbColorDark.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.rbColorDark.Name = "rbColorDark";
            this.rbColorDark.Size = new System.Drawing.Size(97, 26);
            this.rbColorDark.TabIndex = 5;
            this.rbColorDark.Text = "Темная";
            this.rbColorDark.UseVisualStyleBackColor = true;
            this.rbColorDark.CheckedChanged += new System.EventHandler(this.rbColorDark_CheckedChanged);
            // 
            // rbColorOrange
            // 
            this.rbColorOrange.AutoSize = true;
            this.rbColorOrange.Location = new System.Drawing.Point(25, 206);
            this.rbColorOrange.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.rbColorOrange.Name = "rbColorOrange";
            this.rbColorOrange.Size = new System.Drawing.Size(139, 26);
            this.rbColorOrange.TabIndex = 4;
            this.rbColorOrange.Text = "Оранжевая";
            this.rbColorOrange.UseVisualStyleBackColor = true;
            this.rbColorOrange.CheckedChanged += new System.EventHandler(this.rbColorOrange_CheckedChanged);
            // 
            // rbColorPink
            // 
            this.rbColorPink.AutoSize = true;
            this.rbColorPink.Location = new System.Drawing.Point(25, 162);
            this.rbColorPink.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.rbColorPink.Name = "rbColorPink";
            this.rbColorPink.Size = new System.Drawing.Size(101, 26);
            this.rbColorPink.TabIndex = 3;
            this.rbColorPink.Text = "Розовая";
            this.rbColorPink.UseVisualStyleBackColor = true;
            this.rbColorPink.CheckedChanged += new System.EventHandler(this.rbColorPink_CheckedChanged);
            // 
            // rbColorGreen
            // 
            this.rbColorGreen.AutoSize = true;
            this.rbColorGreen.Location = new System.Drawing.Point(25, 118);
            this.rbColorGreen.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.rbColorGreen.Name = "rbColorGreen";
            this.rbColorGreen.Size = new System.Drawing.Size(105, 26);
            this.rbColorGreen.TabIndex = 2;
            this.rbColorGreen.Text = "Зеленая";
            this.rbColorGreen.UseVisualStyleBackColor = true;
            this.rbColorGreen.CheckedChanged += new System.EventHandler(this.rbColorGreen_CheckedChanged);
            // 
            // rbColorRed
            // 
            this.rbColorRed.AutoSize = true;
            this.rbColorRed.Location = new System.Drawing.Point(25, 74);
            this.rbColorRed.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.rbColorRed.Name = "rbColorRed";
            this.rbColorRed.Size = new System.Drawing.Size(109, 26);
            this.rbColorRed.TabIndex = 1;
            this.rbColorRed.Text = "Красная";
            this.rbColorRed.UseVisualStyleBackColor = true;
            this.rbColorRed.CheckedChanged += new System.EventHandler(this.rbColorRed_CheckedChanged);
            // 
            // rbColorStandard
            // 
            this.rbColorStandard.AutoSize = true;
            this.rbColorStandard.Checked = true;
            this.rbColorStandard.Location = new System.Drawing.Point(25, 30);
            this.rbColorStandard.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.rbColorStandard.Name = "rbColorStandard";
            this.rbColorStandard.Size = new System.Drawing.Size(151, 26);
            this.rbColorStandard.TabIndex = 0;
            this.rbColorStandard.TabStop = true;
            this.rbColorStandard.Text = "Стандартная";
            this.rbColorStandard.UseVisualStyleBackColor = true;
            this.rbColorStandard.CheckedChanged += new System.EventHandler(this.rbColorStandard_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "A";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 38);
            this.button2.TabIndex = 16;
            this.button2.Text = "S";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 38);
            this.button3.TabIndex = 17;
            this.button3.Text = "T";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labTCreator
            // 
            this.labTCreator.AutoSize = true;
            this.labTCreator.Location = new System.Drawing.Point(47, 175);
            this.labTCreator.Name = "labTCreator";
            this.labTCreator.Size = new System.Drawing.Size(122, 22);
            this.labTCreator.TabIndex = 18;
            this.labTCreator.Text = "Тест создан";
            // 
            // labTeacherCreator
            // 
            this.labTeacherCreator.AutoSize = true;
            this.labTeacherCreator.Location = new System.Drawing.Point(186, 175);
            this.labTeacherCreator.Name = "labTeacherCreator";
            this.labTeacherCreator.Size = new System.Drawing.Size(0, 22);
            this.labTeacherCreator.TabIndex = 19;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(741, 488);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbDesignSelection);
            this.Controls.Add(this.butEntry);
            this.Controls.Add(this.rbS);
            this.Controls.Add(this.labEntry);
            this.Controls.Add(this.rbT);
            this.Controls.Add(this.panT);
            this.Controls.Add(this.panS);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panT.ResumeLayout(false);
            this.panT.PerformLayout();
            this.panS.ResumeLayout(false);
            this.panS.PerformLayout();
            this.gbDesignSelection.ResumeLayout(false);
            this.gbDesignSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbT;
        private System.Windows.Forms.Label labEntry;
        private System.Windows.Forms.RadioButton rbS;
        private System.Windows.Forms.Button butEntry;
        private System.Windows.Forms.Panel panT;
        private System.Windows.Forms.Panel panS;
        private System.Windows.Forms.Label labPasswordT;
        private System.Windows.Forms.Label labLoginT;
        private System.Windows.Forms.TextBox tbPasswordT;
        private System.Windows.Forms.TextBox tbLoginT;
        private System.Windows.Forms.Label labNumberGr;
        private System.Windows.Forms.Label labFIOS;

        private System.Windows.Forms.GroupBox gbDesignSelection;
        private System.Windows.Forms.RadioButton rbColorLight;
        private System.Windows.Forms.RadioButton rbColorDark;
        private System.Windows.Forms.RadioButton rbColorOrange;
        private System.Windows.Forms.RadioButton rbColorPink;
        private System.Windows.Forms.RadioButton rbColorGreen;
        private System.Windows.Forms.RadioButton rbColorRed;
        private System.Windows.Forms.RadioButton rbColorStandard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbNameS;
        private System.Windows.Forms.ComboBox cbGroupNumber;
        private System.Windows.Forms.ComboBox cbTest;
        private System.Windows.Forms.Label labTest;
        private System.Windows.Forms.Label labTeacherCreator;
        private System.Windows.Forms.Label labTCreator;
    }
}

