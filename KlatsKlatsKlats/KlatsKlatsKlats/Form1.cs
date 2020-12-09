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
using System.Threading;

namespace KlatsKlatsKlats
{
    public partial class Main_Form : Form
    {

        double cash_value = 17000000000;
        double now_cv = 0;
        double main_price = 0;
        double[] price = new double[13];
        double[] last_buy = new double[100];
        double val = 0;
        
        int count = 0;
        int active_number = 0;
        int last_b = 0;
        int[] number = new int[13];
        int key_count = 0;
        int key_count2 = 0;
        int key_count3 = 0;

        string reading = "";
        string cash_val = "";
        string[] name = new string[13];
        string tb_s = "";

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {


            StreamReader SpaceReader = new StreamReader("spacesuits.txt", Encoding.Default);
            while ((reading = SpaceReader.ReadLine()) != null)
            {

                string[] product_name = new string[3];
                reading = reading.Replace(" ", "");
                product_name = reading.Split(';');
                product_name[1] = product_name[1].Insert(0, " ");
                cb_select.Items.Add(product_name[1]);
                name[count] = product_name[1];
                price[count] = Convert.ToDouble(product_name[0]);
                number[count] = Convert.ToInt32(product_name[2]);
                count++;
            }            

            SpaceReader.Close();

            cash_val = Convert.ToString(cash_value);
            for (int i = 0, x = cash_val.Length; i < x; i++)
            {
                if (i % 3 == 0)
                {
                    cash_val = cash_val.Insert(x - i, " ");
                    i++;
                }
            }
            lab_purse_value.Text = cash_val + "₽";
        }

        static string calculate(double a)
        {
            string s = Convert.ToString(a);

            for (int i = 0, x = s.Length; i < x; i++)
            {
                if (i % 3 == 0)
                {
                    s = s.Insert(x - i, " ");
                    i++;
                }
            }
            return s + "₽";
        }

        private void cb_select_SelectedIndexChanged(object sender, EventArgs e)
        {

            //nud.Value = 1;
            //nud.Focus();

            if (cb_select.Text == name[0]) { active_number = 0; tb_name.Text = name[0]; lab_how_cost.Text = calculate(price[0]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\01.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561);}
            else if (cb_select.Text == name[1]) { active_number = 1; tb_name.Text = name[1]; lab_how_cost.Text = calculate(price[1]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\02.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(190, 561); }// pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[2]) { active_number = 2; tb_name.Text = name[2]; lab_how_cost.Text = calculate(price[2]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\03.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561); }// pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[3]) { active_number = 3; tb_name.Text = name[3]; lab_how_cost.Text = calculate(price[3]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\04.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561); }// pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[4]) { active_number = 4; tb_name.Text = name[4]; lab_how_cost.Text = calculate(price[4]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\05.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561); }// pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[5]) { active_number = 5; tb_name.Text = name[5]; lab_how_cost.Text = calculate(price[5]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\06.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561); }//pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[6]) { active_number = 6; tb_name.Text = name[6]; lab_how_cost.Text = calculate(price[6]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\07.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561); }//pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[7]) { active_number = 7; tb_name.Text = name[7]; lab_how_cost.Text = calculate(price[7]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\08.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(270, 561); }// pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[8]) { active_number = 8; tb_name.Text = name[8]; lab_how_cost.Text = calculate(price[8]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\09.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(300, 561); }// pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[9]) { active_number = 9; tb_name.Text = name[9]; lab_how_cost.Text = calculate(price[9]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\10.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(190, 561); }// pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[10]) { active_number = 10; tb_name.Text = name[10]; lab_how_cost.Text = calculate(price[10]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\11.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561); }//pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[11]) { active_number = 11; tb_name.Text = name[11]; lab_how_cost.Text = calculate(price[11]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\12.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561); }//pb_look.ClientSize = new Size(230, 600); }
            else if (cb_select.Text == name[12]) { active_number = 12; tb_name.Text = name[12]; lab_how_cost.Text = calculate(price[12]); pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\13.png"); pb_look.SizeMode = PictureBoxSizeMode.StretchImage; pb_look.ClientSize = new Size(234, 561); }// pb_look.ClientSize = new Size(230, 600); }
                        
            //nud.Value = 0;
            //nud.Focus();
        }


        // Изменение цвета кнопки "Взять!"
        private void but_buy_MouseUp(object sender, MouseEventArgs e)
        {
            Thread.Sleep(50);
            but_buy.BackColor = Color.SeaShell;
        }
        private void but_buy_Enter(object sender, EventArgs e)
        {
            but_buy.BackColor = Color.Silver;
        }

        // Изменение цвета кнопки "Купить!"
        private void but_buy_total_Enter(object sender, EventArgs e)
        {
            but_buy_total.BackColor = Color.Crimson;
            but_buy_total.ForeColor = Color.White;
        }
        private void but_buy_total_MouseUp(object sender, MouseEventArgs e)
        {
            Thread.Sleep(50);
            but_buy_total.BackColor = Color.SeaShell;
            but_buy_total.ForeColor = Color.Crimson;
        }

        // Изменение цвета кнопки "Удалить"
        private void but_del_Enter(object sender, EventArgs e)
        {
            but_del.BackColor = Color.Silver;
        }
        private void but_del_MouseUp(object sender, MouseEventArgs e)
        {
            Thread.Sleep(50);
            but_del.BackColor = Color.SeaShell;
        }


        private void but_buy_Click(object sender, EventArgs e)
        {
            count = 1;

            if (cb_select.SelectedIndex == -1) { }

            else
            {
                if (cb_select.SelectedIndex == 0 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[0]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 1 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[1]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 2 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[2]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 3 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[3]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 4 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[4]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 5 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[5]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 6 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[6]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 7 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[7]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 8 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[8]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 9 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[9]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 10 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[10]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 11 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[11]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }
                else if (cb_select.SelectedIndex == 12 && val <= cash_value && nud.Value != 0) { last_buy[last_b] = val; last_b++; main_price += val; tb_s = " [" + Convert.ToString(nud.Value) + " шт.] " + name[12]; count++; cash_value -= val; lab_purse_value.Text = calculate(cash_value); tb_basket.Text += tb_s + Environment.NewLine; }

                if (nud.Value > 0) { but_del.Visible = true; nud.Value = 0; }
                //lab_how_cost_total.Text = "---";
                now_cv = 17000000000 - cash_value;
                lab_how_cost_total.Text = calculate(now_cv);
                pan_payment.Visible = false;
            }


        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            if (nud.Value == 0)
            {
                cb_select.SelectedIndex = -1;
                lab_how_cost.Text = "---";
                nud.Value = 0;
                tb_name.Text = " ";
                pb_look.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\ready\\NULL.png");
            }

            if (cb_select.SelectedIndex == -1)
            {
                nud.Value = 0;
            }

            if (nud.Value >= 1)
            {
                if (active_number == 0 && price[0] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[0] * Convert.ToDouble(nud.Value); }
                else if (active_number == 1 && price[1] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[1] * Convert.ToDouble(nud.Value); }
                else if (active_number == 2 && price[2] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[2] * Convert.ToDouble(nud.Value); }
                else if (active_number == 3 && price[3] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[3] * Convert.ToDouble(nud.Value); }
                else if (active_number == 4 && price[4] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[4] * Convert.ToDouble(nud.Value); }
                else if (active_number == 5 && price[5] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[5] * Convert.ToDouble(nud.Value); }
                else if (active_number == 6 && price[6] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[6] * Convert.ToDouble(nud.Value); }
                else if (active_number == 7 && price[7] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[7] * Convert.ToDouble(nud.Value); }
                else if (active_number == 8 && price[8] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[8] * Convert.ToDouble(nud.Value); }
                else if (active_number == 9 && price[9] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[9] * Convert.ToDouble(nud.Value); }
                else if (active_number == 10 && price[10] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[10] * Convert.ToDouble(nud.Value); }
                else if (active_number == 11 && price[11] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[11] * Convert.ToDouble(nud.Value); }
                else if (active_number == 12 && price[12] * Convert.ToDouble(nud.Value) <= cash_value) { val = price[12] * Convert.ToDouble(nud.Value); }
                else nud.Value-= 1;

                lab_how_cost.Text = calculate(val);
            }
        }

        private void but_del_Click(object sender, EventArgs e)
        {
            var lines = tb_basket.Lines.ToList();
            count = tb_basket.Lines.Length - 1;
            if (count == 0) { }
            else 
            {
                lines.RemoveAt(count - 1);
                tb_basket.Lines = lines.ToArray();
                cash_value += last_buy[last_b - 1];
                last_b--;
                lab_purse_value.Text = calculate(cash_value);
                count--;
                if (count == 0) { but_buy.Focus(); but_del.Visible = false;  }
            }
            now_cv = 17000000000 - cash_value;
            lab_how_cost_total.Text = calculate(now_cv);
            pan_payment.Visible = false;
        }

        private void but_buy_total_Click(object sender, EventArgs e)
        {
            if (lab_how_cost_total.Text != "---" && lab_how_cost_total.Text != "0 ₽")
            {
                pan_payment.Visible = true;
                tb_numbers.Focus();
            }            
        }        



        private void tb_numbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) { key_count--; return; }
            if (e.KeyChar == 27) { this.tb_numbers.Text = ""; key_count = 0; return; }

            if (tb_numbers.Text.Length < 19)
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    key_count++;
                    if (key_count == 5)// || key_count == 10 || key_count == 15)
                    {
                        e.KeyChar = ' ';
                        key_count = 0;
                    }
                    return;
                }
                if (e.KeyChar == '.') e.Handled = true;
                if (e.KeyChar == ',') e.Handled = true;
                if (e.KeyChar == 8) { key_count--; return; }
                if (e.KeyChar == 27) { this.tb_numbers.Text = ""; key_count = 0; return; }
                e.Handled = true;

            }
            else
            { e.Handled = true; }
        }

        private void tb_ur_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >=65 && e.KeyChar <=90) return;
            if (e.KeyChar == 32) { return; }
            if (e.KeyChar == 8) { return; }
            if (e.KeyChar == 27) { this.tb_numbers.Text = ""; return; }

            e.Handled = true; 
        }        

        private void tb_date_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) { key_count2--; return; }
            if (e.KeyChar == 27) { this.tb_numbers.Text = ""; key_count2 = 0; return; }

            if (tb_date.Text.Length < 5)
            {
                if (e.KeyChar == 8) { key_count2--; return; }
                if (e.KeyChar == 27) { this.tb_numbers.Text = ""; key_count2 = 0; return; }


                if (key_count == 99 && Char.IsDigit(e.KeyChar))
                {
                    if (e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9') e.Handled = true;
                    else { key_count2++; key_count = 0;  return; }
                }

                if (Char.IsDigit(e.KeyChar))
                {
                    if (e.KeyChar == '.') e.Handled = true;
                    if (e.KeyChar == ',') e.Handled = true;

                    if (key_count2 == 2 )
                    {
                        e.KeyChar = '/';
                        key_count2++;
                        return;
                    }
                    if (key_count2 == 0 && e.KeyChar == '1') { key_count2++; key_count = 99; return; }
                    else if (key_count2 == 0 && e.KeyChar == '0') { key_count2++; return; }
                    else if (key_count2 == 0) e.Handled = true;

                    if (key_count2 == 1 || key_count2 == 3 || key_count2 == 4) { key_count2++; return; }

                }
                if (e.KeyChar == '.') e.Handled = true;
                if (e.KeyChar == ',') e.Handled = true;

                e.Handled = true;

            }
            else
            { e.Handled = true; }
        }

        private void tb_cvv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8) { key_count3--; return; }
            if (e.KeyChar == 27) { this.tb_numbers.Text = ""; key_count3 = 0; return; }

            if (key_count3 <= 2)
            {
                if (e.KeyChar == '.') e.Handled = true;
                if (e.KeyChar == ',') e.Handled = true;
                if (Char.IsDigit(e.KeyChar)) { key_count3++; return; }


                if (e.KeyChar == 8) { key_count3--; return; }
                if (e.KeyChar == 27) { this.tb_numbers.Text = ""; key_count3 = 0; return; }
                e.Handled = true;
            }
            else
            { e.Handled = true; }
        }

        private void but_end_Click(object sender, EventArgs e)
        {
            if (tb_numbers.Text.Length == 19 && tb_ur_name != null && tb_date.Text.Length == 5 && tb_cvv.Text.Length == 3)
            {
                MessageBox.Show(
                    "Спасибо за покупку (:",
                    "Покупка завершена!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.None
                    );

                this.Close();
            }
        }
    }
}



