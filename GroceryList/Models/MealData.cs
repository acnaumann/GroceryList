using System;
using System.Collections.Generic;

namespace GroceryList.Models
{
    public class MealData
    {

        private static List<Meal> meals = new List<Meal>();



        public static List<Meal> GetAll()
        {
            return meals;
        }


        public static void Add(Meal newMeal)
        {
            meals.Add(newMeal);
        }


        public MealData()
        {

        }
    }
}
