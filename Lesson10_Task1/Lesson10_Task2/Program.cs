using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person_Initialization;

namespace Lesson10_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            User person = new User("Andrei", "Yermalovich", Companies.Apple, 16);
            User person1 = new User("Ivan", "Volax", Companies.EPAM, 20);
            User person2 = new User("Alex", "Gufov", Companies.Amazon, 21);
            User person3 = new User("Mary", "Reder", Companies.Google, 18);

            User[] arr = { person, person1, person2, person3 };

            DisplayArrayOfUser(arr);
            RemoveUserByCompanyName(ref arr, Companies.EPAM);
            DisplayArrayOfUser(arr);

            Console.ReadLine();
        }

        /// <summary>
        /// Remove person from array by compane name
        /// </summary>
        /// <param name="arr">Takes array of users</param>
        /// <param name="WrokPlace">Takes name of 'Company'</param>
        /// <return>Array of users</return>
        public static void RemoveUserByCompanyName (ref User[] arr, Companies companyName)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].CompanyName == companyName)
                {
                    for (int j = i; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    Array.Resize(ref arr, arr.Length - 1);
                }
            }
        }
           
        /// <summary>
        /// Display to console Array
        /// </summary>
        public static void DisplayArrayOfUser(User[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Name: {arr[i].Name}  Surname: {arr[i].Surname}  WorkPlace: {arr[i].CompanyName}  Age: {arr[i].Age} \n");
            }
        }
    }
}