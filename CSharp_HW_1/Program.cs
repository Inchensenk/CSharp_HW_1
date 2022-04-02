using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MenuAction();
        }
        static int Menu()
        {
            
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("(0) Выход из программы");
            Console.WriteLine("(1) Integer24()");
            Console.WriteLine("(2) Integer29()");
            Console.WriteLine("(3) Boolean25()");
            Console.WriteLine("(4) Boolean30()");
            Console.WriteLine("(5) Boolean35()");
            Console.WriteLine("(6) If20()");
            Console.WriteLine("(7) If23()");
            Console.WriteLine("(8) If26()");
            string str;
            str = Console.ReadLine();
            int choise = Convert.ToInt32(str);
            return choise;
        }

        static void MenuAction()
        {
            Menu();
            

            while (Menu() != 0)
            {

                switch (Menu())
                {
                    case 1:
                        {
                            Console.Clear();
                            Integer24();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Integer29();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Boolean25();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Boolean30();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            Boolean35();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            If20();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            If23();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 8:
                        {
                            Console.Clear();
                            If26();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                }
            }
        }
        /*
        Integer24. Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 — понедельник, 2 — вторник, …, 6 — суббота. 
        Дано целое число K, лежащее в диапазоне 1–365. 
        Определить номер дня недели для K-го дня года, если известно, что в этом году 1 января было понедельником.
         */
        static void Integer24()
        {
            int m, k;
            string str;
            Console.Write("Введите колличество дней года от 1 до 365: ");

            //сохранение считанной с консоли строки в переменную
            str = Console.ReadLine();
            //конвертация введенной строки в целочисленный тип и присваивание сконвертированного значения переменной k
            k = Convert.ToInt32(str);
            //для определения номера дня недели вычислим остаток от деления на 7 (так как в неделе 7 дней)
            m = k % 7;

            switch (m)
            {
                case 0:
                    {
                        Console.WriteLine($"Номер дня недели: {m} - Воскресенье");
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine($"Номер дня недели: {m} - Понедельник");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine($"Номер дня недели: {m} - Вторник");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine($"Номер дня недели: {m} - Среда");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine($"Номер дня недели: {m} - Четверг");
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine($"Номер дня недели: {m} - Пятница");
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine($"Номер дня недели: {m} - Суббота");
                    }
                    break;
            }
        }
        /*
        Integer29. Даны целые положительные числа A, B, C. На прямоугольнике размера A × B размещено максимально возможное количество квадратов со стороной C (без наложений). 
        Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника.
         */
        static void Integer29()
        {
            string str;
            int A, B, C, R1, R2, K, K2;

            Console.Write("A:");
            str=Console.ReadLine();
            A = Convert.ToInt32(str);

            Console.Write("B:");
            str = Console.ReadLine();
            B = Convert.ToInt32(str);

            Console.Write("C:");
            str = Console.ReadLine();
            C = Convert.ToInt32(str);

            R1 = A * B;
            R2 = C * C;
            K = R1/R2;
            K2 = R1 - (K * R2);

            Console.WriteLine($"Колличесво квадратов = {K}");
            Console.WriteLine($"Площадь незаполненная квадратами = {K2}");
        }

        /*
         Boolean25. Даны числа x, y. Проверить истинность высказывания: «Точка с ко-ординатами (x, y) лежит во второй координатной четверти».
         */
        static void Boolean25()
        {
            string str;
            int x, y;
            Console.Write("X: ");
            str = Console.ReadLine();
            x= Convert.ToInt32(str);

            Console.Write("Y: ");
            str = Console.ReadLine();
            y = Convert.ToInt32(str);

            if (x < 0 && y > 0)
            {
                Console.WriteLine("Высказывание истинно");
            }
            else
            {
                Console.WriteLine("Высказывание ложно");
            }
            
        }

        /*
        Boolean30. Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника. 
        Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним».
         */
        static void Boolean30()
        {
            string str;
            float a, b, c;
            Console.Write("Введите сторону треугольника a: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Введите сторону треугольника b: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.Write("Введите сторону треугольника c: ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            if((a == b) & (a == c) & (b == c))
            {
                Console.WriteLine($"Треугольник со сторонами a = {a}, b = {b}, c = {c} является равносторонним");
            }
            else
            {
                Console.WriteLine($"Треугольник со сторонами a = {a}, b = {b}, c = {c} НЕ является равносторонним");
            }
            
        }

        /*
        Boolean35. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). 
        Проверить истинность высказывания: «Данные поля имеют одинаковый цвет».
         */
        static void Boolean35()
        {
            string str;
            int x1, x2, y1, y2;
            Console.Write("Введите координату X1: ");
            str = Console.ReadLine();
            x1 = Convert.ToInt32(str);

            Console.Write("Введите координату Y1: ");
            str = Console.ReadLine();
            y1 = Convert.ToInt32(str);

            Console.Write("Введите координату X2: ");
            str = Console.ReadLine();
            x2 = Convert.ToInt32(str);

            Console.Write("Введите координату Y2: ");
            str = Console.ReadLine();
            y2 = Convert.ToInt32(str);

            if ((x1 + y1) % 2 == (x2 + y2) % 2)
            {
                Console.WriteLine("Данные поля имеют одинаковый цвет");
            }
            else
            {
                Console.WriteLine("Данные поля НЕ имеют одинаковый цвет");
            }
        }

        /*
        If20. На числовой оси расположены три точки: A, B, C. 
        Определить, какая из двух последних точек (B или C) расположена ближе к A, и вывести эту точку и ее расстояние от точки A.
         */
        static void If20()
        {
            string str;
            int a, b, c;

            Console.Write("Введите первое число: ");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Введите второе число: ");
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.Write("Введите третье число: ");
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            if (Math.Abs(a - b) < Math.Abs(a - c))
            {
                Console.WriteLine($"Точка: {b}");
            }
            if ((a - b) > 0)
            {
                Console.WriteLine($"Расстояние: {a-b}");
            }
            else if ((a - b) < 0)
            {
                Console.WriteLine($"Расстояние: {(a - b)*(-1)}");
            }
            else
            {
                Console.WriteLine($"Точка: {c}");
            }
            if ((a - c) > 0)
            {
                Console.WriteLine($"Расстояние: {a-c}");
            }
            else if ((a - c) < 0)
            {
                Console.WriteLine($"Расстояние: {(a - c) * (-1)}");
            }
        }

        /*
        If23. Даны целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. 
        Найти координаты его четвертой вершины.
         */
        static void If23()
        {
            string str;
            int x1, y1, x2, y2, x3, y3;

            Console.Write("Введите координату X1: ");
            str = Console.ReadLine();
            x1 = Convert.ToInt32(str);

            Console.Write("Введите координату Y1: ");
            str = Console.ReadLine();
            y1 = Convert.ToInt32(str);

            Console.Write("Введите координату X2: ");
            str = Console.ReadLine();
            x2 = Convert.ToInt32(str);

            Console.Write("Введите координату Y2: ");
            str = Console.ReadLine();
            y2 = Convert.ToInt32(str);

            Console.Write("Введите координату X3: ");
            str = Console.ReadLine();
            x3 = Convert.ToInt32(str);

            Console.Write("Введите координату Y3: ");
            str = Console.ReadLine();
            y3 = Convert.ToInt32(str);

            if (x2 == x3)
            {
                Console.WriteLine($"X4:{x1}");
            }
            else if (x3 == x1)
            {
                Console.WriteLine($"X4:{x2}");
            }
            else
            {
                Console.WriteLine($"X4:{x3}");
            }
            if (y2 == y3)
            {
                Console.WriteLine($"Y4:{y1}");
            }
            else if (y3 == y1)
            { 
                Console.WriteLine($"Y4:{y2}"); 
            }
            else
            {
                Console.WriteLine($"Y4:{y3}");
            }
        }

        static void If26()
        {
            string str;
            float x;
            Console.Write("Введите X: ");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);

            if(x <= 0)
            {
                Console.WriteLine($"F(x) = {(-1) * x} ");
            }

            if (x>0 && x < 2)
            {
                Console.WriteLine($"F(x) = {Math.Sqrt(x)} ");
            }
            if (x >= 2)
            {
                Console.WriteLine($"F(x) = {4} ");
            }
        }
    }
}
