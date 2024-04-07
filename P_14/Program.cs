using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Repository repository = new Repository();


            while (true) 
            {

                Console.Write("\n1 - Abiturient\n2 - Student\n3 - Teacher\n4 - All Info\n5 - Filter");

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char keyChar = keyInfo.KeyChar;

                switch (keyChar)
                {

                    case '1':
                        Console.Clear();
                        repository.GetAbiturient();
                        Console.Clear();
                        break;
                    case '2':
                        Console.Clear();
                        repository.GetStudent();
                        Console.Clear();
                        break;
                    case '3':
                        Console.Clear();
                        repository.GetTeacher();
                        Console.Clear();
                        break;
                    case '4':
                        Console.Clear();
                        repository.GetAll();
                       
                        break;

                    case '5':
                        repository.Filter();
                        break;

                }



            }





        }
    }
}
