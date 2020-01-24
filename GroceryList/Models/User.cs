using System;
namespace GroceryList.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }

        private static int nextId = 1;


        public User()
        {
            ID = nextId;
            nextId++;
        }
    }
}
