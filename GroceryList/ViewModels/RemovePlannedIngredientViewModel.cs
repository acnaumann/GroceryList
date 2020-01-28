using System;
using System.Collections.Generic;

namespace GroceryList.ViewModels
{
    public class RemovePlannedIngredientViewModel
    {
        public List<int> IngreditentIDs { get; set; }

        public int IngredientID { get; set; }

        public bool IsInCart { get; set; } 

        public RemovePlannedIngredientViewModel()
        {
        }
    }
}
