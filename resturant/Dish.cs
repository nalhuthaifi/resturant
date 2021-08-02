using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain
{
    public class Dish
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Price { get; set; }
        public string Ingredients { get; set; }

        public Dish(int id, string name, int type, int price, string ingredients)
        {
            Id = id;
            Name = name;
            Type = type;
            Price = price;
            Ingredients = ingredients;
        }
    }



}
