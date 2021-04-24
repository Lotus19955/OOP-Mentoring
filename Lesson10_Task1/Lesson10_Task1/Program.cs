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
            User person;
            do
            {
                person = CreateUser();
            }
            while (person == null);

            person.DisplayAge(person);
            person.DisplayUserName(person);
            person.DisplayWorkPlace(person);
            person.DisplayAge(person);

            Console.ReadLine();
        }
        public static User CreateUser()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Companies: ");
            var values = Enum.GetValues(typeof(Companies));
            int companyCounter = 1;
            foreach (var item in values)
            {
                Console.WriteLine($"{item} - {companyCounter}");
                companyCounter++;
            }

            Console.Write("Enter number of company: ");
            string strCompany = Console.ReadLine();
            int company;
            int.TryParse(strCompany, out company);
            Companies companyName;
            switch (company)
            {
                case 1:
                    companyName = Companies.Amazon;
                    break;
                case 2:
                    companyName = Companies.Apple;
                    break;
                case 3:
                    companyName = Companies.EPAM;
                    break;
                case 4:
                    companyName = Companies.Google;
                    break;
                default:
                    companyName = Companies.NoCompany;
                    break;
            }

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            User person = new User(name, surname, companyName, age);

            if (person.Age == -1)
            {
                Console.WriteLine();
                Console.WriteLine("Age must be not less than 18, create 'User' again");
                return null;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("User created");
                return person;
            }
        }
    }
}  