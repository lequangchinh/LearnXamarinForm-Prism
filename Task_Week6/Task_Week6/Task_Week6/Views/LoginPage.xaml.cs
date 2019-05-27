using Xamarin.Forms;
using Task_Week6.ViewModels;
using System;

namespace Task_Week6.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            MessagingCenter.Subscribe<LoginPageViewModel, string>(this, "LoginAlert", (sender, username) =>
            {
                DisplayAlert("Not Empty", username, "OK");
            });

            MessagingCenter.Subscribe<LoginPageViewModel, string>(this, "LoginFail", (sender, username) =>
            {
                DisplayAlert("Login Fail", username, "OK");
            });


            etrUserName.Completed += (object sender, EventArgs e) =>
            {
                etrPass.Focus();
            };
        }
    }
}
