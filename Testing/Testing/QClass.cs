using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Testing
{
    class QClass
    {
        public static bool save = false, saveAndExit = false; // сохранение ИЛИ сохранение и выход

        public static List<string> localQ = new List<string>(); // Вопросы
        public static List<string> localA = new List<string>(); // Правильные ответы
        public static List<string> localQT = new List<string>(); // Тип вопроса
        public static List<int> localQN = new List<int>(); // Номер вопроса
        public static List<string> localQPic = new List<string>(); // Адрес картинки

        public static List<string> localUserA = new List<string>(); // Ответы для студента
        public static List<string> localUserAnswers = new List<string>(); // Ответы самого студента (для сравнения с правильными ответами)

        public static void SetAnswers()
        {
            //localUserA.AddRange(localA);
            localUserAnswers.Clear();
            localUserA.Clear();

            for (int i = 0; i < localA.Count; i++)
            {
                localUserAnswers.Add("");

                if (localQT.ElementAt(i) == "О" || localQT.ElementAt(i) == "КО" || localQT.ElementAt(i) == "Н" || localQT.ElementAt(i) == "КН")
                {
                    localUserA.Add(localA.ElementAt(i).Replace('+', '-'));
                }
                else if (localQT.ElementAt(i) == "В" || localQT.ElementAt(i) == "КВ")
                {
                    localUserA.Add(localA.ElementAt(i).Replace('+', ';'));
                }
                else localUserA.Add("");

            }

        }


        public static void AddQ(string answer, string question, string qType, int qNumber, string path)
        {
            localQ.Add(question);
            localA.Add(answer);
            localQT.Add(qType);
            localQN.Add(qNumber);
            localQPic.Add(path);
        }

        public static void ChangeQ(string answer, string question, string qType, int qNumber, string path)
        {
            //qNumber -= 1;

            localQ.RemoveAt(qNumber);
            localQ.Insert(qNumber, question);
            

            localA.RemoveAt(qNumber);
            localA.Insert(qNumber, answer);
            

            localQPic.RemoveAt(qNumber);
            localQPic.Insert(qNumber, path);            
        }

        public static void DelQ()
        {
            localQ.Clear();
            localA.Clear();
            localQT.Clear();
            localQN.Clear();
            localQPic.Clear();

        }

        public static void DelSomeQ(int qNumber)
        {
            localQ.RemoveAt(qNumber);
            localA.RemoveAt(qNumber);
            localQT.RemoveAt(qNumber);
            localQN.RemoveAt(qNumber);
            localQPic.RemoveAt(qNumber);
        }

    }
}
