using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryList.Controllers
{
    public class PlanController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        // TODO -- How to clear the week's meals and stay on the index page

        //[HttpPost]
        //public IActionResult Clear(string name)
        //{
        //    return Redirect("Index");
        //}
    }
}
