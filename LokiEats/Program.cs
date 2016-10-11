using System;
using System.Collections.Generic;
using System.Linq;

namespace LokiEats
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodToEat = Console.ReadLine();
            var ingredients = GetIngredients(foodToEat);
            var isToxic = ingredients.Any(i => i.IsToxic);
            if (isToxic)
            {
                Console.WriteLine(foodToEat + " is toxic to dogs!");
            }
            else
            {
                Console.WriteLine(foodToEat + " is not toxic to dogs!");
            }
            Console.ReadLine();
        }

        static List<Ingredient> GetIngredients(string food)
        {
            return new List<Ingredient>
            {
                new Ingredient
                {
                    Name = "Garlic",
                    IsToxic = true
                }
            };
        }
    }
}
