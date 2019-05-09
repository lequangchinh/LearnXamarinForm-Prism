using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoNavigationPrism.ViewModels
{
    public class ViewAModel : BindableBase
    {
        private string _title;
        private DelegateCommand _navigateCommad;
        private readonly INavigationService _navigateService;

        public DelegateCommand NavigateCommand => _navigateCommad ?? (_navigateCommad = new DelegateCommand(ExecuteNavigateCommand));

        private async void ExecuteNavigateCommand()
        {
            var p = new NavigationParameters();
            p.Add("title", "Welcom xamarin");

            await _navigateService.NavigateAsync("ViewB", p);
            
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewAModel(INavigationService navigationService)
        {
            Title = "View A";
            _navigateService = navigationService;
        }
    }
}
