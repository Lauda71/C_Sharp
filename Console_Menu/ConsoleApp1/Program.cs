using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using Maassa;


namespace ConsoleApp1 
{
    class Program
    {

       
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetBufferSize(9999, 500);

            

            // Создание блокоов
            Methods.Block(2, 1, 70, 3, 15, 2, "Создать массив");
            Methods.Block(2, 5, 70, 3, 8, 15, "Суммировать все элементы массива");
            Methods.Block(2, 9, 70, 3, 8, 15, "Суммировать некоторые элементы массива");
            Methods.Block(2, 13, 70, 3, 8, 15, "Суммировать от одного до другого элементы массива");
            Methods.Block(2, 17, 70, 3, 8, 15, "Увеличить все элементы массива на необходимое значение");
            Methods.Block(2, 21, 70, 3, 8, 15, "Вычислить среднее арифметическое элементов массива");
            Methods.Block(2, 25, 70, 3, 8, 15, "Выполнить Реверс всего массива");
            Methods.Block(2, 29, 70, 3, 8, 15, "Переставить одну пару элементов по их позициям");
            Methods.Block(2, 33, 70, 3, 8, 15, "Найти позицию максимального элемента массива");
            Methods.Block(2, 37, 70, 3, 8, 15, "Найти позицию минимального элемента массива");
            Methods.Block(2, 41, 70, 3, 8, 15, "Выполнить поиск элемента в массиве ");
            Methods.Block(2, 45, 70, 3, 8, 15, "Выполнить поиск элемента в заданном фрагменте массива ");
            Methods.Block(2, 49, 70, 3, 8, 15, "Бегущая строка влево");
            Methods.Block(2, 53, 70, 3, 8, 15, "Бегущая строка вправо");
            Methods.Block(2, 57, 70, 3, 8, 15, "Удаление всего массива ");
            Methods.Block(2, 61, 70, 3, 8, 15, "Удаление от одного элемента массива до конечного");
            Methods.Block(2, 65, 70, 3, 8, 15, "Удаление нескольких элементов массива");
            Methods.Block(2, 69, 70, 3, 8, 15, "Добавление нескольких элементов массива");
            Methods.Block(2, 73, 70, 3, 8, 15, "Копировать весь массив");
            Methods.Block(2, 77, 70, 3, 8, 15, "Копировать от выбранного элемента массива до конечного");
            

            Console.SetCursorPosition(0, 0);

            int block = 1; // Активный блок 

            int[] z = new int[0];
            int elements = 0; // Количество элементов массива
            int oot = 0, doo = 0; // Границы элементов массива


            int a = 0, b = 0, c = 0; // Подопотные кролики...

            //Цикл передвижения по меню (Esc - выход) 

            SoundPlayer prom1 = new SoundPlayer("D:\\MUS\\prom8.wav"); 
            SoundPlayer prom2 = new SoundPlayer("D:\\MUS\\prom2.wav");
            SoundPlayer prom3 = new SoundPlayer("D:\\MUS\\prom3.wav");
            SoundPlayer prom4 = new SoundPlayer("D:\\MUS\\prom4.wav");
            SoundPlayer prom5 = new SoundPlayer("D:\\MUS\\prom5.wav");
            SoundPlayer prom6 = new SoundPlayer("D:\\MUS\\prom6.wav");

            

            
            
            ConsoleKeyInfo keyinfo;
            do
            {
                
                keyinfo = Console.ReadKey(true);

                if (keyinfo.Key == ConsoleKey.UpArrow && block != 1) // Вверх 
                {
                    block--;
                    switch (block)
                    {
                        case 1:
                            prom1.Play();
                            Methods.Block(2, 1, 70, 3, 15, 2, "Создать массив");
                            Methods.Block(2, 5, 70, 3, 8, 15, "Суммировать все элементы массива");
                            Console.SetCursorPosition(0, 0);
                            break;
                        case 2:
                            prom2.Play();
                            Methods.Block(2, 5, 70, 3, 15, 2, "Суммировать все элементы массива");
                            Methods.Block(2, 9, 70, 3, 8, 15, "Суммировать некоторые элементы массива");
                            break;
                        case 3:
                            prom3.Play();
                            Methods.Block(2, 9, 70, 3, 15, 2, "Суммировать некоторые элементы массива");
                            Methods.Block(2, 13, 70, 3, 8, 15, "Суммировать от одного до другого элементы массива");
                            break;
                        case 4:
                            prom4.Play();
                            Methods.Block(2, 13, 70, 3, 15, 2, "Суммировать от одного до другого элементы массива");
                            Methods.Block(2, 17, 70, 3, 8, 15, "Увеличить все элементы массива на необходимое значение");
                            break;
                        case 5:
                            prom5.Play();
                            Methods.Block(2, 17, 70, 3, 15, 2, "Увеличить все элементы массива на необходимое значение");
                            Methods.Block(2, 21, 70, 3, 8, 15, "Вычислить среднее арифметическое элементов массива");
                            break;
                        case 6:
                            prom6.Play();
                            Methods.Block(2, 21, 70, 3, 15, 2, "Вычислить среднее арифметическое элементов массива");
                            Methods.Block(2, 25, 70, 3, 8, 15, "Выполнить Реверс всего массива");
                            break;
                        case 7:
                            prom1.Play();
                            Methods.Block(2, 25, 70, 3, 15, 2, "Выполнить Реверс всего массива");
                            Methods.Block(2, 29, 70, 3, 8, 15, "Переставить одну пару элементов по их позициям");
                            break;
                        case 8:
                            prom2.Play();
                            Methods.Block(2, 29, 70, 3, 15, 2, "Переставить одну пару элементов по их позициям");
                            Methods.Block(2, 33, 70, 3, 8, 15, "Найти позицию максимального элемента массива");
                            break;
                        case 9:
                            prom6.Play();
                            Methods.Block(2, 33, 70, 3, 15, 2, "Найти позицию максимального элемента массива");
                            Methods.Block(2, 37, 70, 3, 8, 15, "Найти позицию минимального элемента массива");
                            break;
                        case 10:
                            prom3.Play();
                            Methods.Block(2, 37, 70, 3, 15, 2, "Найти позицию минимального элемента массива");
                            Methods.Block(2, 41, 70, 3, 8, 15, "Выполнить поиск элемента в массиве ");
                            break;
                        case 11:
                            prom4.Play();
                            Methods.Block(2, 41, 70, 3, 15, 2, "Выполнить поиск элемента в массиве ");
                            Methods.Block(2, 45, 70, 3, 8, 15, "Выполнить поиск элемента в заданном фрагменте массива ");
                            break;
                        case 12:
                            prom5.Play();
                            Methods.Block(2, 45, 70, 3, 15, 2, "Выполнить поиск элемента в заданном фрагменте массива ");
                            Methods.Block(2, 49, 70, 3, 8, 15, "Бегущая строка влево");
                            break;
                        case 13:
                            prom6.Play();
                            Methods.Block(2, 49, 70, 3, 15, 2, "Бегущая строка влево");
                            Methods.Block(2, 53, 70, 3, 8, 15, "Бегущая строка вправо");
                            break;
                        case 14:
                            prom1.Play();
                            Methods.Block(2, 53, 70, 3, 15, 2, "Бегущая строка вправо");
                            Methods.Block(2, 57, 70, 3, 8, 15, "Удаление всего массива ");
                            break;
                        case 15:
                            prom2.Play();
                            Methods.Block(2, 57, 70, 3, 15, 2, "Удаление всего массива ");
                            Methods.Block(2, 61, 70, 3, 8, 15, "Удаление от одного элемента массива до конечного");
                            break;
                        case 16:
                            prom3.Play();
                            Methods.Block(2, 61, 70, 3, 15, 2, "Удаление от одного элемента массива до конечного");
                            Methods.Block(2, 65, 70, 3, 8, 15, "Удаление нескольких элементов массива");
                            break;
                        case 17:
                            prom4.Play();
                            Methods.Block(2, 65, 70, 3, 15, 2, "Удаление нескольких элементов массива");
                            Methods.Block(2, 69, 70, 3, 8, 15, "Добавление нескольких элементов массива");
                            break;
                        case 18:
                            prom5.Play();
                            Methods.Block(2, 69, 70, 3, 15, 2, "Добавление нескольких элементов массива");
                            Methods.Block(2, 73, 70, 3, 8, 15, "Копировать весь массив");
                            break;
                        case 19:
                            prom6.Play();
                            Methods.Block(2, 73, 70, 3, 15, 2, "Копировать весь массив");
                            Methods.Block(2, 77, 70, 3, 8, 15, "Копировать от выбранного элемента массива до конечного");
                            break;
                        
                    }
                }

                else if (keyinfo.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(75, 2);

                    switch (block)
                    {
                        case 1:

                            Methods.Block(75, 1, 50, 100, 0, 0, "");
                            Console.SetCursorPosition(0, 0);

                            Methods.Block(75, 1, 70, 3, 5, 15, "                  Укажите, сколько элементов должно быть в массиве:"); //Создание блока
                            Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока                            
                            do { elements = Methods.proverka(152, 2); } while (elements <= 0);



                            Methods.Block(75, 1, 70, 3, 5, 15, "                          Укажите нижнюю границу элементов массива:"); //Создание блока
                            Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока
                            oot = Methods.proverka(152, 2);


                            Methods.Block(75, 1, 70, 3, 5, 15, "                         Укажите верхнюю границу элементов массива:"); //Создание блока
                            Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока
                            do { doo = Methods.proverka(152, 2); } while (doo <= oot);


                            Methods.Block(75, 1, 120, 3, 0, 0, " "); //Создание блока

                            Random ran = new Random();
                            z = new int[elements];



                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;

                            z = Methods.mass(elements, oot, doo);


                            Console.SetCursorPosition(0, 0);
                            break;





                        case 2:
                            //Суммировать все элементы массива

                            if (z.Length != 0)
                            {
                                Methods.summ(z);
                            }
                            break;



                        case 3:
                            //Суммировать некоторые элементы массива

                            if(z.Length!=0)
                            {
                                Methods.Block(75, 1, 70, 3, 5, 15, "                  Укажите номер 1-го элемента в массиве:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { a = Methods.proverka(152, 2); } while (oot-1 > a || a > doo);

                                Methods.Block(75, 1, 70, 3, 5, 15, "                  Укажите номер 2-го элемента в массиве:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока 

                                do { b = Methods.proverka(152, 2); } while (oot-1 > b || b > doo || b<=a);
                                Methods.summ(a, b, z);
                            }
                            break;




                        case 4:
                            //Суммировать от одного до другого элементы массива

                            if (z.Length != 0)
                            {
                                Methods.Block(75, 1, 70, 3, 5, 15, "                  Укажите номер 1-го элемента в массиве:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { a = Methods.proverka(152, 2); } while (oot - 1 > a || a > doo);

                                Methods.Block(75, 1, 70, 3, 5, 15, "                  Укажите номер 2-го элемента в массиве:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока 

                                do { b = Methods.proverka(152, 2); } while (oot - 1 > b || b > doo);

                                Methods.summ(z, a, b, a);
                                
                            }
                            break;




                        case 5:
                            //Увеличить все элементы массива на необходимое значение

                            if (z.Length != 0)
                            {
                                Methods.Block(75, 1, 120, 3, 0, 0, " "); //Создание блока
                                Methods.Block(75, 1, 70, 3, 5, 15, "      Укажите, какое число прибавить ко всем элементам массива:"); //Создание блока

                                do { elements = Methods.proverka(152, 2); } while (elements > 101 || elements < -101);

                                z = Methods.massplus(z, elements);
                            }
                            oot = oot + elements;
                            doo = doo + elements;
                            break;




                        case 6:
                            //Вычислить среднее арифметическое элементов массива

                            if (z.Length != 0)
                            {
                                Methods.srednee(z);
                            }
                            break;




                        case 7:
                            //Выполнить Реверс всего массива

                            if (z.Length != 0)
                            {
                                z = Methods.reverse(z);
                            }
                            break;




                        case 8:
                            //Переставить одну пару элементов по их позициям

                            if (z.Length != 0)
                            {
                                Methods.Block(75, 1, 70, 3, 5, 15, "                  Укажите номер 1-го элемента в массиве:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { a = Methods.proverka(152, 2); } while (oot - 1 >= a || a >= doo);

                                Methods.Block(75, 1, 70, 3, 5, 15, "                  Укажите номер 2-го элемента в массиве:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока 

                                do { b = Methods.proverka(152, 2); } while (oot - 1 >= b || b >= doo);

                                Methods.reverse(z, a, b);
                            }                            
                            break;



                        case 9:
                            //Найти позицию максимального элемента массива
                            if (z.Length != 0)
                            {
                                Methods.pozamax(z);
                            }
                            break;



                        case 10:
                            //Найти позицию минимального элемента массива
                            if (z.Length != 0)
                            {
                                Methods.pozamin(z);
                            }
                            break;



                        case 11:
                            //Выполнить поиск элемента в массиве 
                            if (z.Length != 0)
                            {
                                Methods.Block(75, 1, 70, 3, 5, 15, "                      Укажите значение искомого элемента в массиве:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { a = Methods.proverka(152, 2); } while (oot - 1 >= a || a > doo);

                                Methods.poiskelementa(z, a);
                            }
                            break;



                        case 12:
                            //Выполнить поиск элемента в заданном фрагменте массива 
                            if (z.Length != 0)
                            {
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока  
                                Methods.Block(75, 1, 70, 3, 5, 15, "          Укажите нижнюю границу для поиска элемента в массиве:"); //Создание блока                            

                                do { a = Methods.proverka(152, 2); } while (oot - 1 >= a || a >= doo - 1);

                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока  
                                Methods.Block(75, 1, 70, 3, 5, 15, "          Укажите верхнюю границу для поиска элемента в массиве:"); //Создание блока                            

                                do { b = Methods.proverka(152, 2); } while (oot - 1 >= b || b >= doo);

                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока 
                                Methods.Block(75, 1, 70, 3, 5, 15, "          Укажите значение искомого элемента в массиве:"); //Создание блока
                                { elements = Methods.proverka(152, 2); }

                                Methods.poiskelementa(z, elements, a, b);
                            }
                            break;


                        case 13:
                            //Бегущая строка влево

                            SoundPlayer sp = new SoundPlayer("D:\\feeling\\feeling.wav");
                            sp.Play();
                            Methods.lbegstroka();                            
                            sp.Stop();
                            break;


                        case 14:
                            //Бегущая строка вправо
                            Methods.pbegstroka();
                            break;


                        case 15:
                            //Удаление всего массива 
                            if (z.Length != 0)
                            {
                                z = Methods.deletepls(z);
                            }
                            break;



                        case 16:
                            //Удаление от одного элемента массива до конечного
                            if (z.Length != 0)
                            {
                                Methods.Block(75, 1, 70, 3, 5, 15, "                     Укажите позицию 'не счастливого' элемента:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { a = Methods.proverka(152, 2); } while (0 > a || a > z.Length - 1);
                                z = Methods.deletepls(z, a);
                            }
                            break;



                        case 17:
                            //Удаление нескольких элементов массива
                            if (z.Length != 0)
                            {
                                Console.SetCursorPosition(0, 0);

                                Methods.Block(75, 1, 70, 3, 5, 15, " Укажите позицию 1 элемента ['-1' , если не хотите удалять элемент]:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { a = Methods.proverka(152, 2); } while (-1 > a || a > z.Length - 1);


                                Methods.Block(75, 1, 70, 3, 5, 15, " Укажите позицию 2 элемента ['-1' , если не хотите удалять элемент]:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { b = Methods.proverka(152, 2); } while (-1 > b || b > z.Length - 1);


                                Methods.Block(75, 1, 70, 3, 5, 15, " Укажите позицию 3 элемента ['-1' , если не хотите удалять элемент]:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { c = Methods.proverka(152, 2); } while (-1 > c || c > z.Length - 1);

                                z = Methods.deletepls(z, a, b, c);
                            }
                            break;



                        case 18:
                            //Добавление нескольких элементов массива
                            if (z.Length != 0)
                            {
                                Console.SetCursorPosition(0, 0);

                                Methods.Block(75, 1, 70, 3, 5, 15, " Укажите значение 1 эл-та ['-1' , если не хотите добавлять эл-т]:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { a = Methods.proverka(152, 2); } while (-1 > a);


                                Methods.Block(75, 1, 70, 3, 5, 15, " Укажите значение 2 эл-та ['-1' , если не хотите добавлять эл-т]:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { b = Methods.proverka(152, 2); } while (-1 > b);


                                Methods.Block(75, 1, 70, 3, 5, 15, " Укажите значение 3 эл-та ['-1' , если не хотите добавлять эл-т]:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { c = Methods.proverka(152, 2); } while (-1 > c);

                                z = Methods.addpls(z, a, b, c);
                            }
;                           break;



                        case 19:
                            //Копировать весь массива
                            if (z.Length != 0)
                            {
                                z = Methods.copymass(z);
                            }
                            break;



                        case 20:
                            //Копировать от одного элемента массива до конечного
                            if (z.Length != 0)
                            {
                                Console.SetCursorPosition(0, 0);

                                Methods.Block(75, 1, 70, 3, 5, 15, " Укажите значение элемента, с которого начнется копирование:"); //Создание блока
                                Methods.Block(148, 1, 15, 3, 14, 5, ""); //Создание блока    

                                do { a = Methods.proverka(152, 2); } while (-1 > a || a >= z.Length-1);


                                z = Methods.copymass(z, a);
                            }
                            break;


                    }
                }
                else if (keyinfo.Key == ConsoleKey.DownArrow && block != 20) // Вниз 
                {
                    block++;
                    switch (block)
                    {
                        case 2:
                            prom1.Play();
                            Methods.Block(2, 1, 70, 3, 8, 15, "Создать массив");
                            Methods.Block(2, 5, 70, 3, 15, 2, "Суммировать все элементы массива");
                            break;
                        case 3:
                            prom2.Play();
                            Methods.Block(2, 5, 70, 3, 8, 15, "Суммировать все элементы массива");
                            Methods.Block(2, 9, 70, 3, 15, 2, "Суммировать некоторые элементы массива");
                            break;
                        case 4:
                            prom3.Play();
                            Methods.Block(2, 9, 70, 3, 8, 15, "Суммировать некоторые элементы массива");
                            Methods.Block(2, 13, 70, 3, 15, 2, "Суммировать от одного до другого элементы массива");
                            break;
                        case 5:
                            prom4.Play();
                            Methods.Block(2, 13, 70, 3, 8, 15, "Суммировать от одного до другого элементы массива");
                            Methods.Block(2, 17, 70, 3, 15, 2, "Увеличить все элементы массива на необходимое значение");
                            break;
                        case 6:
                            prom5.Play();
                            Methods.Block(2, 17, 70, 3, 8, 15, "Увеличить все элементы массива на необходимое значение");
                            Methods.Block(2, 21, 70, 3, 15, 2, "Вычислить среднее арифметическое элементов массива");
                            break;
                        case 7:
                            prom6.Play();
                            Methods.Block(2, 21, 70, 3, 8, 15, "Вычислить среднее арифметическое элементов массива");
                            Methods.Block(2, 25, 70, 3, 15, 2, "Выполнить Реверс всего массива");
                            break;
                        case 8:
                            prom1.Play();
                            Methods.Block(2, 25, 70, 3, 8, 15, "Выполнить Реверс всего массива");
                            Methods.Block(2, 29, 70, 3, 15, 2, "Переставить одну пару элементов по их позициям");
                            break;
                        case 9:
                            prom2.Play();
                            Methods.Block(2, 29, 70, 3, 8, 15, "Переставить одну пару элементов по их позициям");
                            Methods.Block(2, 33, 70, 3, 15, 2, "Найти позицию максимального элемента массива");
                            break;
                        case 10:
                            prom3.Play();
                            Methods.Block(2, 33, 70, 3, 8, 15, "Найти позицию максимального элемента массива");
                            Methods.Block(2, 37, 70, 3, 15, 2, "Найти позицию минимального элемента массива");
                            break;
                        case 11:
                            prom4.Play();
                            Methods.Block(2, 37, 70, 3, 8, 15, "Найти позицию минимального элемента массива");
                            Methods.Block(2, 41, 70, 3, 15, 2, "Выполнить поиск элемента в массиве ");
                            break;
                        case 12:
                            prom5.Play();
                            Methods.Block(2, 41, 70, 3, 8, 15, "Выполнить поиск элемента в массиве");
                            Methods.Block(2, 45, 70, 3, 15, 2, "Выполнить поиск элемента в заданном фрагменте массива");
                            break;
                        case 13:
                            prom6.Play();
                            Methods.Block(2, 45, 70, 3, 8, 15, "Выполнить поиск элемента в заданном фрагменте массива ");
                            Methods.Block(2, 49, 70, 3, 15, 2, "Бегущая строка влево");
                            break;
                        case 14:
                            prom1.Play();
                            Methods.Block(2, 49, 70, 3, 8, 15, "Бегущая строка влево");
                            Methods.Block(2, 53, 70, 3, 15, 2, "Бегущая строка вправо");
                            break;
                        case 15:
                            prom2.Play();
                            Methods.Block(2, 53, 70, 3, 8, 15, "Бегущая строка вправо");
                            Methods.Block(2, 57, 70, 3, 15, 2, "Удаление всего массива ");
                            break;
                        case 16:
                            prom3.Play();
                            Methods.Block(2, 57, 70, 3, 8, 15, "Удаление всего массива ");
                            Methods.Block(2, 61, 70, 3, 15, 2, "Удаление от одного элемента массива до конечного");
                            break;
                        case 17:
                            prom4.Play();
                            Methods.Block(2, 61, 70, 3, 8, 15, "Удаление от одного элемента массива до конечного");
                            Methods.Block(2, 65, 70, 3, 15, 2, "Удаление нескольких элементов массива");
                            break;
                        case 18:
                            prom5.Play();
                            Methods.Block(2, 65, 70, 3, 8, 15, "Удаление нескольких элементов массива");
                            Methods.Block(2, 69, 70, 3, 15, 2, "Добавление нескольких элементов массива");
                            break;
                        case 19:
                            prom6.Play();
                            Methods.Block(2, 69, 70, 3, 8, 15, "Добавление нескольких элементов массива");
                            Methods.Block(2, 73, 70, 3, 15, 2, "Копировать весь массив");
                            break;
                        case 20:
                            prom1.Play();
                            Methods.Block(2, 73, 70, 3, 8, 15, "Копировать весь массив");
                            Methods.Block(2, 77, 70, 3, 15, 2, "Копировать от выбранного элемента массива до конечного");
                            break;   
                    }
                }

            } while (keyinfo.Key != ConsoleKey.Escape);


            Console.ReadKey(true);
        }
    }
}
