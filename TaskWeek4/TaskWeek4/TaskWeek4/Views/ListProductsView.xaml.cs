using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Refit;
using TaskWeek4.ViewModels;

namespace TaskWeek4.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListProductsView : ContentPage
	{
		public ListProductsView ()
		{
		    InitializeComponent ();
            GetListProducts();
        }

        private async void GetListProducts()
        {
            var respone = RestService.For<IListProducts>("http://makeup-api.herokuapp.com");
            var product = await respone.GetProducts("maybelline");

            lvwListProducts.ItemsSource = product;
        }
	}
}