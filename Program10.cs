using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<B, string> map = new();
            var el1 = new B();
            var el2 = new B();
            map[el1] = "12";
            map[el2] = "14";
            Console.WriteLine(map[el1]);
        }
        class B
        {
            private readonly Random _random = new();
            public override int GetHashCode() => _random.Next();
            public override bool Equals(object obj) => true;
        }
    }
}
