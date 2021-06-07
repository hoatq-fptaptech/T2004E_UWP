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
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "select * from Cart";
            var statement = sQLiteConnection.Prepare(sql_txt);
            List<CartItem> list = new List<CartItem>();
            while(SQLiteResult.ROW == statement.Step())
            {
                int id = Convert.ToInt32(statement[0]);
                string name = (string)statement[1];
                string image = (string)statement[2];
                int price = Convert.ToInt32(statement[3]);
                int qty = Convert.ToInt32(statement[4]);
                CartItem c = new CartItem(id, name, image, price, qty);
                list.Add(c);
            }
            return list;
        }

        public bool RemoveItem(CartItem item)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "delete from cart where id= ?";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, item.id);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }
         public bool UpdateCart(CartItem item, int qty) {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "update cart set qty = ? where id= ?";
            var statement = sQLiteConnection.Prepare(sql_txt);
            statement.Bind(1, qty);
            statement.Bind(2, item.id);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }
        public bool ClearCart()
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = "delete from cart";
            var statement = sQLiteConnection.Prepare(sql_txt);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }
    }
}
