using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryList.Controllers
{
    public class ExploreController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            return View();
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
