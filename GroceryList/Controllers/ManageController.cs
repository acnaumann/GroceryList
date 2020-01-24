using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroceryList.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryList.Controllers
{
    public class ManageController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.meals = MealData.GetAll();
            return View();
        }

        public IActionResult AddAMeal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAMeal(Meal newMeal)
        {
            //TODO -- List<string> result = names.Split(',').ToList();
            //TODO -- add meal to db
            MealData.Add(newMeal);
            return Redirect("/Manage/Index");
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