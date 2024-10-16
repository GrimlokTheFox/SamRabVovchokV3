using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamRabVovchokV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здраствуйте! Это задание выполнено студентом ТВИД-124з Вовчок Глебом Ивановичем.");
            Start();
        }
        static public void Start()
        {
            Console.WriteLine("Введите номер от 1 до 5.");
        start:
            //Чтобы было безперебойно, была введена проверка фаталок и проверка от неверных значений, не входящих в результат.
            try
            {
                //goto уже устарел, но всё ещё работает, хотя всё можно было чисто через switch... ...case реализовать.
                int VarNum = int.Parse(Console.ReadLine());
                if (VarNum > 0 && VarNum <= 5)
                {
                    switch (VarNum)
                    {
                        case 1:
                            goto first;
                        case 2:
                            goto second;
                        case 3:
                            goto third;
                        case 4:
                            goto fourth;
                        case 5:
                            goto fifth;
                    }



                }
                else
                {
                    Console.WriteLine("Такой цифры нет в задании.");
                    Console.Read();
                }
            }
            catch (System.Exception)
            {
                Console.WriteLine("Вы ввели неверно. Попробуйте ещё раз");
            }
            goto start;

        first:
            //Простое вычисление, не объясняя. Вывод результата.
            Console.WriteLine(" Задание 1.\nРешение арифметического уравнеия.");

            Num1();
            Console.ReadKey();
            goto start;
        second:
            Console.WriteLine(" Задание 2.\nЗадача с графикой.");

            Num2();
            Console.ReadKey();
            goto start;
        third:
            Console.WriteLine(" Задание 3.\n");

            Num3();
            Console.ReadKey();
            goto start;
        fourth:
            Console.WriteLine(" Задание 4.\n");

            Num4();
            Console.ReadKey();
            goto start;
        fifth:
            Console.WriteLine(" Задание 5.\n");

            Num5();
            Console.ReadKey();
            goto start;


        }

        static public void Num1()
        {
            //Здесь происходят базовые расчёты, использующие библиотеку Math.
            double a = 0;
            double b = 0;
            double c = 0;
            double res = 0;
            Console.Write("Первый вариант(контрольный пример): ");
            a = 5;
            b = 9;
            c = -3;
            res = ((8+Math.Sin(3+c)/(b-a))+(3*(Math.Log((3*b-2),a)))+((Math.Sqrt(a+b+2))/(Math.Pow((b-1),3.0))));
            Console.WriteLine(res);
            Console.Write("Второй вариант(реальный пример):");
            a = 5.23;
            b = 8.54;
            c = 1.46;
            res = ((8 + Math.Sin(3 + c) / (b - a)) + (3 * (Math.Log((3 * b - 2), a))) + ((Math.Sqrt(a + b + 2)) / (Math.Pow((b - 1), 3.0))));
            Console.WriteLine(res);
            //Третий вариант чисто для проверки того, что в случае неверных значений, у вас будет выдаваться 
            //"не число" или ошибка, что вы неверно ввели
            Console.WriteLine("Ваш вариант: ");
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Произошла критическая ошибка, попробуйте ввести другое значение");
                Num1();
            }
            try
            {
                b = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Произошла критическая ошибка, попробуйте ввести другое значение");
                Num1();
            }
            try
            {
                c = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Произошла критическая ошибка, попробуйте ввести другое значение");
                Num1();
            }
            try
            {
                res = ((8 + Math.Sin(3 + c) / (b - a)) + (3 * (Math.Log((3 * b - 2), a))) + ((Math.Sqrt(a + b + 2)) / (Math.Pow((b - 1), 3.0))));
                Console.WriteLine("Результат: " + res);

            }
            catch (System.Exception)
            {
                Console.WriteLine("Произошла критическая ошибка, попробуйте ввести другие значения для выражения");
                Num1();
            }

        }
        public static double X = 0;
        public static double Y = 0;
        static public void Num2()
        {
            //
            //Задействован WinForms. 
            //Есть отображение.
            //Ваши переменные вводятся с проверкой.
            //
            Console.WriteLine("Задача на поиск точки, которая попадает в закрашенную территорию. (После того, как вы введёте, увидите изображение, куда вы попали.");
            Console.Write("Введите X: ");
            try
            {
                X = double.Parse(Console.ReadLine());
            }
            catch (System.Exception)
            {
                Console.WriteLine("Произошла критическая ошибка, попробуйте ввести другие значения для выражения");
                Num2();
            }
            Console.Write("Введите Y: ");
            try
            {
             Y = double.Parse(Console.ReadLine());
                Task2Graphics task2 = new Task2Graphics(X, Y);
                task2.ShowDialog();
                Start();
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                Num2();
            }
            


        }
        static public void Num3()
        {
            // Считываем размер матрицы
            Console.Write("Введите размер матрицы n (n >= 2): ");
            int n = int.Parse(Console.ReadLine());

            // Проверка на корректный ввод
            if (n < 2)
            {
                Console.WriteLine("Размер матрицы должен быть >= 2.");
                return;
            }

            // Инициализируем матрицу
            double[,] matrix = new double[n, n];
            Random rand = new Random();

            // Заполняем матрицу случайными числами
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.NextDouble() * 100; // Заполняем числами от 0 до 100
                }
            }

            // Выводим матрицу
            Console.WriteLine("Сгенерированная матрица:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j]:F2} ");
                }
                Console.WriteLine();
            }

            // Создаем последовательность b
            int[] b = new int[n];

            for (int i = 0; i < n; i++)
            {
                bool isDecreasing = true;
                for (int j = 1; j < n; j++)
                {
                    if (matrix[i, j] >= matrix[i, j - 1]) // Проверяем на убывание
                    {
                        isDecreasing = false;
                        break;
                    }
                }
                b[i] = isDecreasing ? 1 : 0;
            }

            // Выводим последовательность b
            Console.WriteLine("Последовательность b:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            Start();
        }
        static public void Num4()
        {
            // Считываем входную строку
            Console.Write("Введите строку символов: ");
            string input = Console.ReadLine();

            // Находим индекс первой точки
            int dotIndex = input.IndexOf('.');

            // Проверка, что точка найдена
            if (dotIndex != -1)
            {
                // Удаляем запятые перед первой точкой
                string partBeforeDot = input.Substring(0, dotIndex).Replace(",", "");
                string partAfterDot = input.Substring(dotIndex);

                // Заменяем все '3' на '+' после первой точки
                partAfterDot = partAfterDot.Replace('3', '+');

                // Объединяем части
                string result = partBeforeDot + partAfterDot;

                // Выводим результат
                Console.WriteLine("Результат: " + result);
            }
            else
            {
                Console.WriteLine("Нет точки в строке.");
            }
            Start();
        }
        static public void Num5()
        {
            Console.WriteLine("Чтобы реализовать задание в 3D графике, нужно задействовать пакет NuGet: OpenTK, к сожалению, в этом я не силён.");
            Start();
        }
    }
}
