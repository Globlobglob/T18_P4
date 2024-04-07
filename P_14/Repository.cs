using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_14
{
    internal class Repository
    {

        List<Person> person = new List<Person>();


        public void GetStudent()
        {
            person.Add(Student.StudentInput());
        }

        public void GetAbiturient()
        {
            person.Add(Abiturient.AbiturientInput());
        }

        public void GetTeacher()
        {
            person.Add(Teacher.TeacherInput());
        }

         public void GetAll()
          {
              foreach(var item in person)
              {
                 Console.WriteLine(item.ToString());
              }
         }

        public void Filter()
        {
            Console.Clear();
            Console.Write("Введите нижнюю границу");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Введите верхнюю границу");
            int max = int.Parse(Console.ReadLine());

            foreach(var num in person)
            {
                if(num.Age()>min & num.Age() <= max)
                {
                    Console.WriteLine(num.ToString());
                }
            }

        }


    }
}

