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
            AddMealViewModel addMealViewModel = new AddMealViewModel(context.Categories.ToList());

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

                meal.Ingredients = new List<Ingredient>();
                foreach (var ingr in addMealViewModel.Ingredients)
                {
                    Ingredient ingredient = new Ingredient()
                    {
                        //make it so that each ingredient is added as upper case(all)
                        //and check if already in db
                        Name = ingr
                    };

                    
                    meal.Ingredients.Add(ingredient);
                }

                context.Meals.Add(meal);
                context.SaveChanges();

                return Redirect("/Manage/Index");
            }
            

            return View(addMealViewModel);
        }


  





        //public IActionResult ViewAMeal(int id)
        //{
        //    Meal meal = context.Meals.Include(m => m.Ingredients).Single(mi => mi.ID == id);

        //    //ViewMealViewModel viewMealViewModel = new ViewMealViewModel
        //    //{
        //    //    Meal = meal,
        //    //    Ingredients = ingredients
        //    //};

        //    return View(meal);
        //}


        // TODO -- later -- add an edit option for each meal

    }
}


















