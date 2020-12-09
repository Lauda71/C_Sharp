using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TakeYourCheckPlease
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int count = 0;
        string[] name = new string[0];
        int[] price = new int[7];
        int[] check = new int[0];

        int count0 = 0;
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        int count4 = 0;
        int count5 = 0;
        int count6 = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            string s;
            //Encoding text = Encoding.GetEncoding(1251);
            StreamReader ReaderKiller = new StreamReader("Products.txt", Encoding.Default);
            int n = 0;
            
            while ((s = ReaderKiller.ReadLine()) != null)
            {
                string[] product_name = new string[2];
                product_name = s.Split(' ');
                CBProductSelect.Items.Add(product_name[0]);
                price[n] = Convert.ToInt32(product_name[1]);
                n++;
            }
            ReaderKiller.Close();
            TBBasket.Text = "";
        }

        private void choice(object sender, EventArgs e)
        {
            ButtonProductAdd.Focus();
        }

        private void ButtonProductAdd_Click(object sender, EventArgs e)
        {
            if (CBProductSelect.SelectedIndex == -1)
            {

            }
            else
            {
                count++;
                Array.Resize<string>(ref name, count);
                Array.Resize<int>(ref check, count);
                name[count - 1] = Convert.ToString(CBProductSelect.SelectedItem);

                if (name[count - 1] == "Конфетка")
                {
                    check[count - 1] = price[0];
                }
                else if (name[count - 1] == "Пирожок")
                {
                    check[count - 1] = price[1];
                }
                else if (name[count - 1] == "Котлетка")
                {
                    check[count - 1] = price[2];
                }
                else if (name[count - 1] == "Макароны")
                {
                    check[count - 1] = price[3];
                }
                else if (name[count - 1] == "Чай")
                {
                    check[count - 1] = price[4];
                }
                else if (name[count - 1] == "Пистолет")
                {
                    check[count - 1] = price[5];
                }
                else if (name[count - 1] == "Танк")
                {
                    check[count - 1] = price[6];
                }

                string s;
                string[] pzd = new string[name.Length];
                if (CBProductSelect.SelectedIndex == 0)
                {
                    int price = 9000;
                    s = "№" + Convert.ToString(count) + ". Название товара: " + name[count - 1] + " Цена: " + Convert.ToString(price) + " Кол-во: 1 Итого: " + Convert.ToString(price);
                    pzd[count - 1] = s;
                    count0++;
                }
                else if (CBProductSelect.SelectedIndex == 1)
                {
                    int price = 9390;
                    s = "№" + Convert.ToString(count) + ". Название товара: " + name[count - 1] + " Цена: " + Convert.ToString(price) + " Кол-во: 1 Итого: " + Convert.ToString(price);
                    pzd[count - 1] = s;
                    count1++;
                }
                else if (CBProductSelect.SelectedIndex == 2)
                {
                    int price = 12;
                    s = "№" + Convert.ToString(count) + ". Название товара: " + name[count - 1] + " Цена: " + Convert.ToString(price) + " Кол-во: 1 Итого: " + Convert.ToString(price);
                    pzd[count - 1] = s;
                    count2++;
                }
                else if (CBProductSelect.SelectedIndex == 3)
                {
                    int price = 200;
                    s = "№" + Convert.ToString(count) + ". Название товара: " + name[count - 1] + " Цена: " + Convert.ToString(price) + " Кол-во: 1 Итого: " + Convert.ToString(price);
                    pzd[count - 1] = s;
                    count3++;
                }
                else if (CBProductSelect.SelectedIndex == 4)
                {
                    int price = 10;
                    s = "№" + Convert.ToString(count) + ". Название товара: " + name[count - 1] + " Цена: " + Convert.ToString(price) + " Кол-во: 1 Итого: " + Convert.ToString(price);
                    pzd[count - 1] = s;
                    count4++;
                }
                else if (CBProductSelect.SelectedIndex == 5)
                {
                    int price = 50000;
                    s = "№" + Convert.ToString(count) + ". Название товара: " + name[count - 1] + " Цена: " + Convert.ToString(price) + " Кол-во: 1 Итого: " + Convert.ToString(price);
                    pzd[count - 1] = s;
                    count5++;
                }
                else if (CBProductSelect.SelectedIndex == 6)
                {
                    int price = 9999;
                    s = "№" + Convert.ToString(count) + ". Название товара: " + name[count - 1] + " Цена: " + Convert.ToString(price) + " Кол-во: 1 Итого: " + Convert.ToString(price);
                    pzd[count - 1] = s;
                    count6++;
                }
                TBBasket.Text += pzd[count - 1] + Environment.NewLine;

                if (count > 0)
                {
                    BBuyProducts.Enabled = true;
                    ButtonDeleteProduct.Visible = true;
                }

                int summa = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] == "Конфетка")
                    {
                        summa = summa + 9000;
                    }
                    else if (name[i] == "Пирожок")
                    {
                        summa = summa + 9390;
                    }
                    else if (name[i] == "Котлетка")
                    {
                        summa = summa + 12;
                    }
                    else if (name[i] == "Макароны")
                    {
                        summa = summa + 200;
                    }
                    else if (name[i] == "Чай")
                    {
                        summa = summa + 10;
                    }
                    else if (name[i] == "Пистолет")
                    {
                        summa = summa + 50000;
                    }
                    else if (name[i] == "Танк")
                    {
                        summa = summa + 9999;
                    }
                }

                TBSum.Text = Convert.ToString(summa);
            }
        }

        private void ButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            int activeprice = 0;
            int summa;

            if (name[count - 1] == "Конфетка")
            {
                activeprice = 9000;
            }
            else if (name[count - 1] == "Пирожок")
            {
                activeprice = 9390;
            }
            else if (name[count - 1] == "Котлетка")
            {
                activeprice = 12;
            }
            else if (name[count - 1] == "Макароны")
            {
                activeprice = 200;
            }
            else if (name[count - 1] == "Чай")
            {
                activeprice = 10;
            }
            else if (name[count - 1] == "Пистолет")
            {
                activeprice = 50000;
            }
            else if (name[count - 1] == "Танк")
            {
                activeprice = 9999;
            }


            summa = Convert.ToInt32(TBSum.Text) - activeprice;
            TBSum.Text = Convert.ToString(summa);
            checksumma.Text = "";
            var lines = TBBasket.Lines.ToList();
            int n = TBBasket.Lines.Length - 1;
            if (n > 0)
            {
                lines.RemoveAt(n - 1);
                TBBasket.Lines = lines.ToArray();
                count--;
                Array.Resize<string>(ref name, count);
                Array.Resize<int>(ref check, count);
                n--;
            }

            if (n < 1)
            {
                BBuyProducts.Enabled = false;
                ButtonDeleteProduct.Visible = false;
                ButtonProductAdd.Focus();
            }
        }

        private void BBuyProducts_Click(object sender, EventArgs e)
        {
            int summa = 0;
            for (int i = 0; i < check.Length; i++)
            {
                summa = summa + check[i];
            }
            checksumma.Text = Convert.ToString(summa);
        }

        private void checksumma_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
