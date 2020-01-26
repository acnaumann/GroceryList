using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using GroceryList.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryList.ViewModels
{
    public class PlanWeekViewModel
    {
        public int SundayMealID { get; set; }
        public int MondayMealID { get; set; }
        public int TuesdayMealID { get; set; }
        public int WednesdayMealID { get; set; }
        public int ThursdayMealID { get; set; }
        public int FridayMealID { get; set; }
        public int SaturdayMealID { get; set; }

        public bool IsPlanned { get; set; }

        public int MealID { get; set; }

        public List<SelectListItem> Meals { get; set; }


        public PlanWeekViewModel(IEnumerable<Meal> meals)
        {

            Meals = new List<SelectListItem>();

            Meals.Add(new SelectListItem
            {
                Value = "-1",
                Text = "Select A Meal"
            });

            foreach (Meal meal in meals.OrderBy(m => m.Name))
            {
                Meals.Add(new SelectListItem
                {
                    Value = meal.ID.ToString(),
                    Text = meal.Name
                });
            }
        }

        public PlanWeekViewModel()
        {

        }
    }
}
