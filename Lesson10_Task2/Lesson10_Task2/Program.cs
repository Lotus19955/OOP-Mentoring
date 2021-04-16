using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Woker_Initialization;

namespace Lesson10_Task2
{
    class Program
    {
        //    enum CompaniesNames
        //    EPAM = 1,
        //    Google,
        //    Amazon,
        //    Apple,
        /// <summary>
        /// Returns information about the user
        /// </summary>
        /// <returns>Name; SurName; CompanyWhereUserWork; Age
        /// </returns>
        /// <param name="person.name">Take user 'name'</param>
        /// <param name="person.surname">Take user 'surname'</param>
        /// /// <param name="person.companyName">Take user 'company'</param>
        /// /// <param name="person.age">Take user 'age'</param>
        
        static void Main(string[] args)
        {
            
            User person = new User { name = "Oleg", surname = "Gelo", age = 18, companyName = 1 };
            User person1 = new User { name = "Andrei", surname = "Dna", age = 19, companyName = 2 };
            User person2 = new User { name = "Mariya", surname = "Iram", age = 20, companyName = 3 };
            User person3 = new User { name = "Alexander", surname = "Axela", age = 17, companyName = 4 };

            person.Print();
            person1.Print();
            person2.Print();
            person3.Print();
            Console.ReadLine();
        }
    }
}
