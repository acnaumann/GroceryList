using System;
using System.Collections.Generic;

namespace GroceryList.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }
        public int CategoryID { get; set; }

        public Meal Meal { get; set; }
        public int MealID { get; set; }

        public bool IsInCart { get; set; }

        public Ingredient()
        {
         
        }

    }
}
