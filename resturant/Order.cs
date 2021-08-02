using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int TaxPercentage { get; set; }
        public bool DineIn { get; set; }
        public List<Dish> Dishes { get; set; } = new List<Dish>();

        public String ToString()
        {
            String str = ("Order Id: " + Id +
                "\t\t Price:  " + Price + "\nTax percentage:  " + TaxPercentage + "%\t\tDine in?:"+"\n"+"==================================");
            return str; 


        }
    }
}
