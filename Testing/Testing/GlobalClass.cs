using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace Testing
{
    class GlobalClass
    {
        public static string connectionString;

        public static bool EditTableMode = false; // для перезаписи теста, а не создания нового
        public static bool IcameHereToSaveTheTest = false; // для CreateTestForm - чтобы брал уже имеющийся тест

        public static string nameTeacher, login, pass;
        public static int idTeacher;

        public static int group;
        public static string studentName;
        public static int testIdentifier;
        public static int studIdentifier;

        public static string ID_test = "";
        public static string UriHostNameType = ""; // MainForm - Yor ID hostnametype 
        public static int selectedIn = 0;


        public static bool teachers = true; // для показа списка преподавателей или студентов в режиме Админ-а

        public static string mainBackColor, mainForeColor;

        public static int questionsInTest = 0;

        public static string testsName = ""; // названия тестов  !!!
        public static string testsTopic = ""; // темы тестов  !!!
        public static string TimeLimit = ""; // ограничения тестов по времени  !!!
        public static string tryLimit = ""; // ограничения тестов по попыткам прохождения  !!!
        public static string testsWasBorn = ""; // даты создания тестов  !!!
        public static string testsComment = ""; // комментарии к  тестам  !!!
        public static string testsReturnLimit = ""; // ограничения тестов по возврату к вопросам  !!!

        public static void DelDate()
        {
            testsName = "";
            testsTopic = "";
            TimeLimit = "";
            tryLimit = "";
            testsWasBorn = "";
            testsComment = ""; 
            testsReturnLimit = "";
        }

        // динамическое добавление TextBox'a
        public static void tbAdd(Panel pan, int left, int top, int width, int height)
        {
            TextBox tb = new TextBox();
            tb.Multiline = true;
            tb.ScrollBars = ScrollBars.Both;
            tb.Height = height;
            tb.Width = width;
            tb.Left = left;
            tb.Top = top;

            tb.BackColor = Color.White; // добавить изменение
            tb.ForeColor = Color.Black;

            tb.Text = "";
            tb.ReadOnly = false;
            pan.Controls.Add(tb);
        }

        // динамическое добавление RB'a
        public static void rbAdd(Panel pan, int left, int top, int width, int height)
        {
            RadioButton rb = new RadioButton();
            rb.Height = height;
            rb.Width = width;
            rb.Left = left;
            rb.Top = top;
            rb.Text = "";
            rb.Enabled = true;
            pan.Controls.Add(rb);
        }

        // динамическое добавление CB'a
        public static void cbAdd(Panel pan, int left, int top, int width, int height)
        {
            CheckBox cb = new CheckBox();
            cb.Height = height;
            cb.Width = width;
            cb.Left = left;
            cb.Top = top;
            cb.Text = "";
            cb.Enabled = true;
            pan.Controls.Add(cb);
        }



        // вывод нужных элементов с уже указанными данными
        public static void showMeAQuestion(int num, Panel panAnswers, TextBox tbQ)
        {
            int number = num - 1;

            tbQ.Text = QClass.localQ.ElementAt(number);

            if (QClass.localQT.ElementAt(number) == "О" || QClass.localQT.ElementAt(number) == "КО") // ОООООООООООООООООООООООООООООООООООООООООООООООООООООООООО
            {
                int count = 0;
                char[] answers = QClass.localA.ElementAt(number).ToCharArray();
                for (int i = 0; i < answers.Length; i++)
                {
                    if (answers[i] == ';')
                    {
                        count++;
                    }
                }

                bool[] checkd = new bool[count];
                string[] goodAnswers = QClass.localA.ElementAt(number).Split(';');
                for (int i = 0; i < goodAnswers.Length - 1; i++)
                {
                    string check = goodAnswers[i].Remove(1);
                    if(check == "+")
                    {
                        checkd[i] = true;
                    }
                    else
                    {
                        checkd[i] = false;
                    }
                    goodAnswers[i] = goodAnswers[i].Remove(0, 1);
                }

                int deeper = 0;
                for (int i = 0; i < count; i++)
                {
                    GlobalClass.rbAddWithCheking(panAnswers, 40, 35 + deeper, 14, 13, checkd[i]);
                    GlobalClass.tbAddWithAnswers(panAnswers, 66, 30 + deeper, 629, 71, goodAnswers[i]);
                    deeper += 111;
                }
            }
            else if(QClass.localQT.ElementAt(number) == "Н" || QClass.localQT.ElementAt(number) == "КН")// НННННННННННННННННННННННННННННННННННННННННННННННННННННННННН
            {
                int count = 0;
                char[] answers = QClass.localA.ElementAt(number).ToCharArray();
                for (int i = 0; i < answers.Length; i++)
                {
                    if (answers[i] == ';')
                    {
                        count++;
                    }
                }

                bool[] checkd = new bool[count];
                string[] goodAnswers = QClass.localA.ElementAt(number).Split(';');
                for (int i = 0; i < goodAnswers.Length - 1; i++)
                {
                    string check = goodAnswers[i].Remove(1);
                    if (check == "+")
                    {
                        checkd[i] = true;
                    }
                    else
                    {
                        checkd[i] = false;
                    }
                    goodAnswers[i] = goodAnswers[i].Remove(0, 1);
                }

                int deeper = 0;
                for (int i = 0; i < count; i++)
                {
                    GlobalClass.cbAddWithCheking(panAnswers, 40, 35 + deeper, 14, 13, checkd[i]);
                    GlobalClass.tbAddWithAnswers(panAnswers, 66, 30 + deeper, 629, 71, goodAnswers[i]);
                    deeper += 111;
                }
            }
            else if (QClass.localQT.ElementAt(number) == "В" || QClass.localQT.ElementAt(number) == "КВ")// ВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВ
            {
                int count = 0;
                char[] answers = QClass.localA.ElementAt(number).ToCharArray();
                for (int i = 0; i < answers.Length; i++)
                {
                    if (answers[i] == ';')
                    {
                        count++;
                    }
                }
                                
                string[] goodAnswers = QClass.localA.ElementAt(number).Split(';');
                string[] answer1 = new string[goodAnswers.Length - 1];
                string[] answer2 = new string[goodAnswers.Length - 1];
                for (int i = 0; i < goodAnswers.Length - 1; i++)
                {
                    answer1[i] = goodAnswers[i].Remove(goodAnswers[i].IndexOf('+'));
                    answer2[i] = goodAnswers[i].Remove(0, goodAnswers[i].IndexOf('+') + 1);
                }

                int deeper = 0;
                for (int i = 0; i < count; i++)
                {
                    GlobalClass.tbAddWithAnswers(panAnswers, 66, 30 + deeper, 295, 71, answer1[i]);
                    GlobalClass.tbAddWithAnswers(panAnswers, 400, 30 + deeper, 295, 71, answer2[i]);
                    deeper += 111;
                }                
            }
            else if (QClass.localQT.ElementAt(number) == "Ч" || QClass.localQT.ElementAt(number) == "КЧ")// ЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧ
            {
                GlobalClass.tbAddWithAnswers(panAnswers, 66, 30, 629, 71, QClass.localA.ElementAt(number));
            }
            else if (QClass.localQT.ElementAt(number) == "С" || QClass.localQT.ElementAt(number) == "КС")// СССССССССССССССССССССССССССССССССССССССССССССССССССССССССС
            {
                GlobalClass.tbAddWithAnswers(panAnswers, 66, 30, 629, 71, QClass.localA.ElementAt(number));
            }

        }

        public static void showMeAQuestionWithNoAnswers(int num, Panel panAnswers, TextBox tbQ)
        {
            int number = num - 1;

            tbQ.Text = QClass.localQ.ElementAt(number);

            if (QClass.localQT.ElementAt(number) == "О" || QClass.localQT.ElementAt(number) == "КО") // ОООООООООООООООООООООООООООООООООООООООООООООООООООООООООО
            {
                int count = 0;
                char[] answers = QClass.localUserA.ElementAt(number).ToCharArray();
                for (int i = 0; i < answers.Length; i++)
                {
                    if (answers[i] == ';')
                    {
                        count++;
                    }
                }



                bool[] checkd = new bool[count];
                string[] goodAnswers = QClass.localUserA.ElementAt(number).Split(';');
                for (int i = 0; i < goodAnswers.Length - 1; i++)
                {
                    string check = goodAnswers[i].Remove(1);
                    if (check == "+")
                    {
                        checkd[i] = true;
                    }
                    else
                    {
                        checkd[i] = false;
                    }
                    goodAnswers[i] = goodAnswers[i].Remove(0, 1);
                }



                int deeper = 0;
                for (int i = 0; i < count; i++)
                {
                    GlobalClass.rbAddWithCheking(panAnswers, 40, 35 + deeper, 14, 13, checkd[i]);
                    GlobalClass.tbAddWithAnswersunobtainable(panAnswers, 66, 30 + deeper, 629, 71, goodAnswers[i]);
                    deeper += 111;
                }
            }
            else if (QClass.localQT.ElementAt(number) == "Н" || QClass.localQT.ElementAt(number) == "КН")// НННННННННННННННННННННННННННННННННННННННННННННННННННННННННН
            {
                int count = 0;
                char[] answers = QClass.localUserA.ElementAt(number).ToCharArray();
                for (int i = 0; i < answers.Length; i++)
                {
                    if (answers[i] == ';')
                    {
                        count++;
                    }
                }

                bool[] checkd = new bool[count];
                string[] goodAnswers = QClass.localUserA.ElementAt(number).Split(';');
                for (int i = 0; i < goodAnswers.Length - 1; i++)
                {
                    string check = goodAnswers[i].Remove(1);
                    if (check == "+")
                    {
                        checkd[i] = true;
                    }
                    else
                    {
                        checkd[i] = false;
                    }
                    goodAnswers[i] = goodAnswers[i].Remove(0, 1);
                }

                int deeper = 0;
                for (int i = 0; i < count; i++)
                {
                    GlobalClass.cbAddWithCheking(panAnswers, 40, 35 + deeper, 14, 13, checkd[i]);
                    GlobalClass.tbAddWithAnswersunobtainable(panAnswers, 66, 30 + deeper, 629, 71, goodAnswers[i]);
                    deeper += 111;
                }
            }
            else if (QClass.localQT.ElementAt(number) == "В" || QClass.localQT.ElementAt(number) == "КВ")// ВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВВ
            {
                int count = 0;
                char[] answers = QClass.localUserA.ElementAt(number).ToCharArray();
                for (int i = 0; i < answers.Length; i++)
                {
                    if (answers[i] == ';')
                    {
                        count++;
                    }
                }

                string[] goodAnswers = QClass.localUserA.ElementAt(number).Split(';');
                string[] answer1 = new string[(goodAnswers.Length - 1 ) / 2];
                string[] answer2 = new string[(goodAnswers.Length - 1 ) / 2];                
                for (int i = 0; i <= goodAnswers.Length - 2; i++)
                {
                    if(i == 0)
                    {
                        answer1[0] = goodAnswers[i];
                    }
                    else if(i == 1)
                    {
                        answer2[0] = goodAnswers[i];
                    }
                    else if (i == 2)
                    {
                        answer1[1] = goodAnswers[i];
                    }
                    else if (i == 3)
                    {
                        answer2[1] = goodAnswers[i];
                    }
                    else if (i == 4)
                    {
                        answer1[2] = goodAnswers[i];
                    }
                    else if (i == 5)
                    {
                        answer2[2] = goodAnswers[i];
                    }
                    else if (i == 6)
                    {
                        answer1[3] = goodAnswers[i];
                    }
                    else if (i == 7)
                    {
                        answer2[3] = goodAnswers[i];
                    }

                    //answer1[i] = goodAnswers[i].Remove(goodAnswers[i].IndexOf('+'));
                    //answer2[i] = goodAnswers[i].Remove(0, goodAnswers[i].IndexOf('+') + 1);
                }

                int deeper = 0;
                for (int i = 0; i < count / 2; i++)
                {
                    GlobalClass.tbAddWithAnswersunobtainable(panAnswers, 66, 30 + deeper, 295, 71, answer1[i]);
                    GlobalClass.cbAddWithAnswers(panAnswers, 400, 30 + deeper, 295, 71, answer2);
                    deeper += 111;
                }
            }
            else if (QClass.localQT.ElementAt(number) == "Ч" || QClass.localQT.ElementAt(number) == "КЧ")// ЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧЧ
            {
                GlobalClass.tbAddWithAnswers(panAnswers, 66, 30, 629, 71, QClass.localUserA.ElementAt(number));
            }
            else if (QClass.localQT.ElementAt(number) == "С" || QClass.localQT.ElementAt(number) == "КС")// СССССССССССССССССССССССССССССССССССССССССССССССССССССССССС
            {
                GlobalClass.tbAddWithAnswers(panAnswers, 66, 30, 629, 71, QClass.localUserA.ElementAt(number));
            }

        }




        public static void tbAddWithAnswers(Panel pan, int left, int top, int width, int height, string answer)
        {
            TextBox tb = new TextBox();
            tb.Multiline = true;
            tb.ScrollBars = ScrollBars.Both;
            tb.Height = height;
            tb.Width = width;
            tb.Left = left;
            tb.Top = top;

            tb.BackColor = Color.White; // добавить изменение
            tb.ForeColor = Color.Black;

            tb.Text = answer;
            tb.ReadOnly = false;
            pan.Controls.Add(tb);
        }

        public static void rbAddWithCheking(Panel pan, int left, int top, int width, int height, bool check)
        {
            RadioButton rb = new RadioButton();
            rb.Height = height;
            rb.Width = width;
            rb.Left = left;
            rb.Top = top;
            rb.Text = "";
            rb.Enabled = true;
            if (check)
            {
                rb.Checked = true;
            }
            else
            {
                rb.Checked = false;
            }
            pan.Controls.Add(rb);
        }

        public static void cbAddWithCheking(Panel pan, int left, int top, int width, int height, bool check)
        {
            CheckBox cb = new CheckBox();
            cb.Height = height;
            cb.Width = width;
            cb.Left = left;
            cb.Top = top;
            cb.Text = "";
            cb.Enabled = true;
            if (check)
            {
                cb.Checked = true;
            }
            else
            {
                cb.Checked = false;
            }
            pan.Controls.Add(cb);
        }



        public static void tbAddWithAnswersunobtainable(Panel pan, int left, int top, int width, int height, string answer)
        {
            TextBox tb = new TextBox();
            tb.Multiline = true;
            tb.ScrollBars = ScrollBars.Both;
            tb.Height = height;
            tb.Width = width;
            tb.Left = left;
            tb.Top = top;
            tb.Enabled = false;
            tb.BackColor = Color.White; // добавить изменение
            tb.ForeColor = Color.Black;

            tb.Text = answer;
            tb.ReadOnly = false;
            pan.Controls.Add(tb);
        }

        public static void cbAddWithAnswers(Panel pan, int left, int top, int width, int height, string[] answer)
        {
            ComboBox cb = new ComboBox();
            cb.Width = 230;
            cb.Height = 30;
            cb.Left = left;
            cb.Top = top;
            //cb.Height = height;
            cb.Width = width;
            cb.BackColor = Color.White; // добавить изменение
            cb.ForeColor = Color.Black;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            cb.Items.AddRange(answer);

            cb.Enabled = true;

            pan.Controls.Add(cb);
        }




        public static double all = 0; // всего 
        public static double good = 0; // правильных ответов
        public static double bad = 0; // неправильных ответов

        public static double percentGood = 0; // правильных ответов в %
        public static double percentBad = 0; // неправильных ответов в %

        public static int mark = 0;

        public static void End()
        {
            all = 0; 
            good = 0; 
            bad = 0;

            percentGood = 0;
            percentBad = 0;

            for (int i = 0; i < QClass.localUserAnswers.Count(); i++)
            {
                all++;
                if (QClass.localA.ElementAt(i).Trim() == QClass.localUserAnswers.ElementAt(i).Trim()) good++;
                else bad++;
            }

            percentGood = (100 * good) / all;
            percentGood = Math.Round(percentGood, 2);

            percentBad = (100 * bad) / all;
            percentBad = Math.Round(percentBad, 2);

            if (percentGood >= 90) mark = 5;
            else if (percentGood >= 80) mark = 4;
            else if (percentGood >= 65) mark = 3;
            else mark = 2;
        }
    }
}
