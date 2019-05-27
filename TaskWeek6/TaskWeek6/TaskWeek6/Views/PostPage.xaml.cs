using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refit;
using TaskWeek6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskWeek6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PostPage : ContentPage
	{
		public PostPage ()
		{
			InitializeComponent ();
            GetImage();

            lvwPost.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var item = (Post)e.SelectedItem;
                var page = new PostPageDetail();
                page.BindingContext = item;
                Navigation.PushAsync(page);

            };
        }
        private async void GetImage()
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var posts = await apiResponse.GetPosts();
          
            lvwPost.ItemsSource = posts;
        }
    }
}