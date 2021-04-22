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
        public string Name { get; set; }
        public string Surname { get; set; }
        public Companies CompanyName { get; set; }
        private int age;
        public int Age
        {
            set
            {
                if (value < 18)
                {
                    age = -1;
                }
                else
                {
                    age = value;
                }
            }
            get { return age; }
        }
        public User(string name, string surname, Companies companyName, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.CompanyName = companyName;
            this.Age = age;

        }
        /// <summary>
        /// Display to console person 'name' and 'surname'
        /// </summary>
        public void DisplayUserName(User person)
        {
            Console.WriteLine($"User: {person.Name} {person.Surname}");
        }
        /// <summary>
        /// Display to console person 'name' and 'company' where user work
        /// </summary>
        public void DisplayWorkPlace(User person)
        {
            Console.WriteLine($"User: {person.Name} works in company: {person.CompanyName}");
        }
        /// <summary>
        /// Display to console person 'name' and 'age'
        /// </summary>
        public void DisplayAge(User person)
        {
            Console.WriteLine($"User: {person.Name} Age: {person.age}");
        }
    }
}
