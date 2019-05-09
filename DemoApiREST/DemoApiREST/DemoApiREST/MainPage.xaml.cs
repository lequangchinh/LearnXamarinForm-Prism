using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace DemoApiREST
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetProducts();
        }

        private async void GetProducts()
        {
            HttpClient client = new HttpClient();

            var respone= await client.GetStringAsync("http://makeup-api.herokuapp.com/api/v1/products.json?brand=maybelline");
            var product = JsonConvert.DeserializeObject<List<Product>>(respone);
            lvwProduct.ItemsSource = product;

        }
    }
}
