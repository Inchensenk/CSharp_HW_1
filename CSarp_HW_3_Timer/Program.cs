using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Выполнить когда познакомимся с классами

Написать класс "Timer" который будет отчитывать время от старта

В программе должно быть простое меню где будут пункты меню "Старт" и "Выход"
В методе "main" создаем экземпляр класса и при нажатии пункта меню "Старт" на консоль выводится таймер отсчитующий часы, минуты и секунты с момента старта таймера.
Когда таймер включен пункт меню "Старт" должен измениться на пункт меню "Остановить", останавливающий и сбрасывающий таймер.

В классе должен быть метод "run" который запускает таймер и печатает в консоль текущее его состояние.

Для отсчета секунд можно использовать метод:

#include <chrono>
#include <thread>

std::this_thread::sleep_for(std::chrono::milliseconds(x));

или другой подходящий способ.

Задание должно быть выполнено в решении в котором содержиться проект Timer, а в самом проекте должен быть хэдер-файл "Timer.h" и файл с исходным кодом с таким же именем*/

namespace CSarp_HW_3_Timer
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param str=""
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string str= "SPACE: Run\nESC: Exit\n";
            Timer timer = new Timer { StrMenu = str };
            timer.PrintMenu();
            
            
            ConsoleKey consoleKey = Console.ReadKey().Key;
            if (consoleKey == ConsoleKey.Spacebar)
            {
                Console.Clear();
                timer.StrMenu = "SPACE: Stop\nESC: Exit\n";
                timer.PrintMenu();
                timer.Run();
            }
            else if (consoleKey == ConsoleKey.Escape)
                Environment.Exit(0);
        }
    }
}
