namespace osaGO
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
            this.lb_Tb = new System.Windows.Forms.ListBox();
            this.lb_Kt = new System.Windows.Forms.ListBox();
            this.lb_Ko = new System.Windows.Forms.ListBox();
            this.lb_Kvc = new System.Windows.Forms.ListBox();
            this.lb_Km = new System.Windows.Forms.ListBox();
            this.lb_Kbm = new System.Windows.Forms.ListBox();
            this.lab_inf1 = new System.Windows.Forms.Label();
            this.lab_inf2 = new System.Windows.Forms.Label();
            this.lab_inf3 = new System.Windows.Forms.Label();
            this.lab_inf4 = new System.Windows.Forms.Label();
            this.lab_inf5 = new System.Windows.Forms.Label();
            this.lab_inf6 = new System.Windows.Forms.Label();
            this.lab_k_1 = new System.Windows.Forms.Label();
            this.lab_k_2 = new System.Windows.Forms.Label();
            this.lab_k_3 = new System.Windows.Forms.Label();
            this.lab_k_4 = new System.Windows.Forms.Label();
            this.lab_k_5 = new System.Windows.Forms.Label();
            this.lab_k_6 = new System.Windows.Forms.Label();
            this.tb_inf = new System.Windows.Forms.TextBox();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.but_GO = new System.Windows.Forms.Button();
            this.lab_tot = new System.Windows.Forms.Label();
            this.lab_total_cost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Tb
            // 
            this.lb_Tb.FormattingEnabled = true;
            this.lb_Tb.Items.AddRange(new object[] {
            "( А кат.)            1215            Мотоциклы, мотороллеры",
            "( В кат.)            1980            Легковые авто физ. лиц, ИП",
            "( В кат.)            2375            Легковые авто юр. лиц",
            "( В кат.)            2965            Легковые авто такси",
            "( С кат.)            2025            Грузовое авто с разреш. макс. массой 16 тонн" +
                " и менее",
            "( С кат.)            3240            Грузовое авто с разреш. макс. массой более 1" +
                "6 тонн",
            "( С кат.)            810              Прицепы к грузовым авто, полуприцепы, прице" +
                "пы-роспуски",
            "( D кат.)            1620            Автобус с числом пассажирских мест до 20 вкл" +
                ".",
            "( D кат.)            2025            Автобус с числом пассажирских мест более 20",
            "( D кат.)            2965            Автобусы, используемые в качестве такис",
            "( D кат.)            1620            Троллейбусы",
            "( D кат.)            1010            Трамваи",
            "( D кат.)            1215            Тракторы, самоходные дорожно-транспортные и " +
                "иные машины",
            "( D кат.)            305              Прицепы к тракторам, самоходным дорожно-тра" +
                "нспортным и иным машинам"});
            this.lb_Tb.Location = new System.Drawing.Point(50, 24);
            this.lb_Tb.Name = "lb_Tb";
            this.lb_Tb.Size = new System.Drawing.Size(588, 186);
            this.lb_Tb.TabIndex = 0;
            this.lb_Tb.SelectedIndexChanged += new System.EventHandler(this.lb_Tb_SelectedIndexChanged);
            // 
            // lb_Kt
            // 
            this.lb_Kt.FormattingEnabled = true;
            this.lb_Kt.Items.AddRange(new object[] {
            "1,8         1,0         Архангельск ",
            "1,3         0,8         Белгород",
            "1,6         1,0         Владимир",
            "1,8         1,0         Санкт-Петербург",
            "2,0         1,2         Москва"});
            this.lb_Kt.Location = new System.Drawing.Point(50, 252);
            this.lb_Kt.Name = "lb_Kt";
            this.lb_Kt.Size = new System.Drawing.Size(264, 69);
            this.lb_Kt.TabIndex = 1;
            this.lb_Kt.SelectedIndexChanged += new System.EventHandler(this.lb_Kt_SelectedIndexChanged);
            // 
            // lb_Ko
            // 
            this.lb_Ko.FormattingEnabled = true;
            this.lb_Ko.Items.AddRange(new object[] {
            "Строго определен",
            "Неограниченно по количеству"});
            this.lb_Ko.Location = new System.Drawing.Point(50, 370);
            this.lb_Ko.Name = "lb_Ko";
            this.lb_Ko.Size = new System.Drawing.Size(264, 30);
            this.lb_Ko.TabIndex = 2;
            this.lb_Ko.SelectedIndexChanged += new System.EventHandler(this.lb_Ko_SelectedIndexChanged);
            // 
            // lb_Kvc
            // 
            this.lb_Kvc.FormattingEnabled = true;
            this.lb_Kvc.Items.AddRange(new object[] {
            "1,8    до 22 лет вкл.         до 3 лет вкл.",
            "1,6    до 22 лет вкл.         свыше 3 лет",
            "1,7    старше 22 лет        до 3 лет вкл.",
            "1,0    старше 22 лет        свыше 3 лет"});
            this.lb_Kvc.Location = new System.Drawing.Point(50, 447);
            this.lb_Kvc.Name = "lb_Kvc";
            this.lb_Kvc.Size = new System.Drawing.Size(264, 56);
            this.lb_Kvc.TabIndex = 3;
            this.lb_Kvc.SelectedIndexChanged += new System.EventHandler(this.lb_Kvc_SelectedIndexChanged);
            // 
            // lb_Km
            // 
            this.lb_Km.FormattingEnabled = true;
            this.lb_Km.Items.AddRange(new object[] {
            "0,6    до 50 л.с. вкл.",
            "1,0    от 51 до 70 л.с. вкл.",
            "1,1    от 71 до 100 л.с. вкл.",
            "1,2    от 101 до 120 л.с. вкл.",
            "1,4    от 121 до 150 л.с. вкл.",
            "1,6    от 151 л.с."});
            this.lb_Km.Location = new System.Drawing.Point(50, 541);
            this.lb_Km.Name = "lb_Km";
            this.lb_Km.Size = new System.Drawing.Size(264, 82);
            this.lb_Km.TabIndex = 4;
            this.lb_Km.SelectedIndexChanged += new System.EventHandler(this.lb_Km_SelectedIndexChanged);
            // 
            // lb_Kbm
            // 
            this.lb_Kbm.FormattingEnabled = true;
            this.lb_Kbm.Items.AddRange(new object[] {
            "М               0     М      М      М        М     2,45",
            "0                1     М      М      М        М     2,30",
            "1                2     М      М      М        М     1,55",
            "2                3      1      М      М        М     1,40",
            "3                4      1      М      М        М     1,00",
            "4                5       2      1      М        М     0,95",
            "5                6       3      1      М        М     0,90",
            "6                7       4      2      М        М     0,85",
            "7                8       4      2      М        М     0,80",
            "8                9       5      2      М        М     0,75",
            "9                10     5      2       1        М     0,70",
            "10              11     6      3       1        М     0,65",
            "11              12     6      3       1        М     0,6",
            "12              13     6      3       1        М     0,55",
            "13              13     7      3       1        М     0,5"});
            this.lb_Kbm.Location = new System.Drawing.Point(384, 304);
            this.lb_Kbm.Name = "lb_Kbm";
            this.lb_Kbm.Size = new System.Drawing.Size(254, 199);
            this.lb_Kbm.TabIndex = 5;
            this.lb_Kbm.SelectedIndexChanged += new System.EventHandler(this.lb_Kbm_SelectedIndexChanged);
            // 
            // lab_inf1
            // 
            this.lab_inf1.AutoSize = true;
            this.lab_inf1.Location = new System.Drawing.Point(51, 8);
            this.lab_inf1.Name = "lab_inf1";
            this.lab_inf1.Size = new System.Drawing.Size(162, 13);
            this.lab_inf1.TabIndex = 6;
            this.lab_inf1.Text = "Категория   Тариф (руб.)    Тип";
            // 
            // lab_inf2
            // 
            this.lab_inf2.AutoSize = true;
            this.lab_inf2.Location = new System.Drawing.Point(50, 233);
            this.lab_inf2.Name = "lab_inf2";
            this.lab_inf2.Size = new System.Drawing.Size(264, 13);
            this.lab_inf2.TabIndex = 7;
            this.lab_inf2.Text = "К. об.ТС   К. др.   Место жительства собственника";
            // 
            // lab_inf3
            // 
            this.lab_inf3.AutoSize = true;
            this.lab_inf3.Location = new System.Drawing.Point(53, 351);
            this.lab_inf3.Name = "lab_inf3";
            this.lab_inf3.Size = new System.Drawing.Size(100, 13);
            this.lab_inf3.TabIndex = 8;
            this.lab_inf3.Text = "Кол- во водителей";
            // 
            // lab_inf4
            // 
            this.lab_inf4.AutoSize = true;
            this.lab_inf4.Location = new System.Drawing.Point(52, 428);
            this.lab_inf4.Name = "lab_inf4";
            this.lab_inf4.Size = new System.Drawing.Size(157, 13);
            this.lab_inf4.TabIndex = 9;
            this.lab_inf4.Text = "К.      Возраст                  Стаж";
            // 
            // lab_inf5
            // 
            this.lab_inf5.AutoSize = true;
            this.lab_inf5.Location = new System.Drawing.Point(47, 525);
            this.lab_inf5.Name = "lab_inf5";
            this.lab_inf5.Size = new System.Drawing.Size(94, 13);
            this.lab_inf5.TabIndex = 10;
            this.lab_inf5.Text = "  К.      Мощность";
            // 
            // lab_inf6
            // 
            this.lab_inf6.AutoSize = true;
            this.lab_inf6.Location = new System.Drawing.Point(384, 285);
            this.lab_inf6.Name = "lab_inf6";
            this.lab_inf6.Size = new System.Drawing.Size(206, 13);
            this.lab_inf6.TabIndex = 11;
            this.lab_inf6.Text = "Кл.н.г.с.   б.в.   1в.   2в.    3в.    4иб.    К.";
            // 
            // lab_k_1
            // 
            this.lab_k_1.AutoSize = true;
            this.lab_k_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_k_1.Location = new System.Drawing.Point(24, 24);
            this.lab_k_1.Name = "lab_k_1";
            this.lab_k_1.Size = new System.Drawing.Size(27, 16);
            this.lab_k_1.TabIndex = 12;
            this.lab_k_1.Text = "Тб";
            // 
            // lab_k_2
            // 
            this.lab_k_2.AutoSize = true;
            this.lab_k_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_k_2.Location = new System.Drawing.Point(24, 252);
            this.lab_k_2.Name = "lab_k_2";
            this.lab_k_2.Size = new System.Drawing.Size(25, 16);
            this.lab_k_2.TabIndex = 13;
            this.lab_k_2.Text = "Кт";
            // 
            // lab_k_3
            // 
            this.lab_k_3.AutoSize = true;
            this.lab_k_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_k_3.Location = new System.Drawing.Point(24, 370);
            this.lab_k_3.Name = "lab_k_3";
            this.lab_k_3.Size = new System.Drawing.Size(26, 16);
            this.lab_k_3.TabIndex = 14;
            this.lab_k_3.Text = "Ко";
            // 
            // lab_k_4
            // 
            this.lab_k_4.AutoSize = true;
            this.lab_k_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_k_4.Location = new System.Drawing.Point(15, 447);
            this.lab_k_4.Name = "lab_k_4";
            this.lab_k_4.Size = new System.Drawing.Size(34, 16);
            this.lab_k_4.TabIndex = 15;
            this.lab_k_4.Text = "Квс";
            // 
            // lab_k_5
            // 
            this.lab_k_5.AutoSize = true;
            this.lab_k_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_k_5.Location = new System.Drawing.Point(17, 541);
            this.lab_k_5.Name = "lab_k_5";
            this.lab_k_5.Size = new System.Drawing.Size(27, 16);
            this.lab_k_5.TabIndex = 16;
            this.lab_k_5.Text = "Км";
            // 
            // lab_k_6
            // 
            this.lab_k_6.AutoSize = true;
            this.lab_k_6.BackColor = System.Drawing.Color.Transparent;
            this.lab_k_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_k_6.Location = new System.Drawing.Point(342, 304);
            this.lab_k_6.Name = "lab_k_6";
            this.lab_k_6.Size = new System.Drawing.Size(36, 16);
            this.lab_k_6.TabIndex = 17;
            this.lab_k_6.Text = "Кбм";
            // 
            // tb_inf
            // 
            this.tb_inf.Location = new System.Drawing.Point(663, 24);
            this.tb_inf.Multiline = true;
            this.tb_inf.Name = "tb_inf";
            this.tb_inf.Size = new System.Drawing.Size(540, 186);
            this.tb_inf.TabIndex = 18;
            // 
            // tb_total
            // 
            this.tb_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_total.ForeColor = System.Drawing.Color.Maroon;
            this.tb_total.Location = new System.Drawing.Point(384, 606);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(254, 29);
            this.tb_total.TabIndex = 19;
            // 
            // but_GO
            // 
            this.but_GO.BackColor = System.Drawing.Color.DarkViolet;
            this.but_GO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.but_GO.ForeColor = System.Drawing.Color.Cornsilk;
            this.but_GO.Location = new System.Drawing.Point(663, 304);
            this.but_GO.Name = "but_GO";
            this.but_GO.Size = new System.Drawing.Size(540, 331);
            this.but_GO.TabIndex = 20;
            this.but_GO.Text = "Рассчитать!";
            this.but_GO.UseVisualStyleBackColor = false;
            this.but_GO.Click += new System.EventHandler(this.but_GO_Click);
            // 
            // lab_tot
            // 
            this.lab_tot.AutoSize = true;
            this.lab_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_tot.Location = new System.Drawing.Point(753, 245);
            this.lab_tot.Name = "lab_tot";
            this.lab_tot.Size = new System.Drawing.Size(313, 25);
            this.lab_tot.TabIndex = 21;
            this.lab_tot.Text = "Тб × Кт × Ко × Квс × Км × Кбм";
            // 
            // lab_total_cost
            // 
            this.lab_total_cost.AutoSize = true;
            this.lab_total_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_total_cost.Location = new System.Drawing.Point(380, 579);
            this.lab_total_cost.Name = "lab_total_cost";
            this.lab_total_cost.Size = new System.Drawing.Size(151, 24);
            this.lab_total_cost.TabIndex = 22;
            this.lab_total_cost.Text = "Итого к оплате:";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1215, 647);
            this.Controls.Add(this.lab_total_cost);
            this.Controls.Add(this.lab_tot);
            this.Controls.Add(this.but_GO);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.tb_inf);
            this.Controls.Add(this.lab_k_6);
            this.Controls.Add(this.lab_k_5);
            this.Controls.Add(this.lab_k_4);
            this.Controls.Add(this.lab_k_3);
            this.Controls.Add(this.lab_k_2);
            this.Controls.Add(this.lab_k_1);
            this.Controls.Add(this.lab_inf6);
            this.Controls.Add(this.lab_inf5);
            this.Controls.Add(this.lab_inf4);
            this.Controls.Add(this.lab_inf3);
            this.Controls.Add(this.lab_inf2);
            this.Controls.Add(this.lab_inf1);
            this.Controls.Add(this.lb_Kbm);
            this.Controls.Add(this.lb_Km);
            this.Controls.Add(this.lb_Kvc);
            this.Controls.Add(this.lb_Ko);
            this.Controls.Add(this.lb_Kt);
            this.Controls.Add(this.lb_Tb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "osaGO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Tb;
        private System.Windows.Forms.ListBox lb_Kt;
        private System.Windows.Forms.ListBox lb_Ko;
        private System.Windows.Forms.ListBox lb_Kvc;
        private System.Windows.Forms.ListBox lb_Km;
        private System.Windows.Forms.ListBox lb_Kbm;
        private System.Windows.Forms.Label lab_inf1;
        private System.Windows.Forms.Label lab_inf2;
        private System.Windows.Forms.Label lab_inf3;
        private System.Windows.Forms.Label lab_inf4;
        private System.Windows.Forms.Label lab_inf5;
        private System.Windows.Forms.Label lab_inf6;
        private System.Windows.Forms.Label lab_k_1;
        private System.Windows.Forms.Label lab_k_2;
        private System.Windows.Forms.Label lab_k_3;
        private System.Windows.Forms.Label lab_k_4;
        private System.Windows.Forms.Label lab_k_5;
        private System.Windows.Forms.Label lab_k_6;
        private System.Windows.Forms.TextBox tb_inf;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.Button but_GO;
        private System.Windows.Forms.Label lab_tot;
        private System.Windows.Forms.Label lab_total_cost;
    }
}

