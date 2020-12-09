using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Poiskkk
{
    class Program
    {

        static int proverka(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            int a = 0;
            string ss;

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.SetCursorPosition(x, y);
                ss = Console.ReadLine();

                if (Int32.TryParse(ss, out a) == false)
                {                    
                    Console.SetCursorPosition(x, y);
                    Console.Write("                                                                  ");
                }

            }
            while (Int32.TryParse(ss, out a) == false);
            Console.ForegroundColor = ConsoleColor.White;
            return a;
        }

        static int[] mass(int a, int oot, int doo) // Создание массива
        {
            Random ran = new Random();
            int[] z = new int[a];

            for (int i = 0, x = 1; i < z.Length; i++, x++)
            {
                z[i] = ran.Next(oot, doo + 1);
                Thread.Sleep(100);

                if (x % 6 == 0) { Console.SetCursorPosition(60, 4 + x); x = x + 1; }
                else Console.SetCursorPosition(60, 3 + x);
                Console.ForegroundColor = ConsoleColor.White; Console.Write(" Элемент массива № "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(i); Console.ForegroundColor = ConsoleColor.White; Console.Write(" = "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(z[i] + "\n");
            }

            return z;
        }

        static void lin_poisk(int[] a, int b)
        {
            int s = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b) { s = i; break; }
            }

            if (s != -1) { Console.ForegroundColor = ConsoleColor.White; Console.Write("\n\n   Первый № элемента с заданным значением = "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(s); }
            else Console.Write("\n\n   Нет элемента с заданным значением.");

        }

        static void lin_ksiop(int[] a, int b)
        {
            int s = -1;
            for (int i = a.Length - 1; i != -1; i--)
            {
                if (a[i] == b) { s = i; break; }
            }

            if (s != -1) { Console.ForegroundColor = ConsoleColor.White; Console.Write("\n\n   Последний № элемента с заданным значением = "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(s); }
            else Console.Write("\n\n   Нет элемента с заданным значением.");
        }

        static void poisk_v_diap(int[] a, int b, int ot, int to)
        {
            int s = -1;
            for (int i = ot; i <= to; i++)
            {
                if (a[i] == b) { s = i; break; }
            }

            if (s != -1) { Console.ForegroundColor = ConsoleColor.White; Console.Write("\n\n   № элемента с заданным значением = "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(s); }
            else Console.Write("\n\n   В диапазоне нет элемента с заданным значением.");
        }

        static void vse_poisk(int[] a, int b)
        {
            Console.ForegroundColor = ConsoleColor.White; 
            Console.Write("\n\n   № элементов с указанным значением: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int s = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b) { s = i; Console.Write(s + " "); }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" \n \n \n ");
        }

        static void here_we_go_again(int[] a, int b) // АААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААААА
        {
            double left, right;
            double mid;
            int midd = 0, tik_tak = 0;
            left = 0;
            right = a.Length - 1;

            do
            {
                mid = Math.Ceiling((left + right) / 2);
                midd = (int)mid;
                if (a[midd] == b)
                {
                    Console.ForegroundColor = ConsoleColor.White; Console.Write("   Искомый № элемента = "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(mid); break;
                }
                else if (b < a[midd])
                {
                    right = mid;
                }
                else if (b > a[midd])
                {
                    left = mid;
                }
                tik_tak++;

                if (tik_tak > a.Length) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("   В массиве нет элемента с данным значением!"); break; }

            } while (a[midd] != b);

        }

        static void here_we_go_again_infinity_edition(int[] a, int b, double left, double right, double mid, int midd)
        {            
            mid = Math.Ceiling((left + right) / 2);
            midd = (int)mid;
            //tik_tak++;

            //if (tik_tak > a.Length) { Console.ForegroundColor = ConsoleColor.Red; Console.Write("   В массиве нет элемента с данным значением!"); }
            if (left == right && a[midd] != b)
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.Write("   В массиве нет элемента с данным значением!");
            }
            else if (a[midd] == b)
            {
                Console.ForegroundColor = ConsoleColor.White; Console.Write("   Искомый № элемента = "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write(mid); 
            }
            else if (b < a[midd] )
            {
                right = mid;                
                here_we_go_again_infinity_edition(a, b, left, right, mid, midd);
            }
            else if (b > a[midd] )
            {
                left = mid;                
                here_we_go_again_infinity_edition(a, b, left, right, mid, midd);
            }

            
            
        }







        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" \n \n   Создание массива. \n \n   Укажите количество элементов:");
            int m_number = 1;
            do
            {
                m_number = proverka(33, 4);
                if (m_number <= 0) { Console.SetCursorPosition(33, 4);  Console.Write("             "); }
            } while (m_number <= 0);
           


            Console.Write(" \n   Укажите"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" нижнюю "); Console.ForegroundColor = ConsoleColor.White; Console.Write("границу массива:");
            int oot = proverka(35, 6);


            Console.Write(" \n   Укажите"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" верхнюю "); Console.ForegroundColor = ConsoleColor.White; Console.Write("границу массива:");
            int doo = proverka(36, 8);

            
            int[] z = mass(m_number, oot, doo);
            Console.SetCursorPosition(48, 14);
            Console.ForegroundColor = ConsoleColor.White; // Линейный поиск по всему массиву
            Console.Write(" \n\n   Укажите искомое"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" значение элемента "); Console.ForegroundColor = ConsoleColor.White; Console.Write("в массиве:");
            int b = proverka(48, 16);


            lin_poisk(z, b); // первый элемент с таким значением
            lin_ksiop(z, b); // последний элемент с таким значением


            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\n");
            Console.Write(" \n   Укажите"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" нижнюю "); Console.ForegroundColor = ConsoleColor.White; Console.Write("границу диапазона для поиска:");
            do
            {
                oot = proverka(48, 24);
                if (oot < 0 || oot >= z.Length) { Console.SetCursorPosition(48, 24); Console.Write("             "); }
            } while (oot < 0|| oot >= z.Length); 

            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Write(" \n   Укажите"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" верхнюю "); Console.ForegroundColor = ConsoleColor.White; Console.Write("границу диапазона для поиска:");
            do
            {
                doo = proverka(49, 26);
                if (doo < 0 || doo >= z.Length) { Console.SetCursorPosition(49, 26); Console.Write("             "); }
            } while (doo < 0 || doo >= z.Length);

            

            poisk_v_diap(z, b, oot, doo);

            vse_poisk(z, b);


            //Console.ReadKey(true);
            Array.Sort(z);


            for (int i = 0, x = 1; i < z.Length; i++, x++)
            {                
                Thread.Sleep(100);
                if (x % 6 == 0) { Console.SetCursorPosition(60, 4 + x); x = x + 1; }
                else Console.SetCursorPosition(60, 3 + x);
                Console.Write("                                                                   ");
                if (x % 6 == 0) { Console.SetCursorPosition(60, 4 + x); x = x + 1; }
                else Console.SetCursorPosition(60, 3 + x);
                Console.ForegroundColor = ConsoleColor.White; Console.Write(" Элемент массива № "); Console.ForegroundColor = ConsoleColor.DarkGreen; Console.Write(i); Console.ForegroundColor = ConsoleColor.White; Console.Write(" = "); Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write(z[i] + "\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 34); Console.ForegroundColor = ConsoleColor.White; Console.Write("[Бинарный поиск без рекурсии] ");
            here_we_go_again(z, b);

            Console.SetCursorPosition(3, 38); Console.ForegroundColor = ConsoleColor.White; Console.Write("[Бинарный поиск с рекурсией]  ");
            here_we_go_again_infinity_edition(z, b, 0, z.Length-1, 0, 0);

            Console.ReadKey(true);
        }
    }
}
