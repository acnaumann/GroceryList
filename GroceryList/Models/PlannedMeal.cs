using System;
namespace GroceryList.Models
{
    public class PlannedMeal
    {
        public int ID { get; set; }
        public string Day { get; set; }

        public Meal Meal { get; set; }
        public int MealID { get; set; }

        public PlannedMeal()
        {
            
        }
    }
}
