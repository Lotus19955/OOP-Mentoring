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
            User person = new User("Andrei", "Yermalovich", Companies.Apple, 19);
            User person1 = new User("Ivan", "Volax", Companies.EPAM, 20);
            User person2 = new User("Alex", "Gufov", Companies.Amazon, 21);
            User person3 = new User("Mary", "Reder", Companies.Google, 18);
            
            User[] arr = { person, person1, person2, person3 };

            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Age == 0)
                {
                    Console.WriteLine($"Name: {arr[i].Name}  Surname: {arr[i].Surname}  WorkPlace: {arr[i].WorkPlace}  Age: less then 18 \n");
                }
                else
                {
                    Console.WriteLine($"Name: {arr[i].Name}  Surname: {arr[i].Surname}  WorkPlace: {arr[i].WorkPlace}  Age: {arr[i].Age} \n");
                }

            User.RemoveFilter(arr, Companies.EPAM);
            Console.ReadLine();
        }
    }
}
