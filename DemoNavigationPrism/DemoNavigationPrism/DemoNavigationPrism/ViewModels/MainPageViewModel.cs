using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoNavigationPrism.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private DelegateCommand _navigateCommand;
        private readonly INavigationService _navigationService;

        public DelegateCommand NavigateCommand => _navigateCommand ?? (_navigateCommand = new DelegateCommand(ExecuteNavigateCommand));

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            _navigationService = navigationService;

        }

        async void ExecuteNavigateCommand()
        {
            await _navigationService.NavigateAsync("ViewA");
        }

    }
}
