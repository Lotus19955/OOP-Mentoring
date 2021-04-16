using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Woker_Initialization
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
        public int age;
        public void Print()
        {
            Console.WriteLine($"User: {name} {surname}");
            if (companyName < 4)
            {
                Console.WriteLine($"Company: {(CompaniesNames)companyName}");
            }
            else
            {
                Console.WriteLine("You must select company from 1 to 4, look 'enum'");
            }
            if (age < 18)
            {
                Console.WriteLine($"Age must not be less than 18");
            }
            else
            {
                Console.WriteLine($"Age: {age}");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
