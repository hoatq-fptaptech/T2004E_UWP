using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Models
{
    class Menu
    {
        public string message { get; set; }
        public List<Item> data { get; set; }
    }

    class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
    } 
}