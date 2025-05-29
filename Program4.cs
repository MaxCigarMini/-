using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ConstantReader reader = new ConstantReader();
            ConsoleReader consoleReader = new ConsoleReader();
            InegerParser eblo1 = new InegerParser(reader);
            InegerParser eblo2 = new InegerParser(consoleReader);
            Console.WriteLine(eblo1.Parser());
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(eblo2.Parser());
        }
    }
    interface IInputReader
    {
        string ReadFromSource();
    }

    class ConstantReader : IInputReader
    {
        public string ReadFromSource() => "5";
    }
    class ConsoleReader : IInputReader
    {
        public string ReadFromSource() => Console.ReadLine(); //int.TryParse()
    }
    class InegerParser
    {
        private readonly IInputReader _reader;
        public InegerParser(IInputReader reader)
        {
            _reader = reader;
        }

        public int Parser()
        {

            var inputedValue = _reader.ReadFromSource();
            return int.Parse(inputedValue);
        }
    }

}
