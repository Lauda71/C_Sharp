using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace super_code_373
{
    class Program
    {
        static double go_d(string s)
        {
            double a;
            bool flag;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\n  Введите переменную ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(s);

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(": ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                flag = double.TryParse(Console.ReadLine(), out a);
                if (!flag)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Не корректный ввод переменной!");
                }
                else if (a > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Не корректный ввод переменной!");
                    flag = false;
                }
                else if (a < -100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Не корректный ввод переменной!");
                    flag = false;
                }
            }
            while (!flag);
            Console.ForegroundColor = ConsoleColor.White;
            return a;
        }

        static void Main(string[] args)
        {
            string s_hello = "\n\n  Приветсвувем вас в программе-расчете корней квадратного уравнения!";
            string s_dip = "  Диапазон переменных: от -100 до 100.  \n\n";
            string sa = "а", sb = "b", sc = "c";

            double a, b, c, x1, x2, d;
            char go_next;

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.WriteLine(s_hello);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(s_dip);
                Console.ForegroundColor = ConsoleColor.White;

                a = go_d(sa);
                b = go_d(sb);
                c = go_d(sc);

                d = b * b - 4 * a * c;

                if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\n  x1");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" = ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0:0.###}", x1);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(";");



                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("  x2");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" = ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0:0.###}", x2);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(".");
                }
                else if (d == 0)
                {
                    x1 = (-b) / (2 * a);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\n  x1");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" = ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(Math.Round(x1, 3));

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(".");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n  Уравнение не имеет корней.");
                    Console.ForegroundColor = ConsoleColor.White;
                }


                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n\n  Для выхода из программы нажмите клавишу Esc, для повтора - любую другую.  \n\n  ");

                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                if (!Char.TryParse(Console.ReadLine(), out go_next)) go_next = '1';

            }
            while (go_next != 27);

        }
    }
}