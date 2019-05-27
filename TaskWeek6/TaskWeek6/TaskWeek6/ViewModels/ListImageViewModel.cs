using Prism.Commands;
using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaskWeek6.Views;

namespace TaskWeek6.ViewModels
{
    public class ListImageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private ObservableCollection<ImageView> _images;
        public ObservableCollection<ImageView> Images
        {
            get { return _images; }
            set { SetProperty(ref _images, value); }
        }

        public ICommand SelectCommand { get; set; }
       

        public ListImageViewModel(INavigationService navigationService) : base(navigationService)
        {

            SelectCommand = new DelegateCommand<ImageView>(SelectHandle);
            GetImage();
            _navigationService = navigationService;
        }

        private async void SelectHandle(ImageView obj)
        {
            var p = new NavigationParameters();
            string k = obj.Id.ToString();
            p.Add("Image", k);
           await _navigationService.NavigateAsync("ImageDetailPage", p);
        }

        private async void GetImage()
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var imageslist = await apiResponse.GetListImage("1");

            Images = imageslist;
        }
        
    }
}
