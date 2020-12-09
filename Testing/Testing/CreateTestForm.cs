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

namespace Testing
{
    public partial class CreateTestForm : Form
    {
        public CreateTestForm()
        {
            InitializeComponent();
        }


        
        private void CreateTestForm_Load(object sender, EventArgs e)
        {
            if (GlobalClass.IcameHereToSaveTheTest)
            {
                GlobalClass.EditTableMode = true;

                for (int i = 1; i <= QClass.localQT.Count; i++)
                {
                    countQ++;
                    string count = "";
                    if (i <= 9) count = "0" + Convert.ToString(i);
                    else count = "";
                    lbQ.Items.Add(Convert.ToString(count + " " + QClass.localQT.ElementAt(i-1)));
                }

                GlobalClass.IcameHereToSaveTheTest = false;
            }

            if (lbQ.Items.Count < 1) butDelQ.Enabled = false;

            rbOne.Checked = true;
            tslDate.Text = DateTime.Now.ToShortDateString();
            tbQ.Visible = false;
            panAnswers.Visible = false;

            timerButAddStop.Interval = 1000;
            

            this.BackColor = Color.FromName(GlobalClass.mainBackColor);
            this.ForeColor = Color.FromName(GlobalClass.mainForeColor);

            tbQ.BackColor = Color.FromName(GlobalClass.mainBackColor);
            tbQ.ForeColor = Color.FromName(GlobalClass.mainForeColor);

            lbQ.BackColor = Color.FromName(GlobalClass.mainBackColor);
            lbQ.ForeColor = Color.FromName(GlobalClass.mainForeColor);
            
            int[] varAns = { 4, 3, 2 };
            for (int i = 0; i < varAns.Length; i++)
            {
                DUDAnswers.Items.Add(varAns[i]);
            }
            DUDAnswers.Text = "4";

            pb.Click += new EventHandler(this.pbClick);
        }




        private void rbPic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPic.Checked)
            {
                rbPicOne.Checked = true;
                panQQ.Enabled = true;
            }
            else
            {
                rbPicOne.Checked = false;
                rbPicFew.Checked = false;
                rbPicConform.Checked = false;
                rbPicNumberInput.Checked = false;
                rbPicWordInput.Checked = false;

                panQQ.Enabled = false;
            }
        }



        bool picChanged = false;
        // Изменение картинки
        private void pbClick(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";

            if (opfd.ShowDialog(this) == DialogResult.OK)
            {
                //pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = Image.FromFile(opfd.FileName);
                pb.Height = 302;
                pb.Width = 358;
                pb.Left = 476;
                pb.Top = 0;
                this.Controls.Add(pb);
                //GlobalClass.pbAdd(this, 473, 0, 419, 302, opfd);

                PictureFile = opfd.FileName;
                picChanged = true;
            }
            else
            {

            }
        }



        bool exit = false;
        int deeper = 0;
        PictureBox pb = new PictureBox();        
        bool pic = false;
        int countQ = 1;
        bool automaticSwitchingInlbQ = true;
        bool qAlreadySaved = false;

        //  butAddQ
        private void butAddQ_Click(object sender, EventArgs e)
        {
            firstTimeChange = true;

            //qType

            if (countQ > 1 && tbQ.Visible == true && panAnswers.Visible == true)
            {
                // проверки на корректность вопрсоа
                if (tbQ.Text == "")
                {
                    MessageBox.Show("Не указан текст вопроса!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (panAnswers.Controls.Count == 1)
                {
                    
                    panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                        if (tb.Text == "") {
                            MessageBox.Show("Не указан текст ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            exit = true;
                            return;
                        }

                        
                        char[] arr = tb.Text.ToCharArray();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] == '+' || arr[i] == '-' || arr[i] == ';')
                            {
                                catchingError = false;
                                lbQ.SelectedIndex = lastIndex;
                                exit = true;
                                MessageBox.Show("Введен недопустимый символ ('+', '-' или ';')!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        
                    });

                    if (exit)
                    {
                        exit = false;
                        return;
                    }

                    string qqttyyppee = Convert.ToString(lbQ.Items[lbQ.Items.Count - 1]);
                    qqttyyppee = qqttyyppee.Remove(0, qqttyyppee.Length - 1);
                    if (qqttyyppee == "Ч")
                    {
                        double num;
                        string numm = "";
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            numm = tb.Text;
                        });

                        try
                        {
                            num = Convert.ToDouble(numm);
                        }
                        catch
                        {
                            MessageBox.Show("Не корректно указан текст ответа [введите число]!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                }
                else if(panAnswers.Controls.Count > 1)
                {
                    int cbChecked = 0, rbChecked = 0, tbClear = 0;
                    int countrb = 0, countcb = 0, countTB = 0;

                    string[] sameString = new string[8];
                    int sameStringCount = 0;
                    panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                        if (tb.Text == "") { tbClear++; }
                        countTB++;

                        sameString[sameStringCount] = tb.Text;
                        sameStringCount++;

                        char[] arr = tb.Text.ToCharArray();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] == '+' || arr[i] == '-' || arr[i] == ';')
                            {
                                catchingError = false;
                                lbQ.SelectedIndex = lastIndex;
                                exit = true;
                                MessageBox.Show("Введен недопустимый символ ('+', '-' или ';')!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        if (exit) return;
                    });
                    if (tbClear != 0)
                    {
                        MessageBox.Show("Не указан текст ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (exit)
                    {
                        exit = false;
                        return;
                    }

                    for (int i = 0; i < sameString.Count() - 1; i++)
                    {
                        for (int n = 0; n < sameString.Count() - 1; n++)
                        {
                            if (i == n)
                            {
                            }
                            else if(sameString[i] == null)
                            { }
                            else if (sameString[i] == sameString[n])
                            {
                                MessageBox.Show("Несколько одинаковых ответов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                //exit = true;
                                return;
                            }

                            if (exit) return;
                        }
                        if (exit) return;
                    }

                    if (exit)
                    {
                        exit = false;
                        return;
                    }

                    panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(chbox =>
                    {
                        if (chbox.Checked == true) { cbChecked++; }
                        countcb++;
                    });                    
                    if (countcb == 0)
                    {
                        // нет выбранных cb
                    }
                    else if (cbChecked < 2)
                    {
                        MessageBox.Show("Выбрано мало правильных вариантов ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                    {
                        if (rb.Checked == true) { rbChecked++; }
                        countrb++;
                    });
                    if (countrb == 0)
                    {
                        // нет выбранных rb
                    }
                    else if (rbChecked != 1)
                    {
                        MessageBox.Show("Не выбран правильный вариант ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                butDelQ.Enabled = true;

                if (lbQ.SelectedIndex != lbQ.Items.Count - 1)
                {                    

                    qType = AllSelectedQ.ElementAt(AllSelectedQ.Count - 1);
                    // сохранение вопроса
                    if (qType == "О")
                    {
                        string qquestion = "", aanswers = "", rrb = "";
                        int qqNumber;

                        int countRB = 1;
                        int countTB = 1;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                        {
                            if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                            else { countRB++; }
                        });

                        // Добавление текста ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            countTB++;
                            aanswers += tb.Text + ";";
                        });

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, lastIndex, "none");
                    }
                    else if (qType == "Н")
                    {
                        string qquestion = "", aanswers = "";
                        int[] ccb = { 0, 0, 0, 0 };
                        int qqNumber;

                        int countCB = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                        {
                            if (cb.Checked == true) { ccb[countCB] = 1; }
                            else { }
                            countCB++;
                        });

                        countCB = 0;
                        // Добавление ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            if (ccb[countCB] == 1) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            aanswers += tb.Text + ";";
                            countCB++;
                        });

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "В")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber, ccount = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                            else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                        });
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "Ч")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = lastIndex; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "С")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = lastIndex; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                    }

                    // сохранение вопроса с картинкой
                    else if (qType == "КО")
                    {
                        string qquestion = "", aanswers = "", rrb = "";
                        int qqNumber;

                        int countRB = 1;
                        int countTB = 1;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                        {
                            if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                            else { countRB++; }
                        });

                        // Добавление текста ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            countTB++;
                            aanswers += tb.Text + ";";
                        });

                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КН")
                    {
                        string qquestion = "", aanswers = "";
                        int[] ccb = { 0, 0, 0, 0 };
                        int qqNumber;

                        int countCB = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                        {
                            if (cb.Checked == true) { ccb[countCB] = 1; }
                            else { }
                            countCB++;
                        });

                        countCB = 0;
                        // Добавление ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            if (ccb[countCB] == 1) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            aanswers += tb.Text + ";";
                            countCB++;
                        });

                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КВ")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber, ccount = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                            else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                        });

                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КЧ")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = lastIndex; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КС")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = lastIndex; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                }
                else
                {
                    if(qAlreadySaved) // tr tl
                    {
                        qType = AllSelectedQ.ElementAt(AllSelectedQ.Count - 1);

                        // сохранение вопроса
                        if (qType == "О")
                        {
                            string qquestion = "", aanswers = "", rrb = "";
                            int qqNumber;

                            int countRB = 1;
                            int countTB = 1;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                            {
                                if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                else { countRB++; }
                            });

                            // Добавление текста ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                countTB++;
                                aanswers += tb.Text + ";";
                            });

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, lastIndex, "none");
                        }
                        else if (qType == "Н")
                        {
                            string qquestion = "", aanswers = "";
                            int[] ccb = { 0, 0, 0, 0 };
                            int qqNumber;

                            int countCB = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                            {
                                if (cb.Checked == true) { ccb[countCB] = 1; }
                                else { }
                                countCB++;
                            });

                            countCB = 0;
                            // Добавление ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccb[countCB] == 1) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                aanswers += tb.Text + ";";
                                countCB++;
                            });

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "В")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber, ccount = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                            });
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "Ч")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = lastIndex; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text.Trim().ToLower();
                            });
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "С")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = lastIndex; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text.Trim().ToLower();
                            });
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                        }

                        // сохранение вопроса с картинкой
                        else if (qType == "КО")
                        {
                            string qquestion = "", aanswers = "", rrb = "";
                            int qqNumber;

                            int countRB = 1;
                            int countTB = 1;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                            {
                                if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                else { countRB++; }
                            });

                            // Добавление текста ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                countTB++;
                                aanswers += tb.Text + ";";
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КН")
                        {
                            string qquestion = "", aanswers = "";
                            int[] ccb = { 0, 0, 0, 0 };
                            int qqNumber;

                            int countCB = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                            {
                                if (cb.Checked == true) { ccb[countCB] = 1; }
                                else { }
                                countCB++;
                            });

                            countCB = 0;
                            // Добавление ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccb[countCB] == 1) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                aanswers += tb.Text + ";";
                                countCB++;
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КВ")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber, ccount = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КЧ")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = lastIndex; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text.Trim().ToLower();
                            });
                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КС")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = lastIndex; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text.Trim().ToLower();
                            });
                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }

                        qAlreadySaved = false;
                    }
                    else// tr tl
                    {
                        // сохранение вопроса
                        if (qType == "О")
                        {
                            string qquestion = "", aanswers = "", rrb = "";
                            int qqNumber;

                            int countRB = 1;
                            int countTB = 1;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = countQ - 2; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                            {
                                if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                else { countRB++; }
                            });

                            // Добавление текста ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                countTB++;
                                aanswers += tb.Text + ";";
                            });

                            // добавление в коллекцию
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "Н")
                        {
                            string qquestion = "", aanswers = "";
                            int[] ccb = { 0, 0, 0, 0 };
                            int qqNumber;

                            int countCB = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = countQ - 2; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                            {
                                if (cb.Checked == true) { ccb[countCB] = 1; }
                                else { }
                                countCB++;
                            });

                            countCB = 0;
                            // Добавление ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccb[countCB] == 1) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                aanswers += tb.Text + ";";
                                countCB++;
                            });

                            // добавление в коллекцию
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "В")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber, ccount = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = countQ - 2; // Номер вопроса

                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                            });
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "Ч")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = countQ - 2; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text.Trim().ToLower();
                            });
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "С")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = countQ - 2; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text.Trim().ToLower();
                            });
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                        }

                        // сохранение вопроса с картинкой
                        else if (qType == "КО")
                        {
                            string qquestion = "", aanswers = "", rrb = "";
                            int qqNumber;

                            int countRB = 1;
                            int countTB = 1;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = countQ - 2; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                            {
                                if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                else { countRB++; }
                            });

                            // Добавление текста ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                countTB++;
                                aanswers += tb.Text + ";";
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КН")
                        {
                            string qquestion = "", aanswers = "";
                            int[] ccb = { 0, 0, 0, 0 };
                            int qqNumber;

                            int countCB = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = countQ - 2; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                            {
                                if (cb.Checked == true) { ccb[countCB] = 1; }
                                else { }
                                countCB++;
                            });

                            countCB = 0;
                            // Добавление ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccb[countCB] == 1) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                aanswers += tb.Text + ";";
                                countCB++;
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КВ")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber, ccount = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = countQ - 2; // Номер вопроса

                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КЧ")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = countQ - 2; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text.Trim().ToLower();
                            });
                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КС")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = countQ - 2; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text.Trim().ToLower();
                            });
                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }

                        //qAlreadySaved = true;
                    }
                    
                }

            }
            butDelQ.Enabled = true;

            tbQ.Visible = true;
            panAnswers.Visible = true;

            AnsAmount = 0;

            panAnswers.Controls.Clear();

            if (pic)
            {
                //pb = null;
                this.Controls.Remove(pb);
                pic = false;
            }

            tbQ.Height = 151;
            tbQ.Width = 721;

            panAnswers.Height = 454;
            panAnswers.Top = 154;

            if (rbOne.Checked)
            {
                qType = "О";
                deeper = 0;
                for (int i = 0; i < Convert.ToInt32(DUDAnswers.Text); i++)
                {
                    AnsAmount++;
                    GlobalClass.rbAdd(panAnswers, 40, 35 + deeper, 14, 13);
                    GlobalClass.tbAdd(panAnswers, 66, 30 + deeper, 629, 71);
                    deeper += 111;
                }
                if(countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  О");
                else lbQ.Items.Add(Convert.ToString(countQ) + "  О");
                //AllQTypes.Add("О");
            }
            else if (rbFew.Checked)
            {
                qType = "Н";
                deeper = 0;
                for (int i = 0; i < Convert.ToInt32(DUDAnswers.Text); i++)
                {
                    AnsAmount++;
                    GlobalClass.cbAdd(panAnswers, 40, 35 + deeper, 15, 14);
                    GlobalClass.tbAdd(panAnswers, 66, 30 + deeper, 629, 71);
                    deeper += 111;
                }
                if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  Н");
                else lbQ.Items.Add(Convert.ToString(countQ) + "  Н");
                //AllQTypes.Add("Н");
            }
            else if (rbConform.Checked)
            {
                //GlobalClass.tbAdd(panAnswers, 66, 30, 295, 71);
                //GlobalClass.tbAdd(panAnswers, 400, 30, 295, 71);
                qType = "В";
                deeper = 0;

                for (int i = 0; i < Convert.ToInt32(DUDAnswers.Text); i++)
                {
                    AnsAmount++;
                    GlobalClass.tbAdd(panAnswers, 66, 30 + deeper, 295, 71);
                    GlobalClass.tbAdd(panAnswers, 400, 30 + deeper, 295, 71);
                    deeper += 111;
                }


                if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  В");
                else lbQ.Items.Add(Convert.ToString(countQ) + "  В");
                //AllQTypes.Add("В");
            }
            else if (rbNumberInput.Checked)
            {
                AnsAmount++;
                qType = "Ч";
                GlobalClass.tbAdd(panAnswers, 66, 30, 629, 71); // ввод числа
                if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  Ч");
                else lbQ.Items.Add(Convert.ToString(countQ) + "  Ч");
                //AllQTypes.Add("Ч");
            }
            else if (rbWordInput.Checked)
            {
                AnsAmount++;
                qType = "С";
                GlobalClass.tbAdd(panAnswers, 66, 30, 629, 71); // ввод слова
                if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  С");
                else lbQ.Items.Add(Convert.ToString(countQ) + "  С");
                //AllQTypes.Add("С");
            }
            else if (rbPic.Checked)
            {
                pic = true;
                //GlobalClass.tbAdd(CreateTestForm.ActiveForm, 113, 0, 419, 302);
                tbQ.Height = 302;
                tbQ.Width = 360;

                panAnswers.Height = 302;
                panAnswers.Top = 306;

                OpenFileDialog opfd = new OpenFileDialog();
                opfd.Filter = "Файлы изображений (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";

                if (opfd.ShowDialog(this) == DialogResult.OK)
                {
                    //pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = Image.FromFile(opfd.FileName);
                    pb.Height = 302;
                    pb.Width = 358;
                    pb.Left = 476;
                    pb.Top = 0;
                    this.Controls.Add(pb);
                    //GlobalClass.pbAdd(this, 473, 0, 419, 302, opfd);

                    PictureFile = opfd.FileName;
                }
                else
                {
                    PictureFile = "";
                    //countQ--;
                    //lbQ.Items.RemoveAt(countQ - 1);
                    //lbQ.Items.RemoveAt(lbQ.Items.Count - 1);

                    tbQ.Text = "";
                    tbQ.Visible = false;

                    panAnswers.Controls.Clear();
                    panAnswers.Visible = false;

                    this.Controls.Remove(pb);
                    pic = false;

                    return;
                }
                               
                if (rbPicOne.Checked)
                {
                    qType = "КО";
                    deeper = 0;
                    for (int i = 0; i < Convert.ToInt32(DUDAnswers.Text); i++)
                    {
                        AnsAmount++;
                        GlobalClass.rbAdd(panAnswers, 40, 35 + deeper, 14, 13);
                        GlobalClass.tbAdd(panAnswers, 66, 30 + deeper, 629, 71);
                        deeper += 111;
                    }

                    if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  КО");
                    else lbQ.Items.Add(Convert.ToString(countQ) + "  КО");
                    //AllQTypes.Add("КО");
                }
                else if (rbPicFew.Checked)
                {
                    qType = "КН";
                    deeper = 0;
                    for (int i = 0; i < Convert.ToInt32(DUDAnswers.Text); i++)
                    {
                        AnsAmount++;
                        GlobalClass.cbAdd(panAnswers, 40, 35 + deeper, 15, 14);
                        GlobalClass.tbAdd(panAnswers, 66, 30 + deeper, 629, 71);
                        deeper += 111;
                    }

                    if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  КН");
                    else lbQ.Items.Add(Convert.ToString(countQ) + "  КН");
                    //AllQTypes.Add("КН");
                }
                else if (rbPicConform.Checked)
                {
                    qType = "КВ";
                    deeper = 0;
                    for (int i = 0; i < Convert.ToInt32(DUDAnswers.Text); i++)
                    {
                        AnsAmount++;
                        GlobalClass.tbAdd(panAnswers, 66, 30 + deeper, 295, 71);
                        GlobalClass.tbAdd(panAnswers, 400, 30 + deeper, 295, 71);
                        deeper += 111;
                    }

                    if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  КВ");
                    else lbQ.Items.Add(Convert.ToString(countQ) + "  КВ");
                    //AllQTypes.Add("КВ");
                }
                else if (rbPicNumberInput.Checked)
                {
                    qType = "КЧ";
                    GlobalClass.tbAdd(panAnswers, 66, 30, 629, 71); // ввод числа

                    if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  КЧ");
                    else lbQ.Items.Add(Convert.ToString(countQ) + "  КЧ");
                    //AllQTypes.Add("КЧ");
                }
                else if (rbPicWordInput.Checked)
                {
                    qType = "КС";
                    GlobalClass.tbAdd(panAnswers, 66, 30, 629, 71); // ввод слова

                    if (countQ <= 9) lbQ.Items.Add("0" + Convert.ToString(countQ) + "  КС");
                    else lbQ.Items.Add(Convert.ToString(countQ) + "  КС");
                    //AllQTypes.Add("КС");
                }

                

            }
            firstTimeChange = true;
            countQ++;
            tbQ.Text = "";
            automaticSwitchingInlbQ = true;            
            lbQ.SelectedIndex = lbQ.Items.Count - 1;
        } // aaaaaaaaaaa
        string PictureFile = ""; 
        

        bool firstTime = true;
        private void tsbSave_Click(object sender, EventArgs e)
        {

            //if (countQ > 1)
            //{
            //    if (firstTime)
            //    {
            //        QClass.save = true;
            //        SaveTestForm frm = new SaveTestForm();
            //        frm.ShowDialog();
            //    }
            //    else MessageBox.Show("Тест сохранен (нет)", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else MessageBox.Show("Так мало вопросов (и еще меньше ответов)..", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }




        private void tsbSaveAndExit_Click(object sender, EventArgs e)
        {
            if (countQ > 1)
            {
                if (firstTime)
                {

                    // проверка финального вопроса 
                    if (tbQ.Text == "")
                    {
                        MessageBox.Show("Не указан текст вопроса!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (panAnswers.Controls.Count == 1)
                    {

                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            if (tb.Text == "")
                            {
                                MessageBox.Show("Не указан текст ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                exit = true;
                                return;
                            }


                            char[] arr = tb.Text.ToCharArray();
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] == '+' || arr[i] == '-' || arr[i] == ';')
                                {
                                    catchingError = false;
                                    lbQ.SelectedIndex = lastIndex;
                                    exit = true;
                                    MessageBox.Show("Введен недопустимый символ ('+', '-' или ';')!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }

                        });

                        if (exit)
                        {
                            exit = false;
                            return;
                        }

                        string qqttyyppee = Convert.ToString(lbQ.Items[lbQ.Items.Count - 1]);
                        qqttyyppee = qqttyyppee.Remove(0, qqttyyppee.Length - 1);
                        if (qqttyyppee == "Ч")
                        {
                            double num;
                            string numm = "";
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                numm = tb.Text;
                            });

                            try
                            {
                                num = Convert.ToDouble(numm);
                            }
                            catch
                            {
                                MessageBox.Show("Не корректно указан текст ответа [введите число]!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                    }
                    else if (panAnswers.Controls.Count > 1)
                    {
                        int cbChecked = 0, rbChecked = 0, tbClear = 0;
                        int countrb = 0, countcb = 0, countTB = 0;

                        string[] sameString = new string[8];
                        int sameStringCount = 0;
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                            if (tb.Text == "") { tbClear++; }
                            countTB++;

                            sameString[sameStringCount] = tb.Text;
                            sameStringCount++;

                            char[] arr = tb.Text.ToCharArray();
                            for (int i = 0; i < arr.Length; i++)
                            {
                                if (arr[i] == '+' || arr[i] == '-' || arr[i] == ';')
                                {
                                    catchingError = false;
                                    lbQ.SelectedIndex = lastIndex;
                                    exit = true;
                                    MessageBox.Show("Введен недопустимый символ ('+', '-' или ';')!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            if (exit) return;
                        });
                        if (tbClear != 0)
                        {
                            MessageBox.Show("Не указан текст ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (exit)
                        {
                            exit = false;
                            return;
                        }

                        for (int i = 0; i < sameString.Count() - 1; i++)
                        {
                            for (int n = 0; n < sameString.Count() - 1; n++)
                            {
                                if (i == n)
                                {
                                }
                                else if (sameString[i] == null)
                                { }
                                else if (sameString[i] == sameString[n])
                                {
                                    MessageBox.Show("Несколько одинаковых ответов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    //exit = true;
                                    return;
                                }

                                if (exit) return;
                            }
                            if (exit) return;
                        }

                        if (exit)
                        {
                            exit = false;
                            return;
                        }

                        panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(chbox =>
                        {
                            if (chbox.Checked == true) { cbChecked++; }
                            countcb++;
                        });
                        if (countcb == 0)
                        {
                            // нет выбранных cb
                        }
                        else if (cbChecked < 2)
                        {
                            MessageBox.Show("Выбрано мало правильных вариантов ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }


                        panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                        {
                            if (rb.Checked == true) { rbChecked++; }
                            countrb++;
                        });
                        if (countrb == 0)
                        {
                            // нет выбранных rb
                        }
                        else if (rbChecked != 1)
                        {
                            MessageBox.Show("Не выбран правильный вариант ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    butDelQ.Enabled = true;

                    // сохранение финального вопроса
                    if (lbQ.SelectedIndex != lbQ.Items.Count - 1)
                    {

                        qType = AllSelectedQ.ElementAt(AllSelectedQ.Count - 1);
                        // сохранение вопроса
                        if (qType == "О")
                        {
                            string qquestion = "", aanswers = "", rrb = "";
                            int qqNumber;

                            int countRB = 1;
                            int countTB = 1;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                            {
                                if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                else { countRB++; }
                            });

                            // Добавление текста ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                countTB++;
                                aanswers += tb.Text + ";";
                            });

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, lastIndex, "none");
                        }
                        else if (qType == "Н")
                        {
                            string qquestion = "", aanswers = "";
                            int[] ccb = { 0, 0, 0, 0 };
                            int qqNumber;

                            int countCB = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                            {
                                if (cb.Checked == true) { ccb[countCB] = 1; }
                                else { }
                                countCB++;
                            });

                            countCB = 0;
                            // Добавление ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccb[countCB] == 1) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                aanswers += tb.Text + ";";
                                countCB++;
                            });

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "В")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber, ccount = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                            });
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "Ч")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = lastIndex; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text;
                            });
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                        }
                        else if (qType == "С")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = lastIndex; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text;
                            });
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                        }

                        // сохранение вопроса с картинкой
                        else if (qType == "КО")
                        {
                            string qquestion = "", aanswers = "", rrb = "";
                            int qqNumber;

                            int countRB = 1;
                            int countTB = 1;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                            {
                                if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                else { countRB++; }
                            });

                            // Добавление текста ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                countTB++;
                                aanswers += tb.Text + ";";
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КН")
                        {
                            string qquestion = "", aanswers = "";
                            int[] ccb = { 0, 0, 0, 0 };
                            int qqNumber;

                            int countCB = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            // Какой из RB отмечен
                            panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                            {
                                if (cb.Checked == true) { ccb[countCB] = 1; }
                                else { }
                                countCB++;
                            });

                            countCB = 0;
                            // Добавление ответов с указанием правильного или неправильного
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccb[countCB] == 1) { aanswers += "+"; }
                                else { aanswers += "-"; }
                                aanswers += tb.Text + ";";
                                countCB++;
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КВ")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber, ccount = 0;

                            qquestion = tbQ.Text; // Текст вопроса

                            qqNumber = lastIndex; // Номер вопроса

                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                            });

                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КЧ")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = lastIndex; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text;
                            });
                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                        else if (qType == "КС")
                        {
                            string qquestion = "", aanswers = "";
                            int qqNumber;

                            qquestion = tbQ.Text; // Текст вопроса
                            qqNumber = lastIndex; // Номер вопроса
                            panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                aanswers += tb.Text;
                            });
                            string picPath = PictureFile;

                            // добавление в коллекцию
                            QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                        }
                    }
                    else
                    {
                        if (qAlreadySaved)
                        {
                            qType = AllSelectedQ.ElementAt(AllSelectedQ.Count - 1);

                            // сохранение вопроса
                            if (qType == "О")
                            {
                                string qquestion = "", aanswers = "", rrb = "";
                                int qqNumber;

                                int countRB = 1;
                                int countTB = 1;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = lastIndex; // Номер вопроса

                                // Какой из RB отмечен
                                panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                                {
                                    if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                    else { countRB++; }
                                });

                                // Добавление текста ответов с указанием правильного или неправильного
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                    else { aanswers += "-"; }
                                    countTB++;
                                    aanswers += tb.Text + ";";
                                });

                                // добавление в коллекцию
                                QClass.ChangeQ(aanswers, qquestion, qType, lastIndex, "none");
                            }
                            else if (qType == "Н")
                            {
                                string qquestion = "", aanswers = "";
                                int[] ccb = { 0, 0, 0, 0 };
                                int qqNumber;

                                int countCB = 0;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = lastIndex; // Номер вопроса

                                // Какой из RB отмечен
                                panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                                {
                                    if (cb.Checked == true) { ccb[countCB] = 1; }
                                    else { }
                                    countCB++;
                                });

                                countCB = 0;
                                // Добавление ответов с указанием правильного или неправильного
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (ccb[countCB] == 1) { aanswers += "+"; }
                                    else { aanswers += "-"; }
                                    aanswers += tb.Text + ";";
                                    countCB++;
                                });

                                // добавление в коллекцию
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                            }
                            else if (qType == "В")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber, ccount = 0;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = lastIndex; // Номер вопроса

                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                    else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                                });
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                            }
                            else if (qType == "Ч")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber;

                                qquestion = tbQ.Text; // Текст вопроса
                                qqNumber = lastIndex; // Номер вопроса
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    aanswers += tb.Text;
                                });
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                            }
                            else if (qType == "С")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber;

                                qquestion = tbQ.Text; // Текст вопроса
                                qqNumber = lastIndex; // Номер вопроса
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    aanswers += tb.Text;
                                });
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                            }

                            // сохранение вопроса с картинкой
                            else if (qType == "КО")
                            {
                                string qquestion = "", aanswers = "", rrb = "";
                                int qqNumber;

                                int countRB = 1;
                                int countTB = 1;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = lastIndex; // Номер вопроса

                                // Какой из RB отмечен
                                panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                                {
                                    if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                    else { countRB++; }
                                });

                                // Добавление текста ответов с указанием правильного или неправильного
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                    else { aanswers += "-"; }
                                    countTB++;
                                    aanswers += tb.Text + ";";
                                });

                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }
                            else if (qType == "КН")
                            {
                                string qquestion = "", aanswers = "";
                                int[] ccb = { 0, 0, 0, 0 };
                                int qqNumber;

                                int countCB = 0;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = lastIndex; // Номер вопроса

                                // Какой из RB отмечен
                                panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                                {
                                    if (cb.Checked == true) { ccb[countCB] = 1; }
                                    else { }
                                    countCB++;
                                });

                                countCB = 0;
                                // Добавление ответов с указанием правильного или неправильного
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (ccb[countCB] == 1) { aanswers += "+"; }
                                    else { aanswers += "-"; }
                                    aanswers += tb.Text + ";";
                                    countCB++;
                                });

                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }
                            else if (qType == "КВ")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber, ccount = 0;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = lastIndex; // Номер вопроса

                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                    else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                                });

                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }
                            else if (qType == "КЧ")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber;

                                qquestion = tbQ.Text; // Текст вопроса
                                qqNumber = lastIndex; // Номер вопроса
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    aanswers += tb.Text;
                                });
                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }
                            else if (qType == "КС")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber;

                                qquestion = tbQ.Text; // Текст вопроса
                                qqNumber = lastIndex; // Номер вопроса
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    aanswers += tb.Text;
                                });
                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }

                            qAlreadySaved = false;
                        }
                        else
                        {
                            // сохранение вопроса
                            if (qType == "О")
                            {
                                string qquestion = "", aanswers = "", rrb = "";
                                int qqNumber;

                                int countRB = 1;
                                int countTB = 1;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = countQ - 2; // Номер вопроса

                                // Какой из RB отмечен
                                panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                                {
                                    if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                    else { countRB++; }
                                });

                                // Добавление текста ответов с указанием правильного или неправильного
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                    else { aanswers += "-"; }
                                    countTB++;
                                    aanswers += tb.Text + ";";
                                });

                                // добавление в коллекцию
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                            }
                            else if (qType == "Н")
                            {
                                string qquestion = "", aanswers = "";
                                int[] ccb = { 0, 0, 0, 0 };
                                int qqNumber;

                                int countCB = 0;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = countQ - 2; // Номер вопроса

                                // Какой из RB отмечен
                                panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                                {
                                    if (cb.Checked == true) { ccb[countCB] = 1; }
                                    else { }
                                    countCB++;
                                });

                                countCB = 0;
                                // Добавление ответов с указанием правильного или неправильного
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (ccb[countCB] == 1) { aanswers += "+"; }
                                    else { aanswers += "-"; }
                                    aanswers += tb.Text + ";";
                                    countCB++;
                                });

                                // добавление в коллекцию
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                            }
                            else if (qType == "В")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber, ccount = 0;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = countQ - 2; // Номер вопроса

                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                    else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                                });
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                            }
                            else if (qType == "Ч")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber;

                                qquestion = tbQ.Text; // Текст вопроса
                                qqNumber = countQ - 2; // Номер вопроса
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    aanswers += tb.Text;
                                });
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                            }
                            else if (qType == "С")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber;

                                qquestion = tbQ.Text; // Текст вопроса
                                qqNumber = countQ - 2; // Номер вопроса
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    aanswers += tb.Text;
                                });
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                            }

                            // сохранение вопроса с картинкой
                            else if (qType == "КО")
                            {
                                string qquestion = "", aanswers = "", rrb = "";
                                int qqNumber;

                                int countRB = 1;
                                int countTB = 1;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = countQ - 2; // Номер вопроса

                                // Какой из RB отмечен
                                panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                                {
                                    if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                                    else { countRB++; }
                                });

                                // Добавление текста ответов с указанием правильного или неправильного
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                                    else { aanswers += "-"; }
                                    countTB++;
                                    aanswers += tb.Text + ";";
                                });

                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }
                            else if (qType == "КН")
                            {
                                string qquestion = "", aanswers = "";
                                int[] ccb = { 0, 0, 0, 0 };
                                int qqNumber;

                                int countCB = 0;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = countQ - 2; // Номер вопроса

                                // Какой из RB отмечен
                                panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                                {
                                    if (cb.Checked == true) { ccb[countCB] = 1; }
                                    else { }
                                    countCB++;
                                });

                                countCB = 0;
                                // Добавление ответов с указанием правильного или неправильного
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (ccb[countCB] == 1) { aanswers += "+"; }
                                    else { aanswers += "-"; }
                                    aanswers += tb.Text + ";";
                                    countCB++;
                                });

                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }
                            else if (qType == "КВ")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber, ccount = 0;

                                qquestion = tbQ.Text; // Текст вопроса

                                qqNumber = countQ - 2; // Номер вопроса

                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                                    else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                                });

                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }
                            else if (qType == "КЧ")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber;

                                qquestion = tbQ.Text; // Текст вопроса
                                qqNumber = countQ - 2; // Номер вопроса
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    aanswers += tb.Text;
                                });
                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }
                            else if (qType == "КС")
                            {
                                string qquestion = "", aanswers = "";
                                int qqNumber;

                                qquestion = tbQ.Text; // Текст вопроса
                                qqNumber = countQ - 2; // Номер вопроса
                                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                                    aanswers += tb.Text;
                                });
                                string picPath = PictureFile;

                                // добавление в коллекцию
                                QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                            }

                            //qAlreadySaved = true;
                        }

                    }


                    GlobalClass.questionsInTest = countQ - 1;
                    //QClass.saveAndExit = true;
                    SaveTestForm frm = new SaveTestForm();
                    frm.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Тест сохранен (нет). Покеда", "Сохранение и выход", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Так мало вопросов (и еще меньше ответов)..", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            
        }




        private void tsbDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить все вопросы?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                lbQ.Items.Clear();
                countQ = 1;
                panAnswers.Controls.Clear();
                tbQ.Text = "";

                pb.Image = null;
                tbQ.Visible = false;
                panAnswers.Visible = false;

                QClass.DelQ();
                AllSelectedQ.Clear();
                qAlreadySaved = false;

                butDelQ.Enabled = false;
            }
            else { }
        }





        int AnsAmount = 0; // количество полей ответов
        string qType = "";
        private void tsbAddField_Click(object sender, EventArgs e)
        {
            if (AnsAmount == 4)
            {
                MessageBox.Show("Достигнуто максимальное количество вариантов ответа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int lilDep = 0;
            switch (qType)
            {
                case ("О"):
                    if (AnsAmount == 2) lilDep = 222;
                    else if (AnsAmount == 3) lilDep = 333;
                    GlobalClass.rbAdd(panAnswers, 40, 35 + lilDep, 14, 13);
                    GlobalClass.tbAdd(panAnswers, 66, 30 + lilDep, 629, 71);

                    AnsAmount++;
                    break;

                case ("Н"):
                    if (AnsAmount == 2) lilDep = 222;
                    else if (AnsAmount == 3) lilDep = 333;
                    GlobalClass.cbAdd(panAnswers, 40, 35 + lilDep, 15, 14);
                    GlobalClass.tbAdd(panAnswers, 66, 30 + lilDep, 629, 71);

                    AnsAmount++;
                    break;

                case ("В"):
                    if (AnsAmount == 2) lilDep = 222;
                    else if (AnsAmount == 3) lilDep = 333;
                    GlobalClass.tbAdd(panAnswers, 66, 30 + lilDep, 295, 71);
                    GlobalClass.tbAdd(panAnswers, 400, 30 + lilDep, 295, 71);

                    AnsAmount++;
                    break;

                case ("Ч"):
                    MessageBox.Show("Достигнуто максимальное количество вариантов ответа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                case ("С"):
                    MessageBox.Show("Достигнуто максимальное количество вариантов ответа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                case ("КО"):

                    if (AnsAmount == 2) lilDep = 222;
                    else if (AnsAmount == 3) lilDep = 333;
                    GlobalClass.rbAdd(panAnswers, 40, 35 + lilDep, 14, 13);
                    GlobalClass.tbAdd(panAnswers, 66, 30 + lilDep, 629, 71);
                    AnsAmount++;
                    break;

                case ("КН"):

                    if (AnsAmount == 2) lilDep = 222;
                    else if (AnsAmount == 3) lilDep = 333;
                    GlobalClass.cbAdd(panAnswers, 40, 35 + lilDep, 15, 14);
                    GlobalClass.tbAdd(panAnswers, 66, 30 + lilDep, 629, 71);
                    AnsAmount++;
                    break;

                case ("КВ"):
                    if (AnsAmount == 2) lilDep = 222;
                    else if (AnsAmount == 3) lilDep = 333;
                    GlobalClass.tbAdd(panAnswers, 66, 30 + lilDep, 295, 71);
                    GlobalClass.tbAdd(panAnswers, 400, 30 + lilDep, 295, 71);
                    AnsAmount++;
                    break;

                case ("КЧ"):
                    MessageBox.Show("Достигнуто максимальное количество вариантов ответа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                case ("КС"):
                    MessageBox.Show("Достигнуто максимальное количество вариантов ответа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

            }

            timerButAddStop.Start();
            tsbAddField.Enabled = false;
        }




        private void tsbDelField_Click(object sender, EventArgs e)
        {
            if (panAnswers.Controls.Count == 4)
            {
                MessageBox.Show("Достигнуто минимальное количество вариантов ответа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (panAnswers.Controls.Count == 1)
            {
                MessageBox.Show("Достигнуто минимальное количество вариантов ответа", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            panAnswers.Controls.RemoveAt(panAnswers.Controls.Count - 1);
            panAnswers.Controls.RemoveAt(panAnswers.Controls.Count - 1);
            AnsAmount--;
        }




        // С Д Е Л А Н О ?
        bool ultraDelQ = false;
        int IJustDelQ = 0, IJustDelQ2 = 0;
        private void butDelQ_Click(object sender, EventArgs e)
        {
            if (lbQ.SelectedIndex == -1) return;
            else if (lbQ.SelectedIndex == (lbQ.Items.Count - 1) && lbQ.Items.Count > QClass.localQ.Count)
            {
                /////
                ///
                ultraDelQ = true;
                lbQ.Items.RemoveAt(lbQ.Items.Count - 1);

                panAnswers.Controls.Clear();
                countQ--;

                tbQ.Visible = false;
                panAnswers.Visible = false;

                AnsAmount = 0;

                if (pic)
                {
                    this.Controls.Remove(pb);
                    pic = false;
                }

                if (lbQ.Items.Count == 0) butDelQ.Enabled = false;

            }
            else
            {
                QClass.DelSomeQ(lbQ.SelectedIndex);


                catchingError = false;
                lbQ.Items.RemoveAt(lbQ.Items.Count - 1);
                for (int i = 0; i < lbQ.Items.Count; i++)
                {
                    IJustDelQ2 = 1;
                    lbQ.Items[i] = lbQ.Items[i].ToString().Remove(3, lbQ.Items[i].ToString().Length - 3) + QClass.localQT.ElementAt(i);
                }

                qAlreadySaved = true;

                IJustDelQ = 3;
                lbQ.SelectedIndex = -1;

                panAnswers.Controls.Clear();
                countQ--;

                tbQ.Visible = false;
                panAnswers.Visible = false;

                AnsAmount = 0;

                if (pic)
                {
                    this.Controls.Remove(pb);
                    pic = false;
                }

                if (lbQ.Items.Count == 0) butDelQ.Enabled = false;
            }
            
        }




        private void timerButAddStop_Tick(object sender, EventArgs e)
        {
            tsbAddField.Enabled = true;
            timerButAddStop.Stop();
        }




        int lastIndex = 0;
        bool firstTimeChange = true;
        bool catchingError = true;
        //string typeQforChangeSaving = "";
        //int countForQChangeSaving = 0;
        List<string> AllSelectedQ = new List<string>();
        // lbQ
        private void lbQ_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (catchingError == false)
            {
                catchingError = true;
                return;
            }
            else if(GlobalClass.IcameHereToSaveTheTest)
            {
                return;
            }
            else if (automaticSwitchingInlbQ)
            {

                //AllSelectedQ.Add(questionTypeSelected);

                automaticSwitchingInlbQ = false;
                firstTimeChange = true;
                return;
            }
            else if (IJustDelQ2 != 0)
            {
                IJustDelQ2 = 0;
                return;
            }
            else if (IJustDelQ == 3)
            {
                IJustDelQ--;
                return;
            }
            else if (IJustDelQ == 2)
            {
                //IJustDelQ--;
                IJustDelQ = 0;
                string qtselected = lbQ.SelectedItem.ToString().Remove(0, 3).Trim();
                int qnselected = Convert.ToInt32(lbQ.SelectedItem.ToString().Remove(2, (lbQ.SelectedItem.ToString().Length - 2)));

                AllSelectedQ.Add(qtselected);

                qAlreadySaved = false;
                //qType = qtselected;

                GlobalClass.showMeAQuestion(qnselected, panAnswers, tbQ);

                if (qtselected == "КО" || qtselected == "КН" || qtselected == "КВ" || qtselected == "КЧ" || qtselected == "КС")
                {
                    tbQ.Height = 302;
                    tbQ.Width = 360;

                    panAnswers.Height = 302;
                    panAnswers.Top = 306;

                    if (this.Controls.Contains(pb))
                    {
                        this.Controls.Remove(pb);
                    }

                    pb.SizeMode = PictureBoxSizeMode.Zoom;
                    pb.Image = Image.FromFile(QClass.localQPic.ElementAt(qnselected - 1));
                    pb.Height = 302;
                    pb.Width = 358;
                    pb.Left = 476;
                    pb.Top = 0;
                    this.Controls.Add(pb);
                }
                else
                {
                    if (this.Controls.Contains(pb))
                    {
                        this.Controls.Remove(pb);
                    }


                    tbQ.Height = 151;
                    tbQ.Width = 721;

                    panAnswers.Height = 454;
                    panAnswers.Top = 154;
                }

                qAlreadySaved = true; // 

                tbQ.Show();
                panAnswers.Show();

                lastIndex = lbQ.SelectedIndex;
                return;
            }
            else if (IJustDelQ == 1)
            {
                qAlreadySaved = true;
                IJustDelQ--;
                return;
            }
            else if (ultraDelQ)
            {
                ultraDelQ = false;
                return;
            }
            else { }

            string questionTypeSelected = lbQ.SelectedItem.ToString().Remove(0, 3).Trim();
            int questionNumberSelected = Convert.ToInt32(lbQ.SelectedItem.ToString().Remove(2, (lbQ.SelectedItem.ToString().Length - 2)));

            if (firstTimeChange)
            {
                lastIndex = lbQ.Items.Count - 1;
                //typeQforChangeSaving = qType;
            }
            else
            {

            }



            // проверки на корректность вопрсоа
            if (panAnswers.Visible == false && tbQ.Visible == false)
            {

            }
            else if (tbQ.Text == "")
            {
                catchingError = false;
                lbQ.SelectedIndex = lastIndex;
                MessageBox.Show("Не указан текст вопроса!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (panAnswers.Controls.Count == 1)
            {
                
                    panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                        if (tb.Text == "")
                        {
                            MessageBox.Show("Не указан текст ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            exit = true;
                            return;
                        }


                        char[] arr = tb.Text.ToCharArray();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i] == '+' || arr[i] == '-' || arr[i] == ';')
                            {
                                catchingError = false;
                                lbQ.SelectedIndex = lbQ.Items.Count - 1; 
                                exit = true;
                                MessageBox.Show("Введен недопустимый символ ('+', '-' или ';')!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                    });

                    if (exit)
                    {
                        exit = false;
                        return;
                    }

                
                //qType = questionTypeSelected;
                string qqttyyppee = Convert.ToString(lbQ.Items[lbQ.Items.Count - 1]);
                qqttyyppee = qqttyyppee.Remove(0, qqttyyppee.Length - 1);
                if (qqttyyppee == "Ч")
                {
                    double num;
                    string numm = "";
                    panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                        numm = tb.Text;
                    });

                    try
                    {
                        num = Convert.ToDouble(numm);
                    }
                    catch
                    {
                        catchingError = false;
                        lbQ.SelectedIndex = lbQ.Items.Count - 1;
                        MessageBox.Show("Не корректно указан текст ответа [введите число]!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);                        
                        return;
                    }
                }

            }
            else if (panAnswers.Controls.Count > 1)
            {
                int cbChecked = 0, rbChecked = 0, tbClear = 0;
                int countrb = 0, countcb = 0, countTB = 0;

                string[] sameString = new string[8];
                int sameStringCount = 0;
                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb => {
                    if (tb.Text == "") { tbClear++; }
                    countTB++;

                    char[] arr = tb.Text.ToCharArray();
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == '+' || arr[i] == '-' || arr[i] == ';')
                        {
                            catchingError = false;
                            lbQ.SelectedIndex = lastIndex;//lbQ.Items.Count - 1;
                            exit = true;
                            MessageBox.Show("Введен недопустимый символ ('+', '-' или ';')!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    if (exit) return;

                    sameString[sameStringCount] = tb.Text;
                    sameStringCount++;
                });

                if(exit)
                {
                    exit = false;
                    return;
                }

                for (int i = 0; i < sameString.Count() - 1; i++)
                {
                    for (int n = 0; n < sameString.Count() - 1; n++)
                    {
                        if (i == n)
                        {
                        }
                        else if (sameString[i] == null)
                        { }
                        else if (sameString[i] == sameString[n])
                        {
                            MessageBox.Show("Несколько одинаковых ответов!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            catchingError = false;
                            lbQ.SelectedIndex = lbQ.Items.Count - 1;                            
                            //exit = true;
                            return;
                        }

                        if (exit) return;
                    }
                    if (exit) return;
                }

                if(exit)
                {
                    exit = false;
                    return;
                }

                if (tbClear != 0)
                {
                    catchingError = false;
                    lbQ.SelectedIndex = lastIndex;
                    MessageBox.Show("Не указан текст ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);                    
                    return;
                }

                panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(chbox =>
                {
                    if (chbox.Checked == true) { cbChecked++; }
                    countcb++;
                });
                if (countcb == 0)
                {
                    // нет выбранных cb
                }
                else if (cbChecked < 2)
                {
                    catchingError = false;
                    lbQ.SelectedIndex = lbQ.Items.Count - 1;
                    MessageBox.Show("Выбрано мало правильных вариантов ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                {
                    if (rb.Checked == true) { rbChecked++; }
                    countrb++;
                });
                if (countrb == 0)
                {
                    // нет выбранных rb
                }
                else if (rbChecked != 1)
                {
                    catchingError = false;
                    lbQ.SelectedIndex = lastIndex;
                    MessageBox.Show("Не выбран правильный вариант ответа!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            butDelQ.Enabled = true;

            if (panAnswers.Visible == false && tbQ.Visible == false)
            {
                panAnswers.Visible = true;
                tbQ.Visible = true;
            }
            else if (firstTimeChange) // впервые переключаемся в lbQ
            {
                AllSelectedQ.Add(questionTypeSelected);

                // save question
                if (countQ > 1 && tbQ.Visible == true && panAnswers.Visible == true)
                {
                    // сохранение вопроса
                    if (qType == "О")
                    {
                        string qquestion = "", aanswers = "", rrb = "";
                        int qqNumber;

                        int countRB = 1;
                        int countTB = 1;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = countQ - 1; //2; // Номер вопроса АХТУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУУНГ !!!
                                               //qqNumber = lbQ.SelectedIndex + 1; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                        {
                            if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                            else { countRB++; }
                        });

                        // Добавление текста ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            countTB++;
                            aanswers += tb.Text + ";";
                        });

                        // добавление в коллекцию
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "Н")
                    {
                        string qquestion = "", aanswers = "";
                        int[] ccb = { 0, 0, 0, 0 };
                        int qqNumber;

                        int countCB = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = countQ - 1; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                        {
                            if (cb.Checked == true) { ccb[countCB] = 1; }
                            else { }
                            countCB++;
                        });

                        countCB = 0;
                        // Добавление ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (ccb[countCB] == 1) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            aanswers += tb.Text + ";";
                            countCB++;
                        });

                        // добавление в коллекцию
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "В")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber, ccount = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = countQ - 1; // Номер вопроса

                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                            else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                        });
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "Ч")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = countQ - 1; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "С")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = countQ - 1; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, "none");
                    }

                    // сохранение вопроса с картинкой
                    else if (qType == "КО")
                    {
                        string qquestion = "", aanswers = "", rrb = "";
                        int qqNumber;

                        int countRB = 1;
                        int countTB = 1;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = countQ - 1; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                        {
                            if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                            else { countRB++; }
                        });

                        // Добавление текста ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            countTB++;
                            aanswers += tb.Text + ";";
                        });

                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КН")
                    {
                        string qquestion = "", aanswers = "";
                        int[] ccb = { 0, 0, 0, 0 };
                        int qqNumber;

                        int countCB = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = countQ - 1; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                        {
                            if (cb.Checked == true) { ccb[countCB] = 1; }
                            else { }
                            countCB++;
                        });

                        countCB = 0;
                        // Добавление ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (ccb[countCB] == 1) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            aanswers += tb.Text + ";";
                            countCB++;
                        });

                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КВ")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber, ccount = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = countQ - 1; // Номер вопроса

                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                            else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                        });

                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КЧ")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = countQ - 1; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КС")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = countQ - 1; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        string picPath = PictureFile;

                        // добавление в коллекцию
                        QClass.AddQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }

                    qAlreadySaved = true;
                }
                //panAnswers.Controls.Clear();
                firstTimeChange = false;
                lastIndex = lbQ.SelectedIndex;
            }
            else // второй или более раз переключаемся в lbQ
            {
                AllSelectedQ.Add(questionTypeSelected);
                qType = AllSelectedQ.ElementAt(AllSelectedQ.Count - 2);

                if (countQ > 1 && tbQ.Visible == true && panAnswers.Visible == true)
                {

                    // сохранение вопроса
                    if (qType == "О")
                    {
                        string qquestion = "", aanswers = "", rrb = "";
                        int qqNumber;

                        int countRB = 1;
                        int countTB = 1;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                        {
                            if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                            else { countRB++; }
                        });

                        // Добавление текста ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            countTB++;
                            aanswers += tb.Text + ";";
                        });

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, lastIndex, "none");
                    }
                    else if (qType == "Н")
                    {
                        string qquestion = "", aanswers = "";
                        int[] ccb = { 0, 0, 0, 0 };
                        int qqNumber;

                        int countCB = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                        {
                            if (cb.Checked == true) { ccb[countCB] = 1; }
                            else { }
                            countCB++;
                        });

                        countCB = 0;
                        // Добавление ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (ccb[countCB] == 1) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            aanswers += tb.Text + ";";
                            countCB++;
                        });

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "В")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber, ccount = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                            else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                        });
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "Ч")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = lastIndex; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                    }
                    else if (qType == "С")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = lastIndex; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, "none");
                    }

                    // сохранение вопроса с картинкой
                    else if (qType == "КО")
                    {
                        string qquestion = "", aanswers = "", rrb = "";
                        int qqNumber;

                        int countRB = 1;
                        int countTB = 1;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                        {
                            if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                            else { countRB++; }
                        });

                        // Добавление текста ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (countTB == Convert.ToInt32(rrb)) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            countTB++;
                            aanswers += tb.Text + ";";
                        });

                        string picPath = "";
                        if (picChanged)
                        {
                            picPath = PictureFile; //pb.ImageLocation
                            picChanged = false;
                        }
                        else
                        {
                            picPath = QClass.localQPic.ElementAt(qqNumber);//pb.ImageLocation;
                        }

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КН")
                    {
                        string qquestion = "", aanswers = "";
                        int[] ccb = { 0, 0, 0, 0 };
                        int qqNumber;

                        int countCB = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        // Какой из RB отмечен
                        panAnswers.Controls.OfType<CheckBox>().ToList().ForEach(cb =>
                        {
                            if (cb.Checked == true) { ccb[countCB] = 1; }
                            else { }
                            countCB++;
                        });

                        countCB = 0;
                        // Добавление ответов с указанием правильного или неправильного
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (ccb[countCB] == 1) { aanswers += "+"; }
                            else { aanswers += "-"; }
                            aanswers += tb.Text + ";";
                            countCB++;
                        });

                        string picPath = "";
                        if (picChanged)
                        {
                            picPath = PictureFile; //pb.ImageLocation
                            picChanged = false;
                        }
                        else
                        {
                            picPath = QClass.localQPic.ElementAt(qqNumber);//pb.ImageLocation;
                        }

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КВ")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber, ccount = 0;

                        qquestion = tbQ.Text; // Текст вопроса

                        qqNumber = lastIndex; // Номер вопроса

                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            if (ccount == 0) { aanswers += tb.Text + "+"; ccount++; }
                            else if (ccount == 1) { aanswers += tb.Text + ";"; ccount--; }
                        });

                        string picPath = "";
                        if (picChanged)
                        {
                            picPath = PictureFile; //pb.ImageLocation
                            picChanged = false;
                        }
                        else
                        {
                            picPath = QClass.localQPic.ElementAt(qqNumber);//pb.ImageLocation;
                        }

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КЧ")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = lastIndex; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        string picPath = "";
                        if (picChanged)
                        {
                            picPath = PictureFile; //pb.ImageLocation
                            picChanged = false;
                        }
                        else
                        {
                            picPath = QClass.localQPic.ElementAt(qqNumber);//pb.ImageLocation;
                        }

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }
                    else if (qType == "КС")
                    {
                        string qquestion = "", aanswers = "";
                        int qqNumber;

                        qquestion = tbQ.Text; // Текст вопроса
                        qqNumber = lastIndex; // Номер вопроса
                        panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                        {
                            aanswers += tb.Text.Trim().ToLower();
                        });
                        string picPath = "";
                        if (picChanged)
                        {
                            picPath = PictureFile; //pb.ImageLocation
                            picChanged = false;
                        }
                        else
                        {
                            picPath = QClass.localQPic.ElementAt(qqNumber);//pb.ImageLocation;
                        }

                        // добавление в коллекцию
                        QClass.ChangeQ(aanswers, qquestion, qType, qqNumber, picPath);
                    }

                    lastIndex = lbQ.SelectedIndex;
                }
            }
                        
            panAnswers.Controls.Clear();

            
            GlobalClass.showMeAQuestion(questionNumberSelected, panAnswers, tbQ);

            if (questionTypeSelected == "КО" || questionTypeSelected == "КН" || questionTypeSelected == "КВ" || questionTypeSelected == "КЧ" || questionTypeSelected == "КС")
            {
                tbQ.Height = 302;
                tbQ.Width = 360;

                panAnswers.Height = 302;
                panAnswers.Top = 306;

                if (this.Controls.Contains(pb))
                {
                    this.Controls.Remove(pb);
                }

                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Image = Image.FromFile(QClass.localQPic.ElementAt(questionNumberSelected - 1));
                pb.Height = 302;
                pb.Width = 358;
                pb.Left = 476;
                pb.Top = 0;
                this.Controls.Add(pb);
            }
            else
            {
                if(this.Controls.Contains(pb))
                {
                    this.Controls.Remove(pb);
                }


                tbQ.Height = 151;
                tbQ.Width = 721;

                panAnswers.Height = 454;
                panAnswers.Top = 154;
            }

            lastIndex = lbQ.SelectedIndex;
        }

        private void CreateTestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            QClass.DelQ();
        }

    }
}
