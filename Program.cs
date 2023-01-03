using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {  //Получаем вводные данные, количество вводимых слов
            Console.WriteLine("Укажите номер задачи от 1 до 7 и 0 для выхода");
            int a = Convert.ToInt32(Console.ReadLine());
            while (a != 0)
            {
                switch (a)
                {
                    case 1: task1(); break;
                    case 2: task2(); break;
                    case 3: task3(); break;
                    case 4: task4(); break;
                    case 5: task5(); break;
                    case 6: task6(); break;
                    case 7: task7(); break;
                    default: Console.WriteLine("Такой задачи нет"); break;

                }
                Console.WriteLine("Укажите номер задачи от 1 до 7 и 0 для выхода");
                a = Convert.ToInt32(Console.ReadLine());

            }
        }

        static void task1()
        {
            Console.WriteLine("Место для условия задачи 1");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Все натуральные числа от 1 до " + n);
            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }


        static void task2()
        {
            Console.WriteLine("Место для условия задачи 2");

            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число M");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Все натуральные числа от " + n + " до " + m);
            for (int i = n; i < m + 1; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
        static void task3()
        {
            Console.WriteLine("Место для условия задачи 3");

            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int sum = 0;

            while (n > 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }


            Console.WriteLine("Cумма цифр числа " + m + " равна " + sum);
            Console.WriteLine("");
        }
        static void task4()
        {
            Console.WriteLine("Место для условия задачи 4");

            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число M");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n + " в степени " + m + " равняется " + recurs(n, m));
            Console.WriteLine("");
        }

        static int recurs(int basis, int power)
        {
            if (power == 1) return basis;
            else return basis * recurs(basis, power - 1);

        }
        static void task5()
        {
            Console.WriteLine("Место для условия задачи 5");
            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Все натуральные числа от " + n + " до 1");
            for (int i = n; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }
        static void task6()
        {
            Console.WriteLine("Место для условия задачи 6");

            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число M");
            int m = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = n; i < m + 1; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Cумма натуральных элементов в диапазоне от " + n + " до " + m + " равняется " + sum);
        }
        static void task7()
        {
            Console.WriteLine("Место для условия задачи 7");

            Console.WriteLine("Введите число N");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число M");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Функция Аккермана для " + n + " и " + m + " равняется " + acc(n,m));
        }

        static int acc(int n, int m)
        {
            if (n == 0)
                return m + 1;
            else
              if ((n != 0) && (m == 0))
                return acc(n - 1, 1);
            else
                return acc(n - 1, acc(n, m - 1));
        }
    }
}
