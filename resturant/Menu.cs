using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain
{
    public class Menu
    {
        int count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public bool TaxIncluded { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();

        public Dish addDish()
        {

            Console.WriteLine("Enter new Dish's name: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter new dish's type, 1 for food, 2 for sweets, and 3 for beverages: ");
            int Type = Console.Read();
            Console.WriteLine("Enter new dish's price: ");
            int price = Console.Read();
            Console.WriteLine("Enter new dish'singredients: ");
            string ingredients = Console.ReadLine();
            count++;
            Dish dish = new Dish(count, Name, Type, price, ingredients);
            Dishes.Add(dish);
            return dish;
        }
    }
}
