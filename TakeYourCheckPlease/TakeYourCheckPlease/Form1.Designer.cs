namespace TakeYourCheckPlease
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LabelProductAdd = new System.Windows.Forms.Label();
            this.CBProductSelect = new System.Windows.Forms.ComboBox();
            this.ButtonProductAdd = new System.Windows.Forms.Button();
            this.TBBasket = new System.Windows.Forms.TextBox();
            this.ButtonDeleteProduct = new System.Windows.Forms.Button();
            this.BBuyProducts = new System.Windows.Forms.Button();
            this.TBSum = new System.Windows.Forms.TextBox();
            this.checksumma = new System.Windows.Forms.TextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelProductAdd
            // 
            this.LabelProductAdd.AutoSize = true;
            this.LabelProductAdd.BackColor = System.Drawing.Color.PaleVioletRed;
            this.LabelProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelProductAdd.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductAdd.ForeColor = System.Drawing.Color.DarkMagenta;
            this.LabelProductAdd.Location = new System.Drawing.Point(452, 20);
            this.LabelProductAdd.Name = "LabelProductAdd";
            this.LabelProductAdd.Size = new System.Drawing.Size(210, 25);
            this.LabelProductAdd.TabIndex = 0;
            this.LabelProductAdd.Text = "Выберите товарчик:";
            // 
            // CBProductSelect
            // 
            this.CBProductSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBProductSelect.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBProductSelect.ForeColor = System.Drawing.Color.IndianRed;
            this.CBProductSelect.FormattingEnabled = true;
            this.CBProductSelect.Location = new System.Drawing.Point(333, 63);
            this.CBProductSelect.Name = "CBProductSelect";
            this.CBProductSelect.Size = new System.Drawing.Size(444, 31);
            this.CBProductSelect.TabIndex = 1;
            this.CBProductSelect.SelectedIndexChanged += new System.EventHandler(this.choice);
            // 
            // ButtonProductAdd
            // 
            this.ButtonProductAdd.BackColor = System.Drawing.Color.Plum;
            this.ButtonProductAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonProductAdd.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonProductAdd.ForeColor = System.Drawing.Color.DeepPink;
            this.ButtonProductAdd.Location = new System.Drawing.Point(333, 100);
            this.ButtonProductAdd.Name = "ButtonProductAdd";
            this.ButtonProductAdd.Size = new System.Drawing.Size(205, 75);
            this.ButtonProductAdd.TabIndex = 2;
            this.ButtonProductAdd.Text = "Добавить товарчик";
            this.ButtonProductAdd.UseVisualStyleBackColor = false;
            this.ButtonProductAdd.Click += new System.EventHandler(this.ButtonProductAdd_Click);
            // 
            // TBBasket
            // 
            this.TBBasket.BackColor = System.Drawing.Color.Orchid;
            this.TBBasket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBBasket.Location = new System.Drawing.Point(131, 196);
            this.TBBasket.Multiline = true;
            this.TBBasket.Name = "TBBasket";
            this.TBBasket.ReadOnly = true;
            this.TBBasket.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TBBasket.Size = new System.Drawing.Size(855, 237);
            this.TBBasket.TabIndex = 3;
            // 
            // ButtonDeleteProduct
            // 
            this.ButtonDeleteProduct.BackColor = System.Drawing.Color.Plum;
            this.ButtonDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonDeleteProduct.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDeleteProduct.ForeColor = System.Drawing.Color.DeepPink;
            this.ButtonDeleteProduct.Location = new System.Drawing.Point(131, 439);
            this.ButtonDeleteProduct.Name = "ButtonDeleteProduct";
            this.ButtonDeleteProduct.Size = new System.Drawing.Size(309, 81);
            this.ButtonDeleteProduct.TabIndex = 4;
            this.ButtonDeleteProduct.Text = "Удалить последний товарчик";
            this.ButtonDeleteProduct.UseVisualStyleBackColor = false;
            this.ButtonDeleteProduct.Visible = false;
            this.ButtonDeleteProduct.Click += new System.EventHandler(this.ButtonDeleteProduct_Click);
            // 
            // BBuyProducts
            // 
            this.BBuyProducts.BackColor = System.Drawing.Color.Plum;
            this.BBuyProducts.Enabled = false;
            this.BBuyProducts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBuyProducts.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBuyProducts.ForeColor = System.Drawing.Color.DeepPink;
            this.BBuyProducts.Location = new System.Drawing.Point(572, 100);
            this.BBuyProducts.Name = "BBuyProducts";
            this.BBuyProducts.Size = new System.Drawing.Size(205, 75);
            this.BBuyProducts.TabIndex = 5;
            this.BBuyProducts.Text = "Купить товарчик";
            this.BBuyProducts.UseVisualStyleBackColor = false;
            this.BBuyProducts.Click += new System.EventHandler(this.BBuyProducts_Click);
            // 
            // TBSum
            // 
            this.TBSum.Location = new System.Drawing.Point(712, 439);
            this.TBSum.Name = "TBSum";
            this.TBSum.ReadOnly = true;
            this.TBSum.Size = new System.Drawing.Size(274, 20);
            this.TBSum.TabIndex = 6;
            // 
            // checksumma
            // 
            this.checksumma.Location = new System.Drawing.Point(712, 500);
            this.checksumma.Name = "checksumma";
            this.checksumma.ReadOnly = true;
            this.checksumma.Size = new System.Drawing.Size(274, 20);
            this.checksumma.TabIndex = 7;
            this.checksumma.TextChanged += new System.EventHandler(this.checksumma_TextChanged);
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.BackColor = System.Drawing.Color.PaleVioletRed;
            this.LabelTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.Color.DarkMagenta;
            this.LabelTotal.Location = new System.Drawing.Point(520, 500);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(171, 25);
            this.LabelTotal.TabIndex = 8;
            this.LabelTotal.Text = "Итоговая сумма:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1211, 682);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.checksumma);
            this.Controls.Add(this.TBSum);
            this.Controls.Add(this.BBuyProducts);
            this.Controls.Add(this.ButtonDeleteProduct);
            this.Controls.Add(this.TBBasket);
            this.Controls.Add(this.ButtonProductAdd);
            this.Controls.Add(this.CBProductSelect);
            this.Controls.Add(this.LabelProductAdd);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pokupka";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelProductAdd;
        private System.Windows.Forms.ComboBox CBProductSelect;
        private System.Windows.Forms.Button ButtonProductAdd;
        private System.Windows.Forms.TextBox TBBasket;
        private System.Windows.Forms.Button ButtonDeleteProduct;
        private System.Windows.Forms.Button BBuyProducts;
        private System.Windows.Forms.TextBox TBSum;
        private System.Windows.Forms.TextBox checksumma;
        private System.Windows.Forms.Label LabelTotal;
    }
}

