using System;
using System.Collections.Generic;
using GroceryList.Models;

namespace GroceryList.ViewModels
{
    public class RemovePlannedIngredientViewModel
    {
        public List<int> IngredientIDs { get; set; }

        public RemovePlannedIngredientViewModel()
        {
        }
    }
}




//TODO -- remove:
//public Ingredient Ingredient { get; set; }

//public bool IsInCart { get; set; } 