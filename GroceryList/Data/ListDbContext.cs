using System;
using GroceryList.Models;
using Microsoft.EntityFrameworkCore;

namespace GroceryList.Data
{
    public class ListDbContext : DbContext
    {
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<PlannedMeal> PlannedMeals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=GroceryList.db");
    }
}
