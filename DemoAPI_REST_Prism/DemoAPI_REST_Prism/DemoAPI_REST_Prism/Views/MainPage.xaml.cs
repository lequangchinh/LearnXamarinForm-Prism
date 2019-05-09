using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Refit;
using DemoAPI_REST_Prism.ViewModels;

namespace DemoAPI_REST_Prism.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetListProducts();
        }

        private async void GetListProducts()
        {
            var apiResponse = RestService.For<IListProducts>("http://makeup-api.herokuapp.com");
            var product = await apiResponse.GetProducts("maybelline");

            lvwListProducts.ItemsSource = product;
        }

        
    }
}