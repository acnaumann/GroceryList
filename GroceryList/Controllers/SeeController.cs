using System;
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
    public class SeeController : Controller
    {

        private ListDbContext context;

        public SeeController(ListDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            SeeIngredientsViewModel seeIViewModel = new SeeIngredientsViewModel();

            List<int> PlannedMealIDs = context.PlannedMeals.Select(m => m.MealID).ToList();

            seeIViewModel.Categories = context.Categories.ToList();

            //foreach Ingredient ingredient in Ingredients
            //if ingredient.IsInCart
            seeIViewModel.Ingredients = context.Ingredients
                .Where(x => PlannedMealIDs.Contains(x.MealID))//another way --> after (x.MealID) --> && !x.IsInCart
                .Where(i => i.IsInCart)
                .Include(c => c.Category)
                .OrderBy(i => i.Name).ToList();

            seeIViewModel.IsPlanned = context.PlannedMeals.Any();

            return View(seeIViewModel);
        }


        [HttpPost]
        public IActionResult RemoveIngredient(RemovePlannedIngredientViewModel rPIngredientViewModel)
        {

            if (ModelState.IsValid)
            {
                //context.SaveChanges();

                foreach (int id in rPIngredientViewModel.IngredientIDs)
                {
                    Ingredient ingredient = context.Ingredients.Single(i => i.ID == id);

                    ingredient.IsInCart = false;
                    
                }
                context.SaveChanges();
            }

            return Redirect("Index");
        }
    }
}