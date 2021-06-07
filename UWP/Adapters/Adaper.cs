using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP.Adapters
{
    class Adaper
    {
        private string baseURL = "https://foodgroup.herokuapp.com";

        // singleton pattern

        private static Adaper instance;

        private Adaper()
        {
        }

        public static Adaper GetAdaper()
        {
            if(instance == null)
            {
                instance = new Adaper();
            }
            return instance;   
        }

        public string GetMenuApi
        {
            get => String.Format(baseURL + "/api/menu");
        }

        public string GetCreateOrderApi
        {
            get => String.Format(baseURL + "/api/create-order");
        }

    }
}
