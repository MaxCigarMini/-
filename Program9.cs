using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<A> @set = new();
            var el1 = new A { Value = 1 };
            var el2 = new A { Value = 1 };
            @set.Add(el1);
            Console.WriteLine(@set.Contains(el2));
        }

        class A
        {
            public int Value { get; set; }
            public override int GetHashCode()
            {
                Console.WriteLine("GetHashCode");
                return Value;
            }
            public override bool Equals(object obj)
            {
                Console.WriteLine("Equals");
                return obj is A a && Value == a.Value;
            }
            // Все равно не пониммаю очередность. Почему сначала GetHashCode и только в конце True/False
            // В Dictionary и HashSet метод GetHashCode вызывается у объекта ключа, чтобы
            //проверить наличие элемента или при других операциях.После GetHashCode будет
            //вызван Equals , если значение из GetHashCode было найдено в словаре или хэш-сете.

        }
    }
    
}
