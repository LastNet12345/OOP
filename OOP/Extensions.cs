using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal static class Extensions
    {
        public static string AddString(this string name, string second)
        {
            return name + " " + second;
        }

        //public static void PrintAll(this List<Person> source)
        //{
        //    foreach (Person person in source)
        //    {
        //        Console.WriteLine(person);
        //    }
        //} 
        //public static void PrintAll(this Person[] source)
        //{
        //    foreach (Person person in source)
        //    {
        //        Console.WriteLine(person);
        //    }
        //} 
        
        public static void PrintAll<T>(this IEnumerable<T> source)
        {
            foreach (T person in source)
            {
                Console.WriteLine(person);
            }
        }
    }
}
