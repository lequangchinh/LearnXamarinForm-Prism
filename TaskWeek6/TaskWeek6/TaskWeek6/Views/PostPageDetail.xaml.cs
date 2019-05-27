using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWeek6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Refit;
using Prism.Navigation;

namespace TaskWeek6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PostPageDetail : ContentPage
	{
        
		public PostPageDetail ()
		{
			InitializeComponent ();
            GetComments("1");
        }
        private async void GetComments(string postId)
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var comments = await apiResponse.GetComments(postId);

            lvwComments.ItemsSource = comments;
        }



    }
}