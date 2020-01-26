using System;
using System.Collections.Generic;

namespace GroceryList.Models
{
    public class Meal
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }

        public Meal()
        {
          
        }

        public List<Ingredient> Ingredients { get; set; }


        IList<PlannedMeal> PlannedMeals { get; set; }
    }
}











// ***if many-to-many***
//public string Ingredient { get; set; }
//public int IngredientID { get; set; }



//  *** more advanced ***
//public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();