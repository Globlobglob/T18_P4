using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_14
{
    internal class Teacher:Person
    {

        public string Post { get; set; }
        public int Stan { get; set; }
        public Teacher() { }
        public Teacher(string name, string surname, DateTime bday, string fuculty,string post,int stan) : base(name, surname, bday, fuculty)
        {
           
            Post = post;
            Stan = stan;
        }


       

        public override string ToString()
        {
            return $"\nTeacher:{Name}\n Bithday:{Bday}\nFuculty:{Fuculty}\nPost:{Post}\nWork Experience:{Stan}\nAge:{Age()}";
        }


       


        public static Teacher TeacherInput()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter Teacher data:\n");
            Console.ResetColor();
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Surname:");
            string surname = Console.ReadLine();
            Console.Write("Birthday:");
            DateTime bday = DateTime.Parse(Console.ReadLine());
            Console.Write("Fuculty:");
            string fuculty = Console.ReadLine();
            Console.Write("Post:");
            string post = Console.ReadLine();
            Console.Write("Work Experience:");
            int stan = int.Parse(Console.ReadLine());


            return new Teacher(name, surname, bday, fuculty,post,stan);
        }

    }
}
