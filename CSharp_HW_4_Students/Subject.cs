using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_4_Students
{
    internal class Subject
    {
        /// <summary>
        /// Название предмета
        /// </summary>
        private string name;

        /// <summary>
        /// Возвращает название предмета
        /// </summary>
        private string Name { get;}

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название предмета</param>
        Subject(string name)
        {
            this.name = name;
        }
    }
}
