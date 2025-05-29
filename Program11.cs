using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Start();
            while (true)
            {
                Console.Write("Введите команду: ");
                string input = Console.ReadLine().Trim().ToLower();
                if (input.Equals("Exit", StringComparison.OrdinalIgnoreCase)) // input == "Exit"
                {
                    break;
                }
                else if (input.Equals("Help", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Информация.....");
                    Console.ReadKey();
                }
                else Calculation(input);
            }           

            Console.WriteLine("Завершено");
        }
        static void Start()
        {
            {
                Console.WriteLine("Выберете функцию.");
                Console.WriteLine("Help");
                Console.WriteLine("Exit");
                Console.WriteLine("Для вычисления введите выражение: Operand operator Operand");
                Console.WriteLine("-------------------------");
            }

        }
        public static void Calculation(string input)
        {
            string[] parts = input.Split(' ');
            double operand1 = double.Parse(parts[0]);
            string op = parts[1];
            double operand2 = double.Parse(parts[2]);
            double result = 0;
            switch (op)
            {
                case "+":
                    result = Sum(operand1, operand2);
                    break;
                case "-":
                    result = Substract(operand1,operand2);
                    break;
                case "*":
                    result = Multiply(operand1,operand2);
                    break;
                case "/":
                    result = Divide(operand1,operand2);
                    break;                
            }
            Console.WriteLine($"Результат: {result}");
        }
        public static double Sum(double a, double b)
        {           
            return a + b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}
// void Sum(double x, double y, out double result)
// {
// result = x + y
// }

/*
 * 
 * 
 * static void DoOperation(Double x, Double y, Operanion op)
 * {
 *      Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y
 * }
 * 
 * enum Operation
{
    Add,
    Subtract,
    Multiply,
    Divide
}
case "-":
                    result = operand1 - operand2;
*/
