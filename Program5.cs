using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                 "Миша",
                 "Вася",
                 "Петя",
                 "Гриша"
            };
            var firstPerson = names.First();
            var secondAndThird = names.Skip(1).Take(2).ToList();
            Console.WriteLine($"2. Второй и третий: {string.Join(", ", secondAndThird)}");

            var nameM = names.FirstOrDefault( m => m.ToUpper().StartsWith("М"));
            var nameY = names.Where(p => p.Contains("я")).ToList();
            Console.WriteLine($"4. Содержит 'я': {string.Join(", ", nameY)}");

            var allname = nameY.Count;
            var petya = names.Contains("Петя");
            Console.WriteLine(petya);

            var sort = names.OrderBy(n => n).ToList();
            Console.WriteLine(string.Join(",", sort));
        }
    }
}
