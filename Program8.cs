using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6 };
            var query = arr
                .Select(el =>
                {
                    Console.WriteLine(el);
                    return el;
                })
                .Where(el => el > 4)
                .Select(el =>
                {
                    var res = el * 2;
                    Console.WriteLine(res);
                    return res;
                });
            Console.WriteLine("Output");
            _ = query.ToArray();
        }
    }
}
