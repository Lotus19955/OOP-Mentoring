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
        static User GetUser()
        {
            User person = new User();

            person.name = "Andrei";
            person.surname = "Yermalovich";
            person.companyName = 2;
            person.age = 25;

            return person;
        }
        static void Main(string[] args)
        {
            
            User person = GetUser();
            
            ActionWithUser.GetUsername(person);
            ActionWithUser.GetWorkCompany(person);
            ActionWithUser.GetAge(person);
            Console.ReadLine();
        }
    }
}
