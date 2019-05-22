using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWeek6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskWeek6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ThumbnailListImage : ContentPage
	{
		public ThumbnailListImage ()
		{
			InitializeComponent ();

            LoadBitmapCollection();
        }

        async void LoadBitmapCollection()
        {

            // Download the list of stock photos
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var images = await apiResponse.GetListImage("1");

            // Convert to a Stream object

            // Create an Image object for each bitmap
            foreach (ImageView imageAPI in images)
            {
                Image image = new Image
                {
                    Source = ImageSource.FromUri(new Uri(imageAPI.Url))
                };
                image.HeightRequest = 200;
                fllListImages.Children.Add(image);
            }
            
            activityIndicator.IsRunning = false;
            activityIndicator.IsVisible = false;
        }


            
	}
}