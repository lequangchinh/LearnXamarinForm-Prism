using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoNavigationPrism.ViewModels
{
    class ViewBModel : BindableBase, INavigationAware, IConfirmNavigationAsync
    {
        private IPageDialogService _pageDialogService;
        private string _title;
        public string Title
        {
            set { SetProperty(ref _title, value); }
            get { return _title; }
        }
        private DelegateCommand _gateCommand;
        private readonly INavigationService _navigationService;
        public ViewBModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }

        public DelegateCommand CommandNavigation => _gateCommand ?? (_gateCommand = new DelegateCommand(ExecuteNavigateCommand));

        private async void ExecuteNavigateCommand()
        {
            await _navigationService.GoBackAsync();
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Title = parameters.GetValue<string>("title");
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
           
        }

        public Task<bool> CanNavigateAsync(INavigationParameters parameters)
        {
            return _pageDialogService.DisplayAlertAsync("My Title", "Exit", "Cancel", "Acept");
        }
    }
}
