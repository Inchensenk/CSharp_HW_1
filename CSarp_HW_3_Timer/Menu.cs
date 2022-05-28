using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSarp_HW_3_Timer
{
    abstract class Menu
    {
        public string StrMenu { get; set; }

        public void PrintMenu()
        {
            Console.WriteLine(StrMenu);
            
        }
    }
}
