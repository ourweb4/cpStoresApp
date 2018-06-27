using cpStoresApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cpStoresApp
{
    public partial class MainPage : ContentPage
    {
        public const string api = "http://stores.ourweb.net/";
        public List<StoreEntity> thelist;
        private StoreAPI client;

        public MainPage()
        {
            InitializeComponent();
            Client = new StoreAPI(api);
        }

        internal StoreAPI Client { get => client; set => client = value; }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {

        }
    }
}
