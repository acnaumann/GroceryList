using System;
using System.Collections.Generic;

namespace GroceryList.Models
{
    public class Category
    {
        //public const string Vegetable = "Fruits and Vegetables";
        //public const string Meat = "Meats";
        //public const string Bread = "Breads";
        //public const string Bulk = "Bulk";
        //public const string Spices = "Spices and Baking";
        //public const string Canned = "Canned Goods";
        //public const string Pasta = "Rice and Pasta";
        //public const string Dairy = "Dairy";
        //public const string Frozen = "Frozen";

        public int ID { get; set; }
        public string Name { get; private set; }


        IList<Ingredient> Ingredients { get; set; }

        public Category(string name)
        {
            
            name = "Bread";

        }
    }

}
