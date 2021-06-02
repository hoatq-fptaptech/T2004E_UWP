using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Models
{
    class TodaySpecial
    {
        public string message { get; set; }
        public List<Food> data { get; set; }
    }
    
    public class FoodDetail
    {
        public string message { get; set; }
        public Food data { get; set; } // fooddetail.data
    }

    public class CategoryDetail // cdetail.data.foods
    {
        public string message { get; set; }
        public CategoryData data { get; set; }
    }

    public class CategoryData
    {
        public Category category { get; set; }
        public List<Food> foods { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    }

    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public int price { get; set; }
    }
}
