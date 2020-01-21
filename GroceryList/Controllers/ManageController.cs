using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryList.Controllers
{
    public class ManageController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddAMeal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAMeal(string name, List<string> ingredients, string notes)
        {
            //TODO -- add meal to db
            return Redirect("/Index");
        }

        public IActionResult ViewAMeal(/*int id*/)
        {
            
            return View();
        }

        // TODO -- later -- add an edit option for each meal
        
    }
}
