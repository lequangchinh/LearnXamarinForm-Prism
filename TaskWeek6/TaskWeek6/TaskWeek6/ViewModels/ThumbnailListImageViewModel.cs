using Prism.Commands;
using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TaskWeek6.ViewModels
{
   public class ThumbnailListImageViewModel : ViewModelBase
    {
        private ObservableCollection<ImageView> _images;
        public ObservableCollection<ImageView> Images
        {
            get { return _images; }
            set { SetProperty(ref _images, value); }
        }

        public ThumbnailListImageViewModel(INavigationService navigationService) : base(navigationService)
        {
            GetPosts();
        }

        private async void GetPosts()
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var images = await apiResponse.GetListImage("1");

            Images = images;
        }

    }
}
