using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskWeek6.ViewModels
{
    public class PostPageDetailViewModel : ViewModelBase
    {
        private Post _post;
        public Post Postm
        {
            get { return _post; }
            set
            {
                SetProperty(ref _post, value);
            }
        }
        private string _myPost;
        public string MyPost
        {
            get { return _myPost; }
            set
            {
                SetProperty(ref _myPost, value);
            }
        }

        public PostPageDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            GetImage();
        }

        private async void GetImage()
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var post = await apiResponse.GetPost(MyPost);

            //Postm = post;
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            MyPost = parameters.GetValue<string>("Image");
            MyPost = parameters.GetValue<string>("Image");
        }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            MyPost = parameters.GetValue<string>("Image");
        }
    }
}
