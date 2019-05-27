using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using Prism.Mvvm;
using Prism.Navigation;
using Refit;

namespace TaskWeek6.ViewModels
{
    public class ImageDetailPageViewModel : ViewModelBase

    {
        private ImageView _image;
        public ImageView Image
        {
            get { return _image; }
            set
            {
                SetProperty(ref _image, value);
            }
        }
        private string _imag;
        public string Imag
        {
            get { return _imag; }
            set
            {
                SetProperty(ref _imag, value);
            }
        }

        public ImageDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            GetImage();
        }

        private async void GetImage()
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var img= await apiResponse.GetImage(Imag);

            Image = img;
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            Imag = parameters.GetValue<string>("Image");
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            Imag = parameters.GetValue<string>("Image");
        }
    }
}
