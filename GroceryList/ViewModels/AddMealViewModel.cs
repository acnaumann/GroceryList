using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GroceryList.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryList.ViewModels
{
    public class AddMealViewModel
    {
        [Required]
        public string Name { get; set; }


        [Required]
        public string Ingredient { get; set; }



        [Required]
        public string Note { get; set; }
  
    }
}











/*public AddMealViewModel(IEnumerable<Category> categories)
{
    Categories = new List<SelectListItem>();

    foreach (Category category in categories)
    {
        Categories.Add(new SelectListItem
        {
            Value = "0",
            Text =
                }
            }

}*/


//public List<SelectListItem> Categories { get; }
