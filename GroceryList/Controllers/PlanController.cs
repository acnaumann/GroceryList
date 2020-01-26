using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            PlannedMeal Sunday = context.PlannedMeals.First(x => x.Day == "Sunday");

            if (Sunday != null)
            {
                planWeekViewModel.Sunday = Sunday.MealID.ToString();
            }


            PlannedMeal Monday = context.PlannedMeals.First(x => x.Day == "Monday");

            if (Monday != null)
            {
                planWeekViewModel.Monday = Monday.MealID.ToString();
            }


            PlannedMeal Tuesday = context.PlannedMeals.First(x => x.Day == "Tuesday");

            if (Tuesday != null)
            {
                planWeekViewModel.Tuesday = Tuesday.MealID.ToString();
            }


            PlannedMeal Wednesday = context.PlannedMeals.First(x => x.Day == "Wednesday");

            if (Wednesday != null)
            {
                planWeekViewModel.Wednesday = Wednesday.MealID.ToString();
            }


            PlannedMeal Thursday = context.PlannedMeals.First(x => x.Day == "Thursday");

            if (Thursday != null)
            {
                planWeekViewModel.Thursday = Thursday.MealID.ToString();
            }


            PlannedMeal Friday = context.PlannedMeals.First(x => x.Day == "friday");

            if (Friday != null)
            {
                planWeekViewModel.Friday = Friday.MealID.ToString();
            }


            PlannedMeal Saturday = context.PlannedMeals.First(x => x.Day == "Saturday");

            if (Saturday != null)
            {
                planWeekViewModel.Saturday = Saturday.MealID.ToString();
            }

            

            return View(planWeekViewModel);
        }

        [HttpPost]
        public IActionResult Index(PlanWeekViewModel planWeekViewModel)
        {
            if (ModelState.IsValid)
            {
                if (planWeekViewModel.Sunday != "-1")
                {
                    PlannedMeal sunday = new PlannedMeal()
                    {
                        Day = "Sunday",
                        MealID = Convert.ToInt32(planWeekViewModel.Sunday)
                    };

                    context.PlannedMeals.Add(sunday);
                }

                if (planWeekViewModel.Monday != "-1")
                {
                    PlannedMeal monday = new PlannedMeal()
                    {
                        Day = "Monday",
                        MealID = Convert.ToInt32(planWeekViewModel.Monday)
                    };

                    context.PlannedMeals.Add(monday);
                }

                if (planWeekViewModel.Tuesday != "-1")
                {
                    PlannedMeal tuesday = new PlannedMeal()
                    {
                        Day = "Tuesday",
                        MealID = Convert.ToInt32(planWeekViewModel.Tuesday)
                    };

                    context.PlannedMeals.Add(tuesday);
                }

                if (planWeekViewModel.Wednesday != "-1")
                {
                    PlannedMeal wednesday = new PlannedMeal()
                    {
                        Day = "Wednesday",
                        MealID = Convert.ToInt32(planWeekViewModel.Wednesday)
                    };

                    context.PlannedMeals.Add(wednesday);
                }

                if (planWeekViewModel.Thursday != "-1")
                {
                    PlannedMeal thursday = new PlannedMeal()
                    {
                        Day = "Thursday",
                        MealID = Convert.ToInt32(planWeekViewModel.Thursday)
                    };

                    context.PlannedMeals.Add(thursday);
                }

                if (planWeekViewModel.Friday != "-1")
                {
                    PlannedMeal friday = new PlannedMeal()
                    {
                        Day = "friday",
                        MealID = Convert.ToInt32(planWeekViewModel.Friday)
                    };

                    context.PlannedMeals.Add(friday);
                }

                if (planWeekViewModel.Saturday != "-1")
                {
                    PlannedMeal Saturday = new PlannedMeal()
                    {
                        Day = "Saturday",
                        MealID = Convert.ToInt32(planWeekViewModel.Saturday)
                    };

                    context.PlannedMeals.Add(Saturday);
                }

                context.SaveChanges();
                return Redirect("/Plan/Index");
            }
            
            // TODO -- How to clear the week's meals and stay on the index page
            PlanWeekViewModel pWVM = new PlanWeekViewModel(context.Meals.ToList());
            return View(pWVM);
        }

        //public IActionResult Clear()
        //{
        //    ClearPlannedMealViewModel clearPlannedMealViewModel = new ClearPlannedMealViewModel();
        //    return View(clearPlannedMealViewModel);
        //}

        //[HttpPost]
        //public IActionResult Clear(int[] plannedMealIDs)
        //{
        //    foreach (int plannedMealID in plannedMealIDs)
        //    {
        //        PlannedMeal plannedMeal = context.PlannedMeals.Single(c => c.ID == plannedMealID);
        //        context.PlannedMeals.Remove(plannedMeal);
        //    }

        //    context.SaveChanges();
        //    return Redirect("/Plan/Index");
        }
    }
}
