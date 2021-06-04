using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP.Services;
using UWP.Adapters;
using SQLitePCL;
namespace UWP.Models
{
    class Cart : CartService
    {
        public bool AddToCart(CartItem item)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "insert into Cart (id,name,image,price,qty) values(?,?,?,?,?)";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.id);
            statement.Bind(2, item.name);
            statement.Bind(3, item.image);
            statement.Bind(4, item.price);
            statement.Bind(5, item.qty);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }

        public List<CartItem> GetCart()
        {
            return null;
        }

        public bool RemoveItem(CartItem item)
        {
            return false;
        }
         public bool UpdateCart(CartItem item, int qty) { 
            return false;
         }
        public bool ClearCart()
        {
            return false;
        }
    }
}
