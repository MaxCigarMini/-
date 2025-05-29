using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var i = 10;
            var query = list.Where(x => x == i).Where(x => x < 20);
            list.Add(10);
            list.Add(15);
            list.Add(20);
            i = 15;
            var result = query.ToList();
            list.Clear();
            Console.WriteLine(result.Count); // 1
            Console.WriteLine(result.FirstOrDefault()); // 15


            var funcs = new List<Func<int, int>>();
            for (int i = 0; i < 10; i++)
              
                funcs.Add(x => x + i);
            foreach (var func in funcs)
                Console.WriteLine(func(1)); // 11 // Тоесть Есть цыкл(иттерация) Которая доводит i до 10,(отображение 0-9) но не показывает ее
            //так как не входит в последовательность, но передаёт ее дальше?


            var abc = new List<Func<int, int>>();
            for (int p = 0; p < 10; p ++)
                Console.WriteLine(p);


               

        }

    }
}
