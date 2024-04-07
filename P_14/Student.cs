using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;

namespace P_14
{
    internal class Student:Person
    {
        public int Course { get; set; }

        public Student () { }
        public Student(string name, string surname, DateTime bday, string fuculty,int course) : base(name, surname, bday, fuculty)
        {
            Name = name;
            Surname = surname;
            Bday = bday;
            Fuculty = fuculty;
            Course = course;
        }


        public override string ToString()
        {
            return $"\nStudent:{Name}\nBithday:{Bday}\nFuculty:{Fuculty}\nCourse:{Course}\nAge:{Age()}";
        }

      public  static Student StudentInput()
      {
         Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Student data:\n");
           Console.ResetColor();
            Console.Write("Name:");
            string name=Console.ReadLine();
            Console.Write("Surname:");
            string surname=Console.ReadLine();
            Console.Write("Birthday:");
            DateTime bday = DateTime.Parse(Console.ReadLine());
            Console.Write("Fuculty:");
            string fuculty =Console.ReadLine();
            Console.Write("Course:");
            int course = int.Parse(Console.ReadLine());

            return new Student(name,surname,bday,fuculty,course);
      }

    }
}
