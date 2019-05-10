﻿using Prism;
using Prism.Ioc;
using TaskWeek4.ViewModels;
using TaskWeek4.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TaskWeek4
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            //await NavigationService.NavigateAsync("NavigationPage/HomePage");
            MainPage = new HomePage();
            //await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<ListProductsView>();
            containerRegistry.RegisterForNavigation<NavigationView>();
            containerRegistry.RegisterForNavigation<HomePage>();
            //containerRegistry.RegisterForNavigation<, TabbedPageViewViewModel>();
            containerRegistry.RegisterForNavigation<MapPageView, MapPageViewModel>();
        }
    }
}
