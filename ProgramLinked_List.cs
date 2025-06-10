using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;

namespace Linked_list
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var List = new Model.LinkedList<int>();
            List.Add(1);
            List.Add(2);
            List.Add(3);
            List.Add(4);
            List.Add(5);
            List.Add(6);
            List.Add(7);
            List.Add(8);                   
            List.Add(9);
            List.Add(10);

            foreach (var item in List)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
            List.Replace(1, 11111111);
            foreach (var item in List)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            List.Delete(3);
            List.Delete(7);

            foreach (var item in List)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            List.InsertAfter(4, 155);

            foreach (var item in List)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            List.AppendHead(10);

            foreach (var item in List)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
          

            Console.WriteLine($"Длина списка: {List.Count}");

            List.GetEnumerator();

            Console.ReadLine();
        }
    }
}
