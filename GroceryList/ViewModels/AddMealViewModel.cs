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

        public List<string> Ingredients { get; set; }

        [Required]
        public string Note { get; set; }

        //public List<SelectListItem> Categories { get; set; }

        //public AddMealViewModel(IEnumerable<Category> categories)
        //{
        //    Categories = new List<SelectListItem>();

        //    foreach (Category category in categories)
        //    {
        //        Categories.Add(new SelectListItem
        //        {
        //            Value = category.ID.ToString(),
        //            Text = category.Name
        //        });
        //    }
        //}
  
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
