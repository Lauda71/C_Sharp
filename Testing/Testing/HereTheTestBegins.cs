using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Testing
{
    public partial class HereTheTestBegins : Form
    {
        public HereTheTestBegins()
        {
            InitializeComponent();
        }


        string timeLim = "", tryLim = "", retLim = "";
        string TeacherComment = "";
        int returnToQ = 0, countQ = 1;
        private void HereTheTestBegins_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromName(GlobalClass.mainBackColor);
            this.ForeColor = Color.FromName(GlobalClass.mainForeColor);



            DB16TestDataSetTableAdapters.TestsTableAdapter tadap = new DB16TestDataSetTableAdapters.TestsTableAdapter();
            var records = tadap.GetData();
            var filter = records.Where(p => p.ID_test == GlobalClass.testIdentifier);
            int tryLimit = Convert.ToInt32(filter.ElementAt(0).Try_limit.Trim()); // количество разрешенных попыток прохождения

                // проверка на допуск студента к тесту (попытки есь? а есл найду?)
                DB16TestDataSetTableAdapters.ResultsTableAdapter res = new DB16TestDataSetTableAdapters.ResultsTableAdapter();
                var recc = res.GetData();
                var fill = recc.Where(p => p.ID_student == GlobalClass.studIdentifier && p.ID_test == GlobalClass.testIdentifier);
                if(tryLimit < fill.Count())
                {
                    MessageBox.Show("Все попытки прохождения теста закончились.",
                    "Нет больше попыток!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

            if (filter.ElementAt(0).Comment.Trim() == "none")
            {
                TeacherComment = "отсустствует";
            }
            else TeacherComment = filter.ElementAt(0).Comment.Trim();

            if (filter.ElementAt(0).Time_limit.Trim() == "none")
            {
                timeLim = "отсутствуют";
            }
            else timeLim = Convert.ToString(filter.ElementAt(0).Time_limit.Trim());

            if (filter.ElementAt(0).Try_limit.Trim() == "none")
            {
                tryLim = "отсутствуют";
            }
            else tryLim = Convert.ToString(filter.ElementAt(0).Try_limit.Trim());

            if (filter.ElementAt(0).Test_return_limit.Trim() == "none")
            {
                retLim = "функция недоступна";
            }
            else if(filter.ElementAt(0).Test_return_limit.Trim() == "все")
            {
                retLim = "отсутствуют";
            }
            else retLim = Convert.ToString(filter.ElementAt(0).Test_return_limit.Trim());


            MessageBox.Show("Приветствуем вас, " + GlobalClass.studentName + "\n\n" + 
                "Вы проходите следюущий тест: " + filter.ElementAt(0).Name_test + "\n\n" +
                "Ограничения по времени: " + timeLim + " мин." + "\n\n" +
                "Ограничения по попыткам: " + tryLim + "\n\n" +
                "Ограничения по возвращению к предыдущим вопросам: " + retLim + "\n\n" + 
                "Комментарий преподавателя: " + TeacherComment + "\n\n" + 
                "\n\n" + "Желаем удачи!", 
                "Пристегните ремни!", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);


            if(timeLim != "отсутствуют")
            {
                timerRestOfTime.Interval = 1000;
                timerRestOfTime.Start();

                labtime.Visible = true;
                labHowManyTime.Visible = true;
                chbTimePB.Visible = true;
                SecondPB.Visible = true;
                chbTime.Visible = true;
                //this.Width = 1285;
                //fsPB.Width = 1263;

                SecondPB.Maximum = Convert.ToInt32(timeLim) * 60;
                SecondPB.Value = Convert.ToInt32(timeLim) * 60;

                timerCounterMin = Convert.ToInt32(timeLim);
                timerCounterHour = timerCounterMin / 60;
                timerCounterMin = timerCounterMin % 60;
            }
            else
            {
                labtime.Visible = false;
                labHowManyTime.Visible = false;
                chbTimePB.Visible = false;
                SecondPB.Visible = false;
                chbTime.Visible = false;
                fsPB.Width = 1216;
                this.Width = 1239;

                butPause.Enabled = false;
            }
            

            if(retLim == "функция недоступна")
            {
                lbQ.Enabled = false;
                butChange.Enabled = false;
                //returnToQ = Convert.ToInt32(retLim);
                //butChange.Text = "Перейти к вопросу (" + Convert.ToString(returnToQ) + ")";
            }
            else if(retLim == "отсутствуют")
            {
                lbQ.Enabled = true;
                butChange.Enabled = true;
            }
            else
            {
                returnToQ = Convert.ToInt32(retLim);
                butChange.Text = "Перейти к вопросу (" + Convert.ToString(returnToQ) + ")";
            }




            // захват данных по тесту из БД
            string connectionString = Properties.Settings.Default.DB16TestConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(); //Создали
            command.Connection = connection;

            DB16TestDataSetTableAdapters.TestsTableAdapter ts = new DB16TestDataSetTableAdapters.TestsTableAdapter();
            var rec = ts.GetData();
            var fil = rec.Where(p => p.ID_test == GlobalClass.testIdentifier);

            string nameTest = fil.ElementAt(0).Name_test;
            int teacherID = fil.ElementAt(0).ID_teacher;

            string name = nameTest + "_" + teacherID;  //Название таблицы, откуда будем брать всю информацию (вопросы, ответы)
            string commandString;

            try
            {
                commandString = "SELECT * FROM " + name;
                command.CommandText = commandString; //Выполнить команду
                command.ExecuteNonQuery(); //Выполнить команду без результатов
            }
            catch
            {
                MessageBox.Show("Ошибка при работе с данными теста.\r\n" +
                                "Повторите запрос.");
                connection.Close();
                return;
            }

            QClass.DelQ();

            //int countTestNum = 0;
            SqlDataReader dataReader = command.ExecuteReader(); //Все записи
            while (dataReader.Read())                   //Перебрать все записи по одной
            {
                QClass.localQN.Add(Convert.ToInt32(dataReader["Number_question"]));
                QClass.localQT.Add(Convert.ToString(dataReader["Type_question"]));
                QClass.localQ.Add(Convert.ToString(dataReader["Text_question"]));
                QClass.localA.Add(Convert.ToString(dataReader["Answers"]));
                QClass.localQPic.Add(Convert.ToString(dataReader["Picture"]));
            }
            dataReader.Close();
            connection.Close();

            for (int i = 1; i <= QClass.localQT.Count; i++)
            {                
                string count = "";
                if (i <= 9) count = "0" + Convert.ToString(i);
                else count = "";
                lbQ.Items.Add(Convert.ToString(count + " " + QClass.localQT.ElementAt(i - 1)));
            }
            QClass.SetAnswers();

            fsPB.Value++;
            automaticChange = true;
            lbQ.SelectedIndex = 0;

            fsPB.MaxValue = QClass.localQN.Count();
            labAllQ.Text = Convert.ToString(QClass.localQN.Count());
            labQNumber.Text = Convert.ToString(countQ);
        }


        
        int timerCounterSec = 0; //счётчик для таймера
        int timerCounterMin = 0; //счётчик для таймера

        

        private void butNext_Click(object sender, EventArgs e)
        {
            savingAnswers(qnselected);
            if(badEnding)
            {
                badEnding = false;
                return;
            }


            if (butNext.Text == "Завершить тест!")
            {
                //переход к подсчетам результатов
                timerRestOfTime.Stop();
                FinalresultTest final = new FinalresultTest();
                this.Hide();
                final.ShowDialog();

                // а пока заглушка
                return;
            }

            if(pause)
            {
                timerRestOfTime.Stop();
                this.Visible = false;
                MessageBox.Show("Для возобновления теста нажмите 'OK'",
                "ПАУЗА",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                butPause.BackColor = Color.Transparent;
                this.Visible = true;
                timerRestOfTime.Start();
                pause = false;
            }

            automaticChange = true;
            lbQ.SelectedIndex = countQ;
            

            countQ++;
            labQNumber.Text = Convert.ToString(countQ);

            fsPB.Value++;
            
            if(fsPB.Value == fsPB.MaxValue)
            {
                butNext.Text = "Завершить тест!";
            }
        }

        private void chbTimePB_CheckedChanged(object sender, EventArgs e)
        {
            if(chbTimePB.Checked == true)
            {
                SecondPB.Visible = false;
            }
            else if(chbTimePB.Checked == false)
            {
                SecondPB.Visible = true;
            }
        }

        private void chbTime_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTime.Checked == true)
            {
                labtime.Visible = false;
                labHowManyTime.Visible = false;
            }
            else if (chbTime.Checked == false)
            {
                labtime.Visible = true;
                labHowManyTime.Visible = true;
            }
        }

        private void butChange_Click(object sender, EventArgs e)
        {
            if (retLim != "отсутствуют")
            {
                if(returnToQ == 0)
                {
                    MessageBox.Show("Все возможности возврата к вопросу уже потрачены!",
                    "Отказано!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    returnToQ--;
                    butChange.Text = "Перейти к вопросу (" + Convert.ToString(returnToQ) + ")";
                }
                
            }

            if (pause)
            {
                timerRestOfTime.Stop();
                this.Visible = false;
                MessageBox.Show("Для возобновления теста нажмите 'OK'",
               "ПАУЗА",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);

                butPause.BackColor = Color.Transparent;
                this.Visible = true;
                timerRestOfTime.Start();
                pause = false;
            }

            savingAnswers(qnselected);
            if (badEnding)
            {
                badEnding = false;
                return;
            }

            automaticChange = true;
            this.lbQ_SelectedIndexChanged(this, e);
        }

        bool pause = false;
        private void butPause_Click(object sender, EventArgs e)
        {
            if(pause)
            {
                pause = false;
                butPause.BackColor = Color.Transparent;
            }
            else
            {
                pause = true;
                butPause.BackColor = Color.Green;
            }
            
        }

        int timerCounterHour = 0; //счётчик для таймера
        private void timerRestOfTime_Tick(object sender, EventArgs e)
        {
            //labHowManyTime.Text =

            timerCounterSec -= 1;

            if (timerCounterSec == -1 && timerCounterMin == 0 && timerCounterHour == 0)
            {
                labHowManyTime.Text = "00:00:00";
                timerRestOfTime.Stop();

                MessageBox.Show("Время истекло! Возможность ответить на вопрос истекла!", "Время вышло", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                savingAnswers(qnselected);

                FinalresultTest final = new FinalresultTest();
                this.Hide();
                final.ShowDialog();
                // ссылка на зварешение теста
                return;
            }


            SecondPB.Value--;
            if (SecondPB.Value <= 300)
            {
                SecondPB.ForeColor = Color.Yellow;
            }
            else if (SecondPB.Value <= 60)
            {
                SecondPB.ForeColor = Color.Black;
            }

            if (timerCounterSec == -1)
            {
                timerCounterMin--;
                timerCounterSec = 59;
            }

            if (timerCounterMin == -1)
            {
                timerCounterMin = 59;
                timerCounterHour--;
            }
                        
            if (timerCounterHour == 0 && timerCounterMin == 0 && timerCounterSec < 10)
            {
                labHowManyTime.Text = "00:00:0" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour == 0 && timerCounterMin == 0)
            {
                labHowManyTime.Text = "00:00:" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour == 0 && timerCounterMin < 10 && timerCounterSec < 10)
            {
                labHowManyTime.Text = "00:0" + (timerCounterMin).ToString() + ":0" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour == 0 && timerCounterMin < 10)
            {
                labHowManyTime.Text = "00:0" + (timerCounterMin).ToString() + ":" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour == 0)
            {
                labHowManyTime.Text = "00:" + (timerCounterMin).ToString() + ":" + (timerCounterSec).ToString();
            }
            else if (timerCounterHour < 10)
            {
                labHowManyTime.Text = "0" + (timerCounterHour).ToString() + ":" + (timerCounterMin).ToString() + ":" + (timerCounterSec).ToString();
            }
            else labHowManyTime.Text = (timerCounterHour).ToString() + ":" + (timerCounterMin).ToString() + ":" + (timerCounterSec).ToString();


        }


        bool automaticChange = false;
        string qtselected = "";
        int qnselected = 0;

        private void butEndTest_Click(object sender, EventArgs e)
        {
            savingAnswers(qnselected);

            DialogResult ressss = MessageBox.Show("Хотите завершить тест, не ответив на все вопросы?\n[Оценка может быть хуже]", "Досрочное завершение теста", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ressss == DialogResult.Yes)
            {
                FinalresultTest final = new FinalresultTest();
                this.Hide();
                final.ShowDialog();
            }

        }

        private void lbQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(automaticChange) automaticChange = false;
            
            else if(automaticChange == false) return;
            
            panAnswers.Controls.Clear();
            
            int questionNumberSelected = Convert.ToInt32(lbQ.SelectedItem.ToString().Remove(2, (lbQ.SelectedItem.ToString().Length - 2)));

            GlobalClass.showMeAQuestionWithNoAnswers(questionNumberSelected, panAnswers, tbQ);

            qtselected = lbQ.SelectedItem.ToString().Remove(0, 3).Trim();
            qnselected = Convert.ToInt32(lbQ.SelectedItem.ToString().Remove(2, (lbQ.SelectedItem.ToString().Length - 2)));

            if (qtselected == "КО" || qtselected == "КН" || qtselected == "КВ" || qtselected == "КЧ" || qtselected == "КС")
            {
                pb.Image = Image.FromFile(QClass.localQPic.ElementAt(qnselected - 1));
            }
            else
            {
                pb.Image = null;
            }

        }


        bool badEnding = false;
        private void savingAnswers(int qnumber)
        {
             
            if (qtselected == "О" || qtselected == "КО")
            {
                string aanswers = "", rrb = "";
                int countRB = 1, countTB = 1;

                // Какой из RB отмечен
                panAnswers.Controls.OfType<RadioButton>().ToList().ForEach(rb =>
                {
                    if (rb.Checked == true) { rrb = Convert.ToString(countRB); }
                    else { countRB++; }
                });

                // Добавление текста ответов с указанием правильного или неправильного
                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                {
                    if (Convert.ToString(countTB) == rrb) { aanswers += "+"; }
                    else { aanswers += "-"; }
                    countTB++;
                    aanswers += tb.Text + ";";
                });

                // удаление из коллекции
                QClass.localUserAnswers.RemoveAt(qnumber - 1);
                // добавление в коллекцию
                QClass.localUserAnswers.Insert(qnumber - 1, aanswers);
            }
            else if (qtselected == "Н" || qtselected == "КН")
            {
                string aanswers = "";
                int[] ccb = { 0, 0, 0, 0 };

                int countCB = 0;

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

                // удаление из коллекции
                QClass.localUserAnswers.RemoveAt(qnumber - 1);
                // добавление в коллекцию
                QClass.localUserAnswers.Insert(qnumber - 1, aanswers);
            }
            else if (qtselected == "В" || qtselected == "КВ")
            {
                string aanswers = "";
                string[] aaanswers = new string[4];
                string[] aaaanswers = new string[4];
                int howManyTb = 0;

                int i = 0;
                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                {
                    aaanswers[i] = tb.Text + "+";
                    i++;
                    howManyTb++;
                });
                i = 0;
                panAnswers.Controls.OfType<ComboBox>().ToList().ForEach(cb =>
                {
                    aaaanswers[i] = cb.Text + ";";
                    i++;
                });

                for (i = 0; i < howManyTb; i++)
                {
                    aaanswers[i] += aaaanswers[i];
                }
                for (i = 0; i < howManyTb; i++)
                {
                    aanswers += aaanswers[i];
                }

                // удаление из коллекции
                QClass.localUserAnswers.RemoveAt(qnumber - 1);
                // добавление в коллекцию
                QClass.localUserAnswers.Insert(qnumber - 1, aanswers);
            }
            else if (qtselected == "Ч" || qtselected == "КЧ")
            {
                string aanswers = "";

                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                {
                    aanswers += tb.Text.Trim().ToLower();
                });

                try
                {
                    double i = Convert.ToDouble(aanswers);
                }
                catch
                {
                    MessageBox.Show("Введите число!",
                        "Некорректный ввод ответа",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    badEnding = true;
                    return;
                }

                // удаление из коллекции
                QClass.localUserAnswers.RemoveAt(qnumber - 1);
                // добавление в коллекцию
                QClass.localUserAnswers.Insert(qnumber - 1, aanswers);
            }
            else if (qtselected == "С" || qtselected == "КС")
            {
                string aanswers = "";

                panAnswers.Controls.OfType<TextBox>().ToList().ForEach(tb =>
                {
                    aanswers += tb.Text.Trim().ToLower();
                });
                // удаление из коллекции
                QClass.localUserAnswers.RemoveAt(qnumber - 1);
                // добавление в коллекцию
                QClass.localUserAnswers.Insert(qnumber - 1, aanswers);
            }
        }







    }
        
}
