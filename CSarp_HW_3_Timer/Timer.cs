using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSarp_HW_3_Timer
{
    class Timer : Menu
    {
        /// <summary>
        /// Запуск таймера
        /// </summary>
        /// <param name="sec">секунды</param>
        /// <param name="min">минуты</param>
        /// <param name="hour">часы</param>
        public void Run(int sec = 0, int min = 0, int hour = 0)
        {
              while (true)
              {
                  while (!Console.KeyAvailable)
                  {
                      Console.SetCursorPosition(0, 3);
                      Console.WriteLine($"{hour}:{min}:{sec}");
                      Thread.Sleep(1000);
                      sec++;
                      if (sec >= 60)
                      {                    
                          min += sec / 60;
                          sec = sec % 60;
                      }
                      if (min >= 60)
                      {
                          hour += min / 60;
                          min = min % 60;
                      }      
                  }
                  ConsoleKey consoleKey = Console.ReadKey(true).Key;
                  if (consoleKey == ConsoleKey.Spacebar)
                  {
                      Stop();
                  }
                  else if (consoleKey == ConsoleKey.Escape)
                      Environment.Exit(0);
              }  
        }
        /// <summary>
        /// Остановка таймера
        /// </summary>
        private void Stop()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("SPACE: Run ");

            while (true)
            {
                while (!Console.KeyAvailable)
                {
                    
                }
                ConsoleKey consoleKey = Console.ReadKey(true).Key;
                if (consoleKey == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.Write("SPACE: Stop");
                    Run();
                }
                else if (consoleKey == ConsoleKey.Escape)
                    Environment.Exit(0);
            }
        }
    }
}
