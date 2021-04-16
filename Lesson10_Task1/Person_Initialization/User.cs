﻿using System;
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

    /// <summary>
    /// Returns information about the user
    /// </summary>
    /// <returns>Name; SurName; CompanyWhereUserWork; Age
    /// </returns>
    /// <param name="person.name">Take user 'name'</param>
    /// <param name="person.surname">Take user 'surname'</param>
    /// /// <param name="person.companyName">Take user 'company'</param>
    /// /// <param name="person.age">Take user 'age'</param>
    public class User
    {
        public string name;
        public string surname;
        public int companyNumber;
        public int age;

        public void Print()
        {
            Console.WriteLine($"User: {name} {surname}");
            if (companyNumber < 4)
            {
                Console.WriteLine($"Company: {(CompaniesNames)companyNumber}");
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



