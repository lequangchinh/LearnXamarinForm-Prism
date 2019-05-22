using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using TaskWeek6.Views;
using Xamarin.Forms;
using System.ComponentModel;
using Prism.Navigation.Xaml;

namespace TaskWeek6.ViewModels
{
  public  class LoginPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string username;
        public string UserName {
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangedEventArgs("UserName"));
            }
            get
            {
                return username;
            }
        }

        public string password;
        public string PassWord
        {
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("PassWord"));
            }
            get
            {
                return password;
            }
        }


        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Login";
            _navigationService = navigationService;

        }
        public string temp = "";

        async void ExecuteNavigateCommand()
        {
            /*
            HttpClient client = new HttpClient();
            var respone = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
            var product = JsonConvert.DeserializeObject<List<User>>(respone);
            */
            

            if (string.IsNullOrEmpty(UserName))
            {
                MessagingCenter.Send(this, "LoginAlert", UserName);
            }
            else if (UserName.Equals("abc123") == true && PassWord.Equals("123456") == true)
            {
                await _navigationService.NavigateAsync("HomePage");
                temp = UserName;
                MessagingCenter.Send(this, "UserName", UserName);
                MessagingCenter.Send(this, "PassWord", PassWord);
            }
            else if (UserName.Equals("abc123") == false || PassWord.Equals("123456") == false)
            {
                MessagingCenter.Send(this, "LoginFail", UserName);
            }
        }
    }
}
