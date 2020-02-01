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
    public class CategoryController : Controller
    {
        private ListDbContext context;

        public CategoryController(ListDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }

        public IActionResult Index(AddCategoryViewModel acvm)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category
                {
                    Name = acvm.Name,
                };

                context.Categories.Add(category);
                context.SaveChanges();

                return Redirect("/Manage/Index");
            }

            return View(acvm);
        }
    }
}
