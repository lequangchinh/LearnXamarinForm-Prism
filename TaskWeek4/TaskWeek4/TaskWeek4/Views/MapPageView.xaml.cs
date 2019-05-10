using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace TaskWeek4.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MapPageView : ContentPage
	{
		public MapPageView ()
		{
			InitializeComponent ();
            OpenMapPage();

		}
        public async void OpenMapPage()
        {
            var location = new Location(10.813215, 106.663884);
            var options = new MapLaunchOptions { NavigationMode = NavigationMode.Driving };

            await Map.OpenAsync(location, options);
        }

    }
}