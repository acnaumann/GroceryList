using System;
using System.Collections.Generic;

namespace GroceryList.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        IList<Ingredient> Ingredients { get; set; }

        public Category()
        {
      
        }
    }

}
