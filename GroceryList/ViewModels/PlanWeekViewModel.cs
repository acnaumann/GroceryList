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
        public string Sunday { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }

        

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
