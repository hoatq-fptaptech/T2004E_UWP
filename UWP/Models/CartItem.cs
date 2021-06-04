using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Models
{
    class CartItem
    {
        public CartItem(int id,string name,string image,int price,int qty)
        {
            this.id = id;
            this.name = name;
            this.image = image;
            this.price = price;
            this.qty = qty;
        }

        public int id { get; set; } // property --> tham chieu sang id product
        public string name { get; set; }
        public string image { get; set; }
        public int price { get; set; }
        public int qty { get; set; }
    }
}
