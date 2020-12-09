namespace KlatsKlatsKlats
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
            this.lab_hello = new System.Windows.Forms.Label();
            this.lab_purse = new System.Windows.Forms.Label();
            this.lab_purse_value = new System.Windows.Forms.Label();
            this.cb_select = new System.Windows.Forms.ComboBox();
            this.lab_choose = new System.Windows.Forms.Label();
            this.lab_cost = new System.Windows.Forms.Label();
            this.lab_how_cost = new System.Windows.Forms.Label();
            this.lab_amount = new System.Windows.Forms.Label();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.tb_basket = new System.Windows.Forms.TextBox();
            this.but_buy = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.lab_how_cost_total = new System.Windows.Forms.Label();
            this.lab_total_cost = new System.Windows.Forms.Label();
            this.but_buy_total = new System.Windows.Forms.Button();
            this.pb_look = new System.Windows.Forms.PictureBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.pan_payment = new System.Windows.Forms.Panel();
            this.lab_enter_ur_cvv = new System.Windows.Forms.Label();
            this.lab_enter_ur_date = new System.Windows.Forms.Label();
            this.lab_enter_ur_name = new System.Windows.Forms.Label();
            this.tb_cvv = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_ur_name = new System.Windows.Forms.TextBox();
            this.tb_numbers = new System.Windows.Forms.TextBox();
            this.but_end = new System.Windows.Forms.Button();
            this.pb_pay2 = new System.Windows.Forms.PictureBox();
            this.pb_pay1 = new System.Windows.Forms.PictureBox();
            this.lab_enter_ur_data = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_look)).BeginInit();
            this.pan_payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pay1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_hello
            // 
            this.lab_hello.AutoSize = true;
            this.lab_hello.BackColor = System.Drawing.Color.Transparent;
            this.lab_hello.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_hello.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.lab_hello.Location = new System.Drawing.Point(34, 38);
            this.lab_hello.Name = "lab_hello";
            this.lab_hello.Size = new System.Drawing.Size(210, 32);
            this.lab_hello.TabIndex = 0;
            this.lab_hello.Text = "Приветствуем!";
            // 
            // lab_purse
            // 
            this.lab_purse.AutoSize = true;
            this.lab_purse.BackColor = System.Drawing.Color.Transparent;
            this.lab_purse.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_purse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_purse.Location = new System.Drawing.Point(34, 100);
            this.lab_purse.Name = "lab_purse";
            this.lab_purse.Size = new System.Drawing.Size(225, 32);
            this.lab_purse.TabIndex = 1;
            this.lab_purse.Text = "Ваши средства:";
            // 
            // lab_purse_value
            // 
            this.lab_purse_value.AutoSize = true;
            this.lab_purse_value.BackColor = System.Drawing.Color.Transparent;
            this.lab_purse_value.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_purse_value.ForeColor = System.Drawing.Color.Tomato;
            this.lab_purse_value.Location = new System.Drawing.Point(265, 100);
            this.lab_purse_value.Name = "lab_purse_value";
            this.lab_purse_value.Size = new System.Drawing.Size(60, 32);
            this.lab_purse_value.TabIndex = 2;
            this.lab_purse_value.Text = "---";
            // 
            // cb_select
            // 
            this.cb_select.BackColor = System.Drawing.Color.DimGray;
            this.cb_select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_select.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_select.ForeColor = System.Drawing.Color.Turquoise;
            this.cb_select.FormattingEnabled = true;
            this.cb_select.Location = new System.Drawing.Point(40, 227);
            this.cb_select.MaxDropDownItems = 14;
            this.cb_select.Name = "cb_select";
            this.cb_select.Size = new System.Drawing.Size(265, 40);
            this.cb_select.TabIndex = 3;
            this.cb_select.SelectedIndexChanged += new System.EventHandler(this.cb_select_SelectedIndexChanged);
            // 
            // lab_choose
            // 
            this.lab_choose.AutoSize = true;
            this.lab_choose.BackColor = System.Drawing.Color.Transparent;
            this.lab_choose.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_choose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_choose.Location = new System.Drawing.Point(34, 179);
            this.lab_choose.Name = "lab_choose";
            this.lab_choose.Size = new System.Drawing.Size(285, 32);
            this.lab_choose.TabIndex = 4;
            this.lab_choose.Text = "Выберете скафандр:";
            // 
            // lab_cost
            // 
            this.lab_cost.AutoSize = true;
            this.lab_cost.BackColor = System.Drawing.Color.Transparent;
            this.lab_cost.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_cost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_cost.Location = new System.Drawing.Point(511, 179);
            this.lab_cost.Name = "lab_cost";
            this.lab_cost.Size = new System.Drawing.Size(90, 32);
            this.lab_cost.TabIndex = 5;
            this.lab_cost.Text = "Цена:";
            // 
            // lab_how_cost
            // 
            this.lab_how_cost.AutoSize = true;
            this.lab_how_cost.BackColor = System.Drawing.Color.Transparent;
            this.lab_how_cost.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_how_cost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_how_cost.Location = new System.Drawing.Point(511, 235);
            this.lab_how_cost.Name = "lab_how_cost";
            this.lab_how_cost.Size = new System.Drawing.Size(60, 32);
            this.lab_how_cost.TabIndex = 6;
            this.lab_how_cost.Text = "---";
            // 
            // lab_amount
            // 
            this.lab_amount.AutoSize = true;
            this.lab_amount.BackColor = System.Drawing.Color.Transparent;
            this.lab_amount.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_amount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_amount.Location = new System.Drawing.Point(325, 179);
            this.lab_amount.Name = "lab_amount";
            this.lab_amount.Size = new System.Drawing.Size(180, 32);
            this.lab_amount.TabIndex = 7;
            this.lab_amount.Text = "Количество:";
            // 
            // nud
            // 
            this.nud.BackColor = System.Drawing.Color.DimGray;
            this.nud.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nud.Location = new System.Drawing.Point(331, 227);
            this.nud.Name = "nud";
            this.nud.ReadOnly = true;
            this.nud.Size = new System.Drawing.Size(159, 39);
            this.nud.TabIndex = 8;
            this.nud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud.ValueChanged += new System.EventHandler(this.nud_ValueChanged);
            // 
            // tb_basket
            // 
            this.tb_basket.BackColor = System.Drawing.Color.DimGray;
            this.tb_basket.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_basket.ForeColor = System.Drawing.Color.White;
            this.tb_basket.Location = new System.Drawing.Point(40, 302);
            this.tb_basket.Multiline = true;
            this.tb_basket.Name = "tb_basket";
            this.tb_basket.ReadOnly = true;
            this.tb_basket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_basket.Size = new System.Drawing.Size(450, 423);
            this.tb_basket.TabIndex = 9;
            // 
            // but_buy
            // 
            this.but_buy.BackColor = System.Drawing.Color.SeaShell;
            this.but_buy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_buy.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_buy.ForeColor = System.Drawing.Color.DarkMagenta;
            this.but_buy.Location = new System.Drawing.Point(517, 301);
            this.but_buy.Name = "but_buy";
            this.but_buy.Size = new System.Drawing.Size(219, 67);
            this.but_buy.TabIndex = 10;
            this.but_buy.Text = "Выбрать!";
            this.but_buy.UseVisualStyleBackColor = false;
            this.but_buy.Click += new System.EventHandler(this.but_buy_Click);
            this.but_buy.Enter += new System.EventHandler(this.but_buy_Enter);
            this.but_buy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_buy_MouseUp);
            // 
            // but_del
            // 
            this.but_del.BackColor = System.Drawing.Color.SeaShell;
            this.but_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_del.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_del.ForeColor = System.Drawing.Color.DarkMagenta;
            this.but_del.Location = new System.Drawing.Point(517, 378);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(219, 67);
            this.but_del.TabIndex = 11;
            this.but_del.Text = "Удалить";
            this.but_del.UseVisualStyleBackColor = false;
            this.but_del.Visible = false;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            this.but_del.Enter += new System.EventHandler(this.but_del_Enter);
            this.but_del.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_del_MouseUp);
            // 
            // lab_how_cost_total
            // 
            this.lab_how_cost_total.AutoSize = true;
            this.lab_how_cost_total.BackColor = System.Drawing.Color.Transparent;
            this.lab_how_cost_total.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_how_cost_total.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_how_cost_total.Location = new System.Drawing.Point(511, 559);
            this.lab_how_cost_total.Name = "lab_how_cost_total";
            this.lab_how_cost_total.Size = new System.Drawing.Size(60, 32);
            this.lab_how_cost_total.TabIndex = 13;
            this.lab_how_cost_total.Text = "---";
            // 
            // lab_total_cost
            // 
            this.lab_total_cost.AutoSize = true;
            this.lab_total_cost.BackColor = System.Drawing.Color.Transparent;
            this.lab_total_cost.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_total_cost.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_total_cost.Location = new System.Drawing.Point(511, 503);
            this.lab_total_cost.Name = "lab_total_cost";
            this.lab_total_cost.Size = new System.Drawing.Size(225, 32);
            this.lab_total_cost.TabIndex = 12;
            this.lab_total_cost.Text = "Итоговая цена:";
            this.lab_total_cost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // but_buy_total
            // 
            this.but_buy_total.BackColor = System.Drawing.Color.SeaShell;
            this.but_buy_total.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_buy_total.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_buy_total.ForeColor = System.Drawing.Color.Crimson;
            this.but_buy_total.Location = new System.Drawing.Point(517, 653);
            this.but_buy_total.Name = "but_buy_total";
            this.but_buy_total.Size = new System.Drawing.Size(219, 72);
            this.but_buy_total.TabIndex = 14;
            this.but_buy_total.Text = "Купить!";
            this.but_buy_total.UseVisualStyleBackColor = false;
            this.but_buy_total.Click += new System.EventHandler(this.but_buy_total_Click);
            this.but_buy_total.Enter += new System.EventHandler(this.but_buy_total_Enter);
            this.but_buy_total.MouseUp += new System.Windows.Forms.MouseEventHandler(this.but_buy_total_MouseUp);
            // 
            // pb_look
            // 
            this.pb_look.BackColor = System.Drawing.Color.Transparent;
            this.pb_look.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_look.Location = new System.Drawing.Point(796, 75);
            this.pb_look.Name = "pb_look";
            this.pb_look.Size = new System.Drawing.Size(234, 561);
            this.pb_look.TabIndex = 16;
            this.pb_look.TabStop = false;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_name.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_name.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.tb_name.Location = new System.Drawing.Point(796, 653);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(234, 39);
            this.tb_name.TabIndex = 17;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pan_payment
            // 
            this.pan_payment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pan_payment.BackgroundImage")));
            this.pan_payment.Controls.Add(this.lab_enter_ur_cvv);
            this.pan_payment.Controls.Add(this.lab_enter_ur_date);
            this.pan_payment.Controls.Add(this.lab_enter_ur_name);
            this.pan_payment.Controls.Add(this.tb_cvv);
            this.pan_payment.Controls.Add(this.tb_date);
            this.pan_payment.Controls.Add(this.tb_ur_name);
            this.pan_payment.Controls.Add(this.tb_numbers);
            this.pan_payment.Controls.Add(this.but_end);
            this.pan_payment.Controls.Add(this.pb_pay2);
            this.pan_payment.Controls.Add(this.pb_pay1);
            this.pan_payment.Controls.Add(this.lab_enter_ur_data);
            this.pan_payment.Location = new System.Drawing.Point(1087, 75);
            this.pan_payment.Name = "pan_payment";
            this.pan_payment.Size = new System.Drawing.Size(382, 650);
            this.pan_payment.TabIndex = 18;
            this.pan_payment.Visible = false;
            // 
            // lab_enter_ur_cvv
            // 
            this.lab_enter_ur_cvv.AutoSize = true;
            this.lab_enter_ur_cvv.BackColor = System.Drawing.Color.SkyBlue;
            this.lab_enter_ur_cvv.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_enter_ur_cvv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_enter_ur_cvv.Location = new System.Drawing.Point(249, 444);
            this.lab_enter_ur_cvv.Name = "lab_enter_ur_cvv";
            this.lab_enter_ur_cvv.Size = new System.Drawing.Size(46, 24);
            this.lab_enter_ur_cvv.TabIndex = 26;
            this.lab_enter_ur_cvv.Text = "CVV";
            // 
            // lab_enter_ur_date
            // 
            this.lab_enter_ur_date.AutoSize = true;
            this.lab_enter_ur_date.BackColor = System.Drawing.Color.SkyBlue;
            this.lab_enter_ur_date.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_enter_ur_date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_enter_ur_date.Location = new System.Drawing.Point(277, 242);
            this.lab_enter_ur_date.Name = "lab_enter_ur_date";
            this.lab_enter_ur_date.Size = new System.Drawing.Size(58, 24);
            this.lab_enter_ur_date.TabIndex = 25;
            this.lab_enter_ur_date.Text = "DATE";
            // 
            // lab_enter_ur_name
            // 
            this.lab_enter_ur_name.AutoSize = true;
            this.lab_enter_ur_name.BackColor = System.Drawing.Color.SkyBlue;
            this.lab_enter_ur_name.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_enter_ur_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lab_enter_ur_name.Location = new System.Drawing.Point(52, 242);
            this.lab_enter_ur_name.Name = "lab_enter_ur_name";
            this.lab_enter_ur_name.Size = new System.Drawing.Size(190, 24);
            this.lab_enter_ur_name.TabIndex = 24;
            this.lab_enter_ur_name.Text = "CARDHOLDER NAME";
            // 
            // tb_cvv
            // 
            this.tb_cvv.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_cvv.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tb_cvv.Location = new System.Drawing.Point(237, 405);
            this.tb_cvv.Name = "tb_cvv";
            this.tb_cvv.Size = new System.Drawing.Size(58, 36);
            this.tb_cvv.TabIndex = 23;
            this.tb_cvv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_cvv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_cvv_KeyPress);
            // 
            // tb_date
            // 
            this.tb_date.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_date.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tb_date.Location = new System.Drawing.Point(271, 269);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(76, 36);
            this.tb_date.TabIndex = 22;
            this.tb_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_date_KeyPress);
            // 
            // tb_ur_name
            // 
            this.tb_ur_name.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ur_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tb_ur_name.Location = new System.Drawing.Point(43, 269);
            this.tb_ur_name.Name = "tb_ur_name";
            this.tb_ur_name.Size = new System.Drawing.Size(209, 36);
            this.tb_ur_name.TabIndex = 21;
            this.tb_ur_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ur_name_KeyPress);
            // 
            // tb_numbers
            // 
            this.tb_numbers.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_numbers.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tb_numbers.Location = new System.Drawing.Point(43, 203);
            this.tb_numbers.Name = "tb_numbers";
            this.tb_numbers.Size = new System.Drawing.Size(304, 36);
            this.tb_numbers.TabIndex = 20;
            this.tb_numbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_numbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_numbers_KeyPress);
            // 
            // but_end
            // 
            this.but_end.BackColor = System.Drawing.Color.LightSteelBlue;
            this.but_end.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_end.Font = new System.Drawing.Font("Lucida Bright", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_end.ForeColor = System.Drawing.Color.Black;
            this.but_end.Location = new System.Drawing.Point(85, 578);
            this.but_end.Name = "but_end";
            this.but_end.Size = new System.Drawing.Size(219, 67);
            this.but_end.TabIndex = 19;
            this.but_end.Text = "Закончить!";
            this.but_end.UseVisualStyleBackColor = false;
            this.but_end.Click += new System.EventHandler(this.but_end_Click);
            // 
            // pb_pay2
            // 
            this.pb_pay2.BackColor = System.Drawing.Color.Transparent;
            this.pb_pay2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_pay2.BackgroundImage")));
            this.pb_pay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pay2.Location = new System.Drawing.Point(0, 322);
            this.pb_pay2.Name = "pb_pay2";
            this.pb_pay2.Size = new System.Drawing.Size(379, 253);
            this.pb_pay2.TabIndex = 4;
            this.pb_pay2.TabStop = false;
            // 
            // pb_pay1
            // 
            this.pb_pay1.BackColor = System.Drawing.Color.Transparent;
            this.pb_pay1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb_pay1.BackgroundImage")));
            this.pb_pay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_pay1.Location = new System.Drawing.Point(0, 63);
            this.pb_pay1.Name = "pb_pay1";
            this.pb_pay1.Size = new System.Drawing.Size(382, 262);
            this.pb_pay1.TabIndex = 3;
            this.pb_pay1.TabStop = false;
            // 
            // lab_enter_ur_data
            // 
            this.lab_enter_ur_data.AutoSize = true;
            this.lab_enter_ur_data.BackColor = System.Drawing.Color.Transparent;
            this.lab_enter_ur_data.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lab_enter_ur_data.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lab_enter_ur_data.Location = new System.Drawing.Point(12, 15);
            this.lab_enter_ur_data.Name = "lab_enter_ur_data";
            this.lab_enter_ur_data.Size = new System.Drawing.Size(240, 32);
            this.lab_enter_ur_data.TabIndex = 2;
            this.lab_enter_ur_data.Text = "Введите данные:";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1502, 770);
            this.Controls.Add(this.pan_payment);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.pb_look);
            this.Controls.Add(this.but_buy_total);
            this.Controls.Add(this.lab_how_cost_total);
            this.Controls.Add(this.lab_total_cost);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_buy);
            this.Controls.Add(this.tb_basket);
            this.Controls.Add(this.nud);
            this.Controls.Add(this.lab_amount);
            this.Controls.Add(this.lab_how_cost);
            this.Controls.Add(this.lab_cost);
            this.Controls.Add(this.lab_choose);
            this.Controls.Add(this.cb_select);
            this.Controls.Add(this.lab_purse_value);
            this.Controls.Add(this.lab_purse);
            this.Controls.Add(this.lab_hello);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Space Shop!";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_look)).EndInit();
            this.pan_payment.ResumeLayout(false);
            this.pan_payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pay1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_hello;
        private System.Windows.Forms.Label lab_purse;
        private System.Windows.Forms.Label lab_purse_value;
        private System.Windows.Forms.ComboBox cb_select;
        private System.Windows.Forms.Label lab_choose;
        private System.Windows.Forms.Label lab_cost;
        private System.Windows.Forms.Label lab_how_cost;
        private System.Windows.Forms.Label lab_amount;
        private System.Windows.Forms.NumericUpDown nud;
        private System.Windows.Forms.TextBox tb_basket;
        private System.Windows.Forms.Button but_buy;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Label lab_how_cost_total;
        private System.Windows.Forms.Label lab_total_cost;
        private System.Windows.Forms.Button but_buy_total;
        private System.Windows.Forms.PictureBox pb_look;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Panel pan_payment;
        private System.Windows.Forms.Button but_end;
        private System.Windows.Forms.PictureBox pb_pay2;
        private System.Windows.Forms.PictureBox pb_pay1;
        private System.Windows.Forms.Label lab_enter_ur_data;
        private System.Windows.Forms.Label lab_enter_ur_cvv;
        private System.Windows.Forms.Label lab_enter_ur_date;
        private System.Windows.Forms.Label lab_enter_ur_name;
        private System.Windows.Forms.TextBox tb_cvv;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_ur_name;
        private System.Windows.Forms.TextBox tb_numbers;
    }
}

