﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaskWeek6.ViewModels;
using Newtonsoft.Json;
using Prism.Navigation;

namespace TaskWeek6.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPageView :  ContentPage
    {
        public LoginPageViewModel loginViewModel;

        public LoginPageView(INavigationService navigationService) 
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            this.BindingContext = loginViewModel;

            etrUserName.Completed += (object sender, EventArgs e) =>
              {
                  etrPass.Focus();
              };

            /*
            etrPass.Completed += (object sender, EventArgs e) =>
            {
                loginViewModel.NavigateCommand.Execute();
            };
            */
        }

    }
}