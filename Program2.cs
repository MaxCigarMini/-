using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autor autor = new Autor("Максик", DateTime.Now);
            Recipe Sashka = new Recipe($"Название: Санёчек", "\nОписание: Говно на палке", "\nИнгридиенты: Казявки + Накакал","Алгоритм: Сосать + Лежать", autor, 2, ReceptCategory.Sup);
        }
    }
    class Recipe
    {
        public Recipe(string title, string description,string ingridients, string algorithm, Autor autor, int rating, ReceptCategory category)
        {
            Title = title;
            Description = description;
            Ingridients = ingridients;
            Algorithm = algorithm;
            Autor = autor;
            Rating = rating;
            Category = category;
        }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingridients {  get; set; }
        public string Algorithm { get; set; }
        public Autor Autor { get; set; }
        public double Rating { get; set; }
        public ReceptCategory Category { get; set; }
    }
    class Autor
    {    
        public Autor (string name, DateTime createdAt )
        {
            Name = name;
            CreatedAt = createdAt;                      
        }
        public string Name { get; set; }
        public DateTime CreatedAt { get; } = DateTime.Now;
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
        public double MidleRating()
        {
            if (Recipes.Count == 0) 
            {
                return 0;
            }
            double _rating = 0;
            foreach (var recipe in Recipes)
            {
                _rating += recipe.Rating;               
            }
            return _rating / Recipes.Count;
        }

    }
    public enum ReceptCategory 
    {
        Sup,
        MeatDishes,
        Garnish,
        FastFood,
        Snacks,
        Drink
    }
}
