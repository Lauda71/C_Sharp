using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace Chabra_Kadabra
{
    class Program
    {

        static void okay()
        {
            Console.Beep(700, 700);                        
        } 

        static void not_okay()
        {            
            Console.Beep(200, 700);
        }

        static void bb(string s1)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            s1 = "   Попытки исчерпаны :С ";
            Console.WriteLine("\n\n\n");
            Console.Write(s1);
        } 

        static void Main(string[] args)
        {
            
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  на 3  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
            SoundPlayer south = new SoundPlayer("D:\\CSound\\south.wav");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();

            

            south.Play();
            goto m1;
            int j = 0;
            string s1, s;
            int easy = 0; // показываем корректный пароль?
            int down = 0;
            do
            {
                Console.WriteLine("\n\n\n");
                
                easy = 0;

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(4, 2);
                Console.Write("Условия для пароля:\n\n    - длина: от 4 до 10 символов;\n\n    - может содержать произвольные латинские буквы, цифры и знак подчеркивания;\n\n    - не должен начинаться с цифры;\n\n    - одна цифра должна быть обязательно;\n\n    - знак подчеркивания может отсутствовать или быть только один;\n\n    - пароль преобразуется к нижниму регистру.");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(4, 16 + down);
                Console.Write("Введите пароль: ");
                s1 = "";
                Console.ForegroundColor = ConsoleColor.Black;
                s = Console.ReadLine();
                char[] pass = s.ToCharArray();
                int l;
                l = pass.Length;
                if (l >= 4 && l <= 10)
                {

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    s1 = s1 + "   Пароль должен быть от 4 до 10 символов! ";
                    down = 0;
                    Console.Write(s1);
                    not_okay();
                    j++;
                    if (j > 5)
                    {
                        bb("   Попытки исчерпаны :С ");
                    }
                    Console.ReadKey(true);
                    Console.Clear();
                    easy++;
                    continue;
                }
                if (char.IsDigit(pass[0]))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    s1 = s1 + "   Пароль не должен начинаться с цифры! ";
                    down = 0;
                    Console.Write(s1);
                    not_okay();
                    j++;
                    if (j > 5)
                    {
                        bb("   Попытки исчерпаны :С ");
                    }
                    easy++;
                    Console.ReadKey(true);
                    Console.Clear();
                    continue;
                }
                else
                {

                }

                for (int k = 0, a = 0, i = 0; i < l; i++)
                {
                    if (char.IsDigit(pass[i]) || (pass[i] >= 65 && pass[i] <= 90) || (pass[i] >= 97 && pass[i] <= 122) || pass[i] == 95 || char.IsNumber(pass[i]))
                    {

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        s1 = s1 + "   Пароль может содержать только латинские буквы, цифры и знак подчеркивания! ";
                        down = 0;
                        Console.Write(s1);
                        not_okay();
                        j++;
                        if (j > 5)
                        {
                            bb("   Попытки исчерпаны :С ");
                        }
                        easy++;
                        Console.ReadKey(true);
                        Console.Clear();
                        break;
                    }
                    if (char.IsNumber(pass[i]) == false)
                    {
                        a++;
                    }
                    if (a == l)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        s1 = s1 + "   Пароль должен содержать хотя бы одну цифру! ";
                        down = 0;
                        Console.Write(s1);
                        not_okay();
                        j++;
                        if (j > 5)
                        {
                            bb("   Попытки исчерпаны :С ");
                        }
                        easy++;
                        Console.ReadKey(true);
                        Console.Clear();
                        a = 0;
                        break;
                    }
                    if (pass[i] == 95)
                    {
                        k++;
                    }
                    if (k > 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        s1 = s1 + "   Пароль должен содержать только один знак подчеркивания! ";
                        down = 0;
                        Console.Write(s1);
                        not_okay();
                        j++;
                        if (j > 5)
                        {
                            bb("   Попытки исчерпаны :С ");
                        }
                        easy++;
                        Console.ReadKey(true);
                        Console.Clear();
                        k--;
                        break;
                    }
                    
                }

                if (easy==0)
                { 
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n    ");
                    for (int i = 0; i < l; i++)
                    {
                        Console.Write(char.ToLower(pass[i]));
                    }
                    Console.WriteLine(); okay(); down = down + 4;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }

                
            }
            while (j <= 5);
            south.Stop();
            Console.Clear();

            m1:
        
            // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  на 4  - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.SetCursorPosition(4, 2);
            Console.Write("Введите сообщение, которое будет преобразовано шифром Цезаря:\n\n    ");
            
            Console.ForegroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;

            // Convert.ToChar();

            s = Console.ReadLine();
            char[] kod = s.ToCharArray();
            int dl = kod.Length;


            Random run = new Random();
            int key_lat = 1, key_kir = 1;


            key_kir = run.Next(2, 32);
            key_lat = run.Next(2, 25);

            

            for (int i = 0 ; i < dl; i++)
            {
                if ((kod[i] >= 65 && kod[i] <= 90) || (kod[i] >= 97 && kod[i] <= 122))
                {
                    if (kod[i] >= 65 && kod[i] <= 90)
                    {
                        //kod[i] = (char)(kod[i] + key_lat);
                        kod[i] = Convert.ToChar(kod[i] + Convert.ToChar(key_lat));
                        if (kod[i] > 90)
                        {
                            //kod[i] = (char)(kod[i] - 26);
                            kod[i] = Convert.ToChar(kod[i] - Convert.ToChar(26));
                        }
                    }
                    else if (kod[i] >= 97 && kod[i] <= 122)
                    {
                        //kod[i] = (char)(kod[i] + key_lat);
                        kod[i] = Convert.ToChar(kod[i] + Convert.ToChar(key_lat));
                        if (kod[i] > 122)
                        {
                            //kod[i] = (char)(kod[i] - 26);
                            kod[i] = Convert.ToChar(kod[i] - Convert.ToChar(26));
                        }
                    }
                }

                else if ((kod[i] >= 1040 && kod[i] <= 1071) || (kod[i] >= 1072 && kod[i] <= 1103)) 
                {
                    if (kod[i] >= 1040 && kod[i] <= 1071)
                    {
                        //kod[i] = (char)(kod[i] + key_kir);
                        kod[i] = Convert.ToChar(kod[i] + Convert.ToChar(key_kir - 1));
                        if (kod[i] > 1071)
                        {
                            //kod[i] = (char)(kod[i] - 32);
                            kod[i] = Convert.ToChar(kod[i] - Convert.ToChar(32));
                        }
                    }
                    else if (kod[i] >= 1072 && kod[i] <= 1103)
                    {
                        //kod[i] = (char)(kod[i] + key_kir);
                        kod[i] = Convert.ToChar(kod[i] + Convert.ToChar(key_kir - 1));
                        if (kod[i] > 1103)
                        {
                            //kod[i] = (char)(kod[i] - 32);
                            kod[i] = Convert.ToChar(kod[i] - Convert.ToChar(32));
                        }
                    }
                }
            }

            Console.Write("\n\n\n   Ключ шифра Цезаря для лат. букв = " + key_lat + ", ключ шифра Цезаря для кириллицы = " + key_kir + "\n\n   ");

            for (int i = 0; i < dl; i++)
            {
                Console.Write(kod[i]);
            }
            

            for (int i = 0; i < dl; i++)
            {
                if ((kod[i] >= 65 && kod[i] <= 90) || (kod[i] >= 97 && kod[i] <= 122))
                {
                    if (kod[i] >= 65 && kod[i] <= 90)
                    {
                        //kod[i] = (char)(kod[i] - key_lat);
                        kod[i] = Convert.ToChar(kod[i] - Convert.ToChar(key_lat));
                        if (kod[i] > 90)
                        {
                            //kod[i] = (char)(kod[i] + 26);
                            kod[i] = Convert.ToChar(kod[i] + Convert.ToChar(26));
                        }
                    }
                    else if (kod[i] >= 97 && kod[i] <= 122)
                    {
                        //kod[i] = (char)(kod[i] - key_lat);
                        kod[i] = Convert.ToChar(kod[i] - Convert.ToChar(key_lat));
                        if (kod[i] > 122)
                        {
                            //kod[i] = (char)(kod[i] + 26);
                            kod[i] = Convert.ToChar(kod[i] + Convert.ToChar(26));
                        }
                    }
                }

                else if ((kod[i] >= 1040 && kod[i] <= 1071) || (kod[i] >= 1072 && kod[i] <= 1103))
                {
                    if (kod[i] >= 1040 && kod[i] <= 1071)
                    {
                        //kod[i] = (char)(kod[i] - key_kir);
                        kod[i] = Convert.ToChar(kod[i] - Convert.ToChar(key_kir - 1));
                        if (kod[i] > 1071)
                        {
                            //kod[i] = (char)(kod[i] + 32);
                            kod[i] = Convert.ToChar(kod[i] + Convert.ToChar(32));
                        }
                    }
                    else if (kod[i] >= 1072 && kod[i] <= 1103)
                    {
                        //kod[i] = (char)(kod[i] - key_kir);
                        kod[i] = Convert.ToChar(kod[i] - Convert.ToChar(key_kir - 1));
                        if (kod[i] > 1103)
                        {
                            //kod[i] = (char)(kod[i] + 32);
                            kod[i] = Convert.ToChar(kod[i] + Convert.ToChar(32));
                        }
                    }
                }
            }


            Console.Write("\n\n   Обратная дешифровка:\n\n   ");
            for (int i = 0; i < dl; i++)
            {
                Console.Write(kod[i]);
            }

            Console.ReadKey(true);
        }
    }
}


