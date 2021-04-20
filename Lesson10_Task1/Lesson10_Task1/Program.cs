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
            User person = new User("Andrei", "Yermalovich", Companies.Apple, 16);
            User.DisplayUserName(person);
            User.DisplayWorkPlace(person);
            User.DisplayAge(person);

            Console.ReadLine();
        }
    }
}
             
    
    

