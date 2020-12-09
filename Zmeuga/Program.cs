using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Media;

namespace Zmeuga
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadKey(true);
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.SetWindowSize(50, 26);
            Console.SetBufferSize(51, 30);

            const int n = 25, m = 50;
            int[,] a = new int[n,m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = 0; 
                }
            }

            for (int i = 0; i < n; i++)
            {
                a[i, 0] = -1;
                a[i, m-1] = -1;
            }
            for (int i = 0; i < m; i++)
            {
                a[0, i] = -1;
                a[n-1, i] = -1;
            }

            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < m; j++)
                {                    
                    if (a[i, j] == 0) Console.Write(" ");
                    else if (a[i, j] == -1) Console.Write("#");
                }
                Console.Write("\n");
            }





            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(25,12); Console.Write("@"); a[12, 25] = 2;
            ConsoleKeyInfo keyinfo;

            int count = 1;
            Random ran = new Random();
            int xxx = 0, yyy = 0;  
            int xx = 25, yy = 12;
            int x = 25, y = 12;

            xxx = ran.Next(2, 48); yyy = ran.Next(2, 23);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(xxx, yyy);
            Console.Write("o");
            a[yyy, xxx] = -2;
            
            Console.ForegroundColor = ConsoleColor.DarkMagenta;


            SoundPlayer hrum = new SoundPlayer("D:\\CSound\\hrum.wav");
            SoundPlayer smeh = new SoundPlayer("D:\\CSound\\smeh.wav");



            do
            {
                keyinfo = Console.ReadKey(true);




                if (keyinfo.Key == ConsoleKey.UpArrow)
                {
                    do
                    {
                        Thread.Sleep(100);
                        yy = y; xx = x;
                        a[yy, xx] = count;
                        y--;
                        if (a[y, x] >= 2) { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(30, 10); Console.Write("Игра окончена!"); goto end; }
                        a[y, x] = 2;
                        if (x == 0 || x == 49 || y == 0 || y == 24) { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(30, 10); Console.Write("Игра окончена!"); goto end; }

                        // if(a[y,x]>=2){ Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(20, 10); Console.Write("Игра окончена!"); goto end; }

                        Console.Clear();
                        for (int i = 0; i < n; i++)
                        {

                            for (int j = 0; j < m; j++)
                            {
                                if (a[i, j] >= 1) a[i, j]--;

                                if (a[i, j] == 0) Console.Write(" ");
                                else if (a[i, j] == -1) { Console.ForegroundColor = ConsoleColor.Black; Console.Write("#"); }
                                else if (a[i, j] >= 1) { Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("@"); }
                                else if (a[i, j] == -2) { Console.ForegroundColor = ConsoleColor.White; Console.Write("o"); }
                            }
                            Console.Write("\n");
                        }

                        if (x == xxx && y == yyy)
                        {
                            hrum.Play();
                            a[yyy, xxx] = 2;
                            xxx = ran.Next(2, 48); yyy = ran.Next(2, 23);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(xxx, yyy);
                            Console.Write("o");
                            a[yyy, xxx] = -2;
                            count++;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }

                    } while (Console.KeyAvailable == false);
                }







                if (keyinfo.Key == ConsoleKey.DownArrow)
                {
                    do
                    {
                        Thread.Sleep(100);
                        yy = y; xx = x;
                        a[yy, xx] = count;
                        y++;
                        if (a[y, x] >= 2) { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(30, 10); Console.Write("Игра окончена!"); goto end; }
                        a[y, x] = 2;
                        if (x == 0 || x == 49 || y == 0 || y == 24) { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(30, 10); Console.Write("Игра окончена!"); goto end; }

                        Console.Clear();
                        for (int i = 0; i < n; i++)
                        {

                            for (int j = 0; j < m; j++)
                            {
                                if (a[i, j] >= 1) a[i, j]--;

                                if (a[i, j] == 0) Console.Write(" ");
                                else if (a[i, j] == -1) { Console.ForegroundColor = ConsoleColor.Black; Console.Write("#"); }
                                else if (a[i, j] >= 1) { Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("@"); }
                                else if (a[i, j] == -2) { Console.ForegroundColor = ConsoleColor.White; Console.Write("o"); }
                            }
                            Console.Write("\n");
                        }

                        if (x == xxx && y == yyy)
                        {
                            hrum.Play();
                            a[yyy, xxx] = 2;
                            xxx = ran.Next(2, 48); yyy = ran.Next(2, 23);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(xxx, yyy);
                            Console.Write("o");
                            a[yyy, xxx] = -2;
                            count++;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }

                    } while (Console.KeyAvailable == false);
                }



                if (keyinfo.Key == ConsoleKey.LeftArrow)
                {
                    do
                    {
                        Thread.Sleep(85);
                        yy = y; xx = x;
                        a[yy, xx] = count;
                        x--;
                        if (a[y, x] >= 2) { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(30, 10); Console.Write("Игра окончена!"); goto end; }
                        a[y, x] = 2;
                        if (x == 0 || x == 49 || y == 0 || y == 24) { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(30, 10); Console.Write("Игра окончена!"); goto end; }

                        Console.Clear();
                        for (int i = 0; i < n; i++)
                        {

                            for (int j = 0; j < m; j++)
                            {
                                if (a[i, j] >= 1) a[i, j]--;

                                if (a[i, j] == 0) Console.Write(" ");
                                else if (a[i, j] == -1) { Console.ForegroundColor = ConsoleColor.Black; Console.Write("#"); }
                                else if (a[i, j] >= 1) { Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("@"); }
                                else if (a[i, j] == -2) { Console.ForegroundColor = ConsoleColor.White; Console.Write("o"); }
                            }
                            Console.Write("\n");
                        }

                        if (x == xxx && y == yyy)
                        {
                            hrum.Play();
                            a[yyy, xxx] = 2;
                            xxx = ran.Next(2, 48); yyy = ran.Next(2, 23);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(xxx, yyy);
                            Console.Write("o");
                            a[yyy, xxx] = -2;
                            count++;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }

                    } while (Console.KeyAvailable == false);
                }


                if (keyinfo.Key == ConsoleKey.RightArrow)
                {
                    do
                    {
                        Thread.Sleep(85);
                        yy = y; xx = x;
                        a[yy, xx] = count;
                        x++;
                        if (a[y, x] >= 2) { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(30, 10); Console.Write("Игра окончена!"); goto end; }
                        a[y, x] = 2;
                        if (x == 0 || x == 49 || y == 0 || y == 24) { Console.ForegroundColor = ConsoleColor.Red; Console.BackgroundColor = ConsoleColor.Black; Console.Clear(); Console.SetCursorPosition(30, 10); Console.Write("Игра окончена!"); goto end; }

                        Console.Clear();
                        for (int i = 0; i < n; i++)
                        {

                            for (int j = 0; j < m; j++)
                            {
                                if (a[i, j] >= 1) a[i, j]--;

                                if (a[i, j] == 0) Console.Write(" ");
                                else if (a[i, j] == -1) { Console.ForegroundColor = ConsoleColor.Black; Console.Write("#"); }
                                else if (a[i, j] >= 1) { Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.Write("@"); }
                                else if (a[i, j] == -2) { Console.ForegroundColor = ConsoleColor.White; Console.Write("o"); }
                            }
                            Console.Write("\n");
                        }

                        if (x == xxx && y == yyy)
                        {
                            hrum.Play();
                            a[yyy, xxx] = 2;
                            xxx = ran.Next(2, 48); yyy = ran.Next(2, 23);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.SetCursorPosition(xxx, yyy);
                            Console.Write("o");
                            a[yyy, xxx] = -2;
                            count++;
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        }

                    } while (Console.KeyAvailable == false);
                }

                

            } while (keyinfo.Key != ConsoleKey.Escape);
        end:
            smeh.Play();
            Console.SetBufferSize(100, 93);
            

            Console.SetCursorPosition(5, 1); Console.Write("                ██");
            Console.SetCursorPosition(5, 2); Console.Write("                ███");
            Console.SetCursorPosition(5, 3); Console.Write("  ██           ████");
            Console.SetCursorPosition(5, 4); Console.Write("  ███         ██████");
            Console.SetCursorPosition(5, 5); Console.Write("  ████       ███████");
            Console.SetCursorPosition(5, 6); Console.Write("   █████   █████7███");
            Console.SetCursorPosition(5, 7); Console.Write("    █████▓▓█████████");
            Console.SetCursorPosition(5, 8); Console.Write("     ████▓▓████████");
            Console.SetCursorPosition(5, 9); Console.Write("      ███▓▓███████");
            Console.SetCursorPosition(5, 10); Console.Write("      ██▓▓██████");
            Console.SetCursorPosition(5, 11); Console.Write("     ██▓▓█████");
            Console.SetCursorPosition(5, 12); Console.Write("    ██▓▓████");
            Console.SetCursorPosition(5, 13); Console.Write("   ██▓▓███");
            Console.SetCursorPosition(5, 14); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 15); Console.Write(" ██▓▓██ ");
            Console.SetCursorPosition(5, 16); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 17); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 18); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 19); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 20); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 21); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 22); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 23); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 24); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 25); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 26); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 27); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 28); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 29); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 30); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 31); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 32); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 33); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 34); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 35); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 36); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 37); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 38); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 39); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 40); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 41); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 42); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 43); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 44); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 45); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 46); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 47); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 48); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 49); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 50); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 51); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 52); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 53); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 54); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 55); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 56); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 57); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 58); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 59); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 60); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 61); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 62); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 63); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 64); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 65); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 66); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 67); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 68); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 69); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 70); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 71); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 72); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 73); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 74); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 75); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 76); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 77); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 78); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 79); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 80); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 81); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 82); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 83); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 84); Console.Write("     ██▓▓██");
            Console.SetCursorPosition(5, 85); Console.Write("    ██▓▓██");
            Console.SetCursorPosition(5, 86); Console.Write("   ██▓▓██");
            Console.SetCursorPosition(5, 87); Console.Write("  ██▓▓██");
            Console.SetCursorPosition(5, 88); Console.Write(" ██▓▓██");
            Console.SetCursorPosition(5, 89); Console.Write("  █▓▓█");
            Console.SetCursorPosition(5, 90); Console.Write("   ▓▓");
            Console.SetCursorPosition(5, 91); Console.Write("    ▓");
            Console.SetWindowSize(50, 50);
            Console.SetCursorPosition(0, 0); Console.Write("");

            Console.ReadKey(true);
            Console.ReadKey(true);
        }
    }
}
