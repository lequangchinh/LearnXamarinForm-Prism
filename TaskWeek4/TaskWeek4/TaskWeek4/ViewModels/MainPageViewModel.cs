using Prism.Commands;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace TaskWeek4.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private DelegateCommand _navigateCommand;
        private DelegateCommand _navigateCommandTextToSpeech;

        private readonly INavigationService _navigationService;

        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));
        public DelegateCommand NavigateCommandTextToSpeech => _navigateCommandTextToSpeech ?? (_navigateCommandTextToSpeech = new DelegateCommand(ExecuteNavigateCommandTextToSpeech));

        private async void ExecuteNavigateCommandTextToSpeech()
        {
            await _navigationService.NavigateAsync("NavigationView");
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";

            _navigationService = navigationService;
        }

        async void ExecuteNavigateCommand()
        {
            await _navigationService.NavigateAsync("ListProductsView");
        }

      
    }
}
