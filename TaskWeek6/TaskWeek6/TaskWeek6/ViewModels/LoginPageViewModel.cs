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
using Refit;
using NavigationParameters = Prism.Navigation.NavigationParameters;

namespace TaskWeek6.ViewModels
{
    public class LoginPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string username;
        public string UserName
        {
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


        public DelegateCommand NavigateCommandLogin => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }

        public async void ExecuteNavigateCommand()
        {
            var apiResponse = RestService.For<IPhotoAPI>("https://jsonplaceholder.typicode.com");
            var users = await apiResponse.GetUsers();


            if (string.IsNullOrEmpty(UserName))
            {
                MessagingCenter.Send(this, "LoginAlert", UserName);
            }
            else
            {
                foreach (var user in users)
                {
                    if (UserName.Equals(user.username) == true && PassWord.Length > 6)
                    {
                        //var p = new NavigationParameters();
                        //p.Add("user", user);
                        await _navigationService.NavigateAsync("HomePage");

                        MessagingCenter.Send(this, "UserName", UserName);
                        MessagingCenter.Send(this, "PassWord", PassWord);
                    }/*
                    else
                    {
                        MessagingCenter.Send(this, "LoginFail", UserName);
                    }*/
                }
            }
        }
    }
}
