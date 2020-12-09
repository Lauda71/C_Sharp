namespace Testing
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTC = new System.Windows.Forms.TabControl();
            this.tpReg = new System.Windows.Forms.TabPage();
            this.butStudList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbStudentGrDel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butDelS = new System.Windows.Forms.Button();
            this.tbStudentDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panAddS = new System.Windows.Forms.Panel();
            this.tbStudGrId = new System.Windows.Forms.TextBox();
            this.tbStudName = new System.Windows.Forms.TextBox();
            this.labStudGrId = new System.Windows.Forms.Label();
            this.labStudName = new System.Windows.Forms.Label();
            this.panAddT = new System.Windows.Forms.Panel();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.tbPas = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.labEnterName = new System.Windows.Forms.Label();
            this.labEnterPass = new System.Windows.Forms.Label();
            this.labEnterLog = new System.Windows.Forms.Label();
            this.panDelT = new System.Windows.Forms.Panel();
            this.butDelT = new System.Windows.Forms.Button();
            this.tbDelLog = new System.Windows.Forms.TextBox();
            this.labLogDel = new System.Windows.Forms.Label();
            this.butCheckListTeachers = new System.Windows.Forms.Button();
            this.butChangeUser = new System.Windows.Forms.Button();
            this.butReg = new System.Windows.Forms.Button();
            this.tpTeachers = new System.Windows.Forms.TabPage();
            this.tbEditReturn = new System.Windows.Forms.TextBox();
            this.tbEditTryLim = new System.Windows.Forms.TextBox();
            this.tbEditTimeLim = new System.Windows.Forms.TextBox();
            this.tbEditComment = new System.Windows.Forms.TextBox();
            this.tbEditTopic = new System.Windows.Forms.TextBox();
            this.retLab = new System.Windows.Forms.Label();
            this.labRet = new System.Windows.Forms.Label();
            this.infLab = new System.Windows.Forms.Label();
            this.labInf = new System.Windows.Forms.Label();
            this.infLimTry = new System.Windows.Forms.Label();
            this.infLimTime = new System.Windows.Forms.Label();
            this.infAmountQ = new System.Windows.Forms.Label();
            this.infDate = new System.Windows.Forms.Label();
            this.infTopic = new System.Windows.Forms.Label();
            this.butEditFast = new System.Windows.Forms.Button();
            this.labLimit4Try = new System.Windows.Forms.Label();
            this.labTime4Test = new System.Windows.Forms.Label();
            this.labAmountQuestions = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labTopic = new System.Windows.Forms.Label();
            this.labTimeIn = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.butCreateTest = new System.Windows.Forms.Button();
            this.butChangeTeacher = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butDelTest = new System.Windows.Forms.Button();
            this.butOpenTest = new System.Windows.Forms.Button();
            this.butChangeTest = new System.Windows.Forms.Button();
            this.labUrTest = new System.Windows.Forms.Label();
            this.lbTestList = new System.Windows.Forms.ListBox();
            this.labHello = new System.Windows.Forms.Label();
            this.tpResults = new System.Windows.Forms.TabPage();
            this.butShowMeRes = new System.Windows.Forms.Button();
            this.mainDGV = new System.Windows.Forms.DataGridView();
            this.cbMark = new System.Windows.Forms.ComboBox();
            this.cbGroup = new System.Windows.Forms.ComboBox();
            this.cbNameTest = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerCurrentTimeInSystem = new System.Windows.Forms.Timer(this.components);
            this.statTableAdapter1 = new Testing.DB16TestDataSetTableAdapters.StatTableAdapter();
            this.mainTC.SuspendLayout();
            this.tpReg.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panAddS.SuspendLayout();
            this.panAddT.SuspendLayout();
            this.panDelT.SuspendLayout();
            this.tpTeachers.SuspendLayout();
            this.tpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTC
            // 
            this.mainTC.Controls.Add(this.tpReg);
            this.mainTC.Controls.Add(this.tpTeachers);
            this.mainTC.Controls.Add(this.tpResults);
            this.mainTC.Location = new System.Drawing.Point(0, 0);
            this.mainTC.Name = "mainTC";
            this.mainTC.SelectedIndex = 0;
            this.mainTC.Size = new System.Drawing.Size(1021, 487);
            this.mainTC.TabIndex = 0;
            // 
            // tpReg
            // 
            this.tpReg.Controls.Add(this.butStudList);
            this.tpReg.Controls.Add(this.panel1);
            this.tpReg.Controls.Add(this.panAddS);
            this.tpReg.Controls.Add(this.panAddT);
            this.tpReg.Controls.Add(this.panDelT);
            this.tpReg.Controls.Add(this.butCheckListTeachers);
            this.tpReg.Controls.Add(this.butChangeUser);
            this.tpReg.Controls.Add(this.butReg);
            this.tpReg.Location = new System.Drawing.Point(4, 31);
            this.tpReg.Name = "tpReg";
            this.tpReg.Padding = new System.Windows.Forms.Padding(3);
            this.tpReg.Size = new System.Drawing.Size(1013, 452);
            this.tpReg.TabIndex = 0;
            this.tpReg.Text = "Администрирование";
            this.tpReg.UseVisualStyleBackColor = true;
            // 
            // butStudList
            // 
            this.butStudList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butStudList.ForeColor = System.Drawing.Color.Black;
            this.butStudList.Location = new System.Drawing.Point(530, 324);
            this.butStudList.Name = "butStudList";
            this.butStudList.Size = new System.Drawing.Size(354, 44);
            this.butStudList.TabIndex = 23;
            this.butStudList.Text = "Список студентов";
            this.butStudList.UseVisualStyleBackColor = true;
            this.butStudList.Click += new System.EventHandler(this.butStudList_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.tbStudentGrDel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.butDelS);
            this.panel1.Controls.Add(this.tbStudentDel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(530, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 164);
            this.panel1.TabIndex = 17;
            // 
            // tbStudentGrDel
            // 
            this.tbStudentGrDel.Location = new System.Drawing.Point(132, 65);
            this.tbStudentGrDel.Name = "tbStudentGrDel";
            this.tbStudentGrDel.Size = new System.Drawing.Size(207, 31);
            this.tbStudentGrDel.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID гр.";
            // 
            // butDelS
            // 
            this.butDelS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDelS.ForeColor = System.Drawing.Color.Maroon;
            this.butDelS.Location = new System.Drawing.Point(10, 112);
            this.butDelS.Name = "butDelS";
            this.butDelS.Size = new System.Drawing.Size(329, 44);
            this.butDelS.TabIndex = 13;
            this.butDelS.Text = "Удалить студента";
            this.butDelS.UseVisualStyleBackColor = true;
            this.butDelS.Click += new System.EventHandler(this.butDelS_Click);
            // 
            // tbStudentDel
            // 
            this.tbStudentDel.Location = new System.Drawing.Point(132, 13);
            this.tbStudentDel.Name = "tbStudentDel";
            this.tbStudentDel.Size = new System.Drawing.Size(207, 31);
            this.tbStudentDel.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // panAddS
            // 
            this.panAddS.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panAddS.Controls.Add(this.tbStudGrId);
            this.panAddS.Controls.Add(this.tbStudName);
            this.panAddS.Controls.Add(this.labStudGrId);
            this.panAddS.Controls.Add(this.labStudName);
            this.panAddS.Location = new System.Drawing.Point(61, 10);
            this.panAddS.Name = "panAddS";
            this.panAddS.Size = new System.Drawing.Size(396, 107);
            this.panAddS.TabIndex = 22;
            // 
            // tbStudGrId
            // 
            this.tbStudGrId.Location = new System.Drawing.Point(180, 65);
            this.tbStudGrId.Name = "tbStudGrId";
            this.tbStudGrId.Size = new System.Drawing.Size(207, 31);
            this.tbStudGrId.TabIndex = 20;
            this.tbStudGrId.TextChanged += new System.EventHandler(this.tbStudName_TextChanged);
            // 
            // tbStudName
            // 
            this.tbStudName.Location = new System.Drawing.Point(180, 11);
            this.tbStudName.Name = "tbStudName";
            this.tbStudName.Size = new System.Drawing.Size(207, 31);
            this.tbStudName.TabIndex = 19;
            this.tbStudName.TextChanged += new System.EventHandler(this.tbStudName_TextChanged);
            // 
            // labStudGrId
            // 
            this.labStudGrId.AutoSize = true;
            this.labStudGrId.Location = new System.Drawing.Point(16, 74);
            this.labStudGrId.Name = "labStudGrId";
            this.labStudGrId.Size = new System.Drawing.Size(139, 22);
            this.labStudGrId.TabIndex = 18;
            this.labStudGrId.Text = "Введите ID гр.";
            // 
            // labStudName
            // 
            this.labStudName.AutoSize = true;
            this.labStudName.Location = new System.Drawing.Point(27, 20);
            this.labStudName.Name = "labStudName";
            this.labStudName.Size = new System.Drawing.Size(129, 22);
            this.labStudName.TabIndex = 17;
            this.labStudName.Text = "Введите Имя";
            // 
            // panAddT
            // 
            this.panAddT.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panAddT.Controls.Add(this.tbFIO);
            this.panAddT.Controls.Add(this.tbPas);
            this.panAddT.Controls.Add(this.tbLog);
            this.panAddT.Controls.Add(this.labEnterName);
            this.panAddT.Controls.Add(this.labEnterPass);
            this.panAddT.Controls.Add(this.labEnterLog);
            this.panAddT.Location = new System.Drawing.Point(61, 141);
            this.panAddT.Name = "panAddT";
            this.panAddT.Size = new System.Drawing.Size(397, 159);
            this.panAddT.TabIndex = 21;
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(180, 117);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(207, 31);
            this.tbFIO.TabIndex = 5;
            this.tbFIO.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            // 
            // tbPas
            // 
            this.tbPas.Location = new System.Drawing.Point(180, 63);
            this.tbPas.Name = "tbPas";
            this.tbPas.Size = new System.Drawing.Size(207, 31);
            this.tbPas.TabIndex = 4;
            this.tbPas.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            this.tbPas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPas_KeyPress);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(180, 9);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(207, 31);
            this.tbLog.TabIndex = 3;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLog_TextChanged);
            // 
            // labEnterName
            // 
            this.labEnterName.AutoSize = true;
            this.labEnterName.Location = new System.Drawing.Point(16, 126);
            this.labEnterName.Name = "labEnterName";
            this.labEnterName.Size = new System.Drawing.Size(153, 22);
            this.labEnterName.TabIndex = 2;
            this.labEnterName.Text = "Введите Ф И.О.";
            // 
            // labEnterPass
            // 
            this.labEnterPass.AutoSize = true;
            this.labEnterPass.Location = new System.Drawing.Point(11, 72);
            this.labEnterPass.Name = "labEnterPass";
            this.labEnterPass.Size = new System.Drawing.Size(158, 22);
            this.labEnterPass.TabIndex = 1;
            this.labEnterPass.Text = "Введите пароль";
            // 
            // labEnterLog
            // 
            this.labEnterLog.AutoSize = true;
            this.labEnterLog.Location = new System.Drawing.Point(27, 18);
            this.labEnterLog.Name = "labEnterLog";
            this.labEnterLog.Size = new System.Drawing.Size(142, 22);
            this.labEnterLog.TabIndex = 0;
            this.labEnterLog.Text = "Введите логин";
            // 
            // panDelT
            // 
            this.panDelT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panDelT.Controls.Add(this.butDelT);
            this.panDelT.Controls.Add(this.tbDelLog);
            this.panDelT.Controls.Add(this.labLogDel);
            this.panDelT.Location = new System.Drawing.Point(530, 188);
            this.panDelT.Name = "panDelT";
            this.panDelT.Size = new System.Drawing.Size(354, 112);
            this.panDelT.TabIndex = 16;
            // 
            // butDelT
            // 
            this.butDelT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDelT.ForeColor = System.Drawing.Color.Maroon;
            this.butDelT.Location = new System.Drawing.Point(10, 58);
            this.butDelT.Name = "butDelT";
            this.butDelT.Size = new System.Drawing.Size(329, 44);
            this.butDelT.TabIndex = 13;
            this.butDelT.Text = "Удалить преподавателя";
            this.butDelT.UseVisualStyleBackColor = true;
            this.butDelT.Click += new System.EventHandler(this.butDel_Click);
            // 
            // tbDelLog
            // 
            this.tbDelLog.Location = new System.Drawing.Point(132, 13);
            this.tbDelLog.Name = "tbDelLog";
            this.tbDelLog.Size = new System.Drawing.Size(207, 31);
            this.tbDelLog.TabIndex = 10;
            // 
            // labLogDel
            // 
            this.labLogDel.AutoSize = true;
            this.labLogDel.Location = new System.Drawing.Point(44, 22);
            this.labLogDel.Name = "labLogDel";
            this.labLogDel.Size = new System.Drawing.Size(70, 22);
            this.labLogDel.TabIndex = 7;
            this.labLogDel.Text = "Логин:";
            // 
            // butCheckListTeachers
            // 
            this.butCheckListTeachers.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCheckListTeachers.ForeColor = System.Drawing.Color.Black;
            this.butCheckListTeachers.Location = new System.Drawing.Point(530, 389);
            this.butCheckListTeachers.Name = "butCheckListTeachers";
            this.butCheckListTeachers.Size = new System.Drawing.Size(354, 44);
            this.butCheckListTeachers.TabIndex = 15;
            this.butCheckListTeachers.Text = "Список преподавателей";
            this.butCheckListTeachers.UseVisualStyleBackColor = true;
            this.butCheckListTeachers.Click += new System.EventHandler(this.butCheckListTeachers_Click);
            // 
            // butChangeUser
            // 
            this.butChangeUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butChangeUser.ForeColor = System.Drawing.Color.Black;
            this.butChangeUser.Location = new System.Drawing.Point(61, 389);
            this.butChangeUser.Name = "butChangeUser";
            this.butChangeUser.Size = new System.Drawing.Size(396, 44);
            this.butChangeUser.TabIndex = 14;
            this.butChangeUser.Text = "Сменить пользователя";
            this.butChangeUser.UseVisualStyleBackColor = true;
            this.butChangeUser.Click += new System.EventHandler(this.butChangeUser_Click);
            // 
            // butReg
            // 
            this.butReg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butReg.ForeColor = System.Drawing.Color.Black;
            this.butReg.Location = new System.Drawing.Point(61, 324);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(396, 44);
            this.butReg.TabIndex = 6;
            this.butReg.Text = "Добавить";
            this.butReg.UseVisualStyleBackColor = true;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // tpTeachers
            // 
            this.tpTeachers.Controls.Add(this.tbEditReturn);
            this.tpTeachers.Controls.Add(this.tbEditTryLim);
            this.tpTeachers.Controls.Add(this.tbEditTimeLim);
            this.tpTeachers.Controls.Add(this.tbEditComment);
            this.tpTeachers.Controls.Add(this.tbEditTopic);
            this.tpTeachers.Controls.Add(this.retLab);
            this.tpTeachers.Controls.Add(this.labRet);
            this.tpTeachers.Controls.Add(this.infLab);
            this.tpTeachers.Controls.Add(this.labInf);
            this.tpTeachers.Controls.Add(this.infLimTry);
            this.tpTeachers.Controls.Add(this.infLimTime);
            this.tpTeachers.Controls.Add(this.infAmountQ);
            this.tpTeachers.Controls.Add(this.infDate);
            this.tpTeachers.Controls.Add(this.infTopic);
            this.tpTeachers.Controls.Add(this.butEditFast);
            this.tpTeachers.Controls.Add(this.labLimit4Try);
            this.tpTeachers.Controls.Add(this.labTime4Test);
            this.tpTeachers.Controls.Add(this.labAmountQuestions);
            this.tpTeachers.Controls.Add(this.labDate);
            this.tpTeachers.Controls.Add(this.labTopic);
            this.tpTeachers.Controls.Add(this.labTimeIn);
            this.tpTeachers.Controls.Add(this.labelCurrentTime);
            this.tpTeachers.Controls.Add(this.butCreateTest);
            this.tpTeachers.Controls.Add(this.butChangeTeacher);
            this.tpTeachers.Controls.Add(this.butExit);
            this.tpTeachers.Controls.Add(this.butDelTest);
            this.tpTeachers.Controls.Add(this.butOpenTest);
            this.tpTeachers.Controls.Add(this.butChangeTest);
            this.tpTeachers.Controls.Add(this.labUrTest);
            this.tpTeachers.Controls.Add(this.lbTestList);
            this.tpTeachers.Controls.Add(this.labHello);
            this.tpTeachers.Location = new System.Drawing.Point(4, 31);
            this.tpTeachers.Name = "tpTeachers";
            this.tpTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tpTeachers.Size = new System.Drawing.Size(1013, 452);
            this.tpTeachers.TabIndex = 1;
            this.tpTeachers.Text = "Главное";
            this.tpTeachers.UseVisualStyleBackColor = true;
            // 
            // tbEditReturn
            // 
            this.tbEditReturn.Location = new System.Drawing.Point(670, 333);
            this.tbEditReturn.Name = "tbEditReturn";
            this.tbEditReturn.Size = new System.Drawing.Size(321, 31);
            this.tbEditReturn.TabIndex = 31;
            this.tbEditReturn.Visible = false;
            // 
            // tbEditTryLim
            // 
            this.tbEditTryLim.Location = new System.Drawing.Point(670, 292);
            this.tbEditTryLim.Name = "tbEditTryLim";
            this.tbEditTryLim.Size = new System.Drawing.Size(321, 31);
            this.tbEditTryLim.TabIndex = 30;
            this.tbEditTryLim.Visible = false;
            this.tbEditTryLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEditTryLim_KeyPress);
            // 
            // tbEditTimeLim
            // 
            this.tbEditTimeLim.Location = new System.Drawing.Point(670, 250);
            this.tbEditTimeLim.Name = "tbEditTimeLim";
            this.tbEditTimeLim.Size = new System.Drawing.Size(321, 31);
            this.tbEditTimeLim.TabIndex = 29;
            this.tbEditTimeLim.Visible = false;
            this.tbEditTimeLim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEditTimeLim_KeyPress);
            // 
            // tbEditComment
            // 
            this.tbEditComment.Location = new System.Drawing.Point(670, 167);
            this.tbEditComment.Name = "tbEditComment";
            this.tbEditComment.Size = new System.Drawing.Size(321, 31);
            this.tbEditComment.TabIndex = 28;
            this.tbEditComment.Visible = false;
            // 
            // tbEditTopic
            // 
            this.tbEditTopic.Location = new System.Drawing.Point(670, 81);
            this.tbEditTopic.Name = "tbEditTopic";
            this.tbEditTopic.Size = new System.Drawing.Size(321, 31);
            this.tbEditTopic.TabIndex = 27;
            this.tbEditTopic.Visible = false;
            // 
            // retLab
            // 
            this.retLab.AutoSize = true;
            this.retLab.Enabled = false;
            this.retLab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.retLab.Location = new System.Drawing.Point(666, 336);
            this.retLab.Name = "retLab";
            this.retLab.Size = new System.Drawing.Size(56, 22);
            this.retLab.TabIndex = 26;
            this.retLab.Text = "label";
            // 
            // labRet
            // 
            this.labRet.AutoSize = true;
            this.labRet.Enabled = false;
            this.labRet.Location = new System.Drawing.Point(347, 336);
            this.labRet.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labRet.Name = "labRet";
            this.labRet.Size = new System.Drawing.Size(310, 22);
            this.labRet.TabIndex = 25;
            this.labRet.Text = "Лимит по возврату к вопросам:";
            // 
            // infLab
            // 
            this.infLab.AutoSize = true;
            this.infLab.Enabled = false;
            this.infLab.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infLab.Location = new System.Drawing.Point(666, 170);
            this.infLab.Name = "infLab";
            this.infLab.Size = new System.Drawing.Size(56, 22);
            this.infLab.TabIndex = 24;
            this.infLab.Text = "label";
            // 
            // labInf
            // 
            this.labInf.AutoSize = true;
            this.labInf.Enabled = false;
            this.labInf.Location = new System.Drawing.Point(505, 170);
            this.labInf.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labInf.Name = "labInf";
            this.labInf.Size = new System.Drawing.Size(152, 22);
            this.labInf.TabIndex = 23;
            this.labInf.Text = "Комментарий:";
            // 
            // infLimTry
            // 
            this.infLimTry.AutoSize = true;
            this.infLimTry.Enabled = false;
            this.infLimTry.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infLimTry.Location = new System.Drawing.Point(666, 295);
            this.infLimTry.Name = "infLimTry";
            this.infLimTry.Size = new System.Drawing.Size(56, 22);
            this.infLimTry.TabIndex = 22;
            this.infLimTry.Text = "label";
            // 
            // infLimTime
            // 
            this.infLimTime.AutoSize = true;
            this.infLimTime.Enabled = false;
            this.infLimTime.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infLimTime.Location = new System.Drawing.Point(666, 253);
            this.infLimTime.Name = "infLimTime";
            this.infLimTime.Size = new System.Drawing.Size(56, 22);
            this.infLimTime.TabIndex = 21;
            this.infLimTime.Text = "label";
            // 
            // infAmountQ
            // 
            this.infAmountQ.AutoSize = true;
            this.infAmountQ.Enabled = false;
            this.infAmountQ.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infAmountQ.Location = new System.Drawing.Point(666, 211);
            this.infAmountQ.Name = "infAmountQ";
            this.infAmountQ.Size = new System.Drawing.Size(56, 22);
            this.infAmountQ.TabIndex = 20;
            this.infAmountQ.Text = "label";
            // 
            // infDate
            // 
            this.infDate.AutoSize = true;
            this.infDate.Enabled = false;
            this.infDate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infDate.Location = new System.Drawing.Point(666, 126);
            this.infDate.Name = "infDate";
            this.infDate.Size = new System.Drawing.Size(56, 22);
            this.infDate.TabIndex = 19;
            this.infDate.Text = "label";
            // 
            // infTopic
            // 
            this.infTopic.AutoSize = true;
            this.infTopic.Enabled = false;
            this.infTopic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infTopic.Location = new System.Drawing.Point(666, 84);
            this.infTopic.Name = "infTopic";
            this.infTopic.Size = new System.Drawing.Size(56, 22);
            this.infTopic.TabIndex = 18;
            this.infTopic.Text = "label";
            // 
            // butEditFast
            // 
            this.butEditFast.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butEditFast.ForeColor = System.Drawing.Color.Black;
            this.butEditFast.Location = new System.Drawing.Point(670, 399);
            this.butEditFast.Name = "butEditFast";
            this.butEditFast.Size = new System.Drawing.Size(321, 42);
            this.butEditFast.TabIndex = 17;
            this.butEditFast.Text = "Редактировать";
            this.butEditFast.UseVisualStyleBackColor = true;
            this.butEditFast.Click += new System.EventHandler(this.butEditFast_Click);
            // 
            // labLimit4Try
            // 
            this.labLimit4Try.AutoSize = true;
            this.labLimit4Try.Enabled = false;
            this.labLimit4Try.Location = new System.Drawing.Point(457, 295);
            this.labLimit4Try.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labLimit4Try.Name = "labLimit4Try";
            this.labLimit4Try.Size = new System.Drawing.Size(203, 22);
            this.labLimit4Try.TabIndex = 16;
            this.labLimit4Try.Text = "Лимит по попыткам:";
            // 
            // labTime4Test
            // 
            this.labTime4Test.AutoSize = true;
            this.labTime4Test.Enabled = false;
            this.labTime4Test.Location = new System.Drawing.Point(465, 253);
            this.labTime4Test.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labTime4Test.Name = "labTime4Test";
            this.labTime4Test.Size = new System.Drawing.Size(195, 22);
            this.labTime4Test.TabIndex = 15;
            this.labTime4Test.Text = "Лимит по времени:";
            // 
            // labAmountQuestions
            // 
            this.labAmountQuestions.AutoSize = true;
            this.labAmountQuestions.Enabled = false;
            this.labAmountQuestions.Location = new System.Drawing.Point(444, 211);
            this.labAmountQuestions.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labAmountQuestions.Name = "labAmountQuestions";
            this.labAmountQuestions.Size = new System.Drawing.Size(216, 22);
            this.labAmountQuestions.TabIndex = 14;
            this.labAmountQuestions.Text = "Количество вопросов:";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Enabled = false;
            this.labDate.Location = new System.Drawing.Point(505, 126);
            this.labDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(155, 22);
            this.labDate.TabIndex = 13;
            this.labDate.Text = "Дата создания:";
            // 
            // labTopic
            // 
            this.labTopic.AutoSize = true;
            this.labTopic.Enabled = false;
            this.labTopic.Location = new System.Drawing.Point(592, 84);
            this.labTopic.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labTopic.Name = "labTopic";
            this.labTopic.Size = new System.Drawing.Size(65, 22);
            this.labTopic.TabIndex = 12;
            this.labTopic.Text = "Тема:";
            // 
            // labTimeIn
            // 
            this.labTimeIn.AutoSize = true;
            this.labTimeIn.Location = new System.Drawing.Point(636, 13);
            this.labTimeIn.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labTimeIn.Name = "labTimeIn";
            this.labTimeIn.Size = new System.Drawing.Size(179, 22);
            this.labTimeIn.TabIndex = 11;
            this.labTimeIn.Text = "Время в системе:";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(821, 13);
            this.labelCurrentTime.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(86, 22);
            this.labelCurrentTime.TabIndex = 10;
            this.labelCurrentTime.Text = "00:00:00";
            // 
            // butCreateTest
            // 
            this.butCreateTest.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butCreateTest.ForeColor = System.Drawing.Color.Black;
            this.butCreateTest.Location = new System.Drawing.Point(241, 84);
            this.butCreateTest.Name = "butCreateTest";
            this.butCreateTest.Size = new System.Drawing.Size(173, 42);
            this.butCreateTest.TabIndex = 9;
            this.butCreateTest.Text = "Новый тест";
            this.butCreateTest.UseVisualStyleBackColor = true;
            this.butCreateTest.Click += new System.EventHandler(this.butCreateTest_Click);
            // 
            // butChangeTeacher
            // 
            this.butChangeTeacher.ForeColor = System.Drawing.Color.Black;
            this.butChangeTeacher.Location = new System.Drawing.Point(241, 398);
            this.butChangeTeacher.Name = "butChangeTeacher";
            this.butChangeTeacher.Size = new System.Drawing.Size(249, 42);
            this.butChangeTeacher.TabIndex = 7;
            this.butChangeTeacher.Text = "Сменить пользоваться";
            this.butChangeTeacher.UseVisualStyleBackColor = true;
            this.butChangeTeacher.Click += new System.EventHandler(this.butChangeTeacher_Click);
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butExit.ForeColor = System.Drawing.Color.Red;
            this.butExit.Location = new System.Drawing.Point(506, 398);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(151, 42);
            this.butExit.TabIndex = 6;
            this.butExit.Text = "Выйти";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // butDelTest
            // 
            this.butDelTest.Enabled = false;
            this.butDelTest.ForeColor = System.Drawing.Color.Red;
            this.butDelTest.Location = new System.Drawing.Point(241, 266);
            this.butDelTest.Name = "butDelTest";
            this.butDelTest.Size = new System.Drawing.Size(173, 42);
            this.butDelTest.TabIndex = 5;
            this.butDelTest.Text = "Удалить";
            this.butDelTest.UseVisualStyleBackColor = true;
            this.butDelTest.Click += new System.EventHandler(this.butDelTest_Click);
            // 
            // butOpenTest
            // 
            this.butOpenTest.Enabled = false;
            this.butOpenTest.ForeColor = System.Drawing.Color.Black;
            this.butOpenTest.Location = new System.Drawing.Point(241, 170);
            this.butOpenTest.Name = "butOpenTest";
            this.butOpenTest.Size = new System.Drawing.Size(173, 42);
            this.butOpenTest.TabIndex = 4;
            this.butOpenTest.Text = "Запустить";
            this.butOpenTest.UseVisualStyleBackColor = true;
            // 
            // butChangeTest
            // 
            this.butChangeTest.Enabled = false;
            this.butChangeTest.ForeColor = System.Drawing.Color.Black;
            this.butChangeTest.Location = new System.Drawing.Point(241, 218);
            this.butChangeTest.Name = "butChangeTest";
            this.butChangeTest.Size = new System.Drawing.Size(173, 42);
            this.butChangeTest.TabIndex = 3;
            this.butChangeTest.Text = "Изменить";
            this.butChangeTest.UseVisualStyleBackColor = true;
            this.butChangeTest.Click += new System.EventHandler(this.butChangeTest_Click);
            // 
            // labUrTest
            // 
            this.labUrTest.AutoSize = true;
            this.labUrTest.Location = new System.Drawing.Point(9, 54);
            this.labUrTest.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labUrTest.Name = "labUrTest";
            this.labUrTest.Size = new System.Drawing.Size(217, 22);
            this.labUrTest.TabIndex = 2;
            this.labUrTest.Text = "Список ваших тестов:";
            // 
            // lbTestList
            // 
            this.lbTestList.FormattingEnabled = true;
            this.lbTestList.HorizontalScrollbar = true;
            this.lbTestList.ItemHeight = 22;
            this.lbTestList.Location = new System.Drawing.Point(10, 84);
            this.lbTestList.Name = "lbTestList";
            this.lbTestList.Size = new System.Drawing.Size(216, 356);
            this.lbTestList.TabIndex = 1;
            this.lbTestList.SelectedIndexChanged += new System.EventHandler(this.lbTestList_SelectedIndexChanged);
            // 
            // labHello
            // 
            this.labHello.AutoSize = true;
            this.labHello.Location = new System.Drawing.Point(6, 13);
            this.labHello.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labHello.Name = "labHello";
            this.labHello.Size = new System.Drawing.Size(148, 22);
            this.labHello.TabIndex = 0;
            this.labHello.Text = "Здравствуйте, ";
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.butShowMeRes);
            this.tpResults.Controls.Add(this.mainDGV);
            this.tpResults.Controls.Add(this.cbMark);
            this.tpResults.Controls.Add(this.cbGroup);
            this.tpResults.Controls.Add(this.cbNameTest);
            this.tpResults.Location = new System.Drawing.Point(4, 31);
            this.tpResults.Name = "tpResults";
            this.tpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tpResults.Size = new System.Drawing.Size(1013, 452);
            this.tpResults.TabIndex = 2;
            this.tpResults.Text = "Результаты";
            this.tpResults.UseVisualStyleBackColor = true;
            // 
            // butShowMeRes
            // 
            this.butShowMeRes.Location = new System.Drawing.Point(676, 26);
            this.butShowMeRes.Name = "butShowMeRes";
            this.butShowMeRes.Size = new System.Drawing.Size(235, 40);
            this.butShowMeRes.TabIndex = 4;
            this.butShowMeRes.Text = "Показать результаты";
            this.butShowMeRes.UseVisualStyleBackColor = true;
            this.butShowMeRes.Click += new System.EventHandler(this.butShowMeRes_Click);
            // 
            // mainDGV
            // 
            this.mainDGV.AllowUserToAddRows = false;
            this.mainDGV.AllowUserToDeleteRows = false;
            this.mainDGV.AllowUserToOrderColumns = true;
            this.mainDGV.AllowUserToResizeColumns = false;
            this.mainDGV.AllowUserToResizeRows = false;
            this.mainDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainDGV.Location = new System.Drawing.Point(23, 87);
            this.mainDGV.Name = "mainDGV";
            this.mainDGV.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.mainDGV.RowHeadersVisible = false;
            this.mainDGV.Size = new System.Drawing.Size(968, 343);
            this.mainDGV.TabIndex = 3;
            // 
            // cbMark
            // 
            this.cbMark.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMark.FormattingEnabled = true;
            this.cbMark.Location = new System.Drawing.Point(423, 32);
            this.cbMark.Name = "cbMark";
            this.cbMark.Size = new System.Drawing.Size(149, 30);
            this.cbMark.TabIndex = 2;
            // 
            // cbGroup
            // 
            this.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroup.FormattingEnabled = true;
            this.cbGroup.Location = new System.Drawing.Point(238, 32);
            this.cbGroup.Name = "cbGroup";
            this.cbGroup.Size = new System.Drawing.Size(179, 30);
            this.cbGroup.TabIndex = 1;
            // 
            // cbNameTest
            // 
            this.cbNameTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameTest.FormattingEnabled = true;
            this.cbNameTest.Location = new System.Drawing.Point(23, 32);
            this.cbNameTest.Name = "cbNameTest";
            this.cbNameTest.Size = new System.Drawing.Size(209, 30);
            this.cbNameTest.TabIndex = 0;
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "Teachers";
            // 
            // timerCurrentTimeInSystem
            // 
            this.timerCurrentTimeInSystem.Tick += new System.EventHandler(this.timerCurrentTimeInSystem_Tick);
            // 
            // statTableAdapter1
            // 
            this.statTableAdapter1.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1018, 486);
            this.Controls.Add(this.mainTC);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTC.ResumeLayout(false);
            this.tpReg.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panAddS.ResumeLayout(false);
            this.panAddS.PerformLayout();
            this.panAddT.ResumeLayout(false);
            this.panAddT.PerformLayout();
            this.panDelT.ResumeLayout(false);
            this.panDelT.PerformLayout();
            this.tpTeachers.ResumeLayout(false);
            this.tpTeachers.PerformLayout();
            this.tpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTC;
        private System.Windows.Forms.TabPage tpReg;
        private System.Windows.Forms.Label labEnterLog;
        private System.Windows.Forms.TabPage tpTeachers;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.TextBox tbPas;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Label labEnterName;
        private System.Windows.Forms.Label labEnterPass;
        private System.Windows.Forms.Button butDelT;
        private System.Windows.Forms.TextBox tbDelLog;
        private System.Windows.Forms.Label labLogDel;
        private System.Windows.Forms.Button butChangeUser;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private System.Windows.Forms.Button butCheckListTeachers;
        private System.Windows.Forms.Label labHello;
        private System.Windows.Forms.Button butDelTest;
        private System.Windows.Forms.Button butOpenTest;
        private System.Windows.Forms.Button butChangeTest;
        private System.Windows.Forms.Label labUrTest;
        private System.Windows.Forms.ListBox lbTestList;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Button butCreateTest;
        private System.Windows.Forms.Button butChangeTeacher;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Label labTimeIn;
        private System.Windows.Forms.Timer timerCurrentTimeInSystem;
        private System.Windows.Forms.Button butEditFast;
        private System.Windows.Forms.Label labLimit4Try;
        private System.Windows.Forms.Label labTime4Test;
        private System.Windows.Forms.Label labAmountQuestions;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labTopic;
        private System.Windows.Forms.Label infTopic;
        private System.Windows.Forms.Label infLab;
        private System.Windows.Forms.Label labInf;
        private System.Windows.Forms.Label infLimTry;
        private System.Windows.Forms.Label infLimTime;
        private System.Windows.Forms.Label infAmountQ;
        private System.Windows.Forms.Label infDate;
        private System.Windows.Forms.TabPage tpResults;
        private System.Windows.Forms.Label retLab;
        private System.Windows.Forms.Label labRet;
        private System.Windows.Forms.TextBox tbEditReturn;
        private System.Windows.Forms.TextBox tbEditTryLim;
        private System.Windows.Forms.TextBox tbEditTimeLim;
        private System.Windows.Forms.TextBox tbEditComment;
        private System.Windows.Forms.TextBox tbEditTopic;
        private System.Windows.Forms.ComboBox cbGroup;
        private System.Windows.Forms.ComboBox cbNameTest;
        private System.Windows.Forms.ComboBox cbMark;
        private System.Windows.Forms.DataGridView mainDGV;
        private System.Windows.Forms.Button butShowMeRes;
        private DB16TestDataSetTableAdapters.StatTableAdapter statTableAdapter1;
        private System.Windows.Forms.Panel panDelT;
        private System.Windows.Forms.TextBox tbStudGrId;
        private System.Windows.Forms.TextBox tbStudName;
        private System.Windows.Forms.Label labStudGrId;
        private System.Windows.Forms.Label labStudName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butDelS;
        private System.Windows.Forms.TextBox tbStudentDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panAddS;
        private System.Windows.Forms.Panel panAddT;
        private System.Windows.Forms.TextBox tbStudentGrDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butStudList;
    }
}