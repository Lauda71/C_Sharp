using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osaGO
{
    public partial class Main_Form : Form
    {
        string s_Tb = "0", s_Kt = "0", s_Ko = "0", s_Kvc = "0", s_Km = "0", s_Kbm = "0";

        double Tb = 0, Kt = 0, Ko = 0, Kvc = 0, Km = 0, Kbm = 0;
        double final = 0;
        

        private void lb_Kbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_total.Text = "";

            if (lb_Kbm.SelectedIndex == -1)
            { }
            else
            {
                for (int i = 0; i < 15; i++)
                {
                    if (lb_Kbm.SelectedIndex == i)
                    {
                        s_Kbm = lb_Kbm.Text.Substring(50, lb_Kbm.Text.Length - 50);
                        Kbm = Convert.ToDouble(s_Kbm);

                        lab_tot.Text = Convert.ToString(Tb) + " × " + Convert.ToString(Kt) + " × " + Convert.ToString(Ko) + " × " + Convert.ToString(Kvc) + " × " + Convert.ToString(Km) + " × " + Convert.ToString(Kbm);

                        s_Kbm = "Класс до начала годовго срока страхования: " + lb_Kbm.Text.Substring(0, 2);
                        tb_inf.Text = s_Tb + Environment.NewLine + Environment.NewLine + s_Kt + Environment.NewLine + Environment.NewLine + s_Ko + Environment.NewLine + Environment.NewLine + s_Kvc + Environment.NewLine + Environment.NewLine + s_Km + Environment.NewLine + Environment.NewLine + s_Kbm + Environment.NewLine + Environment.NewLine;
                    }
                }
            }
        }

        private void lb_Km_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_total.Text = "";

            if (lb_Km.SelectedIndex == -1)
            { }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    if (lb_Km.SelectedIndex == i)
                    {
                        s_Km = lb_Km.Text.Substring(0, 3);
                        Km = Convert.ToDouble(s_Km);

                        lab_tot.Text = Convert.ToString(Tb) + " × " + Convert.ToString(Kt) + " × " + Convert.ToString(Ko) + " × " + Convert.ToString(Kvc) + " × " + Convert.ToString(Km) + " × " + Convert.ToString(Kbm);

                        s_Km = "Мощность двигателя: " + lb_Km.Text.Substring(6, lb_Km.Text.Length - 6);
                        tb_inf.Text = s_Tb + Environment.NewLine + Environment.NewLine + s_Kt + Environment.NewLine + Environment.NewLine + s_Ko + Environment.NewLine + Environment.NewLine + s_Kvc + Environment.NewLine + Environment.NewLine + s_Km + Environment.NewLine + Environment.NewLine + s_Kbm + Environment.NewLine + Environment.NewLine;
                    }
                }
            }
        }

        private void lb_Kvc_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_total.Text = "";

            if (lb_Kvc.SelectedIndex == -1)
            { }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (lb_Kvc.SelectedIndex == i)
                    {
                        s_Kvc = lb_Kvc.Text.Substring(0, 3);
                        Kvc = Convert.ToDouble(s_Kvc);

                        lab_tot.Text = Convert.ToString(Tb) + " × " + Convert.ToString(Kt) + " × " + Convert.ToString(Ko) + " × " + Convert.ToString(Kvc) + " × " + Convert.ToString(Km) + " × " + Convert.ToString(Kbm);

                        s_Kvc = "Возраст и стаж: " + lb_Kvc.Text.Substring(6, lb_Kvc.Text.Length - 6);
                        tb_inf.Text = s_Tb + Environment.NewLine + Environment.NewLine + s_Kt + Environment.NewLine + Environment.NewLine + s_Ko + Environment.NewLine + Environment.NewLine + s_Kvc + Environment.NewLine + Environment.NewLine + s_Km + Environment.NewLine + Environment.NewLine + s_Kbm + Environment.NewLine + Environment.NewLine;
                    }
                }
            }
        }

        public Main_Form()
        {
            InitializeComponent();
        }
        

        private void lb_Ko_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_total.Text = "";

            if (lb_Ko.SelectedIndex == -1)
            { }
            else if (lb_Ko.SelectedIndex == 0)
            {
                Ko = 1.0;
                s_Ko = "Количество водителей: Ограничено";
                Kvc = 0;
                lb_Kvc.Enabled = true;

                lab_tot.Text = Convert.ToString(Tb) + " × " + Convert.ToString(Kt) + " × " + Convert.ToString(Ko) + " × " + Convert.ToString(Kvc) + " × " + Convert.ToString(Km) + " × " + Convert.ToString(Kbm);
                tb_inf.Text = s_Tb + Environment.NewLine + Environment.NewLine + s_Kt + Environment.NewLine + Environment.NewLine + s_Ko + Environment.NewLine + Environment.NewLine + s_Kvc + Environment.NewLine + Environment.NewLine + s_Km + Environment.NewLine + Environment.NewLine + s_Kbm + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                Ko = 1.8;
                s_Ko = "Количество водителей: Не ограничено";
                Kvc = 1;
                lb_Kvc.Enabled = false;
                s_Kvc = "0";
                lab_tot.Text = Convert.ToString(Tb) + " × " + Convert.ToString(Kt) + " × " + Convert.ToString(Ko) + " × " + Convert.ToString(Kvc) + " × " + Convert.ToString(Km) + " × " + Convert.ToString(Kbm);
                tb_inf.Text = s_Tb + Environment.NewLine + Environment.NewLine + s_Kt + Environment.NewLine + Environment.NewLine + s_Ko + Environment.NewLine + Environment.NewLine + s_Kvc + Environment.NewLine + Environment.NewLine + s_Km + Environment.NewLine + Environment.NewLine + s_Kbm + Environment.NewLine + Environment.NewLine;
            }
        }        

        private void lb_Kt_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_total.Text = "";

            if (lb_Kt.SelectedIndex == -1)
            { }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (lb_Kt.SelectedIndex == i)
                    {
                        if (lb_Tb.SelectedIndex == 12)
                        {
                            s_Kt = lb_Kt.Text.Substring(13, 3);
                            Kt = Convert.ToDouble(s_Kt);
                        }
                        else
                        {
                            s_Kt = lb_Kt.Text.Substring(0, 3);
                            Kt = Convert.ToDouble(s_Kt);
                        }
                        

                        lab_tot.Text = Convert.ToString(Tb) + " × " + Convert.ToString(Kt) + " × " + Convert.ToString(Ko) + " × " + Convert.ToString(Kvc) + " × " + Convert.ToString(Km) + " × " + Convert.ToString(Kbm);

                        s_Kt = "Выбранный Город: " + lb_Kt.Text.Substring(24, lb_Kt.Text.Length - 24);
                        tb_inf.Text = s_Tb + Environment.NewLine + Environment.NewLine + s_Kt + Environment.NewLine + Environment.NewLine + s_Ko + Environment.NewLine + Environment.NewLine + s_Kvc + Environment.NewLine + Environment.NewLine + s_Km + Environment.NewLine + Environment.NewLine + s_Kbm + Environment.NewLine + Environment.NewLine;
                    }
                }
            }
        }

        private void lb_Tb_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_total.Text = "";

            if (lb_Tb.SelectedIndex == -1)
            { }
            else
            {
                for (int i = 0; i < 14; i++)
                {
                    if (lb_Tb.SelectedIndex == i)
                    {
                        s_Tb = lb_Tb.Text.Substring(21, 4);
                        Tb = Convert.ToDouble(s_Tb);

                        lab_tot.Text = Convert.ToString(Tb) + " × " + Convert.ToString(Kt) + " × " + Convert.ToString(Ko) + " × " + Convert.ToString(Kvc) + " × " + Convert.ToString(Km) + " × " + Convert.ToString(Kbm);

                        s_Tb = "Выбранное ТС: " + lb_Tb.Text.Substring(37, lb_Tb.Text.Length-37);
                        tb_inf.Text = s_Tb + Environment.NewLine + Environment.NewLine + s_Kt + Environment.NewLine + Environment.NewLine + s_Ko + Environment.NewLine + Environment.NewLine + s_Kvc + Environment.NewLine + Environment.NewLine + s_Km + Environment.NewLine + Environment.NewLine + s_Kbm + Environment.NewLine + Environment.NewLine;
                    }
                }
            }
        }

        private void but_GO_Click(object sender, EventArgs e)
        {
            if (lb_Tb.SelectedIndex == -1 || lb_Kt.SelectedIndex == -1 || lb_Ko.SelectedIndex == -1 || lb_Kvc.SelectedIndex == -1 || lb_Km.SelectedIndex == -1 || lb_Kbm.SelectedIndex == -1)
            { }
            else
            {
                final = Tb * Kt * Ko * Kvc * Km * Kbm;
                tb_total.Text = Convert.ToString(final) + " ₽";
            }
        }
    }
}
