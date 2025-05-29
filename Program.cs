using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Owner> owners = new List<Owner>
            {
                new Owner("Valya", DateTime.Now),
                new Owner("Паху-ю", DateTime.Now)

            };


            List<Note> notes = new List<Note>
            {
                new Note("Zapiska1", "Ebalom ne chelkay i pithi kod", DateTime.Now, "Ne sdelano", owners[0]),
                new Note("Zapiska4", "Чё за хуйня с этим списком?", DateTime.Now, "Не сделано", owners[1]),

            };


            Console.WriteLine("Записки: ");
            foreach (var note in notes)
            {
                note.ShowInfo();
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.WriteLine("БЛЯТЬ, ЧЁТКО РАБОТАЕТ");
        }
    }
    class Note
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Accomplishment { get; set; }

        public DateTime CreatedAt { get; } = DateTime.Now;
        public Owner Owner { get; set; }

        public Note(string name, string description, DateTime createdAt, string accomplishment, Owner owner)
        {
            Name = name;
            Description = description;
            CreatedAt = createdAt;
            Accomplishment = accomplishment;
            Owner = owner;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Название: {Name}\n Описание: {Description}\n" +
                $" Выполнение: {Accomplishment}\n Создатель {Owner.OwnerName}\n Дата: {CreatedAt}");
        }
    }
    class Owner
    {
        public string OwnerName { get; set; }
        public DateTime Registration { get; set; } = DateTime.Now;
        public Owner(string ownerName, DateTime registration)
        {
            OwnerName = ownerName;
            Registration = registration;
        }
    }
}
