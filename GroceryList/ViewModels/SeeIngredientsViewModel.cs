using System;
using System.Collections.Generic;
using GroceryList.Models;

namespace GroceryList.ViewModels
{
    public class SeeIngredientsViewModel
    {
        public List<Ingredient> Ingredients { get; set; }

        public int IngredientID { get; set; }

        public SeeIngredientsViewModel()
        {
        }
    }
}