using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Initialization
{
    public enum CompaniesNames
    {
        EPAM = 1,
        Google,
        Amazon,
        Apple,
    }
    public class User
    {
        public string name;
        public string surname;
        public int companyName;
        //private int Age;
        public int age;
        //{
        //    set
        //    {
        //        if (value < 18)
        //        {
        //            Console.WriteLine("Age must not be less than 18");
        //        }

        //        else
        //        {
        //            Age = value;
        //        }
        //    }
        //    get { return Age; }
        //}
    }
    /// <summary>
    /// Do some actions with 'class user'
    /// </summary>
    public class ActionWithUser
    {
        /// <summary>
        /// Write to console person 'name' and 'surname'
        /// </summary>
        public static void GetUsername(User person)
        {
            Console.WriteLine($"User: {person.name} {person.surname}");
        }
        /// <summary>
        /// Write to console person 'name' and 'company' where he work
        /// </summary>
        public static void GetWorkCompany(User person)
        {
            if (person.companyName < 4)
            {
                Console.WriteLine($"User: {person.name} works in company: {(CompaniesNames)person.companyName}");
            }
            else
            {
                Console.WriteLine("You must select company from 1 to 4, look 'enum'");
            }

        }
        /// <summary>
        /// Write to console person 'name' and 'age'
        /// </summary>
        public static void GetAge(User person)
        {
            if (person.age < 18)
            {
                Console.WriteLine($"User: {person.name} Age: Age must not be less than 18");
            }
            else
            {
                Console.WriteLine($"User: {person.name} Age: {person.age}");
            }
        }
    }
 }



