using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MATRIXA
{
    class Program
    {
        static int[,] create_m(int n, int a) // Создание матрицы
        {
            if (a == 1)
            {
                int[,] mas = new int[n, n];
                Random ran = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mas[i, j] = ran.Next(0, 10);
                    }
                }
                return mas;
            }
            else if (a == 0)
            {
                int[,] mas = new int[n, n];
                Random ran = new Random();
                for (int i = 0; i < n; i++)
                {
                    mas[i, 0] = ran.Next(0, 10);
                }
                return mas;
            }
            int[,] mass = new int[n, n];
            return mass;
        }
        static int[,] transpon_m(int[,] a, int n) // Транспонирование матрицы
        {
            int z;
            for (int i = 0; i < (n - 1); i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    z = a[i, j];
                    a[i, j] = a[j, i];
                    a[j, i] = z;
                }
            }
            return a;
        }
        static int[,] multiplication_m(int[,] a, int[,] b, int n) // Умножение на вектор
        {
            int[,] c = new int[n, 1]; ;
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    x = a[i, j] * b[j, 0];
                    c[i, 0] = c[i, 0] + x;
                }
            }
            return c;
        }
        static double ev_norma_m(int[,] a, int n) // Евклидова норма
        {
            double z = 0, x = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    z = a[i, j] * a[i, j];
                    x = x + z;
                }
            }
            z = Math.Sqrt(x);
            return z;
        }
        static int proverka(int x, int y) // Проверка
        {
            Console.SetCursorPosition(x, y);
            int a = 0;
            string ss;
            do
            {
                ss = Console.ReadLine();
                if (Int32.TryParse(ss, out a) == false) { Console.SetCursorPosition(x, y); Console.Write("                                                                   "); }
                if (a <= 0) { Console.SetCursorPosition(x, y); Console.Write("                                                                   "); }
            }
            while (Int32.TryParse(ss, out a) == false || a <= 0);
            return a;
        }
        static void writye_m(int[,] a, int n, int x, int y, int b) // Вывод матрицыыыыыыыыыыы
        {
            if (b == 0)
            {
                int z = x;
                for (int i = 0; i < n; i++)
                {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(x, y);
                    x = x + 5;
                    Console.Write(a[i, 0]);

                    x = z;
                    y = y + 2;
                }
            }
            else if (b == 1)
            {
                int z = x;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Thread.Sleep(100);
                        Console.SetCursorPosition(x, y);
                        x = x + 5;
                        Console.Write(a[i, j]);
                    }
                    x = z;
                    y = y + 2;
                }
            }
        }
        static int[,] Plusik(int[,] matr1, int[,] matr2) // Сложение!
        {
            int m = matr1.GetLength(0);
            int[,] plus = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    plus[i, j] = matr1[i, j] + matr2[i, j];
                }
            }
            return plus;
        }
        static int[,] Minusik(int[,] matr1, int[,] matr2) // Вычетание!
        {
            int m = matr1.GetLength(0);
            int[,] minus = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    minus[i, j] = matr1[i, j] - matr2[i, j];
                }
            }
            return minus;
        }
        static int[,] Umnojenie(int[,] matr1, int[,] matr2) // Умножение!
        {
            int m = matr1.GetLength(0), sum;
            int[,] umnojenie = new int[m, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum = 0;
                    for (int l = 0; l < m; l++)
                    {
                        sum = sum + (matr1[i, l] * matr2[l, j]);
                    }
                    umnojenie[i, j] = sum;
                }
            }
            return umnojenie;
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight / 2);
            Console.Write(" Введите размерность квадратной матрицы: ");
            int n = proverka(41, 0);
            int[,] mass = create_m(n, 1);
            writye_m(mass, n, 3, 2, 1);
            Thread.Sleep(500);
            int[,] mass2 = create_m(n, 1);
            writye_m(mass2, n, 3, 4 + n * 2, 1);
            int[,] mass_shadow = create_m(n, 1);
            Console.ReadKey(true);
            Console.Clear();

            // -------------------------------------------------------- Сумма матриц:
            Console.WriteLine(" Сумма матриц: \n");
            mass_shadow = Plusik(mass, mass2);
            writye_m(mass_shadow, n, 3, 2, 1);
            Console.ReadKey(true);
            Console.Clear();

            // -------------------------------------------------------- Разность матриц:
            Console.WriteLine(" Разность матриц: \n");
            mass_shadow = Minusik(mass, mass2);
            writye_m(mass_shadow, n, 3, 2, 1);
            Console.ReadKey(true);
            Console.Clear();

            // -------------------------------------------------------- Умножение матриц:
            Console.WriteLine(" Умножение матриц: \n");
            mass_shadow = Umnojenie(mass, mass2);
            writye_m(mass_shadow, n, 3, 2, 1);
            Console.ReadKey(true);
            Console.Clear();

            // -------------------------------------------------------- Умножение 1 матрицы на случайный вектор:
            Console.WriteLine(" Умножение 1 матрицы на случайный вектор: \n ");
            int[,] vektor_m = create_m(n, 0);
            mass_shadow = multiplication_m(mass, vektor_m, n);
            writye_m(mass, n, 3, 2, 1); writye_m(vektor_m, n, n * 6 + 3, 2, 0); writye_m(mass_shadow, n, n * 8 + 3, 2, 0);
            Console.ReadKey(true);
            Console.Clear();

            // -------------------------------------------------------- Умножение 2 матрицы на случайный вектор:
            Console.WriteLine(" Умножение 2 матрицы на случайный вектор: \n ");
            mass_shadow = multiplication_m(mass2, vektor_m, n);
            writye_m(mass2, n, 3, 2, 1); writye_m(vektor_m, n, n * 6 + 3, 2, 0); writye_m(mass_shadow, n, n * 8 + 3, 2, 0);
            Console.ReadKey(true);
            Console.Clear();
            // -------------------------------------------------------- Транспонирование 1 матрицы:
            Console.Write(" Транспонирование: 1 матрицы:\n ");
            mass_shadow = transpon_m(mass, n);
            writye_m(mass_shadow, n, 3, 2, 1);
            Console.ReadKey(true);
            Console.Clear();
            // -------------------------------------------------------- Транспонирование 2 матрицы:
            Console.Write(" Транспонирование: 2 матрицы:\n ");
            mass_shadow = transpon_m(mass2, n);
            writye_m(mass_shadow, n, 3, 2, 1);
            Console.ReadKey(true);
            Console.Clear();
            // -------------------------------------------------------- Евклидова норма 1 матрицы:
            Console.WriteLine(" Евклидова норма: \n ");
            Thread.Sleep(200);
            double eva = ev_norma_m(mass, n);
            Console.Write(" 1 matrix = " + Math.Round(eva, 3)); Thread.Sleep(200); Console.Write("\n 2 matrix = ");
            // -------------------------------------------------------- Евклидова норма 2 матрицы:
            eva = ev_norma_m(mass2, n);
            Console.Write(Math.Round(eva, 3));
            Console.ReadKey(true);
            // -------------------------------------------------------- Обратная матрица (1):
            //Console.WriteLine(" Обратная матрица: \n ");


        }
    }
}
