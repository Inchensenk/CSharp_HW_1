using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarp_HW_2
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            MenuAction();
        }
        static int Menu()
        {


            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();
            Console.WriteLine("Выберите действие: ");
            Console.WriteLine(" (0) Выход из программы");
            Console.WriteLine(" (1) Case10()");
            Console.WriteLine(" (2) Case15()");
            Console.WriteLine(" (3) Case15_1()");
            Console.WriteLine(" (4) For17()");
            Console.WriteLine(" (5) For38()");
            Console.WriteLine(" (6) While26()");
            Console.WriteLine(" (7) While28()");
            Console.WriteLine(" (8) Minmax25()");
            Console.WriteLine(" (9) Array16()");
            Console.WriteLine("(10) Array41()");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
            {
                Environment.Exit(0);
            }

            return choice;
        }

        static void MenuAction()
        {
            int choice = Menu();


            while (choice != 0)
            {

                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Case10();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Case15();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Case15_1();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            For17();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 5:
                        {
                            Console.Clear();
                            For38();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 6:
                        {
                            Console.Clear();
                            While26();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 7:
                        {
                            Console.Clear();
                            While28();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 8:
                        {
                            Console.Clear();
                            Minmax25();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 9:
                        {
                            Console.Clear();
                            Array16();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                    case 10:
                        {
                            Console.Clear();
                            Array41();
                            Console.ReadKey();
                            Console.Clear();
                            MenuAction();
                        }
                        break;
                }
            }
        }


        /*
        Case10.Робот может перемещаться в четырех направлениях(«С» — север, «З» — запад, «Ю» — юг, «В» — восток) и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо.
        Дан символ C — исходное направление робота и целое число N — посланная ему команда.
        Вывести направление робота после выполнения полученной команды.
        */
        static void Case10()
        {
            Console.ForegroundColor= ConsoleColor.DarkBlue;
            Console.WriteLine("Исходное направление движения робота: ");
            Console.ResetColor();
            Console.WriteLine("Север  -  С");
            Console.WriteLine("   Юг  -  Ю");
            Console.WriteLine("Запад  -  З");
            Console.WriteLine("Восток -  В");
            Console.Write("Выберите направление: ");
            String c = Console.ReadLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Возможные операции выполняемые роботом: ");
            Console.ResetColor();
            Console.WriteLine("Продолжать движение  -    0");
            Console.WriteLine("   Повернуть налево  -    1");
            Console.WriteLine("  Повернуть направо  -  (-1)");
            Console.Write("Выберите операцию: ");
            int n = int.Parse(Console.ReadLine());

            switch (c)
            {
                case "С":

                    switch (n)
                    {
                        case 1:
                            {
                                c = "З";
                            }
                            break;
                        case 0:
                            {
                                c = "С";
                            }
                            break;
                        case -1:
                            {
                                c = "В";
                            }
                            break;
                    }
                    break;

                case "В":
                    switch (n)
                    {
                        case 1:
                            {
                                c = "С";
                            }
                            break;
                        case 0:
                            {
                                c = "В";
                            }
                            break;
                        case -1:
                            {
                                c = "Ю";
                            }
                            break;
                    }
                    break;
                case "Ю":
                    switch (n)
                    {
                        case 1:
                            {
                                c = "В";
                            }
                            break;
                        case 0:
                            {
                                c = "Ю";
                            }
                            break;
                        case -1:
                            {
                                c = "З";
                            }
                            break;
                    }
                    break;
                default:
                    switch (n)
                    {
                        case 1:
                            {
                                c = "Ю";
                            }
                            break;
                        case 0:
                            {
                                c = "З";
                            }
                            break;
                        case -1:
                            {
                                c = "С";
                            }
                            break;
                    }
                    break;
            }
            
            switch (c)
            {
                case "С":
                    {
                        Console.Clear();
                        Console.Write("Направление робота после выполнения команды: ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("Север");
                        Console.ResetColor();
                    }
                    break;
                case "Ю":
                    {
                        Console.Clear();
                        Console.Write("Направление робота после выполнения команды: ");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Юг");
                        Console.ResetColor();
                    }
                    break;
                case "З":
                    {
                        Console.Clear();
                        Console.Write("Направление робота после выполнения команды: ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Запад");
                        Console.ResetColor();
                    }
                    break;
                case "В":
                    {
                        Console.Clear();
                        Console.Write("Направление робота после выполнения команды: ");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Восток");
                        Console.ResetColor();
                    }
                    break;
            }
            Console.ReadKey();
        }

        /*Case15.Мастям игральных карт присвоены порядковые номера: 1 — пики, 2 — трефы, 3 — бубны, 4 — червы.
        Достоинству карт, старших десятки, присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз.
        Даны два целых числа: N — достоинство(6 ≤ N ≤ 14) и M — масть карты(1 ≤ M ≤ 4). 
        Вывести название соответствующей карты вида «шестерка бубен», «дама червей», «туз треф» и т.п.
        */
        static void Case15()
        {
            int n, m;
            Console.Write("Достоинство: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Масть: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Выбранная карта: ");
            switch (n)
            {
                case 6:
                    {
                        Console.Write("Шестёрка ");
                    }
                    break;

                case 7:
                    {
                        Console.Write("Семёрка ");
                    }
                    break;

                case 8:
                    {
                        Console.Write("Восьмёрка ");
                    }
                    break;

                case 9:
                    {
                        Console.Write("Девятка ");
                    }
                    break;

                case 10:
                    {
                        Console.Write("Десятка ");
                    }
                    break;

                case 11:
                    {
                        Console.Write("Валет ");
                    }
                    break;

                case 12:
                    {
                        Console.Write("Дама ");
                    }
                    break;

                case 13:
                    {
                        Console.Write("Король ");
                    }
                    break;

                case 14:
                    {
                        Console.Write("Туз ");
                    }
                    break;
            }

            switch (m)
            {
                case 1:
                    {
                        Console.WriteLine("пик");
                    }
                    break;

                case 2:
                    {
                        Console.WriteLine("треф");
                    }
                    break;

                case 3:
                    {
                        Console.WriteLine("бубен");
                    }
                    break;

                case 4:
                    {
                        Console.WriteLine("червей");
                    }
                    break;
            }
        }

        static void Case15_1()
        {
            int choise;
            char cardSuit=' ';
            Console.WriteLine("1 — \u2660\n2 — \u2663\n3 — \u2666\n4 — \u2665");
            Console.WriteLine("Выберите масть карты: ");
            Console.WriteLine(">>");
            choise = Convert.ToInt32(Console.ReadLine());

            if (choise > 4 || choise < 1)
            {
                while (true)
                {
                    Console.WriteLine("Масть карты выбрана неверно, введите ещё раз!");
                    Console.WriteLine("1 — пики, 2 — трефы, 3 — бубны, 4 — червы");
                    Console.WriteLine("Выберите масть карты: ");
                    Console.WriteLine(">>");
                    choise = Convert.ToInt32(Console.ReadLine());
                    if (choise <= 4 && choise >= 1)
                    {
                        break;
                    }
                }
            }

            if (choise == 1)
            {
                cardSuit = '\u2660';
            }
            else if (choise == 2)
            {
                cardSuit = '\u2663';
            }
            else if (choise == 3)
            {
                cardSuit = '\u2666';
            }
            else if (choise == 4)
            {
                cardSuit = '\u2665';
            }

            int numcard;
            string[] cardValues = { "А", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            Console.WriteLine("Введите значение карты:");
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine($"{i+1} - {cardValues[i]}");
            }
            Console.WriteLine(">>");
            numcard = Convert.ToInt32(Console.ReadLine());
            if (numcard>13 || numcard<1)
            {
                while (true)
                {
                    Console.WriteLine("Значение карты выбрано неверно, введите ещё раз!");
                    Console.WriteLine("Введите значение карты:");
                    for (int i = 0; i < 13; i++)
                    {
                        Console.WriteLine($"{i + 1} - {cardValues[i]}");
                    }
                    Console.WriteLine(">>");
                    numcard = Convert.ToInt32(Console.ReadLine());
                    if (numcard <=13 && numcard>=1)
                    {
                        break;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("\t* * * * * * *");
            Console.WriteLine($"\t*{cardValues[numcard-1]} \t    *");
            Console.WriteLine($"\t*{cardSuit} \t    *");
            Console.WriteLine("\t*\t    *");
            Console.WriteLine($"\t*     {cardSuit}     *");
            Console.WriteLine("\t*\t    *");
            Console.WriteLine($"\t*          {cardSuit}*");

            if(cardValues[numcard-1] == "10")
            {
                Console.WriteLine($"\t*         {cardValues[numcard-1]}*");
            }
            else
            {
                Console.WriteLine($"\t*          {cardValues[numcard-1]}*");
            }
            
            Console.WriteLine("\t* * * * * * *");

            choise = 0;
            Console.WriteLine("\nЖелаете продолжить?");
            Console.WriteLine("0 - Нет, возврат в главное меню, 1 - Да");
            Console.WriteLine(">>");
            choise=Convert.ToInt32(Console.ReadLine());
            if(choise == 1)
            {
                Case15_1();
            }
            else
            {
                MenuAction();
            }
        }

        /*
        For17. Дано вещественное число A и целое число N (> 0). 
        Используя один цикл, найти сумму 1 + A + A^2 + A^3 + … + A^N.
         */
        static void For17()
        {
            float a;
            Console.Write("Введите вещественное число A: ");
            a = Convert.ToSingle(Console.ReadLine());

            int n;
            Console.Write("Введите целое число N: ");
            n = Convert.ToInt32(Console.ReadLine());

            float a2 = 1, rez = 1;
            int i;

            for (i = 2; i <= n; ++i)
            {
                a2 *= a;
                rez += a2;
            }
            Console.WriteLine(rez);
        }

        /*
        For38. Дано целое число N (> 0). Найти сумму 1N + 2N-1 + … + N1. 
        Чтобы избежать целочисленного переполнения, вычислять слагаемые этой суммы с помощью вещественной переменной и выводить результат как вещественное число.
         */
        static void For38()
        {
            int n;
            Console.Write("Введите целое число N (> 0): ");
            n = Convert.ToInt32(Console.ReadLine());

            int i, i2;
            float rez = 0, ni;
            for (i = 1; i <= n; ++i)
            {
                ni = i;
                for (i2 = 1; i2 <= n; ++i2)
                {
                    ni *= i;
                    rez += ni;
                }
            }
            Console.WriteLine(rez);
        }

        /*
        While26. Дано целое число N (> 1), являющееся числом Фибоначчи: N = F_K (определение чисел Фибоначчи дано в задании While24). 
        Найти целые числа FK-1 и FK+1 — предыдущее и последующее числа Фибоначчи.
         */
        static void While26()
        {
            int n;
            Console.Write("Введите целое число N (> 1): ");
            n = Convert.ToInt32(Console.ReadLine());

            int f = 0, f1 = 1, f2 = 1;

            while (f<n)
            {
                f = f2 + f1;
                f2 = f1;
                f1 = f;
            }
            Console.WriteLine($"F_k - 1 = {f2}\nF_к + 1 = {f1+f2}");
        }

        /*
        While28. Дано вещественное число ε (> 0). 
        Последовательность вещественных чисел AK определяется следующим образом: A1 = 2 , AK = 2 + 1/AK-1, K = 2, 3, … .
        Найти первый из номеров K, для которых выполняется условие |AK — AK-1| < ε, и вывести этот номер, а также числа AK-1 и AK.
         */
        static void While28()
        {
            float e;
            Console.WriteLine("Введите вещественное число e (> 0)");
            e = Convert.ToSingle(Console.ReadLine());

            float ak1 = 0, ak = 2;
            int k = 1;
            while (Math.Abs(ak-ak1)>=e)
            {
                ++k;
                ak1 = ak;
                ak = 2 + 1 / ak1;
            }

            Console.WriteLine($"К = {k}, А(К-1) = {ak1}, А(К) = {ak}");
        }

        /*
        Minmax25. Дано целое число N (> 1) и набор из N чисел. 
        Найти номера двух соседних чисел из данного набора, произведение которых является минимальным, и вывести вначале меньший, а затем больший номер.
         */
        static void Minmax25()
        {
            int n, i, iMul=0;
            float r1=0, r2=0, minMul=0;
            Console.Write("Введите целое число N (> 1): ");
            n = Convert.ToInt32(Console.ReadLine());

            for ( i = 1; i < n; ++i)
            {
                r2 = r1;

                Console.Write($"{i} число: ");
                r1 = Convert.ToInt32(Console.ReadLine());
                if ((i==2)||(r1*r2<minMul))
                {
                    minMul = r2 * r1;
                    iMul = i;
                }
            }
            Console.WriteLine($"\n{iMul-1}\n{iMul}");
        }

        /*
         Array16. Дан массив A размера N. 
        Вывести его элементы в следующем порядке: A1, AN, A2, AN-1, A3, AN-2, … .
         */
        static void Array16()
        {
            
            int n, i;
            Console.Write("Введите размер массива N: ");
            n=Convert.ToInt32(Console.ReadLine());
            int[] a =new int[n];
            for (i = 0; i < n; ++i)
            {
                Console.Write($"A[{i+1}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (i = 0; i < n/2; ++i)
            {
                Console.WriteLine($"A[{i}]\nA[{n-i-1}]");
            }

            if (n % 2 != 0)
            {
                Console.WriteLine($"A[{n/2}]\n");
            }
        }

        /*
         Array41. Дан массив размера N. 
        Найти два соседних элемента, сумма которых максимальна, и вывести эти элементы в порядке возрастания их индексов.
         */
        static void Array41()
        {
            
            int n;

            Console.Write("Введите размер массива N: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            int i;
            for (i = 0; i < n; ++i)
            {
                Console.Write($"a[{i + 1}] = ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            int summax = a[0] + a[1], k = 1;
            for (i = 2; i < n; ++i)
            {
                if ((a[i - 1] + a[i]) > summax)
                {
                    summax = a[i - 1] + a[i];
                    k = i;
                }
            }
            Console.Write($"\nСоседние элементы массива, сумма которых максимальна: {a[k - 1]}, {a[k]}");
            
        }

    }

}
