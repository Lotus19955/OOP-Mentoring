using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Initialization
{
    /// <summary>
    /// Returns information about the user
    /// </summary>
    /// <returns></returns>
    /// <param name="person.name">Take user 'name'</param>
    /// <param name="person.surname">Take user 'surname'</param>
    /// /// <param name="person.companyName">Take user 'company'</param>
    /// /// <param name="person.age">Take user 'age'</param>
    public class User
    {
        public string Name;
        public string Surname;
        public Companies WorkPlace;
        private int age;
        public int Age
        {
            set 
            {
                if (value < 18)
                {
                    age = 0;
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
        public User(string name, string surname, Companies workPlace, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.WorkPlace = workPlace;
            this.Age = age;
        }
        /// <summary>
        /// Display to console person 'name' and 'surname'
        /// </summary>
        public static void DisplayUserName(User person)
        {
            Console.WriteLine($"User: {person.Name} {person.Surname}");
        }
        /// <summary>
        /// Display to console person 'name' and 'company' where user work
        /// </summary>
        public static void DisplayWorkPlace(User person)
        {
            Console.WriteLine($"User: {person.Name} works in company: {person.WorkPlace}");
        }
        /// <summary>
        /// Display to console person 'name' and 'age'
        /// </summary>
        public static void DisplayAge(User person)
        {
            if (person.Age == 0)
            {
                Console.WriteLine($"User: {person.Name} Age: less then 18");
            }
            else
            {
                Console.WriteLine($"User: {person.Name} Age: {person.age}");
            }
        }
        /// <summary>
        /// Display to console array without display without a specific company
        /// </summary>
        /// <param name="arr">Takes array of users</param>
        /// <param name="WrokPlace">Takes name of 'Companies'workplace</param>
        public static void RemoveFilter(User[] arr, Companies WrokPlace)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].WorkPlace == WrokPlace)
                {
                    User x = arr[i];
                    arr[i] = arr[arr.Length - 1];
                    arr[arr.Length - 1] = x;
                    Array.Resize(ref arr, arr.Length - 1);
                }
            }
            for (int j = 0; j < arr.Length; j++)
                if (arr[j].Age == 0)
                {
                    Console.WriteLine($"Name: {arr[j].Name}  Surname: {arr[j].Surname}  WorkPlace: {arr[j].WorkPlace}  Age: less then 18 \n");
                }
            else
                {
                    Console.WriteLine($"Name: {arr[j].Name}  Surname: {arr[j].Surname}  WorkPlace: {arr[j].WorkPlace}  Age: {arr[j].Age} \n");
                }
        }
    }
}



