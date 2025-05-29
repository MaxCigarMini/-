using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Rabbit(),
                new Fox(),
                new Wolf(),

            };
          
            foreach (var animal in animals) 
            { 
                animal.Run();
                Console.WriteLine(new String('-',40));
            }

        }
    }
    abstract class Animal
    {
        public virtual void Run()
        {
            Console.WriteLine("I am animal and I am running for my life!");
        }
    }
    class Rabbit : Animal
    {
        public override void Run()
        {
            Console.WriteLine("I am running from predators");
        }
    }
    class Wolf : Animal
    {

    }
    class Fox : Animal
    {
        public override void Run()
        {
            Console.WriteLine("I am running for tasty rabbit ");

        }
    }

}
