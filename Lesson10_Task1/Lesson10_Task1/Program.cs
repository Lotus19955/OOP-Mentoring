using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_Initialization;

namespace Lesson10_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            User person = new User();

            person.name = "Andrei";
            person.surname = "Termalovich";
            person.age = 19;
            person.companyNumber = 2;

            person.Print();

            Console.ReadLine();
        }
    }
}
