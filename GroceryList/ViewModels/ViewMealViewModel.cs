using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GroceryList.Models;

namespace GroceryList.ViewModels
{
    public class ViewMealViewModel
    {
        [Required]
        public string Name { get; set; }

        public List<string> Ingredients { get; set; }

        [Required]
        public string Note { get; set; }

        public ViewMealViewModel()
        {

        }
    }
}
