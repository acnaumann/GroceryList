using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Data;
using GroceryList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryList.Controllers
{
    public class ExploreController : Controller
    {
        private ListDbContext context;

        public ExploreController(ListDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Meal> meals = context.Meals.Include(m => m.Ingredients).ToList();
            return View(meals);
        }


        [HttpPost]
        public IActionResult Index(int id)
        {
            //TODO -- if add to meals redirect to "/Manage/AddAMeal" else redirect as shown below
            //TODO -- view a meal within this controller or using the Manage controller
            return Redirect("Explore/ViewMeal");
        }

        public IActionResult ViewMeal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ViewMeal(int id)
        {

            return Redirect("Manage/AddAMeal");
        }
    }
}
