using System;

namespace P_14
{
    abstract class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime Bday { get; set; }

        public string Fuculty { get; set; }

        public Person() { }

        public Person(string name, string surname, DateTime bday, string fuculty)
        {
            Name = name;
            Surname = surname;
            Bday = bday;
            Fuculty = fuculty;
        }

        public new abstract string ToString();

        public  int Age()
        {
            TimeSpan ageDiff=DateTime.Now-Bday;
            int age = (int)Math.Floor(ageDiff.TotalDays / 365);
            return age;
        }

    }
}
