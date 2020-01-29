using System.Collections.Generic;
using System.Linq;
using GroceryList.Data;
using GroceryList.Models;
using GroceryList.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryList.Controllers
{
    public class PlanController : Controller
    {

        private ListDbContext context;

        public PlanController(ListDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            PlanWeekViewModel planWeekViewModel = new PlanWeekViewModel(context.Meals.ToList());
            
            PlannedMeal Sunday = context.PlannedMeals.FirstOrDefault(x => x.Day == "Sunday");

            if (Sunday != null)
            {
                planWeekViewModel.SundayMealID = Sunday.MealID;
            }


            PlannedMeal Monday = context.PlannedMeals.FirstOrDefault(x => x.Day == "Monday");

            if (Monday != null)
            {
                planWeekViewModel.MondayMealID = Monday.MealID;
            }


            PlannedMeal Tuesday = context.PlannedMeals.FirstOrDefault(x => x.Day == "Tuesday");

            if (Tuesday != null)
            {
                planWeekViewModel.TuesdayMealID = Tuesday.MealID;
            }


            PlannedMeal Wednesday = context.PlannedMeals.FirstOrDefault(x => x.Day == "Wednesday");

            if (Wednesday != null)
            {
                planWeekViewModel.WednesdayMealID = Wednesday.MealID;
            }


            PlannedMeal Thursday = context.PlannedMeals.FirstOrDefault(x => x.Day == "Thursday");

            if (Thursday != null)
            {
                planWeekViewModel.ThursdayMealID = Thursday.MealID;
            }


            PlannedMeal Friday = context.PlannedMeals.FirstOrDefault(x => x.Day == "Friday");

            if (Friday != null)
            {
                planWeekViewModel.FridayMealID = Friday.MealID;
            }


            PlannedMeal Saturday = context.PlannedMeals.FirstOrDefault(x => x.Day == "Saturday");

            if (Saturday != null)
            {
                planWeekViewModel.SaturdayMealID = Saturday.MealID;
                
            }

            planWeekViewModel.IsPlanned = context.PlannedMeals.Any();

            return View(planWeekViewModel);
        }

        [HttpPost]
        public IActionResult Index(PlanWeekViewModel planWeekViewModel)
        {
            if (ModelState.IsValid)
            {
                List<int> mealIDs = new List<int>();

                if (planWeekViewModel.SundayMealID != -1)
                {

                    PlannedMeal sunday = new PlannedMeal()
                    {
                        Day = "Sunday",
                        MealID = planWeekViewModel.SundayMealID,
                        
                        
                    };

                    mealIDs.Add(planWeekViewModel.SundayMealID);

                    context.PlannedMeals.Add(sunday);            
                    
                }

                if (planWeekViewModel.MondayMealID != -1)
                {
                    PlannedMeal monday = new PlannedMeal()
                    {
                        Day = "Monday",
                        MealID = planWeekViewModel.MondayMealID
                    };

                    mealIDs.Add(planWeekViewModel.MondayMealID);

                    context.PlannedMeals.Add(monday);
                }

                if (planWeekViewModel.TuesdayMealID != -1)
                {
                    PlannedMeal tuesday = new PlannedMeal()
                    {
                        Day = "Tuesday",
                        MealID = planWeekViewModel.TuesdayMealID
                    };

                    mealIDs.Add(planWeekViewModel.TuesdayMealID);

                    context.PlannedMeals.Add(tuesday);
                }

                if (planWeekViewModel.WednesdayMealID != -1)
                {
                    PlannedMeal wednesday = new PlannedMeal()
                    {
                        Day = "Wednesday",
                        MealID = planWeekViewModel.WednesdayMealID
                    };

                    mealIDs.Add(planWeekViewModel.WednesdayMealID);

                    context.PlannedMeals.Add(wednesday);
                }

                if (planWeekViewModel.ThursdayMealID != -1)
                {
                    PlannedMeal thursday = new PlannedMeal()
                    {
                        Day = "Thursday",
                        MealID = planWeekViewModel.ThursdayMealID
                    };

                    mealIDs.Add(planWeekViewModel.ThursdayMealID);

                    context.PlannedMeals.Add(thursday);
                }

                if (planWeekViewModel.FridayMealID != -1)
                {
                    PlannedMeal friday = new PlannedMeal()
                    {
                        Day = "Friday",
                        MealID = planWeekViewModel.FridayMealID
                    };

                    mealIDs.Add(planWeekViewModel.FridayMealID);

                    context.PlannedMeals.Add(friday);
                }

                if (planWeekViewModel.SaturdayMealID != -1)
                {
                    PlannedMeal Saturday = new PlannedMeal()
                    {
                        Day = "Saturday",
                        MealID = planWeekViewModel.SaturdayMealID
                    };

                    mealIDs.Add(planWeekViewModel.SaturdayMealID);

                    context.PlannedMeals.Add(Saturday);
                }

                context.SaveChanges();


                List<Ingredient> ingredients = context.Ingredients.Where(x => mealIDs.Contains(x.MealID)).ToList();


                foreach (Ingredient ingredient in ingredients)
                {
                    ingredient.IsInCart = true;
                }
                context.SaveChanges();

                return Redirect("/See/Index");
            }

            PlanWeekViewModel pWVM = new PlanWeekViewModel(context.Meals.ToList());
            return View(pWVM);
        }

        [HttpPost]
        public IActionResult Clear()
        {
            List<PlannedMeal> plannedMeals = context.PlannedMeals.ToList();

            foreach (PlannedMeal plannedMeal in plannedMeals)
            {
                context.PlannedMeals.Remove(plannedMeal);
            }

            context.SaveChanges();
            return Redirect("/Plan/Index");
        }

    }

}
