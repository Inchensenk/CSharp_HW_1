using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HW_4_Students
{
    internal class Student
    {
        /// <summary>
        /// Имя студента
        /// </summary>
        private string name;

        /// <summary>
        ///  Возвращает имя студента
        /// </summary>
        private string Name { get;}

        /// <summary>
        /// Конструктор с параметром
        /// </summary>
        /// <param name="name">Имя студента</param>
        public Student(string name)
        {
            this.name = name;
        }
    }
}
