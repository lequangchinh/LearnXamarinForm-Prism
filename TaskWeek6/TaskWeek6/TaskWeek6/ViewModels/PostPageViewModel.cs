using Prism.Commands;
using Prism.Navigation;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace TaskWeek6.ViewModels
{
   public class PostPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private ObservableCollection<Post> _posts;
        public ObservableCollection<Post> Posts
        {
            get { return _posts; }
            set { SetProperty(ref _posts, value); }
        }

        public ICommand SelectCommand { get; set; }


        public PostPageViewModel(INavigationService navigationService) : base(navigationService)
        {

            SelectCommand = new DelegateCommand<Post>(SelectHandle);
            GetPosts();
            _navigationService = navigationService;
        }

        private async void SelectHandle(Post obj)
        {
            var p = new NavigationParameters();
            string k = obj.ID.ToString();
            p.Add("Post", k);
            await _navigationService.NavigateAsync("PostPageDetail", p);
        }

        private async void GetPosts()
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var posts = await apiResponse.GetPosts();

            Posts = posts;
        }

    }
}
