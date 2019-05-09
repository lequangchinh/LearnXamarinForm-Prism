using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoAPI_Refit
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
       
        async void OnGetMakeUpClicked(object sender, System.EventArgs e)
        {
            var apiResponse = RestService.For<IMakeUpApi>("http://makeup-api.herokuapp.com");
            var makeUps = await apiResponse.GetMakeUps("maybelline");

            lvwListMakeUp.ItemsSource = makeUps;
        }
    }
}
