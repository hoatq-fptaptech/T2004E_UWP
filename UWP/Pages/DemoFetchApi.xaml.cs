using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP.Models;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using UWP.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoFetchApi : Page
    {
        public DemoFetchApi()
        {
            this.InitializeComponent();
            // co 1 danh sach cac item de truyen vao //  List<Item> list 

            // hom truoc se lam nhu sau:
            /* List<Item> list = new List<Item>();
             list.Add(new Item { id = 1, icon = "", name = "burger" });
             list.Add(new Item { id = 1, icon = "", name = "burger" });
             list.Add(new Item { id = 1, icon = "", name = "burger" });
             MNItems.ItemsSource = list;*/

            // dung ham GetMenu de lay menu tu api ve
            GetMenu();
        }

        public async void GetMenu() // bao hieu rang se su dung cu phap xu ly bat dong bo hoa
        {
            // lay data tu api va nap vao MNItems
            //HttpClient httpClient = new HttpClient();// day la shipper lay hang 
            //var response = await httpClient.GetAsync("https://foodgroup.herokuapp.com/api/menu"); // file_get_content(); // CURL 
            /*  if(response.StatusCode  == HttpStatusCode.OK)
              {
                  var stringContent = await response.Content.ReadAsStringAsync(); // day chinh la string json // read content response
                  // convert cai string tren thanh 1 object Menu -- php json_decode  js: JSON_parser
                  Menu menu = JsonConvert.DeserializeObject<Menu>(stringContent);
                  MNItems.ItemsSource = menu.data;
              }
  */
            // dung MenuService
            MenuService service = new MenuService();
            Menu menu = await service.GetMenu();
            if (menu != null)
            {
                MNItems.ItemsSource = menu.data;
            }
        }


    }
}
