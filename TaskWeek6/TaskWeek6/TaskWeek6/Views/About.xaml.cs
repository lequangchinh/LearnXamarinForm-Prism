﻿using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWeek6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskWeek6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class About : ContentPage
	{
        public string userName;
        public string passWord;
        public About ()
		{
			InitializeComponent ();

            MessagingCenter.Subscribe<LoginPageViewModel, string>(this, "UserName", (sender, username) =>
            {
                userName = username.ToString();
                lblUserName.Text = username;
            });
            MessagingCenter.Subscribe<LoginPageViewModel, string>(this, "PassWord", (sender, pass) =>
            {
                if (!string.IsNullOrEmpty(pass))
                {
                    passWord = pass;
                    lblPass.Text = pass;
                    passWord = lblPass.Text;
                }
            });
          

            lblUserName.Text = userName;
            lblPass.Text = passWord;
        }
       
	}
}