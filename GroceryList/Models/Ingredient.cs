﻿using System;
using System.Collections.Generic;

namespace GroceryList.Models
{
    public class Ingredient
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //TODO -- add category in second push
        //public Category Category { get; set; }
        //public int CategoryID { get; set; }

        public Meal Meal { get; set; }
        public int MealID { get; set; }

        public bool IsInCart { get; set; } = true;

        public Ingredient()
        {
         
        }

        //public Ingredient()
        //{
        //    //Type Ingredient already defines a member called ".ctor" with the same parameter types
        //}
    }
}
