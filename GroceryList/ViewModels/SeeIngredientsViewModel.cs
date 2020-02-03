using System;
using System.Collections.Generic;
using GroceryList.Models;

namespace GroceryList.ViewModels
{
    public class SeeIngredientsViewModel
    {
        public List<Ingredient> Ingredients { get; set; }

        public List<int> IngreditentIDs { get; set; }

        public List<Category> Categories { get; set; }

        public int IngredientID { get; set; }

        public bool IsPlanned { get; set; }

        public SeeIngredientsViewModel()
        {
        }
    }
}


// TODO -- remove the unused/unecessary properties