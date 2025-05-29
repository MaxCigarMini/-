using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        List<Person> persons = new()
{
    new() { FirstName = "Виталий", LastName = "Цаль", Age = 33 },
    new() { FirstName = "Куджо", LastName = "Джотаро", Age = 40 },
    new() { FirstName = "Юрий", LastName = "Хованский", Age = 34 },
    new() { FirstName = "Михаил", LastName = "Петров", Age = 15 },
    new() { FirstName = "Виталий", LastName = "Гачиев", Age = 40 },
    new() { FirstName = "Юрий", LastName = "Гагарин", Age = 34 },
};

        List<Person> FilterPersons(
            List<Person> all,
            string? firstName = null,
            string? lastName = null,
            int? age = null)
        {
            IEnumerable<Person> query = all;
            if (firstName != null)
            {
                query = query.Where(p => p.FirstName == firstName);              
            }
            if (lastName != null)
            {
                query = query.Where(p => p.LastName == lastName);
            }
            if (age != null)
            {
                query = query.Where (p => p.Age == age);
            }
            return query.ToList();

            // IEnumerable<Person> filtered = personList.Where(p => p.FirstName != null && p.Age != null );
            //return personList
               //.Where(p => firstName == null || p.FirstName == firstName)
               //.Where(p => lastName == null || p.LastName == lastName)
               //.Where(p => age == null || p.Age == age)
               //.ToList();
        }



        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}
