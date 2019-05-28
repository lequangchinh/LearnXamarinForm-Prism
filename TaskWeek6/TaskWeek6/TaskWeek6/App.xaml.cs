using Prism;
using Prism.Ioc;
using Prism.Navigation.Xaml;
using TaskWeek6.ViewModels;
using TaskWeek6.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TaskWeek6
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

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("NavigationPage/LoginPageView");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPageView, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage>();
            containerRegistry.RegisterForNavigation<About, AboutModel>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePageMaster, HomePageMasterModel>();
            containerRegistry.RegisterForNavigation<HomePageDetail>();
            containerRegistry.RegisterForNavigation<ListImageView, ListImageViewModel>();
            containerRegistry.RegisterForNavigation<ImageDetailPage, ImageDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ThumbnailListImage, ThumbnailListImageViewModel>();
            containerRegistry.RegisterForNavigation<PostPage, PostPageViewModel>();
            containerRegistry.RegisterForNavigation<PostPageDetail, PostPageDetailViewModel>();
        }
    }
}


