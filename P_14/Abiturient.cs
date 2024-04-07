using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_14
{
    internal class Abiturient : Person
    {

        public Abiturient() { }
        public Abiturient(string name, string surname, DateTime bday, string fuculty) :base( name,surname, bday, fuculty)
        {
            Name = name;
            Surname = surname;
            Bday = bday;
            Fuculty = fuculty;
        }

        public override string ToString()
        {
            return $"\nAbiturient:{Name}\n Bithday:{Bday}\nFuculty:{Fuculty}\nAge:{Age()}";
        }


        public static Abiturient AbiturientInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Abiturient data:\n");
            Console.ResetColor();
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Surname:");
            string surname = Console.ReadLine();
            Console.Write("Birthday:");
            DateTime bday = DateTime.Parse(Console.ReadLine());
            Console.Write("Fuculty:");
             string  fuculty = Console.ReadLine();
            

            return new Abiturient (name, surname, bday, fuculty);
        }
    }
}
