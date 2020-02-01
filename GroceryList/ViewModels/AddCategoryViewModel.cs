using System;
using System.ComponentModel.DataAnnotations;

namespace GroceryList.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        public string Name { get; set; }

        public AddCategoryViewModel()
        {
        }
    }
}
