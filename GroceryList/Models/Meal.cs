using System;
using System.Collections.Generic;

namespace GroceryList.Models
{
    public class Meal
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Ingredient { get; set; }
        public string Note { get; set; }


        public int IngredientID { get; set; }



        public Meal()
        {
          
        }

        IList<Ingredient> Ingredients { get; set; }

    }
}
