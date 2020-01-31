using System;
using System.Collections.Generic;

namespace GroceryList.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; private set; }

        IList<Ingredient> Ingredients { get; set; }

        public Category()
        {
      
        }
    }

}
