using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GroceryList.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryList
{
    public class AddMealViewModel
    {
        [Required]
        public string Name { get; set; }

        //TODO -- enter ingredients one at a time, which adds to the list of ingredients


        [Required]
        public string Note { get; set; }

        public Category Category { get; set; }

        // TODO -- this isn't being set anywhere but in the code
        public List<SelectListItem> Categories { get; set; }




        public AddMealViewModel()
        {
        }
    }
}
