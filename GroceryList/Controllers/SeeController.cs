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

            seeIViewModel.Ingredients = context.Ingredients.Where(x => PlannedMealIDs.Contains(x.MealID)).OrderBy(i => i.Name).ToList();

            return View(seeIViewModel);
        }

        public IActionResult RemoveList()
        {
            //TODO -- remove ingredients from DB
            return Redirect("Index");
        }
    }
}
