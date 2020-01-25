﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data;
using GroceryList.Models;
using GroceryList.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryList.Controllers
{
    public class ManageController : Controller
    {

        private ListDbContext context;

        public ManageController(ListDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Meal> meals = context.Meals.Include(m => m.Ingredients).ToList();
            return View(meals);
        }

        public IActionResult AddAMeal()
        {
            AddMealViewModel addMealViewModel = new AddMealViewModel();

            return View(addMealViewModel);
        }

        [HttpPost]
        public IActionResult AddAMeal(AddMealViewModel addMealViewModel)
        {
            if (ModelState.IsValid)
            {
                Meal meal = new Meal()
                {
                    Name = addMealViewModel.Name,
                    Note = addMealViewModel.Note
                };

                foreach (var ingr in addMealViewModel.Ingredients)
                {
                    Ingredient ingredient = new Ingredient()
                    {
                        Name = ingr
                    };

                    meal.Ingredients = new List<Ingredient>();
                    meal.Ingredients.Add(ingredient);
                }

                context.Meals.Add(meal);
                context.SaveChanges();

                return Redirect("/Manage/Index");
            }
            //TODO -- List<string> result = names.Split(',').ToList();
            //TODO -- add meal to db

            return View(addMealViewModel);
        }

        // TODO -- later -- add an edit option for each meal
        
    }
}
















//public IActionResult AddIngredient()
//{
//    return View();
//}

//[HttpPost]
//public IActionResult AddIngredient(string name)
//{
//    Ingredient ingredient = new Ingredient{ Name = name
//    };
//    return Redirect("/Manage/AddAMeal?=" + ingredient);
//}

//public IActionResult ViewAMeal(/*int id*/)
//{

//    return View();
//}